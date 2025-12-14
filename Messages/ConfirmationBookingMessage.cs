using CommunityToolkit.Mvvm.Messaging.Messages;

namespace PersonalizedHealthcareTrackingSystemFinal.Messages;
public class ConfirmationBookingMessage((TimeOnly, string, string, string, DateTime) ConfirmationMessage) : 
                                                ValueChangedMessage<(TimeOnly, string, string, string, DateTime)>(ConfirmationMessage);
