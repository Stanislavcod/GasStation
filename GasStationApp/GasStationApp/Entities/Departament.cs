using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Departament
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public Manager? Manager { get; set; }
    }
}
