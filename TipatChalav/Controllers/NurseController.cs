using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;



namespace TipatChalav.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class NurseController : ControllerBase

    {

        private static List<Nurse> nurses = new List<Nurse> { new Nurse { ID = 1, NAME = "default" } };



        [HttpGet]

        public IEnumerable<Nurse> Get()

        {

            return nurses;

        }



        [HttpGet("{id}")]

        public IActionResult Get(int id)

        {

            var nurse = nurses.Find(n => n.ID == id);

            if (nurse == null)

            {

                return NotFound();

            }

            return Ok(nurse);

        }



        [HttpPost]

        public void Post([FromBody] Nurse nurse)

        {

            nurses.Add(nurse);

        }



        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] Nurse updatedNurse)

        {

            var nurse = nurses.Find(n => n.ID == id);

            if (nurse != null)

            {

                nurse.NAME = updatedNurse.NAME;

                return Ok(nurse);

            }

            return NotFound();

        }



        [HttpDelete("{id}")]

        public void Delete(int id)

        {

            var nurse = nurses.Find(n => n.ID == id);

            if (nurse != null)

            {

                nurses.Remove(nurse);

            }

        }

    }

}