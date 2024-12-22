using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Interfaces;
using System.Security.Claims;

namespace ObservatoryAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthentificationController(IUserService _service) : ControllerBase
{
    [HttpPost("register")]
    public async Task<ActionResult<UserDTO>> Register(CreateUserDTO dto)
    {
        return Ok(await _service.Register(dto));

    }
    [HttpPost("login")]
    public async Task<ActionResult<UserDTO>> Login(LoginUserDTO dto)
    {
        try
        {
            return Ok(await _service.Login(dto));
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }
    [Authorize]
    [HttpGet("GetMe")]
    public async Task<ActionResult<UserDTO>> GetMe()
    {
        var userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
        try
        {
            return Ok(await _service.GetMe(userId));
        }
        catch (Exception e)
        {
            return Unauthorized(e.Message);
        }
    }
}
