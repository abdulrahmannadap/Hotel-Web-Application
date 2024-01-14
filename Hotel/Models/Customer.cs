using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models
{
    public class Customer
    {
        // Id store in database unique
        public int Id { get; set; }
        // Name proparty i use for Get Customer Name 
        public string? CustomerName { get; set; }

        /// <summary>
        /// this is foreignkey i use for create depandancy on Customer Table 
        /// </summary>
        public OrderList OrderList { get; set; }
        [ForeignKey("OrderList")]
        public int OrderListId { get; set; }
    }
}
