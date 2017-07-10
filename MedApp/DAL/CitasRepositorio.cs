using MedApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedApp.DAL
{
    public class CitasRepositorio : Repositorio<Cita>, ICitasRepositorio
    {
        public CitasRepositorio(DbContext context) : base(context)
        {

        }

        public MedAppContext MedAppContext
        {
            get
            {
                return this.context as MedAppContext;
            }
        }

        public IEnumerable<Cita> TodosConDetalles()
        {

            return MedAppContext.Citas
                .Include(p => p.Paciente)
                .Include(t => t.TipoCita)
                .ToList();
        }

        public bool Existe(int id)
        {
            int count = MedAppContext.Citas.Count(p => p.ID == id);
            return (count > 0) ? true : false;
        }
    }
}