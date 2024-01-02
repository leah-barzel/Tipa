using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using System.Collections.Generic    ;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TipatChalav.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabyController : ControllerBase
    {

        //private readonly DataContex _context = new DataContex();
        private static List<Baby> babies = new List<Baby> { new Baby { Id = 1, Name = "default", DateBorn = DateTime.Now.Date } };
        // GET: api/<BabyController>
        [HttpGet]
        public IEnumerable<Baby> Get()
        {
            return babies;
        }
        // GET api/<BabyController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var Baby = babies.Find(b => b.Id == id);
            //return babys.Find(b => b.Id == id);
            if (Baby == null)
            {
                return NotFound();
            }
            return Ok(Baby);
        }

        // POST api/<BabyController>
        [HttpPost]
        public void Post( [FromBody] Baby baby)
        {

            babies.Add(baby);

        }

        // PUT api/<BabyController>/5
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] Baby updatedBaby)
        {
            var baby = babies.FirstOrDefault(b => b.Id == id);
            if (baby != null)
            {
                baby.Name = updatedBaby.Name;
                baby.DateBorn = updatedBaby.DateBorn;
                return Ok(baby);
            }
            return NotFound();

        }

        // DELETE api/<BabyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id, string name)
        {
            Baby baby = babies.Find(b => b.Id == id);
            if (baby != null)
            {
                babies.Remove(baby);
            }
        }
    }
}
    /*

        [Route("api/[controller]")]
        [ApiController]
        public class BabyController : ControllerBase
        {


            private readonly DataContex _context;
            public BabyController(IDataContex context)
            {
                _context = (DataContex?)context;
            }
            //= new DataContex();
            // private static List<Baby> babys = new List<Baby> { new Baby { Id = 1, Name = "default", DateBorn = DateTime.Now.Date } };
            // GET: api/<BabyController>
            [HttpGet]
            public IEnumerable<Baby> Get()
            {
                return _context.Babies.ToList();
            }
            // GET api/<BabyController>/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var Baby = _context.Babies.Find(b => b.Id == id);
                //return babys.Find(b => b.Id == id);
                if (Baby == null)
                {
                    return NotFound();
                }
                return Ok(Baby);
            }

            // POST api/<BabyController>
            [HttpPost]
            public void Post(int id, string name, DateTime dateTime, [FromBody] Baby baby)
            {

                _context.Babies.Add(baby);

            }

            // PUT api/<BabyController>/5
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody] Baby updatedBaby)
            {
                var baby = _context.Babies.FirstOrDefault(b => b.Id == id);
                if (baby != null)
                {
                    baby.Name = updatedBaby.Name;
                    baby.DateBorn = updatedBaby.DateBorn;
                    return Ok(baby);
                }
                return NotFound();

            }

            // DELETE api/<BabyController>/5
            [HttpDelete("{id}")]
            public void Delete(int id, string name)
            {
                Baby baby = _context.Babies.Find(b => b.Id == id);
                if (baby != null)
                {
                    _context.Babies.Remove(baby);
                }
            }
        }

        public interface IDataContex
        {
        }
    }








    */








