using Microsoft.EntityFrameworkCore;
using GasStationApp.Entities;

namespace GasStationApp
{
    internal class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<CreditCard> CreditCards { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Departament> Departaments { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Equipment> Equipments { get; set; } = null!;
        public DbSet<Fuel> Fuels { get; set; } = null!;
        public DbSet<FuelPump> FuelPumps { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Post> Posts { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<Employee>().HasData(new Employee
            {
                Name = "Tom",
                SurName = "Terakov",
                Age = 22,
                PhoneNumber = "+375298875845",
                Id = 1
            });
        }
    }
}
