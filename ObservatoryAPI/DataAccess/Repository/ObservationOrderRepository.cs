using Microsoft.EntityFrameworkCore;
using ObservatoryAPI.BLL;
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
    public async new Task<ObservationOrder> AddAsync(ObservationOrder entity)
    {
        var order = await context.Orders
            .FirstOrDefaultAsync(o => o.UserId == entity.UserId && o.ObservationId == entity.ObservationId);

        if (order != null)
        {
            throw new OrderExceprion("Order is alrady placed");
        }

        return await base.AddAsync(entity);
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
