using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class FuelPump
    {
        [Key]
        public int Id { get; set; }

        public double Capacity { get; set; }
        
        public List<Fuel> Fuels { get; set; } = new();
    }
}
