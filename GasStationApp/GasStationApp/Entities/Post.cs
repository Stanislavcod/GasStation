using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Post
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public List<Equipment> Equipments { get; set; } = new();

        public List<Employee> Employees { get; set; } = new();
    }
}
