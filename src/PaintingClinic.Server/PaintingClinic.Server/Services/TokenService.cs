using LiteDB;
using PaintingClinic.Server.Models;

namespace PaintingClinic.Server.Services;

public interface ITokenService
{
    bool Exist { get; }
    Token? Get(string id);
    IEnumerable<Token>? GetAll();
    string Insert(Token entity);
    void Update(Token entity);
    void Delete(string id);
}

public class TokenService : ITokenService
{
    readonly ILiteCollection<Token> collection;

    public TokenService(ISecurityDbService securityDb)
    {
        var db = securityDb.Db;
        collection = db!.GetCollection<Token>();
    }

    public bool Exist => throw new NotImplementedException();

    public void Delete(string id)
    {
        throw new NotImplementedException();
    }

    public Token? Get(string id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Token>? GetAll()
    {
        throw new NotImplementedException();
    }

    public string Insert(Token entity)
    {
        var result = collection.Insert(entity);
        return result.ToString();
    }

    public void Update(Token entity)
    {
        throw new NotImplementedException();
    }
}
