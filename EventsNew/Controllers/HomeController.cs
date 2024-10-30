using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EventsNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        static List<string> allStudents = new List<string> {"Sara","Rivka" };

        public HomeController()
        {

        }

        // GET: api/<HomeController>
        [HttpGet]
        public string[] Get()
        {
            return allStudents.ToArray();
        }

        //[HttpGet("GelAllValues1")]
        //public IEnumerable<string> Get1()
        //{
        //    return allStudents;

        //}
        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HomeController>
        [HttpPost]
        public void Post(string value, int age)
        {
           
            allStudents.Add(value);
        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("Delete{name}")]
        public void Delete(string name)
        {
            allStudents.Remove(name);
        }
    }
}
