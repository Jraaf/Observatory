using Microsoft.EntityFrameworkCore;
using ObservatoryAPI.DataAccess.Entities;

namespace ObservatoryAPI.DataAccess.EF;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Observation> Observations { get; set; }
    public DbSet<ObservationOrder> Orders { get; set; }
    public DbSet<SpaceObject> SpaceObjects { get; set; }
    public DbSet<Research> Researches { get; set; }
    public DbSet<User> Users { get; set; }
}
