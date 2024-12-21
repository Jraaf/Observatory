using AutoMapper;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.BLL.Services;

public class SpaceObjectService : Crud<SpaceObject, CreateSpaceObjectDTO>, ISpaceObjectService
{
    public SpaceObjectService(IMapper mapper, ISpaceObjectRepository repo)
        : base(mapper, repo)
    {

    }
}