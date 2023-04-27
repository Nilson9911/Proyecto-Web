using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace Datos
{
    public class ConexionDB
    {

        string cadena = "Data Source=DESKTOP-0JEDCB4;Initial Catalog=DigitalBank;User ID=sa;Password=ngp991111";

        public SqlConnection connection = new SqlConnection();

        //Constructor
        public ConexionDB()
        {
            connection = new SqlConnection(cadena);
        }

        //Metodo para abrir la conexion
        public void abrir()
        {
            connection.Open();
        }

        //Metodo para cerrar la conexion
        public void cerrar()
        {
            connection.Close();
        }


    }
}
