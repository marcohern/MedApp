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
    public class TipoCitasController : ApiController
    {
        private IDatos datos;

        public TipoCitasController()
        {
            datos = DatosFactory.Create();
        }

        // GET: api/TipoCitas
        public IEnumerable<TipoCita> GetTipoCitas()
        {
            return datos.TipoCitas.Todos();
        }

        // GET: api/TipoCitas/5
        [ResponseType(typeof(TipoCita))]
        public IHttpActionResult GetTipoCita(int id)
        {
            TipoCita tipoCita = datos.TipoCitas.Obtener(id);
            if (tipoCita == null)
            {
                return NotFound();
            }

            return Ok(tipoCita);
        }

        // PUT: api/TipoCitas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoCita(int id, TipoCita tipoCita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoCita.ID)
            {
                return BadRequest();
            }

            datos.TipoCitas.Actualizar(tipoCita);

            try
            {
                datos.GuardarCambios();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoCitaExists(id))
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

        // POST: api/TipoCitas
        [ResponseType(typeof(TipoCita))]
        public IHttpActionResult PostTipoCita(TipoCita tipoCita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            datos.TipoCitas.Crear(tipoCita);
            datos.GuardarCambios();

            return CreatedAtRoute("DefaultApi", new { id = tipoCita.ID }, tipoCita);
        }

        // DELETE: api/TipoCitas/5
        [ResponseType(typeof(TipoCita))]
        public IHttpActionResult DeleteTipoCita(int id)
        {
            TipoCita tipoCita = datos.TipoCitas.Obtener(id);
            if (tipoCita == null)
            {
                return NotFound();
            }

            datos.TipoCitas.Eliminar(tipoCita);
            datos.GuardarCambios();

            return Ok(tipoCita);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                datos.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoCitaExists(int id)
        {
            return datos.TipoCitas.Existe(id);
        }
    }
}