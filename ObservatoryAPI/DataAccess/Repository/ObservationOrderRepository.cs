using Microsoft.EntityFrameworkCore;
using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class ObservationOrderRepository : Repo<ObservationOrder, int>, IObservationOrderRepository
{
    private readonly ApplicationDbContext context;

    public ObservationOrderRepository(ApplicationDbContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<ObservationOrder>> GetAllAsync()
    {
        return await context.Orders
            .Include(o => o.Observation)
            .ToListAsync();
    }
    public async Task<List<ObservationOrder>> GetMyOrders(int userId)
    {
        return await context.Orders
            .Include(o=>o.Observation)
            .Where(o => o.UserId == userId)
            .ToListAsync();
    }
}
