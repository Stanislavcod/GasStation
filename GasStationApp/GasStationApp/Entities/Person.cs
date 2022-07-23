using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
