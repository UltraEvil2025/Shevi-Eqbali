using EventsNew.logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        Events[] events = { new Events() { start = new DateTime(), title = "תור לרופא שיניים" },
             new Events() { start = new DateTime().AddDays(2), title = "לא לשכוח ללכת לקחת את השקית" }};
        // GET: api/<ValuesController>
        [HttpGet]
        public Events[] Get( )
        {
           
            return events;
        }

        // GET api/<ValuesController>/5
       
        [HttpGet("calender/{id}")]
        public int Get(int id)
        {
            return 2;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
