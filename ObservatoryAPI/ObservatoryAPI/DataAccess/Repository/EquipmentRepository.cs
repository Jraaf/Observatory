using ObservatoryAPI.DataAccess.EF;
using ObservatoryAPI.DataAccess.Entities;
using ObservatoryAPI.DataAccess.Repository.Base;
using ObservatoryAPI.DataAccess.Repository.Interfaces;

namespace ObservatoryAPI.DataAccess.Repository;

public class EquipmentRepository : Repo<Equipment, int>, IEquipmentRepository
{
    public EquipmentRepository(ApplicationDbContext cotnext) 
        : base(cotnext)
    {

    }
}
