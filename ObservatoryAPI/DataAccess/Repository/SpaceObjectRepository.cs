using Microsoft.EntityFrameworkCore;
using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;
using System.Linq.Expressions;

namespace ObservatoryAPI.DataAccess.Repository;

public class SpaceObjectRepository : Repo<SpaceObject, int>, ISpaceObjectRepository
{
    private readonly ApplicationDbContext context;

    public SpaceObjectRepository(ApplicationDbContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<SpaceObject>> GetAllAsync()
    {
        return await context.SpaceObjects
            .Include(s=>s.Researches)
            .ToListAsync();
    }
    public async new Task<SpaceObject> GetAsync(int id)
    {
        return await context.SpaceObjects
            .Include(s => s.Researches)
            .FirstOrDefaultAsync(s=>s.Id == id);
    }
}
