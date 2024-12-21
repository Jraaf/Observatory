using AutoMapper;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.DataAccess.Entities;

namespace ObservatoryAPI.BLL.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateEquipmentDTO, Equipment>();
        CreateMap<CreateObservationDTO, Observation>();
        CreateMap<CreateObservationOrderDTO, ObservationOrder>();
        CreateMap<CreateResearchDTO, Research>();
        CreateMap<CreateSpaceObjectDTO, SpaceObject>();
        CreateMap<User, UserDTO>();
    }
}
