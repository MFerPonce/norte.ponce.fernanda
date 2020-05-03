using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LPPA.WebSite.Models
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNac { get; set; }
    }
}