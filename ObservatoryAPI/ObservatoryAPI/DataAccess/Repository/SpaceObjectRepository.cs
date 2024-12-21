using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class SpaceObjectRepository : Repo<SpaceObject, int>, ISpaceObjectRepository
{
    public SpaceObjectRepository(ApplicationDbContext cotnext)
        : base(cotnext)
    {

    }
}
