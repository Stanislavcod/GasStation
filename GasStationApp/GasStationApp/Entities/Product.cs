using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Desriptions { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public List<Order> Orders { get; set; } = new();

    }
}
