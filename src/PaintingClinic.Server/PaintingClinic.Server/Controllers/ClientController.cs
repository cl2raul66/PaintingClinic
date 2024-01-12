using EasyAuth.Server.Tools;
using LiteDB;
using Microsoft.AspNetCore.Mvc;
using PaintingClinic.Server.Models;
using PaintingClinic.Server.Services;
using PaintingClinic.Share;

namespace PaintingClinic.Server.Controllers;

[Route("[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    readonly IClientService clientServ;
    readonly IEncodingString encoding;
    readonly ITokenService tokenServ;

    public ClientController(IClientService clientService, IEncodingString encodingString, ITokenService tokenService)
    {
        clientServ = clientService;
        encoding = encodingString;
        tokenServ = tokenService;
    }

    // GET: <ClientController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET <ClientController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST <ClientController>
    [HttpPost]
    public string Post([FromBody] ClientDto value)
    {
        Client newClient = new() { Id = ObjectId.NewObjectId().ToString(), Device = value.Device };
        clientServ.Insert(newClient);
        DateTime nowDt = DateTime.Now;
        return tokenServ.Insert(new Token { Id = encoding.ToSHA256Hash(newClient.Id), IssuedAt = nowDt, ExpiresAt = nowDt.AddDays(7) });
    }

    // PUT <ClientController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE <ClientController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
