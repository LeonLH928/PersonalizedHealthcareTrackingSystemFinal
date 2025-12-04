using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase.Postgrest;
using Supabase.Postgrest.Interfaces;
using static Supabase.Postgrest.Constants;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class MedicationInteractionRepository : IMedicationInteractionRepository
{
    public readonly Supabase.Client _client;
    public MedicationInteractionRepository(Supabase.Client client)
    {
        _client = client;
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public async Task<IEnumerable<MedicationInteractionModel>> GetAllMedicationInteractionsByMedicationIDs(List<string> MedicationIDs)
    {
        var response = await _client
                                    .From<MedicationInteractionModel>()
                                    .Select("*, " +
                                            "Med1:Medications!FK_MedicationInteractions_Medications_Medication1ID(*), " +
                                            "Med2:Medications!FK_MedicationInteractions_Medications_Medication2ID(*)")
                                    .Filter("Medication1ID", Operator.In, MedicationIDs)
                                    .Filter("Medication2ID", Operator.In, MedicationIDs)
                                    .Get();

        return response.Models;
    }
}
