using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class ObservationOrderRepository : Repo<ObservationOrder, int>, IObservationOrderRepository
{
    public ObservationOrderRepository(ApplicationDbContext cotnext)
        : base(cotnext)
    {

    }
}
