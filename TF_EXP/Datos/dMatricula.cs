using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class dMatricula
    {
        DataBase db = new DataBase();
        
        public string Registrar(eMatricula mat)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into UsuarioCurso values({0},{1},'{2}')", mat.CodUsuario, mat.CodCurso, mat.Curso);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Matrícula registrada correctamente";
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

        public string Eliminar(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string delete = string.Format("delete from UsuarioCurso where id={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Matrícula de curso eliminado correctamente";
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

        public List<eMatricula> DatosMatriculados(int cod)
        {
            List<eMatricula> lista = new List<eMatricula>();
            try
            {
                
                eMatricula mat = null;
                SqlConnection con = db.ConectaDB();
                string select = string.Format("SELECT * FROM UsuarioCurso,Curso WHERE Curso.Codigo = UsuarioCurso.CodCurso AND UsuarioCurso.CodUsuario = {0}", cod);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    mat = new eMatricula();
                    mat.CodCurso = (int)reader["Codigo"];
                    mat.CodUsuario = (int)reader["CodUsuario"];
                    mat.Curso = (string)reader["Curso"];
                    lista.Add(mat);
                }
                reader.Close();
                
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                db.DesconectaDB();
            }
            return lista;
        }

        public eMatricula Matricula(int cod)
        {
            try
            {
                eMatricula mat = null;
                SqlConnection con = db.ConectaDB();
                string select = string.Format("SELECT * FROM Usuario, UsuarioCurso WHERE Usuario.Codigo = UsuarioCurso.CodUsuario AND UsuarioCurso.CodUsuario = {0}", cod);
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    mat = new eMatricula();
                    mat.CodCurso = (int)reader["CodCurso"];
                    mat.CodUsuario = (int)reader["CodUsuario"];
                    mat.Curso = (string)reader["Curso"];
                }
                reader.Close();
                return mat;
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

        public List<eMatricula> DatosUsuario()
        {
            try
            {
                List<eMatricula> lista = new List<eMatricula>();
                eMatricula mat = null;
                SqlConnection con = db.ConectaDB();
                string select = string.Format("select uc.CodUsuario,uc.CodCurso,uc.Curso from UsuarioCurso uc inner join Usuario u on uc.CodUsuario=u.Codigo");
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    mat = new eMatricula();
                    mat.CodCurso = (int)reader["CodCurso"];
                    mat.CodUsuario = (int)reader["CodUsuario"];
                    mat.Curso = (string)reader["Curso"];
                    lista.Add(mat);
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