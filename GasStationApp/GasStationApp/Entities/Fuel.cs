using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Fuel
    {
        [Key]
        public int Id { get; set; }
        public string? TypeOfFuel { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public double Volume { get; set; }

        public List<FuelPump> Pumps { get; set; } = new();
    }
}
