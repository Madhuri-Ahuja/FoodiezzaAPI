using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodiezzaAPI.Data
{
    public partial class OrderDetails
    {
        public OrderDetails()
        {
            BillingDetails = new HashSet<BillingDetails>();
        }

        public int OrderId { get; set; }
        public int? FoodId { get; set; }
        public int? UserId { get; set; }
        public int Quantity { get; set; }
        public decimal? SubTotal { get; set; }

        public virtual FoodInfo Food { get; set; }
        public virtual UserTable User { get; set; }
        public virtual ICollection<BillingDetails> BillingDetails { get; set; }
    }
}
