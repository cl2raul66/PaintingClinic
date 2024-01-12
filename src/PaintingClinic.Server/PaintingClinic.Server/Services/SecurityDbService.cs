using LiteDB;

namespace PaintingClinic.Server.Services;

public interface ISecurityDbService
{
    LiteDatabase? Db { get; }
}

public class SecurityDbService : ISecurityDbService
{
    readonly IConfiguration conf;

    public SecurityDbService(IConfiguration configuration)
    {
        conf = configuration;
        string DIR_DB = Path.Combine(AppContext.BaseDirectory, "db");
        if (!Directory.Exists(DIR_DB))
        {
            Directory.CreateDirectory(DIR_DB);
        }
        var cnx = new ConnectionString()
        {
            Filename = Path.Combine(DIR_DB, conf["SecurityDbOptions:Filename"]!),
            Password = conf["SecurityDbOptions:Password"]!
            //Filename = Path.Combine(DIR_DB, "Security.db"),
            //Password = "12345678"
        };
        Db = new LiteDatabase(cnx);
    }

    public LiteDatabase? Db { private set; get; }
}
