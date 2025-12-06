using CommunityToolkit.Mvvm.Messaging.Messages;

namespace PersonalizedHealthcareTrackingSystemFinal.Messages;
public class SelectedMedicationIDsMessage(List<string> MedicationIDs) : ValueChangedMessage<List<string>>(MedicationIDs);
