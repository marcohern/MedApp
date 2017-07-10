using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MedApp.Models
{
    [JsonObject(IsReference = true)]
    public class TipoCita : Entidad
    {
        public string Descripcion { get; set; }

        public virtual ICollection<Cita> Citas { get; set; }
    }
}