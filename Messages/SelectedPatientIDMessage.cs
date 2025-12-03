using CommunityToolkit.Mvvm.Messaging.Messages;

namespace PersonalizedHealthcareTrackingSystemFinal.Messages;
public class SelectedPatientIDMessage(string PatientID) : ValueChangedMessage<string>(PatientID);
