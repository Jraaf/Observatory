using Microsoft.EntityFrameworkCore;
using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class UserRepository : Repo<User, int>, IUserRepository
{
    private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context)
        : base(context)
    {
        _context = context;
    }
    public async Task<User?> GetByUsername(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(x =>
                     x.Username.ToLower() == username.ToLower());
    }

    public async Task<bool> UserExists(string username)
    {
        return await _context.Users.AnyAsync(x =>
            x.Username.ToLower() == username.ToLower());
    }
}
