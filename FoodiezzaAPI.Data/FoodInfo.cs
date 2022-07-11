using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FoodiezzaAPI.Data
{
    public partial class FoodInfo
    {
        public FoodInfo()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public int? Price { get; set; }
        public int? Rating { get; set; }
        public string Category { get; set; }
        public string CookTime { get; set; }
        public string ImageUrl { get; set; }
        public decimal? FoodQuantity { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
