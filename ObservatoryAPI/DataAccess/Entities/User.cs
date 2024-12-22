using System.Text.Json.Serialization;

namespace ObservatoryAPI.DataAccess.Entities;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public bool IsAdmin { get; set; }
    [JsonIgnore]
    public byte[] PasswordHash { get; set; }
    [JsonIgnore]
    public byte[] PasswordSalt { get; set; }
}
