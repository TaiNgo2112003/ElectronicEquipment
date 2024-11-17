using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeChainManagement.Icon
{
    internal class User
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Full Name must be maximum 100 characters")]
        public string FullName { get; set; }

        [StringLength(20, ErrorMessage = "Phone Number must be maximum 20 characters")]
        public string PhoneNumber { get; set; }

        [StringLength(255, ErrorMessage = "Address must be maximum 255 characters")]
        public string Address { get; set; }
    }
}
