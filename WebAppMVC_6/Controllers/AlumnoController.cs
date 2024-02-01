using Microsoft.AspNetCore.Mvc;
using WebAppMVC_6.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppMVC_6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        List<Alumno> ListaAlumnos = new List<Alumno>();
        public AlumnoController() {
            ListaAlumnos.Add(new Alumno(1, "christian", "garrett", "asfd@asdf"));
            ListaAlumnos.Add(new Alumno(2, "christian", "garrett", "asfd@asdf"));
            ListaAlumnos.Add(new Alumno(3, "christian", "garrett", "asfd@asdf"));
            ListaAlumnos.Add(new Alumno(4, "christian", "garrett", "asfd@asdf"));

        }
        // GET: api/<AlumnoController>
        [HttpGet]
        public List<Alumno> Get()
        {
            return ListaAlumnos;
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
