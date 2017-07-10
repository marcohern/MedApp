using MedApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.DAL
{
    public interface ICitasRepositorio : IRepositorio<Cita>
    {
        bool Existe(int id);
        IEnumerable<Cita> TodosConDetalles();
    }
}
