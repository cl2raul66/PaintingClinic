namespace PaintingClinic.Share.NotificationCenter;

public class NotificationService : INotificationService
{
    readonly private List<CustomNotification> Notifications;

    public NotificationService()
    {
        Notifications = [];
    }

    public void Add(CustomNotification notification) => Notifications.Add(notification);

    public void Remove(CustomNotification notification) => Notifications.Remove(notification);

    public IEnumerable<CustomNotification> GetAll() => Notifications;
}
