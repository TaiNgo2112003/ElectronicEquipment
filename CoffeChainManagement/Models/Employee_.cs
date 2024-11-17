using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Models
{
    internal class Employee_
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ShopID { get; set; }
        public string Position { get; set; }
        public DateTime HireDate { get; set; }

        public virtual Shops Shop { get; set; }  // Relationship
    }
}
