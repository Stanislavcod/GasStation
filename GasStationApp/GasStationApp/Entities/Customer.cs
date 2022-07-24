using System.ComponentModel.DataAnnotations.Schema;

namespace GasStationApp.Entities
{
    internal class Customer : Person 
    {
        [ForeignKey("CreditCardId")]
        public int CreditCardId { get; set; }
        public CreditCard? CreditCard { get; set; }
        
        public Order? Order { get; set; }
    }
}
