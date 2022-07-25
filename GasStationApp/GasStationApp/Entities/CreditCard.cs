using System.ComponentModel.DataAnnotations;

namespace GasStationApp.Entities
{
    internal class CreditCard
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public int CVV { get; set; }
        
        public Customer? Customer { get; set; }
    }
}
