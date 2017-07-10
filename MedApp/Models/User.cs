using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedApp.Models
{
    public enum UserRole
    {
        Admin,
        Staff
    }

    [JsonObject(IsReference = true)]
    public class User : Entidad
    {
        [Index("UN_Username", IsUnique = true)]
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public UserRole Role { get; set; }
    }
}