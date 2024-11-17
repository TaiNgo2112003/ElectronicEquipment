using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Models
{
    public class Shipping
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ShippingAddress { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public virtual Order Order { get; set; }  // Relationship
    }
}
