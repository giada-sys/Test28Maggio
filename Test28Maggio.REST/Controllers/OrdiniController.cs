using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test28Maggio.EntityFramework;
using Test28Maggio.EntityFramework.Repositories;
using Test28Maggio.Library;

namespace Test28Maggio.REST.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrdiniController : ControllerBase
    {
        MainBL bl = new MainBL(new OrdiniEFRepository());

        [HttpGet]
        //Route -> Https://[HostName]/Ticket
        public ActionResult Get()
        {
            var result = bl.RecuperaTuttiOrdini();
           
            return Ok(result);
        }

        [HttpGet("{id}")]
        //Route -> Https://[HostName]/Ticket
        public ActionResult Get(int id)
        {
            var result = bl.RecuperaOrdine(id);

            return Ok(result);
        }
        //Creo Ordini
        [HttpPost]
        public ActionResult Post([FromBody] Ordine newOrdine)
        {
            if (newOrdine == null)
                return BadRequest("Invalid Ordine data.");

            bl.CreaOrdine(newOrdine);

            return Created($"/ticket/{newOrdine.Id}", newOrdine);
        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Ordine ordineModificato)
        {
            if (ordineModificato == null)
                return BadRequest("Invalid Book data.");

            if (id != ordineModificato.Id)
                return BadRequest("Book ISBNs don't match.");

            bl.ModificaOrdine(ordineModificato);

            return Ok();
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           
            var ordineDaCancellare = bl.RecuperaOrdine(id);

            if (ordineDaCancellare != null)
                bl.CancellaOrdine(ordineDaCancellare);

            return Ok();
        }
    }
}
