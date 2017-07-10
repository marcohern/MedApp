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

namespace MedApp.Controllers
{
    public class CitasController : ApiController
    {
        private IDatos datos;

        public CitasController()
        {
            datos = DatosFactory.Create();
        }

        // GET: api/Citas
        public IEnumerable<Cita> GetCitas()
        {
            return datos.Citas.TodosConDetalles();
        }

        // GET: api/Citas/5
        [ResponseType(typeof(Cita))]
        public IHttpActionResult GetCita(int id)
        {
            Cita cita = datos.Citas.Obtener(id);
            if (cita == null)
            {
                return NotFound();
            }

            return Ok(cita);
        }

        // PUT: api/Citas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCita(int id, Cita cita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cita.ID)
            {
                return BadRequest();
            }

            datos.Citas.Actualizar(cita);

            try
            {
                datos.GuardarCambios();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitaExists(id))
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

        // POST: api/Citas
        [ResponseType(typeof(Cita))]
        public IHttpActionResult PostCita(Cita cita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            datos.Citas.Crear(cita);
            datos.GuardarCambios();

            return CreatedAtRoute("DefaultApi", new { id = cita.ID }, cita);
        }

        // DELETE: api/Citas/5
        [ResponseType(typeof(Cita))]
        public IHttpActionResult DeleteCita(int id)
        {
            Cita cita = datos.Citas.Obtener(id);
            if (cita == null)
            {
                return NotFound();
            }

            datos.Citas.Eliminar(cita);
            datos.GuardarCambios();

            return Ok(cita);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                datos.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CitaExists(int id)
        {
            return datos.Citas.Existe(id);
        }
    }
}