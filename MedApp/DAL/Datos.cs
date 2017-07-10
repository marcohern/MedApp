using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedApp.DAL
{
    public class Datos : IDatos
    {
        private DbContext context;
        public Datos(DbContext context) 
        {
            this.context = context;
            Pacientes = new PacientesRepositorio(context);
            TipoCitas = new TipoCitasRepositorio(context);
            Citas = new CitasRepositorio(context);
        }

        public IPacientesRepositorio Pacientes { get; private set; }
        public ITipoCitasRepositorio TipoCitas { get; private set; }
        public ICitasRepositorio Citas { get; private set; }

        public int GuardarCambios()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}