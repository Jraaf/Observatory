using System.Reflection.Metadata.Ecma335;

namespace ObservatoryAPI.DataAccess.Entities;

public class SpaceObject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhotoUrl { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public ICollection<Research> Researches { get; set; }
}
