using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public int PromotionId { get; set; }

        public virtual Customer Customer { get; set; }  // Relationship
        public virtual Promotion Promotion { get; set; }  // Relationship
    }
}
