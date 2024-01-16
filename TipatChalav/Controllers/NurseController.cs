using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using Tipa.Core.services;
using Tipa.Service;

namespace TipatChalav.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class NurseController : ControllerBase
    {
        //private static List<Nurse> nurses = new List<Nurse> { new Nurse { Id = 1, Name = "default" } };

        private readonly INurseService _nurseService;
        public NurseController(INurseService nurseService)
        {
            _nurseService = nurseService;   
        }


        [HttpGet]

        public IEnumerable<Nurse> Get()

        {

            return _nurseService.GetAll();

        }



        [HttpGet("{id}")]

        public ActionResult Get(int id)

        {
            var nurse = _nurseService.GetById(id);

            if (nurse == null)

            {
                return NotFound();
            }
            return Ok(nurse);

        }



        [HttpPost]

        public ActionResult Post([FromBody] Nurse nurse)

        {
            var newNurse = _nurseService.add(nurse);

            return Ok(newNurse);
        }



        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Nurse updatedNurse)
        {
            if (updatedNurse != null)
            {
            var nurse = _nurseService.Update(id, updatedNurse);

                return Ok(nurse);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)

        {

            var nurse = _nurseService.GetById(id);

            if (nurse is null)
            {
                return NotFound();
            }
            _nurseService.delete(id);
            return NoContent(); 

        }

    }

}