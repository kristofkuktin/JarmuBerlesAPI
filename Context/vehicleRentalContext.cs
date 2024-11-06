using JarmuBerlesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace JarmuBerlesAPI.Context
{
    public class vehicleRentalContext : DbContext
    {
        public vehicleRentalContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
