using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class nCurso
    {
        dCurso datosCur;

        public nCurso()
        {
            datosCur = new dCurso();
        }

        public string ModificarCurso(eCurso c)
        {
            return datosCur.Modificar(c);
        }

        public string EliminarCurso(int cod)
        {
            return datosCur.Eliminar(cod);
        }

        public string RegistrarCurso(eCurso c)
        {
            return datosCur.Registrar(c);
        }

        public eCurso DatosCurso(int cod)
        {
            return datosCur.Datos(cod);
        }

        public List<eCurso>ListarCurso()
        {
            return datosCur.Listar();
        }
    }
}
