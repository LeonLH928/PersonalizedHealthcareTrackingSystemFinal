using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class MedicationAdherenceRepository : IMedicationAdherenceRepository
{
    public readonly Supabase.Client _client;
    public JsonSerializerOptions options;
    public MedicationAdherenceRepository(Supabase.Client client)
    {
        _client = client;
        options = new()
        {
            PropertyNameCaseInsensitive = true
        };
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetAllAdherencesByPatientIDAsync(string PatientID)
    {
        var response = await _client.From<MedicationAdherenceModel>()
                                    .Select("""
                                        *,
                                        PI:PrescriptionItems(
                                            *,
                                            Medication:Medications(*),
                                            Prescription:Prescriptions(
                                                *,
                                                MedicalRecord:MedicalRecords(
                                                   *,
                                                   Appointment:Appointments(
                                                       *,
                                                       Patient:Patients(
                                                           *,
                                                           User:Users(*)
                                                       ),
                                                       Doctor:Doctors(
                                                           *,
                                                           User:Users(*)
                                                       )
                                                   )
                                                )
                                            )
                                        )
                                        """)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"PrescriptionItems\"", "\"tempPI\"")
                         .Replace("\"PI\"", "\"PrescriptionItem\"");

        var tempMedicationAdherences = JsonSerializer.Deserialize<List<MedicationAdherenceModel>>(content, options);

        var medicationAdherences = tempMedicationAdherences!.Where(ma => ma.PrescriptionItem.Prescription.MedicalRecord.Appointment.PatientID == PatientID);
        return medicationAdherences == null ? [] : medicationAdherences;
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetPendingAdherencesByPatientIDAsync(string PatientID)
    {
        var response = await _client.From<MedicationAdherenceModel>()
                                    .Select("""
                                        *,
                                        PI:PrescriptionItems(
                                            *,
                                            Medication:Medications(*),
                                            Prescription:Prescriptions(
                                                *,
                                                MedicalRecord:MedicalRecords(
                                                   *,
                                                   Appointment:Appointments(
                                                       *,
                                                       Patient:Patients(
                                                           *,
                                                           User:Users(*)
                                                       ),
                                                       Doctor:Doctors(
                                                           *,
                                                           User:Users(*)
                                                       )
                                                   )
                                                )
                                            )
                                        )
                                        """)
                                    .Where(ma => ma.Status == Models.AdherenceStatus.Pending)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"PrescriptionItems\"", "\"tempPI\"")
                         .Replace("\"PI\"", "\"PrescriptionItem\"");

        var tempMedicationAdherences = JsonSerializer.Deserialize<List<MedicationAdherenceModel>>(content, options);

        var medicationAdherences = tempMedicationAdherences!.Where(ma => ma.PrescriptionItem.Prescription.MedicalRecord.Appointment.PatientID == PatientID);
        return medicationAdherences == null ? [] : medicationAdherences;
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetMissedAdherencesByPatientIDAsync(string PatientID)
    {
        var response = await _client.From<MedicationAdherenceModel>()
                                    .Select("""
                                        *,
                                        PI:PrescriptionItems(
                                            *,
                                            Medication:Medications(*),
                                            Prescription:Prescriptions(
                                                *,
                                                MedicalRecord:MedicalRecords(
                                                   *,
                                                   Appointment:Appointments(
                                                       *,
                                                       Patient:Patients(
                                                           *,
                                                           User:Users(*)
                                                       ),
                                                       Doctor:Doctors(
                                                           *,
                                                           User:Users(*)
                                                       )
                                                   )
                                                )
                                            )
                                        )
                                        """)
                                    .Where(ma => ma.Status == Models.AdherenceStatus.Missed)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"PrescriptionItems\"", "\"tempPI\"")
                         .Replace("\"PI\"", "\"PrescriptionItem\"");

        var tempMedicationAdherences = JsonSerializer.Deserialize<List<MedicationAdherenceModel>>(content, options);

        var medicationAdherences = tempMedicationAdherences!.Where(ma => ma.PrescriptionItem.Prescription.MedicalRecord.Appointment.PatientID == PatientID);
        return medicationAdherences == null ? [] : medicationAdherences;
    }
    public async Task UpsertAdherenceAsync(MedicationAdherenceModel NewAdherence)
    {
        await _client.From<MedicationAdherenceModel>()
                     .Upsert(NewAdherence);
    }
}
