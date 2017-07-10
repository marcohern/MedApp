using MedApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedApp.DAL
{
    public interface IPacientesRepositorio : IRepositorio<Paciente>
    {
        bool Existe(int id);
    }
}