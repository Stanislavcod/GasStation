using System.ComponentModel.DataAnnotations.Schema;

namespace GasStationApp.Entities
{
    internal class Manager : Person
    {
        public string? SurName { get; set; }
        public decimal Salary { get; set; }


        [ForeignKey("DepartamentId")]
        public int DepartamentId { get; set; }
        public Departament? Departament { get; set; }

        public List<Employee> Employees { get; set; } = new();
    }
}
