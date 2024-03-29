﻿using LiteDB;
using PaintingClinic.Server.Models;

namespace PaintingClinic.Server.Services;

public interface IUserService
{
    bool Exist { get; }
    User? Get(string id);
    IEnumerable<User>? GetAll();
    void Insert(User entity);
    void Update(User entity);
    void Delete(string id);
}

public class UserService : IUserService
{
    readonly ILiteCollection<User> collection;

    public UserService(ISecurityDbService securityDb)
    {
        var db = securityDb.Db;
        collection = db!.GetCollection<User>();
    }

    public bool Exist => collection.Count() > 0;

    public void Delete(string id)
    {
        _ = collection.Delete(id);
    }

    public User? Get(string id)
    {
        var result = collection.FindById(id);
        return result;
    }

    public IEnumerable<User>? GetAll()
    {
        var result = collection.FindAll();
        return result;
    }

    public void Insert(User entity)
    {
        _ = collection.Insert(entity);
    }

    public void Update(User entity)
    {
        _ = collection.Update(entity);
    }
}