using System.ComponentModel.DataAnnotations.Schema;

namespace GasStationApp.Entities
{
    [Table("Employees")]
    internal class Employee : Person
    {
        public decimal Salary { get; set; }
        public string? SurName { get; set; }

        public int? PostId { get; set; }
        public Post? Post { get; set; }

        public int? ManagerId { get; set; }
        public Manager? Manager { get; set; }

        public List<Order> Orders { get; set; } = new();
    }
}
