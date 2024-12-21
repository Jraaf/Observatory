using System.Data;

namespace ObservatoryAPI.BLL.DTO;

public class UserDTO
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string AccessToken { get; set; }
}