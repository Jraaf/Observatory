namespace ObservatoryAPI.DataAccess.Entities;

public class ObservationOrder
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ObservationId { get; set; }
    public Observation Observation { get; set; }
    public User User { get; set; }
}
