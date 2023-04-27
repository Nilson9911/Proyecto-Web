using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Datos;

namespace Negocio
{
    public class User_Model
    {

        ConexionDB conexion = new ConexionDB();
        User_Data data = new User_Data();

        //Usuarios
        public int id_usuario { get; set; }
        public string nombres { get; set; }
        public DateTime fecha { get; set; }
        public string sexo { get; set; }





        //Crear
        public void Registrar (string nombre, DateTime fecha, string sexo)
        {
            data.Reg_USer(nombre, fecha, sexo);
        }

        //Actualizar

        


        //public void Actualizar(int id, string nombre, DateTime fecha, string sexo)
        //{
        //    data.Up_User(id, nombre, fecha, sexo);
        //}

        //Eliminar

        public void Eliminar(int id)
        {
            data.Del_User(id);
        }

        //listar
        public List<User_Model> Get_Usuarios()
        {

            List<User_Model> users = new List<User_Model>();

            using (conexion.connection)
            {

                SqlCommand command = new SqlCommand("Seleccionar", conexion.connection);

                conexion.abrir();
                command.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        User_Model usuarios = new User_Model();
                        usuarios.id_usuario = reader.GetInt32(0);
                        usuarios.nombres = reader.GetString(1);
                        usuarios.fecha = reader.GetDateTime(2);
                        usuarios.sexo = reader.GetString(3);
                        users.Add(usuarios);

                    }
                    reader.Close();
                }

                    
                conexion.cerrar();

            }
            return users;
        }
    }
}
