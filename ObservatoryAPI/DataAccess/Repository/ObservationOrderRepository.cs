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

    public async Task<List<ObservationOrder>> GetMyOrders(int userId)
    {
        return await context.Orders
            .Where(o => o.UserId == userId)
            .ToListAsync();
    }
}
