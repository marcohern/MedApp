using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedApp.DAL
{
    public class DatosFactory
    {
        public static IDatos Create()
        {
            return new Datos(ContextFactory.Create());
        }
    }
}