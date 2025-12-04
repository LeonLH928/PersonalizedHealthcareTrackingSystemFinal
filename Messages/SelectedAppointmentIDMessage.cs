using CommunityToolkit.Mvvm.Messaging.Messages;

namespace PersonalizedHealthcareTrackingSystemFinal.Messages;
public class SelectedAppointmentIDMessage(string AppointmentID) : ValueChangedMessage<string>(AppointmentID);
