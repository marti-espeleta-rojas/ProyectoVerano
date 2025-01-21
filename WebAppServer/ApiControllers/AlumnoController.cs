using Microsoft.AspNetCore.Mvc;
using WebAppServer.Models;
using WebAppServer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppServer.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        static AlumnoService servicio = new AlumnoService();

        #region Caso GetAll.
        // GET: api/<AlumnoController>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(servicio.GetAll());
        }
        #endregion

        #region CasoGetByID
        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]

        public IActionResult GetByID(int id)
        {
            return Ok(servicio.GetByID(id));
        }
        #endregion

        #region Caso Insert 
        // POST api/<AlumnoController>
        [HttpPost]
        public IActionResult PostInsert([FromBody] Alumno value)
        {
            var a = servicio.Insert(value);
            if (a !=null)
            {
                return Ok(a);
            }
            return BadRequest("No se pudo completar la operación");
        }
        #endregion

        #region Caso Update
        // PUT api/<AlumnoController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Alumno value)
        {
            var valorBool = servicio.Update(value);
            if (valorBool != false)
            {
                return Ok(value);
            }
            return BadRequest("No se pudo realizar la operación");
        }

        #endregion
        
        #region Caso Delete
        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var valorBool = servicio.Delete(id);
            if(valorBool != false)
            {
                return Ok();
            }
            return BadRequest("No se pudo realizar la operación");

        }
        #endregion
    }
}
