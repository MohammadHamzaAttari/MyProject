using Microsoft.EntityFrameworkCore;

public class MyProjectDbContext : DbContext
{

    public MyProjectDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "Pakistan",
                ShortName = "pk"
            },
            new Country
            {
                Id = 2,
                Name = "India",
                ShortName = "In"
            },
            new Country
            {
                Id = 3,
                Name = "Afganistan",
                ShortName = "Afg"
            }
        );
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "RuralArea",
                Rating = 4.2,
                Address = "Punjab,Pakistan",
                CountryId = 1
            },
            new Hotel
            {
                Id = 2,
                Name = "AlinaHotel",
                Rating = 4.5,
                Address = "Punjab,India",
                CountryId = 2
            },
            new Hotel
            {
                Id = 3,
                Name = "Rachna",
                Rating = 4.6,
                Address = "Kabul,Afghanistan",
                CountryId = 3
            }
        );
    }
}