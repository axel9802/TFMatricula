using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class DataBase
    {
        private SqlConnection con;

        public SqlConnection ConectaDB()
        {
            try
            {//Eduardo=EDUARDO\SQLEXPRESS
                //string cadena = @"Data Source = EDUARDO\SQLEXPRESS; Initial Catalog = dbMatricula; Integrated Security = true";
                //string cadena = @"Data Source = LAPTOP-U4ODER7L\SQLEXPRESS (LAPTOP-U4ODER7L\AXEL); Initial Catalog = dbMatricula; Integrated Security = true";
                string cadena = "Data Source = (local); Initial Catalog = dbMatricula; Integrated Security = true";
                con = new SqlConnection(cadena);
                con.Open();
                return con;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void DesconectaDB()
        {
            con.Close();
        }
    }
}