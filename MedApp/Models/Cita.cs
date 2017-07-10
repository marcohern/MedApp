using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedApp.Models
{
    [JsonObject(IsReference = true)]
    public class Cita : Entidad
    {

        public int PacienteID { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoCitaID { get; set; }

        public virtual Paciente Paciente { get; set; }
        public virtual TipoCita TipoCita { get; set; }
    }
}