
using Microsoft.AspNetCore.Mvc;

using System;

using System.Collections.Generic;



namespace TipatChalav.Controllers

{

    [Route("api/[controller]")]

    [ApiController]

    public class TurnController : ControllerBase

    {

        private static List<Turn> turns = new List<Turn> { new Turn { Id = 1, Name = "default", Date = DateTime.Now.Date } };



        [HttpGet]

        public IEnumerable<Turn> Get()

        {

            return turns;

        }



        [HttpGet("{id}")]

        public IActionResult Get(int id)

        {

            var turn = turns.Find(t => t.Id == id);

            if (turn == null)

            {

                return NotFound();

            }

            return Ok(turn);

        }



        [HttpPost]

        public void Post([FromBody] Turn turn)

        {

            turns.Add(turn);

        }



        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] Turn updatedTurn)

        {

            var turn = turns.Find(t => t.Id == id);

            if (turn != null)

            {

                turn.Name = updatedTurn.Name;

                turn.Date = updatedTurn.Date;

                return Ok(turn);

            }

            return NotFound();

        }



        [HttpDelete("{id}")]

        public void Delete(int id)

        {

            var turn = turns.Find(t => t.Id == id);

            if (turn != null)

            {

                turns.Remove(turn);
            }
        }
    }
}