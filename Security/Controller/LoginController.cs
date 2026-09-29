using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Security.Dtos;
using Security.Services;

namespace Security.Controller;

public class LoginController : ControllerBase
{
    private readonly IUserService _userService;

    public LoginController(IUserService userService)
    {
        _userService =  userService;
    }
    
    [HttpPost("/login")]
    public IActionResult Login([FromBody] UserDto userDto)
    {
        return Ok(_userService.TryLogin(new User()
        {
            Username = userDto.Username,
            Password = userDto.Password
        }));
    }
    
    [HttpPost("/register")]
    public void Create([FromBody] UserDto userDto)
    {
        _userService.TryRegister(new User()
        {
            Username = userDto.Username,
            Password = userDto.Password
        });
       
        
    }
}