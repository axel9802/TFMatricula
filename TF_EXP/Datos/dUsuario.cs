using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
    public class dUsuario
    {
        DataBase db = new DataBase();

        public string RegistrarProfesor(eUsuario user)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into Usuario values({0},{1},'{2}','{3}','Profesor','{4}',{5},0)", user.Codigo, user.DNI, user.Nombre, user.Apellido, user.Correo, user.Contra, user.Cursos);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Usuario creado correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        public string RegistrarAlumno(eUsuario user)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into Usuario values({0},{1},'{2}','{3}','Alumno','{4}',{5},0)", user.Codigo, user.DNI, user.Nombre, user.Apellido, user.Correo, user.Contra, user.Cursos);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Usuario creado correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        public string Modificar(eUsuario user)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Usuario set Nombre='{0}', Apellido='{1}', Correo='{2}',Contra={3} where Codigo={4}", user.Nombre, user.Apellido, user.Correo, user.Contra, user.Codigo);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Datos del usuario modificados correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        public string Eliminar(int dni)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string delete = string.Format("delete from Usuario where DNI={0}", dni);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Usuario eliminado correctamente";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                db.DesconectaDB();
            }
        }

        public eUsuario Login(int cod, int pass)
        {
            try
            {
                eUsuario user = null;
                string select = string.Format("select * from Usuario where Codigo={0} and Contra={1}", cod, pass);
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new eUsuario();
                    user.Codigo = (int)reader["Codigo"];
                    user.DNI = (int)reader["DNI"];
                    user.Nombre = (string)reader["Nombre"];
                    user.Apellido = (string)reader["Apellido"];
                    user.Tipo = (string)reader["Tipo"];
                    user.Correo = (string)reader["Correo"];
                    user.Contra = (int)reader["Contra"];
                    user.Cursos = (int)reader["Cursos"];
                }
                reader.Close();
                return user;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }


        public DataTable ListarTodo()
        {
            SqlConnection con = db.ConectaDB();
            SqlDataAdapter da = new SqlDataAdapter("select codigo, dni, nombre, apellido, tipo, correo, contra from Usuario", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public eUsuario Datos(int cod)
        {
            try
            {
                eUsuario user = null;
                string select = string.Format("select * from Usuario where Codigo={0}", cod);
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user = new eUsuario();
                    user.Codigo = (int)reader["Codigo"];
                    user.DNI = (int)reader["DNI"];
                    user.Nombre = (string)reader["Nombre"];
                    user.Apellido = (string)reader["Apellido"];
                    user.Tipo = (string)reader["Tipo"];
                    user.Correo = (string)reader["Correo"];
                    user.Contra = (int)reader["Contra"];
                    user.Cursos = (int)reader["Cursos"];
                }
                reader.Close();
                return user;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public List<eUsuario> ListarProfes()
        {
            try
            {
                List<eUsuario> lista = new List<eUsuario>();
                eUsuario user = null;
                string select = string.Format("select * from Usuario where Tipo='Profesor'");
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new eUsuario();
                    user.Codigo = (int)reader["Codigo"];
                    user.DNI = (int)reader["DNI"];
                    user.Nombre = (string)reader["Nombre"];
                    user.Apellido = (string)reader["Apellido"];
                    user.Tipo = (string)reader["Tipo"];
                    user.Correo = (string)reader["Correo"];
                    user.Contra = (int)reader["Contra"];
                    user.Cursos = (int)reader["Cursos"];
                    lista.Add(user);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public List<eUsuario> ListarAlumnos()
        {
            try
            {
                List<eUsuario> lista = new List<eUsuario>();
                eUsuario user = null;
                string select = string.Format("select * from Usuario where Tipo='Alumno'");
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new eUsuario();
                    user.Codigo = (int)reader["Codigo"];
                    user.DNI = (int)reader["DNI"];
                    user.Nombre = (string)reader["Nombre"];
                    user.Apellido = (string)reader["Apellido"];
                    user.Tipo = (string)reader["Tipo"];
                    user.Correo = (string)reader["Correo"];
                    user.Contra = (int)reader["Contra"];
                    user.Cursos = (int)reader["Cursos"];
                    lista.Add(user);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
        public List<eUsuario> ListarUsuarios()
        {
            try
            {
                List<eUsuario> lista = new List<eUsuario>();
                eUsuario user = null;
                string select = string.Format("select * from Usuario");
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new eUsuario();
                    user.Codigo = (int)reader["Codigo"];
                    user.DNI = (int)reader["DNI"];
                    user.Nombre = (string)reader["Nombre"];
                    user.Apellido = (string)reader["Apellido"];
                    user.Tipo = (string)reader["Tipo"];
                    user.Correo = (string)reader["Correo"];
                    user.Contra = (int)reader["Contra"];
                    user.Cursos = (int)reader["Cursos"];
                    lista.Add(user);
                }
                reader.Close();
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
        }
    }
}