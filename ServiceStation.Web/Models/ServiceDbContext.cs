using Microsoft.EntityFrameworkCore;
using System.Drawing.Imaging;

namespace ServiceStation.Web.Models
{
    public class ServiceDbContext : DbContext
    {
        public ServiceDbContext(DbContextOptions<ServiceDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(localdb)\MSSQLLocaldb;Database=ServiceStation;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleService> VehicleService { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
