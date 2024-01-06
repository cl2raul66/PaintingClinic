namespace PaintingClinic.Share;

public interface IUserService
{
    bool Exist { get; }

    bool Delete(string id);
    IEnumerable<User> GetAll();
    User GetById(string id);
    bool Upsert(User entity);
}

public interface IUser1Service
{
    bool Exist { get; }

    bool Delete(string id);
    IEnumerable<User> GetAll();
    User GetById(string id);
    bool Upsert(User entity);
}
