using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    [Table("Managers")]
    internal class Manager : Person
    {
        public string? SurName { get; set; }
        public decimal Salary { get; set; }

        public int? DepartamentId { get; set; }
        public Departament? Departament { get; set; }

        public List<Employee> Employees { get; set; } = new();

    }
}
