using LiteDB;

namespace PaintingClinic.Server.Models;

public class Client
{
    [BsonId]
    public string? Id { get; set; } 
    public object? Device { get; set; }
}

public class User
{
    [BsonId]
    public string? Id { get; set; } 
    public object? Contact { get; set; }
    public string? Role { get; set; }
    public bool IsBlocked { get; set; }
}

public class Token
{
    [BsonId]
    public string? Id { get; set; } //hash de ClientId:UserId
    public DateTime IssuedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
}