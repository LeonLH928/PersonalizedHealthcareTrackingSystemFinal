using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using Supabase.Postgrest;
using Supabase.Postgrest.Interfaces;
using Supabase.Postgrest.Responses;
using System.Diagnostics;
using System.Text.Json;
using static Supabase.Postgrest.Constants;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class PrescriptionRepository : IPrescriptionRepository
{
    public readonly Supabase.Client _client;
    public JsonSerializerOptions options;
    public PrescriptionRepository(Supabase.Client client)
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
    public async Task AddPrescriptionAsync(PrescriptionModel NewPrescription)
    {
        await _client.From<PrescriptionModel>()
                     .Upsert(NewPrescription);
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllPendingPrescriptionsAsync()
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
                                                *,
                                                MR:MedicalRecords(
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
                                                ),
                                                P:Pharmacists(
                                                    *,
                                                    User:Users(*)
                                                )
                                             """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Pending)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"MedicalRecords\"", "\"tempMR\"")
                         .Replace("\"MR\"", "\"MedicalRecord\"")
                         .Replace("\"Pharmacists\"", "\"tempP\"")
                         .Replace("\"P\"", "\"Pharmacist\"");

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(content, options);

        return prescriptions == null ? [] : prescriptions;
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllDispensingPrescriptionsAsync()
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
                                                *,
                                                MR:MedicalRecords(
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
                                                ),
                                                P:Pharmacists(
                                                    *,
                                                    User:Users(*)
                                                )
                                             """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Dispensed)
                                    .Get();
        var content = response.Content!;
        content = content.Replace("\"MedicalRecords\"", "\"temp\"")
                         .Replace("\"MR\"", "\"MedicalRecord\"")
                         .Replace("\"Pharmacists\"", "\"temp\"")
                         .Replace("\"P\"", "\"Pharmacist\"");

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(content, options);

        return prescriptions == null ? [] : prescriptions;
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllCompletedPrescriptionsAsync()
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
                                                *,
                                                MR:MedicalRecords(
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
                                                ),
                                                P:Pharmacists(
                                                    *,
                                                    User:Users(*)
                                                )
                                             """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Completed)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"MedicalRecords\"", "\"temp\"")
                         .Replace("\"MR\"", "\"MedicalRecord\"")
                         .Replace("\"Pharmacists\"", "\"temp\"")
                         .Replace("\"P\"", "\"Pharmacist\"");

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(content, options);

        return prescriptions == null ? [] : prescriptions;
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllCancelledPrescriptionsAsync()
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
                                                *,
                                                MR:MedicalRecords(
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
                                                ),
                                                P:Pharmacists(
                                                    *,
                                                    User:Users(*)
                                                )
                                             """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Cancelled)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"MedicalRecords\"", "\"temp\"")
                         .Replace("\"MR\"", "\"MedicalRecord\"")
                         .Replace("\"Pharmacists\"", "\"temp\"")
                         .Replace("\"P\"", "\"Pharmacist\"");

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(content, options);

        return prescriptions == null ? [] : prescriptions;
    }
    public async Task<IEnumerable<PrescriptionModel>> SearchByText(string SearchText)
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
                                                *,
                                                MR:MedicalRecords(
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
                                                ),
                                                P:Pharmacists(
                                                    *,
                                                    User:Users(*)
                                                )
                                             """)
                                    .Limit(20)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"MedicalRecords\"", "\"temp\"")
                         .Replace("\"MR\"", "\"MedicalRecord\"")
                         .Replace("\"Pharmacists\"", "\"temp\"")
                         .Replace("\"P\"", "\"Pharmacist\"");

        var models = JsonSerializer.Deserialize<List<PrescriptionModel>>(content, options);

        if (models == null)
            return [];

        var prescriptions = models.Where(p =>
            p.PrescriptionID.ToLower().Contains(SearchText.ToLower().Trim())
         || p.Priority.ToString().ToLower().Contains(SearchText.ToLower().Trim())
         || p.RecordID.ToLower().Contains(SearchText.ToLower().Trim())
         || p.MedicalRecord.Appointment.Doctor.User.FirstName.ToLower().Contains(SearchText.ToLower().Trim())
         || p.MedicalRecord.Appointment.Doctor.User.LastName.ToLower().Contains(SearchText.ToLower().Trim())
         || p.MedicalRecord.Appointment.Patient.User.LastName.ToLower().Contains(SearchText.ToLower().Trim())
         || p.MedicalRecord.Appointment.Patient.User.FirstName.ToLower().Contains(SearchText.ToLower().Trim())
            );

        return prescriptions;
    }

}
