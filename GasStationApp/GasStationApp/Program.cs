using Microsoft.EntityFrameworkCore;
using GasStationApp;
using GasStationApp.Entities;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;

using (ApplicationContext db = new ApplicationContext(options))
{
    Manager andry = new Manager { Name = "Andry", SurName = "Garazh", PhoneNumber = "+375294159628", Age = 25 };
    db.Managers.Add(andry);
    db.SaveChanges();
}

