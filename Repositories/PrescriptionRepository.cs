using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class PrescriptionRepository : IPrescriptionRepository
{
    public readonly Client _client;
    public JsonSerializerOptions options;
    public PrescriptionRepository(Client client)
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
                                     """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Pending)
                                    .Get();

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(response.Content!, options);
       
        return prescriptions == null ? [] : prescriptions;
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllDispensingPrescriptionsAsync()
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
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
                                     """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Dispensed)
                                    .Get();

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(response.Content!, options);

        return prescriptions == null ? [] : prescriptions;
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllCompletedPrescriptionsAsync()
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
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
                                     """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Completed)
                                    .Get();

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(response.Content!, options);

        return prescriptions == null ? [] : prescriptions;
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllCancelledPrescriptionsAsync()
    {
        var response = await _client.From<PrescriptionModel>()
                                    .Select("""
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
                                     """)
                                    .Where(p => p.Status == Models.PrescriptionStatus.Cancelled)
                                    .Get();

        var prescriptions = JsonSerializer.Deserialize<List<PrescriptionModel>>(response.Content!, options);

        return prescriptions == null ? [] : prescriptions;
    }

}
