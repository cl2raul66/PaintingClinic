using LiteDB;
using PaintingClinic.Share;

namespace PaintingClinic.Server.Services;

public class UserService : IUserService
{
    readonly ILiteCollection<User> collection;
    string DIR_DB = Path.Combine(AppContext.BaseDirectory, "db");

    public UserService()
    {
        if (!Directory.Exists(DIR_DB))
        {
            Directory.CreateDirectory(DIR_DB);
        }
        var cnx = new ConnectionString()
        {
            Filename = Path.Combine(DIR_DB, "User.db"),
            Password = "12345678"
        };

        LiteDatabase db = new(cnx);
        collection = db.GetCollection<User>();

        SetRootUser();
    }

    public bool Exist => collection.Count() > 0;

    public IEnumerable<User> GetAll() => collection.FindAll();

    public User GetById(string id) => collection.FindById(id);

    public bool Upsert(User entity) => collection.Upsert(entity);

    public bool Delete(string id) => collection.Delete(id);

    #region Extra
    private void SetRootUser()
    {
        if (Exist)
        {
            return;
        }

        collection.Upsert(new User() { UserID = ObjectId.NewObjectId().ToString(), Name = "root", Password = "admin", Role = UserRole.Administrator });
    }
    #endregion
}