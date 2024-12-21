using AutoMapper;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.BLL.Services;

public class EquipmentService : Crud<Equipment, CreateEquipmentDTO>, IEquipmentService
{
    public EquipmentService(IMapper mapper, IEquipmentRepository repo)
        : base(mapper, repo)
    {

    }
}
