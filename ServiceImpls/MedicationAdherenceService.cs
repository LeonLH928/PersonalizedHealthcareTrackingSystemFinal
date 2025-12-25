using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Text.Json;
using System.Net;
using System.Diagnostics;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;

public class MedicationAdherenceService : IMedicationAdherenceService
{
    private readonly IMedicationAdherenceRepository _medicationAdherenceRepository;
    public MedicationAdherenceService(IMedicationAdherenceRepository medicationAdherenceRepository)
    {
        _medicationAdherenceRepository = medicationAdherenceRepository;
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetAllAdherencesByPatientID(string PatientID)
    {
        return await _medicationAdherenceRepository.GetAllAdherencesByPatientID(PatientID);
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetPendingAdherencesByPatientID(string PatientID)
    {
        return await _medicationAdherenceRepository.GetPendingAdherencesByPatientID(PatientID);
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetMissedAdherencesByPatientID(string PatientID)
    {
        return await _medicationAdherenceRepository.GetMissedAdherencesByPatientID(PatientID);
    }
    public async Task UpsertAdherence(MedicationAdherenceModel NewAdherence)
    {
        await _medicationAdherenceRepository.UpsertAdherence(NewAdherence);
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetTodayAdherencesByPatientIDAsync(string PatientID)
    {
        var adherences = await GetAllAdherencesByPatientID(PatientID);
        return adherences.Where(a => a.ScheduledDateTime.Date == DateTime.Now.Date);
    }
    public async Task<List<MedicationAdherenceModel>> CreateMedicationAdherenceBatchAsync(IEnumerable<PrescriptionItemModel> items)
    {
        var allAdherenceRecords = new List<MedicationAdherenceModel>();
        var currentDateTime = DateTime.Now; 

        var timeMapping = new Dictionary<string, TimeSpan>
        {
            { "morning", new TimeSpan(8, 0, 0) },
            { "afternoon", new TimeSpan(13, 0, 0) },
            { "evening", new TimeSpan(18, 0, 0) },
            { "night", new TimeSpan(21, 0, 0) }
        };

        int gracePeriodHours = 5;

        foreach (var item in items)
        {
            string cleanJson = WebUtility.HtmlDecode(item.DoseScheduleJSON);
            Dictionary<string, JsonElement>? schedule;
            schedule = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(cleanJson);

            if (schedule == null || schedule.ContainsKey("as_needed")) continue;

            DateTime startDate = item.Prescription.PrescriptionDateTime.Date;

            //if (startDate.AddDays(item.DurationDays) < DateTime.Now)
            //    return [];

            DateTime currentDate = DateTime.Now.Date;

            foreach (var key in schedule.Keys)
            {
                string cleanKey = key.Trim().ToLower();

                if (timeMapping.TryGetValue(cleanKey, out TimeSpan timeToTake))
                {
                    DateTime scheduledTime = currentDate.Add(timeToTake);

                    var initialStatus = Models.AdherenceStatus.Pending;

                    if (currentDateTime > scheduledTime.AddHours(gracePeriodHours)
                     || cleanKey == "evening" && currentDateTime > scheduledTime.AddHours(3))
                        initialStatus = Models.AdherenceStatus.Missed;

                    var adherence = new MedicationAdherenceModel
                    {
                        AdherenceID = Guid.NewGuid().ToString(),
                        PrescriptionItemID = item.ItemID,
                        ScheduledDateTime = scheduledTime,
                        Status = initialStatus,
                        TakenDateTime = null,
                        Notes = null,
                        PrescriptionItem = item
                    };

                    allAdherenceRecords.Add(adherence);
                }
            }
        }
        return allAdherenceRecords;
    }
}