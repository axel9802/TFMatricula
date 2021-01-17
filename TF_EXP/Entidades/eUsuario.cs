using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eUsuario
    {
        public int Codigo { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Tipo { get; set; }
        public string Correo { get; set; }
        public int Contra { get; set; }
        public int Cursos { get; set; }
        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}