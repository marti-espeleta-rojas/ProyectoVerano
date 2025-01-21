﻿using Microsoft.AspNetCore.Mvc;
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
