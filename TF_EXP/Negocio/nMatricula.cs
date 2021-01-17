using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class nMatricula
    {
        dMatricula datosMatricula;
        public nMatricula()
        {
            datosMatricula = new dMatricula();
        }
        public string RegistarMatricula(int codC,int codU,string cur)
        {
            eCurso curso = new eCurso()
            {
                Codigo = codC,
                Nombre = cur
            };
            eUsuario user = new eUsuario()
            {
                Codigo = codU
            };
            eMatricula mat = new eMatricula()
            {
                CodCurso = curso.Codigo,
                Curso = curso.Nombre,
                CodUsuario = user.Codigo
            };
            return datosMatricula.Registrar(mat);
        }
        public string EliminarMatricula(int id)
        {
            return datosMatricula.Eliminar(id);
        }
        public List<eMatricula> DatosMatriculados(int cod)
        {
            return datosMatricula.DatosMatriculados(cod);
        }
        public List<eMatricula> DatosMatriculaUsuario()
        {
            return datosMatricula.DatosUsuario();
        }
        public eMatricula DatosMatricula(int cod)
        {
            return datosMatricula.Matricula(cod);
        }
    }
}