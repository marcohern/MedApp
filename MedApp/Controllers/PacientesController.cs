using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MedApp.DAL;
using MedApp.Models;
using MedApp.Filters;

namespace MedApp.Controllers
{
    [Secure]
    public class PacientesController : ApiController
    {
        private IDatos datos;

        public PacientesController()
        {
            datos = DatosFactory.Create();
        }

        // GET: api/Pacientes
        public IEnumerable<Paciente> GetPacientes()
        {
            return datos.Pacientes.Todos();
        }

        // GET: api/Pacientes/5
        [ResponseType(typeof(Paciente))]
        public IHttpActionResult GetPaciente(int id)
        {
            Paciente paciente = datos.Pacientes.Obtener(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return Ok(paciente);
        }

        // PUT: api/Pacientes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPaciente(int id, Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != paciente.ID)
            {
                return BadRequest();
            }

            datos.Pacientes.Actualizar(paciente);

            try
            {
                datos.GuardarCambios();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PacienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pacientes
        [ResponseType(typeof(Paciente))]
        public IHttpActionResult PostPaciente(Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            datos.Pacientes.Crear(paciente);
            datos.GuardarCambios();

            return CreatedAtRoute("DefaultApi", new { id = paciente.ID }, paciente);
        }

        // DELETE: api/Pacientes/5
        [ResponseType(typeof(Paciente))]
        public IHttpActionResult DeletePaciente(int id)
        {
            Paciente paciente = datos.Pacientes.Obtener(id);
            if (paciente == null)
            {
                return NotFound();
            }

            datos.Pacientes.Eliminar(paciente);
            datos.GuardarCambios();

            return Ok(paciente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                datos.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PacienteExists(int id)
        {
            return datos.Pacientes.Existe(id);
        }
    }
}