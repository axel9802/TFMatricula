using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;
namespace Negocio
{
    public class nUsuario
    {
        dUsuario datosUser;

        public nUsuario()
        {
            datosUser = new dUsuario();
        }

        public string RegistrarProfesor(eUsuario user)
        {
            return datosUser.RegistrarProfesor(user);
        }

        public string RegistrarAlumno(eUsuario user)
        {
            return datosUser.RegistrarAlumno(user);
        }

        public string ModificarUsuario(eUsuario user)
        {
            return datosUser.Modificar(user);
        }

        public string EliminarUsuario(int dni)
        {
            return datosUser.Eliminar(dni);
        }

        public eUsuario LoginUsuario(int cod, int pass)
        {
            return datosUser.Login(cod, pass);
        }

        public eUsuario DatosUsuario(int cod)
        {
            return datosUser.Datos(cod);
        }

        public DataTable ListartodosUusarioss()
        {
            return datosUser.ListarTodo();
        }

        public List<eUsuario>listarProfes()
        {
            return datosUser.ListarProfes();
        }
        public List<eUsuario> listarAlumnos()
        {
            return datosUser.ListarAlumnos();
        }
        public List<eUsuario> listarUsuarios()
        {
            return datosUser.ListarUsuarios();
        }
    }
}
