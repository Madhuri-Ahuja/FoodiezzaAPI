using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodiezzaAPI.Data
{
    public class OrderDetailsRepository
    {
        FoodiezzaContext context = null;

        public OrderDetailsRepository(FoodiezzaContext context)
        {
            this.context = context;
        }
        public IEnumerable<OrderDetails> GetOrderDetails()
        {
            return context.OrderDetails.ToList();
        }
        public void AddOrder(OrderDetails o)
        {
            context.OrderDetails.Add(o);
            context.SaveChanges();
        }
        public void DeleteOrder(int id)
        {
            OrderDetails o = context.OrderDetails.Find(id);
            context.OrderDetails.Remove(o);
            context.SaveChanges();
        }
    }
}
