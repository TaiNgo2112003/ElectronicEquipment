using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ShopID { get; set; }
        public int Quantity { get; set; }
        public DateTime LastUpdated { get; set; }

        public virtual Product Product { get; set; }  // Relationship
        public virtual Shops Shop { get; set; }  // Relationship
    }
}
