using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MedApp.Models
{
    public enum Sexo
    {
        Masculino, Femenino
    }

    [JsonObject(IsReference = true)]
    public class Paciente : Entidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Sexo Sexo { get; set; }

        public string SexoStr
        {
            get
            {
                return Sexo.ToString();
            }
        }
        
        public virtual ICollection<Cita> Citas { get; set; }
    }
}