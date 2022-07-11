using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodiezzaAPI.Data
{
    public partial class BillingDetails
    {
        public int BillingId { get; set; }
        public int? UserId { get; set; }
        public int? OrderId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal? ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public decimal? SubTotal { get; set; }
        public string PaymentMode { get; set; }

        public virtual OrderDetails Order { get; set; }
        public virtual UserTable User { get; set; }
    }
}
