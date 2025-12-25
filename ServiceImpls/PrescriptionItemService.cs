using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Net;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;

public class PrescriptionItemService : IPrescriptionItemService
{
    private readonly IPrescriptionItemRepository _prescriptionItemRepository;
    public PrescriptionItemService(IPrescriptionItemRepository prescriptionItemRepository)
    {
        _prescriptionItemRepository = prescriptionItemRepository;
    }
    public async Task AddPrescriptionItemAsync(PrescriptionItemModel NewItem)
    {
        await _prescriptionItemRepository.AddPrescriptionItemAsync(NewItem);
    }
    public async Task<IEnumerable<PrescriptionItemModel>> GetAllPrescriptionItemsByPrescriptionIDAsync(string PrescriptionID)
    {
        return await _prescriptionItemRepository.GetAllPrescriptionItemsByPrescriptionIDAsync(PrescriptionID);
    }
    public async Task<IEnumerable<PrescriptionItemModel>> FilterAsNeededAsync(List<PrescriptionItemModel> items)
    {
        List<PrescriptionItemModel> result = new();
        foreach (var item in items)
        {
            Dictionary<string, JsonElement>? schedule;
            string cleanJson = WebUtility.HtmlDecode(item.DoseScheduleJSON);
            schedule = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(cleanJson);

            if (schedule!.ContainsKey("as_needed"))
                result.Add(item);
        }
        return result;
    }
}