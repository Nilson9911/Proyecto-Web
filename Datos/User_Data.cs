using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    public class User_Data:ConexionDB
    {

        ConexionDB conexion = new ConexionDB();

        public void Reg_USer(string nombre, DateTime fecha, string sexo)
        {
            using (conexion.connection)
            {
                SqlCommand command = new SqlCommand("Crear", conexion.connection);
                
                conexion.abrir();

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@Sexo", sexo);                          
                command.ExecuteNonQuery();

                conexion.cerrar();
            }
        }


        public void Up_User(int id, string nombre, DateTime fecha, string sexo)
        {

            using (conexion.connection)
            {

                conexion.abrir();
                SqlCommand command = new SqlCommand("Actualizar", conexion.connection);


                
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Fecha", fecha);
                command.Parameters.AddWithValue("@Sexo", sexo);
                command.ExecuteNonQuery();
                conexion.cerrar();

            }
        }

        public void Del_User(int id)
        {
            using (conexion.connection)
            {

                SqlCommand command = new SqlCommand("Eliminar", conexion.connection);

                conexion.abrir();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
                conexion.cerrar();

            }
        }

        

    }
}
