using Microsoft.AspNetCore.Mvc;
using PaintingClinic.Share;

namespace PaintingClinic.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_userService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var user = _userService.GetById(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Upsert(User user)
    {
        var result = _userService.Upsert(user);
        if (result)
        {
            return Ok();
        }
        return BadRequest();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        var result = _userService.Delete(id);
        if (result)
        {
            return Ok();
        }
        return NotFound();
    }

    [HttpGet("{id}/role")]
    public IActionResult GetRoleById(string id)
    {
        var user = _userService.GetById(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user.Role);
    }

}