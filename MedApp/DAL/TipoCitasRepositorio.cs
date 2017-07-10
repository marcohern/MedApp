using MedApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedApp.DAL
{
    public class TipoCitasRepositorio : Repositorio<TipoCita>, ITipoCitasRepositorio
    {
        public TipoCitasRepositorio(DbContext context) : base(context)
        {

        }


        public MedAppContext MedAppContext
        {
            get
            {
                return this.context as MedAppContext;
            }
        }

        public bool Existe(int id)
        {
            int count = MedAppContext.TipoCitas.Count(p => p.ID == id);
            return (count > 0) ? true : false;
        }
    }
}