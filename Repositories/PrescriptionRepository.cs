using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class PrescriptionRepository : IPrescriptionRepository
{
    public readonly Client _client;
    public PrescriptionRepository(Client client)
    {
        _client = client;
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
}
