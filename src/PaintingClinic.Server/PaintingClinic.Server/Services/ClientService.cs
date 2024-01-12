using LiteDB;
using PaintingClinic.Server.Models;

namespace PaintingClinic.Server.Services;

public interface IClientService
{
    bool Exist {  get; }
    Client? Get(string id);
    IEnumerable<Client>? GetAll();
    void Insert(Client entity);
    void Update(Client entity);
    void Delete(string id);
}

public class ClientService : IClientService
{
    readonly ILiteCollection<Client> collection;

    public ClientService(ISecurityDbService securityDb)
    {
        var db = securityDb.Db;
        collection = db!.GetCollection<Client>();
    }

    public bool Exist => collection.Count() > 0;

    public void Delete(string id)
    {
        _ = collection.Delete(id);
    }

    public Client? Get(string id)
    {
        var result = collection.FindById(id);
        return result;
    }

    public IEnumerable<Client>? GetAll()
    {
        var result = collection.FindAll();
        return result;
    }

    public void Insert(Client entity)
    {
        _ = collection.Insert(entity);
    }

    public void Update(Client entity)
    {
        _ = collection.Update(entity);
    }
}
