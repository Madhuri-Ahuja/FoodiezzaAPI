using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodiezzaAPI.Data
{
    public partial class UserTable
    {
        public UserTable()
        {
            BillingDetails = new HashSet<BillingDetails>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<BillingDetails> BillingDetails { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
