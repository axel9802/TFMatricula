using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class eCurso
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Vacante { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}