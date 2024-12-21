using AutoMapper;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.BLL.Services;

public class ObservationOrderService : Crud<ObservationOrder, CreateObservationOrderDTO>, IObservationOrderService
{
    public ObservationOrderService(IMapper mapper, IObservationOrderRepository repo)
        : base(mapper, repo)
    {

    }
}
