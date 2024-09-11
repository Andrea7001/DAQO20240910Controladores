using DAQO20240910Controladores.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DAQO20240910Controladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {
        static List<Docente> docentes = new List<Docente>();

        // GET: api/<DocentesController>
        [HttpGet]
        public IEnumerable<Docente> Get()
        {
            return docentes;
        }

        // GET api/<DocentesController>/5
        [HttpGet("{id}")]
        public Docente Get(int id)
        {
            var docente = docentes.FirstOrDefault(d => d.Id == id);
            return docente;
        }

        // POST api/<DocentesController>
        [HttpPost]
        public IActionResult Post([FromBody] Docente docente)
        {
            docentes.Add(docente);
            return Ok();
        }

        // PUT api/<DocentesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Docente docente)
        {
            var existingDocente = docentes.FirstOrDefault(d => d.Id == id);
            if (existingDocente != null)
            {
                existingDocente.Nombre = docente.Nombre;
                existingDocente.Apellido = docente.Apellido;
                existingDocente.Materia = docente.Materia;
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<DocentesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingDocente = docentes.FirstOrDefault(d => d.Id == id);
            if (existingDocente != null)
            {
                docentes.Remove(existingDocente);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }

}

