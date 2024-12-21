using AutoMapper;
using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.BLL.Services.Interfaces;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.BLL.Services;

public class ResearchService : Crud<Research, CreateResearchDTO>, IResearchService
{
    public ResearchService(IMapper mapper, IResearchRepository repo)
        : base(mapper, repo)
    {

    }
}