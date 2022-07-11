using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodiezzaAPI.Data
{
    public class FoodInfoRepository
    {
        FoodiezzaContext context = null;

        public FoodInfoRepository(FoodiezzaContext context)
        {
            this.context = context;
        }

        public IEnumerable<FoodInfo>GetFoods()
        {
            return context.FoodInfo.ToList();
        }
        public void AddFood(FoodInfo f)
        {
            context.FoodInfo.Add(f);
            context.SaveChanges();
        }
        public void UpdateFood(FoodInfo f)
        {
            context.Entry<FoodInfo>(f).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteFood(int id)
        {
            FoodInfo f = context.FoodInfo.Find(id);
            context.FoodInfo.Remove(f);
            context.SaveChanges();
        }
    }
}
