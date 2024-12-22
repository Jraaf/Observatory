using ObservatoryAPI.DataAccess.Entities;

namespace ObservatoryAPI.BLL.DTO;

public class CreateObservationDTO
{
    public string Name { get; set; }
    public DateTime ScheduledTime { get; set; }
    public int SpaceObjectId { get; set; }
    public int EquipmentId { get; set; }
}
