using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public List<Post> Posts { get; set; } = new();
    }
}
