using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static Usuario sesionUser = new Usuario();

        public static DataTable list_Usuarios()
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " usu_id as 'Id', ";
            cmd.CommandText += " usu_username as 'Usuario', ";
            cmd.CommandText += " usu_password as 'Contraseña', ";
            cmd.CommandText += " usu_apellidonombre as 'Apellido y Nombre', ";
            cmd.CommandText += " rol_descripcion as 'Rol' ";
            cmd.CommandText += " From Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_codigo)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;
        
        }

        public static DataTable search_Usuarios(string sPattern)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " usu_id as 'Id', ";
            cmd.CommandText += " usu_username as 'Usuario', ";
            cmd.CommandText += " usu_password as 'Contraseña', ";
            cmd.CommandText += " usu_apellidonombre as 'Apellido y Nombre', ";
            cmd.CommandText += " rol_descripcion as 'Rol' ";
            cmd.CommandText += " From Usuario as U";
            cmd.CommandText += " LEFT JOIN Roles as R ON (R.rol_codigo=U.rol_codigo)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " usu_username LIKE @pattern ";
 
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%"+sPattern+"%");

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;

        }

        public static void insert_Usuario(Usuario oUser)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Usuario(usu_username, usu_password, usu_apellidonombre, rol_codigo) values (@usuario,@contraseña,@apenom,@rol)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", oUser.Usu_UserName);
            cmd.Parameters.AddWithValue("@contraseña", oUser.Usu_Password);
            cmd.Parameters.AddWithValue("@apenom", oUser.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", oUser.Rol_Codigo);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();

        }

        public static DataTable list_Roles()
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;

        }

        public static void update_Usuario(Usuario oUser)
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Usuario set usu_username=@usuario, usu_password=@contraseña, usu_apellidonombre=@apenom, rol_codigo=@rol where usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", oUser.Usu_Id);
            cmd.Parameters.AddWithValue("@usuario", oUser.Usu_UserName);
            cmd.Parameters.AddWithValue("@contraseña", oUser.Usu_Password);
            cmd.Parameters.AddWithValue("@apenom", oUser.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", oUser.Rol_Codigo);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }

        public static void delete_Usuario(int id)
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from Usuario where usu_id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }

        public static bool validate_Usuario(string user, string password)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Usuario where usu_username = @user and usu_password = @password";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    sesionUser.Usu_Id = reader.GetInt32(0);
                    sesionUser.Usu_UserName = reader.GetString(1);
                    sesionUser.Usu_Password = reader.GetString(2);
                    sesionUser.Usu_ApellidoNombre = reader.GetString(3);
                    sesionUser.Rol_Codigo = reader.GetInt32(4);
                }
                return true;
            }
            else
            {
                return false;
            }

            cnn.Close();

        }
    }
}
