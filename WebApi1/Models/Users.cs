using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Models
{
    public class Users : Persona
    {
        public string NombreCorto { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
    }
}
