using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi1.Models
{
    public class Cuenta : Persona
    {
        public string NumCta { get; set; }
        public string TipoCta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Estado { get; set; }

    }
}
