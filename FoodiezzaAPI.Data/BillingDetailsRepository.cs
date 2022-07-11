using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FoodiezzaAPI.Data
{
    public class BillingDetailsRepository
    {
        FoodiezzaContext context = null;

        public BillingDetailsRepository(FoodiezzaContext context)
        {
            this.context = context;
        }
        public IEnumerable<BillingDetails> GetBillingDetails()
        {
            return context.BillingDetails.ToList();
        }
        public void AddBillingDetails(BillingDetails b)
        {
            context.BillingDetails.Add(b);
            context.SaveChanges();
        }
        public void UpdateBillingDetails(BillingDetails b)
        {
            context.Entry<BillingDetails>(b).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteBillingDetails(int id)
        {
            BillingDetails b = context.BillingDetails.Find(id);
            context.BillingDetails.Remove(b);
            context.SaveChanges();
        }
    }
}
