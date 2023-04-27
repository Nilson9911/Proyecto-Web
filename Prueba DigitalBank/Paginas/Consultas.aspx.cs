using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Negocio;
using System.Data;
using Datos;


namespace Prueba_DigitalBank.Paginas
{
    public partial class Consultas : System.Web.UI.Page
    {
        User_Model user = new User_Model();

        protected void Page_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            GVListar.DataSource = user.Get_Usuarios();
            GVListar.DataBind();
        }

        protected void GVListar_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GVListar.DataKeys[e.RowIndex].Value);
            user.Eliminar(id);
            GVListar.DataBind();
        }

        protected void GVListar_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVListar.EditIndex = e.NewEditIndex;
            DataBind();           
        }

        protected void GVListar_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            

            GridViewRow row = GVListar.Rows[e.RowIndex];

            string id = (row.FindControl("txtidusu") as TextBox).Text;
            string nombre = (row.FindControl("txtNombres") as TextBox).Text;
            string fechaNacimientoString = (row.FindControl("txtFechaNacimiento") as TextBox).Text;
            DateTime fecha = DateTime.ParseExact(fechaNacimientoString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string sexo = (row.FindControl("ddlGenero") as DropDownList).SelectedValue;


            //int idUsuario = Convert.ToInt32(GVListar.Rows[e.RowIndex].);
            //string nombres = ((TextBox)GVListar.Rows[e.RowIndex].FindControl("txtNombres")).Text;
            //DateTime fechaNacimiento = DateTime.ParseExact(((TextBox)GVListar.Rows[e.RowIndex].FindControl("txtFechaNacimiento")).Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            //string genero = ((DropDownList)GVListar.Rows[e.RowIndex].FindControl("ddlGenero")).SelectedValue;

            //GridViewRow row = GVListar.Rows[e.RowIndex];
            //int id = Convert.ToInt32(GVListar.DataKeys[e.RowIndex].Value);
            //string nombre = (row.FindControl("Nombres") as TextBox).Text;
            //string fecha = (row.FindControl("fecha") as TextBox).Text;
            //string sexo = (row.FindControl("sexo") as TextBox).Text;
            string connectionString = "Data Source=DESKTOP-0JEDCB4;Initial Catalog=DigitalBank;User ID=sa;Password=ngp991111";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                

                using (SqlCommand command = new SqlCommand("Actualizar", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Fecha", fecha);
                    command.Parameters.AddWithValue("@Sexo", sexo);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            GVListar.EditIndex = -1;
            DataBind();
        }
    }
}