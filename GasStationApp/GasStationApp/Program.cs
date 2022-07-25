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

using (ApplicationContext db = new(options))
{   
    CreditCard credit1 = new() { Number = "4215 2563 8545 2452", CVV = 126 };
    db.CreditCards.Add(credit1);
    Customer mike = new() { Name = "Mike", CreditCard = credit1 };
    db.Customers.Add(mike);
    Post cashier = new() { Title = "Сashier", Description = "Main Cashier" };
    Post tanker = new() { Title = "tanker", Description = "tanker of 5 refueling column" };
    db.Posts.AddRange(cashier,tanker);
    Employee tom = new() { Name = "Tom", SurName = "Garaker", Age = 19, Salary = 1500, Post = cashier, PhoneNumber = "+375332547896" };
    Employee dima = new() { Name = "Dima", SurName = "Kafra", Age = 22, Salary = 1200, Post = tanker, PhoneNumber = "+375339533981" };
    db.Employees.AddRange(tom, dima);
    Departament alldepartament = new() { Title = "All station", Description = "all gas station" };
    db.Departaments.Add(alldepartament);
    Manager andry = new() { Name = "Andry", SurName = "Garazh", PhoneNumber = "+375294159628", Age = 25, Employees = {dima,tom }, Departament = alldepartament, Salary = 2500 };
    db.Managers.Add(andry);
    Fuel diesel = new() { TypeOfFuel = "Diesel", Price = 2.10M, Quantity = 150 };
    Fuel petrol = new() { TypeOfFuel = "Petrol", Price = 2.20M, Quantity = 120 };
    db.Fuels.AddRange(diesel, petrol);
    FuelPump fuelPump1 = new() { Fuels = { diesel, petrol }, Capacity = 300 };
    db.FuelPumps.Add(fuelPump1);
    Product water = new() { Name = "Aqua", Amount = 2, Desriptions = "non - carbonated", Price = 1.50M };
    db.Products.Add(water);
    Order firstOrder = new()
    {
        Products = {water},
        Customer = mike,
        Employee = tom,
        FuelPump = fuelPump1,
        Fuel = diesel,
        FuelQuantity = 5,
        PaymentMethod = "CreditCard",
        OrderTime = DateTime.Now
    };
    db.Orders.Add(firstOrder);
    db.SaveChanges();

    //Info about first order
    var infoFirstOrder = db.Orders.Include(a => a.FuelPump).Include(c => c.Customer)
        .ThenInclude(c => c.CreditCard).Include(f => f.Fuel).AsNoTracking().ToList();
    foreach (var item in infoFirstOrder)
    {
        Console.WriteLine($"Number Order: {item.Id}, NameOfCustomer: {item.Customer?.Name}, TypeOfPayment: {item.PaymentMethod} " +
            $"CreditCardCustomer: {item.Customer?.CreditCard?.Number}, Fuel: {item.Fuel?.TypeOfFuel}, Fuel Pump: {item.FuelPump?.Id}" +
            $"Info Fuel: {item.Fuel?.Price} ");
    }
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    //Delet Employee
    var employees = db.Employees.AsNoTracking().ToList();
    foreach(var employee in employees)
        Console.WriteLine($"Employees Name: {employee.Name}");
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    db.Employees.Remove(tom);
    db.SaveChanges();
    foreach(var item in employees)
    {
        Console.WriteLine($"Employees Name: {item.Name}");
    }
    Console.WriteLine("-------------------------------------------------------------------------------------------");
    //ChangeInfoOrdу
    Order orderChange = db.Orders.FirstOrDefault();
    if (orderChange != null)
    {
        orderChange.Fuel = petrol;
        db.SaveChanges();
        Console.WriteLine(orderChange.Fuel.TypeOfFuel);
    }
}
