using MedApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MedApp.DAL
{
    public class Repositorio<TEntidad> : IRepositorio<TEntidad> where TEntidad : class
    {

        protected DbContext context;

        public Repositorio(DbContext context)
        {
            this.context = context;
        }

        public IEnumerable<TEntidad> Buscar(Expression<Func<TEntidad, bool>> predicate)
        {
            return context.Set<TEntidad>().Where(predicate);
        }

        public void Actualizar(TEntidad entidad)
        {
            context.Entry<TEntidad>(entidad).State = EntityState.Modified;
        }

        public void Crear(TEntidad entidad)
        {
            context.Set<TEntidad>().Add(entidad);
        }

        public void Eliminar(TEntidad entidad)
        {
            context.Set<TEntidad>().Remove(entidad);
        }

        public TEntidad Obtener(int id)
        {
            return context.Set<TEntidad>().Find(id);
        }

        public IEnumerable<TEntidad> Todos()
        {
            return context.Set<TEntidad>().ToList();
        }
    }
}