using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class Conexion
    {

        static string ConnectionString = "Data Source=LAB6-PROF\\SQLEXPRESS;Initial Catalog=ShareThis; Persist Security Info=true; Integrated Security=SSPI;";
        //LAB6-PROF\SQLEXPRESS
        //static string ConnectionString = "DATA SOURCE=.; INITIAL CATALOG=CARRITO; USER ID = sa; PASSWORD=andres";
        static public SqlConnection cn = new SqlConnection(ConnectionString);

        static public void Conectar()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }

        static public void Desconectar()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }

        /*public static SqlConnection Conectar()
        {
             //static string ConnectionString = "Data Source=LAB6-PROF\\SQLEXPRESS;Initial Catalog=agenciaDeTurismo; Persist Security Info=true; Integrated Security=SSPI;";
            SqlConnection cn = new SqlConnection("Data Source=LAB6-PROF\\SQLEXPRESS;Initial Catalog=ShareThis; Persist Security Info=true; Integrated Security=SSPI;");
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }*/
     /*   public SqlConnection Desconectar()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Ha ocurrido un error en SQL. Error: " + ex.Message);
            }
        }*/
    }

}
