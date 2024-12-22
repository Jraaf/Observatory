using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;

namespace ObservatoryAPI.DataAccess.Repository.Interfaces;

public interface IObservationOrderRepository : IRepo<ObservationOrder, int>
{
    Task<List<ObservationOrder>> GetMyOrders(int userId);
}
