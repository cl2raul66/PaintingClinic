namespace PaintingClinic.Share;

public interface IUserService
{
    bool Exist { get; }

    bool Delete(string id);
    IEnumerable<UserDto> GetAll();
    UserDto GetById(string id);
    bool Upsert(UserDto entity);
}

public interface INotificationService
{
    void Add(CustomNotification notification);
    IEnumerable<CustomNotification> GetAll();
    void Remove(CustomNotification notification);
}
