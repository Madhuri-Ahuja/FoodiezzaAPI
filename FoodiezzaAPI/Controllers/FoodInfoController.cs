using FoodiezzaAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodiezzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodInfoController : ControllerBase
    {
        FoodInfoRepository repository = null;
       
        public FoodInfoController(FoodiezzaContext context)
        {
            this.repository = new FoodInfoRepository(context);
            
        }
        // GET: api/<FoodInfoController>
        [HttpGet]
        public IEnumerable<FoodInfo> Get()
        {
            return repository.GetFoods();
        }

        // GET api/<FoodInfoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FoodInfoController>
        [HttpPost]
        public void Post([FromBody] FoodInfo value)
        {
            repository.AddFood(value);

        }

        // PUT api/<FoodInfoController>/5
        [HttpPut]
        public void Put([FromBody] FoodInfo value)
        {
            repository.UpdateFood(value);
        }

        // DELETE api/<FoodInfoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.DeleteFood(id);
        }
       

    }
}
