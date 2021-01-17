using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace Datos
{
    public class dCurso
    {
        DataBase db = new DataBase();

        public string Registrar(eCurso c)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string insert = string.Format("insert into Curso values({0},'{1}',{2})", c.Codigo, c.Nombre, c.Vacante);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Curso creado correctamente";
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

        public string Modificar(eCurso c)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string update = string.Format("update Curso set Nombre='{0}' where Codigo={1}", c.Nombre, c.Codigo);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Datos del curso modificados correctamente";
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

        public string Eliminar(int cod)
        {
            try
            {
                SqlConnection con = db.ConectaDB();
                string delete = string.Format("delete from Curso where Codigo={0}", cod);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Curso eliminado correctamente";
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

        public eCurso Datos(int cod)
        {
            try
            {
                eCurso c = null;
                string select = string.Format("select * from Curso where Codigo={0}", cod);
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    c = new eCurso();
                    c.Codigo = (int)reader["Codigo"];
                    c.Nombre = (string)reader["Nombre"];
                    c.Vacante = (int)reader["Vacante"];
                }
                reader.Close();
                return c;
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

        public List<eCurso>Listar()
        {
            try
            {
                List<eCurso> lista = new List<eCurso>();
                eCurso c = null;
                string select = string.Format("select * from Curso");
                SqlConnection con = db.ConectaDB();
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    c = new eCurso();
                    c.Codigo = (int)reader["Codigo"];
                    c.Nombre = (string)reader["Nombre"];
                    c.Vacante = (int)reader["Vacante"];
                    lista.Add(c);
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