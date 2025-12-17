using CommunityToolkit.Mvvm.Messaging.Messages;

namespace PersonalizedHealthcareTrackingSystemFinal.Messages;
public class PageTypeMessage(Type PageType) : ValueChangedMessage<Type>(PageType);
