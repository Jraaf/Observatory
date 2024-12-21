using ObservatoryAPI.DataAccess.Entities;

namespace ObservatoryAPI.BLL.DTO;

public class CreateObservationDTO
{
    public string Name { get; set; }
    public DateTime SceduledTime { get; set; }
    public int SpaceObjectId { get; set; }
    public int EquipmentId { get; set; }
    public int UserId { get; set; }
}
