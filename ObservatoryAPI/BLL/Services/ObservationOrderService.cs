using AutoMapper;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.BLL.Services;

public class ObservationOrderService : Crud<ObservationOrder, CreateObservationOrderDTO>, IObservationOrderService
{
    private readonly IMapper mapper;
    private readonly IObservationOrderRepository repo;

    public ObservationOrderService(IMapper mapper, IObservationOrderRepository repo)
        : base(mapper, repo)
    {
        this.mapper = mapper;
        this.repo = repo;
    }

    public async Task<List<ObservationOrder>> GetMyOrders(int userId)
    {
        return await repo.GetMyOrders(userId);
    }
}
