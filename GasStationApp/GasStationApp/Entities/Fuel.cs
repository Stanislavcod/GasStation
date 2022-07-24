using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Fuel
    {
        [Key]
        public int Id { get; set; }
        public string? TypeOfFuel { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }

        public List<FuelPump> FuelPumps { get; set; } = new();

        public List<Order> Orders { get; set; } = new();
    }
}
