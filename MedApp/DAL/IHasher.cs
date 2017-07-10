using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedApp.DAL
{
    public interface IHasher
    {
        string GenerateSalt();
        string HashPassword(string password, string salt);
    }
}
