using Microsoft.EntityFrameworkCore;
using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class ObservationRepository : Repo<Observation, int>, IObservationRepository
{
    private readonly ApplicationDbContext context;

    public ObservationRepository(ApplicationDbContext context)
    : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Observation>> GetAllAsync()
    {
        return await context.Observations
            .Include(o=>o.Equipment)
            .ToListAsync();
    }
}
