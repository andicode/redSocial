using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DAO;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    DataSet setDeDatos
    {

        get
        {
            if (Session["nuevoDataSet"] == null)
                Session.Add("nuevoDataSet", GetDataSet());
            return (DataSet)Session["nuevoDataSet"];
        }


    }
    protected void Page_Load(object sender, EventArgs e)
    {
     if(!IsPostBack)
         {
        SqlCommand cmd = new SqlCommand("select * from usuarios ",Conexion.cn);
        SqlDataReader reader;
        DAO.Conexion.Conectar();
        reader = cmd.ExecuteReader();
        DGusuarios.DataSource = setDeDatos;
        DGusuarios.DataBind();

      //  Conexion.Desconectar();
         }
    }
    private DataSet GetDataSet()
    {
        DataSet setDeDatos = new DataSet();
        DataTable usuarios = new DataTable();
        usuarios.Columns.Add("Nombre");
        setDeDatos.Tables.Add(usuarios);
        return setDeDatos;

    }
}
