namespace ObservatoryAPI.DataAccess.Entities;

public class Observation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ScheduledTime { get; set; }
    public int SpaceObjectId { get; set; }
    public SpaceObject SpaceObject { get; set; }
    public int EquipmentId { get; set; }
    public Equipment Equipment { get; set; }
}
