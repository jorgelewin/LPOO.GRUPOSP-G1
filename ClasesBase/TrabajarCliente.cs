using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
   public class TrabajarCliente
    {
        public static DataTable list_Clientes()
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_apellido as 'Apellido', ";
            cmd.CommandText += " cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_direccion as 'Direccion', ";
            cmd.CommandText += " os_razonsocial as 'Obra Social', ";
            cmd.CommandText += " cli_nrocarnet as 'Numero de Carnet' ";
            cmd.CommandText += " From Cliente as C";
            cmd.CommandText += " LEFT JOIN ObraSocial as OS ON (OS.os_cuit=C.os_cuit)";
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

        public static DataTable search_Clientes(string sPattern)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " cli_dni as 'DNI', ";
            cmd.CommandText += " cli_apellido as 'Apellido', ";
            cmd.CommandText += " cli_nombre as 'Nombre', ";
            cmd.CommandText += " cli_direccion as 'Direccion', ";
            cmd.CommandText += " os_razonsocial as 'Obra Social', ";
            cmd.CommandText += " cli_nrocarnet as 'Numero de Carnet' ";
            cmd.CommandText += " From Cliente as C";
            cmd.CommandText += " LEFT JOIN ObraSocial as OS ON (OS.os_cuit=C.os_cuit)";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " cli_dni LIKE @pattern OR OS.os_razonsocial LIKE @pattern";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;
        
        }

        public static void insert_Cliente(Cliente oCliente)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Cliente(cli_dni, cli_apellido, cli_nombre, cli_direccion, os_cuit, cli_nrocarnet) values (@dni,@apellido,@nombre,@direccion,@oscuit,@nrocarnet)";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@oscuit", oCliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nrocarnet", oCliente.Cli_NroCarnet);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        
        }

        public static DataTable list_ComboClientes()
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT cli_dni, (cli_apellido + ' ' + cli_nombre) as nombreCompleto FROM Cliente";
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

        public static DataTable list_ObraSocial()
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from ObraSocial";
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

        public static void update_Cliente(Cliente oCliente)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Cliente set cli_dni=@dni, cli_apellido=@apellido, cli_nombre=@nombre, cli_direccion=@direccion, os_cuit=@oscuit, cli_nrocarnet=@nrocarnet  where cli_dni=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cmd.Parameters.AddWithValue("@dni", oCliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@apellido", oCliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@nombre", oCliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@direccion", oCliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@oscuit", oCliente.Os_CUIT);
            cmd.Parameters.AddWithValue("@nrocarnet", oCliente.Cli_NroCarnet);


            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }

        public static void delete_Cliente(string dni)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "delete from Cliente where cli_dni=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }








    }
}
