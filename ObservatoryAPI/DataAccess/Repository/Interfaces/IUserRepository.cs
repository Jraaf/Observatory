using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;

namespace ObservatoryAPI.DataAccess.Repository.Interfaces;

public interface IUserRepository : IRepo<User, int>
{
    Task<bool> UserExists(string username);
    Task<User> GetByUsername(string username);
}
