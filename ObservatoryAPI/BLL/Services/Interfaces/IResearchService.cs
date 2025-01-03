﻿using ObservatoryAPI.BLL.DTO;
using ObservatoryAPI.BLL.Services.Base;
using ObservatoryAPI.DataAccess.Entities;

namespace ObservatoryAPI.BLL.Services.Interfaces;

public interface IResearchService : ICrud<Research, CreateResearchDTO>
{
}
