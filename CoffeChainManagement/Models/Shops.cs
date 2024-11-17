using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Models
{
    public class Shops
    {
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string OpeningHours { get; set; }
        public decimal Revenue { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }

    }
}
