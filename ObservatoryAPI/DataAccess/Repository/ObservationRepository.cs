using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class ObservationRepository : Repo<Observation, int>, IObservationRepository
{
    public ObservationRepository(ApplicationDbContext cotnext)
    : base(cotnext)
    {

    }
}
