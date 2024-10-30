using EventsNew.logic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/<ProductsController>
        static List<Product> products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Pen" , OrdersAmount = 1100, stock = 1114},
            new Product() { Id = 2, Name = "Paper" , OrdersAmount = 11, stock = 999},
            new Product() { Id = 3, Name = "Book" , OrdersAmount = 7777, stock = 55},
            new Product() { Id = 4, Name = "table" , OrdersAmount = 88, stock = 1333114},
            new Product() { Id = 5, Name = "chair" , OrdersAmount = 111478, stock = 555},
            new Product() { Id = 6, Name = "Oranges" , OrdersAmount = 0, stock = 666},
            new Product() { Id = 7, Name = "computer" , OrdersAmount = 0, stock = 22},
            new Product() { Id = 8, Name = "keyboard" , OrdersAmount = 22, stock = 2222}
        };

        [HttpGet("page/{pageId}")]
        public IEnumerable<Product> Get(int pageId, [FromQuery] int isAmount, [FromQuery] int isOrderAmount, [FromQuery] int isProductId)
        {
          //Product p =  products.FirstOrDefault(product => product.Id == 5);
           
            if (isProductId > 0)
                products = products.OrderBy(o => o.Id).ToList();
            if (isOrderAmount > 0)
                products = products.OrderByDescending(o => o.OrdersAmount).ToList();

            return products;
        }

       

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
