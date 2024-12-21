using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Interfaces;

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
}
