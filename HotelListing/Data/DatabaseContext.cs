using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(new Country
            {
                Id = 1,
                Name = "Jamica",
                ShortName = "JM"
            }, new Country
            {
                Id = 2,
                Name = "Bahamas",
                ShortName = "BS"
            }, new Country
            {
                Id = 3,
                Name = "Cayman Island",
                ShortName = "CI"
            });

            builder.Entity<Hotel>().HasData(new Hotel
            {
                Id = 1,
                Name = "Jamica",
                Address = "Negril",
                Rating = 3,
                CountryId = 1
            }, new Hotel
            {
                Id = 2,
                Name = "Bahamas",
                Address = "George Town",
                Rating = 4.5,
                CountryId = 1
            }, new Hotel
            {
                Id = 3,
                Name = "Cayman Island",
                Address = "Nassue",
                Rating = 4,
                CountryId = 3
            });
        }
    }
}