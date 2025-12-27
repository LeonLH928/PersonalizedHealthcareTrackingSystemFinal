using CommunityToolkit.Mvvm.Messaging.Messages;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;

namespace PersonalizedHealthcareTrackingSystemFinal.Messages;
public class ConfirmationBookingMessage((TimeOnly, string, string, string, DateTime, PatientBookingPageViewModel) ConfirmationMessage) : 
                                                ValueChangedMessage<(TimeOnly, string, string, string, DateTime, PatientBookingPageViewModel)>(ConfirmationMessage);
