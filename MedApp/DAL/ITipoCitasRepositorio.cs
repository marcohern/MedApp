using MedApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.DAL
{
    public interface ITipoCitasRepositorio : IRepositorio<TipoCita>
    {
        bool Existe(int id);
    }
}
