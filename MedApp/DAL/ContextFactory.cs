using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MedApp.DAL
{
    public class ContextFactory
    {
        public static DbContext Create()
        {
            return new MedAppContext();
        }
    }
}