using RestoRite_Entities.DataModels;
using Microsoft.EntityFrameworkCore;

namespace RestoRite_DataAccessLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Restaurant> Restaurants { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Menu> Menus { get; set; }

        public virtual DbSet<RestaurantBranch> RestaurantBranches { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<Rating> Ratings { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Seed();

            // Seed data for Country table
            modelBuilder.Entity<Country>().HasData(
                           new Country { Id = 1, CountryName = "United States" },
                           new Country { Id = 2, CountryName = "Canada" },
                           new Country { Id = 3, CountryName = "United Kingdom" },
                           new Country { Id = 4, CountryName = "Australia" },
                           new Country { Id = 5, CountryName = "Germany" },
                           new Country { Id = 6, CountryName = "France" },
                           new Country { Id = 7, CountryName = "Italy" },
                           new Country { Id = 8, CountryName = "Spain" },
                           new Country { Id = 9, CountryName = "Japan" },
                           new Country { Id = 10, CountryName = "China" },
                           new Country { Id = 11, CountryName = "India" },
                           new Country { Id = 12, CountryName = "Brazil" },
                           new Country { Id = 13, CountryName = "Russia" },
                           new Country { Id = 14, CountryName = "South Korea" },
                           new Country { Id = 15, CountryName = "South Africa" }
                       );

            // Seed data for City table
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, CityName = "New York", CountryId = 1 },
                new City { Id = 2, CityName = "Los Angeles", CountryId = 1 },
                new City { Id = 3, CityName = "Chicago", CountryId = 1 },
                new City { Id = 4, CityName = "Houston", CountryId = 1 },
                new City { Id = 5, CityName = "Toronto", CountryId = 2 },
                new City { Id = 6, CityName = "Vancouver", CountryId = 2 },
                new City { Id = 7, CityName = "Montreal", CountryId = 2 },
                new City { Id = 8, CityName = "London", CountryId = 3 },
                new City { Id = 9, CityName = "Manchester", CountryId = 3 },
                new City { Id = 10, CityName = "Birmingham", CountryId = 3 },
                new City { Id = 11, CityName = "Sydney", CountryId = 4 },
                new City { Id = 12, CityName = "Melbourne", CountryId = 4 },
                new City { Id = 13, CityName = "Brisbane", CountryId = 4 },
                new City { Id = 14, CityName = "Berlin", CountryId = 5 },
                new City { Id = 15, CityName = "Munich", CountryId = 5 },
                new City { Id = 16, CityName = "Frankfurt", CountryId = 5 },
                new City { Id = 17, CityName = "Paris", CountryId = 6 },
                new City { Id = 18, CityName = "Lyon", CountryId = 6 },
                new City { Id = 19, CityName = "Marseille", CountryId = 6 },
                new City { Id = 20, CityName = "Rome", CountryId = 7 },
                new City { Id = 21, CityName = "Milan", CountryId = 7 },
                new City { Id = 22, CityName = "Naples", CountryId = 7 },
                new City { Id = 23, CityName = "Madrid", CountryId = 8 },
                new City { Id = 24, CityName = "Barcelona", CountryId = 8 },
                new City { Id = 25, CityName = "Valencia", CountryId = 8 },
                new City { Id = 26, CityName = "Tokyo", CountryId = 9 },
                new City { Id = 27, CityName = "Osaka", CountryId = 9 },
                new City { Id = 28, CityName = "Kyoto", CountryId = 9 },
                new City { Id = 29, CityName = "Beijing", CountryId = 10 },
                new City { Id = 30, CityName = "Shanghai", CountryId = 10 },
                new City { Id = 31, CityName = "Shenzhen", CountryId = 10 },
                new City { Id = 32, CityName = "Mumbai", CountryId = 11 },
                new City { Id = 33, CityName = "Delhi", CountryId = 11 },
                new City { Id = 34, CityName = "Bangalore", CountryId = 11 },
                new City { Id = 35, CityName = "São Paulo", CountryId = 12 },
                new City { Id = 36, CityName = "Rio de Janeiro", CountryId = 12 },
                new City { Id = 37, CityName = "Brasília", CountryId = 12 },
                new City { Id = 38, CityName = "Moscow", CountryId = 13 },
                new City { Id = 39, CityName = "Saint Petersburg", CountryId = 13 },
                new City { Id = 40, CityName = "Novosibirsk", CountryId = 13 },
                new City { Id = 41, CityName = "Seoul", CountryId = 14 },
                new City { Id = 42, CityName = "Busan", CountryId = 14 },
                new City { Id = 43, CityName = "Incheon", CountryId = 14 },
                new City { Id = 44, CityName = "Johannesburg", CountryId = 15 },
                new City { Id = 45, CityName = "Cape Town", CountryId = 15 },
                new City { Id = 46, CityName = "Durban", CountryId = 15 }
            );

        }

    }
}