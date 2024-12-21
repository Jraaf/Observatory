using AutoMapper;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.BLL.Services;

public class ObservationService : Crud<Observation, CreateObservationDTO>, IObservationService
{
    public ObservationService(IMapper mapper, IObservationRepository repo)
        : base(mapper, repo)
    {

    }
}