using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;

namespace ObservatoryAPI.BLL.Services.Interfaces;

public interface ISpaceObjectService : ICrud<SpaceObject, CreateSpaceObjectDTO>
{
}
