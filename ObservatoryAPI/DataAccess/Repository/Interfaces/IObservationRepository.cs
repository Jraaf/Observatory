using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;

namespace ObservatoryAPI.DataAccess.Repository.Interfaces;

public interface IObservationRepository : IRepo<Observation, int>
{
}
