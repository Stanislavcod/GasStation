using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class Order
    {
        [Key]
        public int Id { get; set; }
    }
}
