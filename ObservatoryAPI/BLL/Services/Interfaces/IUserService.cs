using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.DataAccess.Entities;

namespace ObservatoryAPI.BLL.Services.Interfaces;

public interface IUserService
{
    Task<bool> UserExists(string username);
    Task<UserDTO> Register(CreateUserDTO user);
    Task<UserDTO> Login(LoginUserDTO user);
    string CreateToken(User user);
    Task<User> GetMe(int userId);
}
