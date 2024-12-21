using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class ResearchRepository : Repo<Research, int>, IResearchRepository
{
    public ResearchRepository(ApplicationDbContext cotnext)
        : base(cotnext)
    {

    }
}
