using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Order
    {
        [Key]
        public int Id { get; set; }
        public string? PaymentMethod { get; set; }
        public DateTime? OrderTime { get; set; }

        public List<Product>? Products { get; set; } = new();

        public int CustomerID { get; set; }
        public Customer? Customer { get; set; }

        public int? FuelPumpId { get; set; }
        public FuelPump? FuelPump { get; set; }

        public int? FuelId { get; set; }
        public Fuel? Fuel { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
