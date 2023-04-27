using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Prueba_DigitalBank.Paginas
{
    public partial class Usuario : System.Web.UI.Page
    {

        User_Model user = new User_Model();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bguardar_Click(object sender, EventArgs e)
        {
           if (ddlSexo.SelectedValue != "")
           {
               user.Registrar(txtNombre.Text, DateTime.Parse(txtFecha.Text), Convert.ToString(ddlSexo.SelectedValue));
               msgError("Registro agregado con exito");
               lbError.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                msgError("Seleccione un genero");
            }

            

        }

        private void msgError(string msg)
        {

            lbError.Text = "" + msg;
            lbError.Visible = true;
            lbError.ForeColor = System.Drawing.Color.Red;

        }
    }
}