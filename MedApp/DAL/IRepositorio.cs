using MedApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MedApp.DAL
{
    public interface IRepositorio<TEntidad> where TEntidad : class
    {
        void Crear(TEntidad entidad);
        void Eliminar(TEntidad entidad);
        TEntidad Obtener(int id);
        void Actualizar(TEntidad entidad);

        IEnumerable<TEntidad> Todos();
        IEnumerable<TEntidad> Buscar(Expression<Func<TEntidad, bool>> predicate);
    }
}