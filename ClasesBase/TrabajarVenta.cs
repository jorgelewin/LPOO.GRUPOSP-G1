using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace ClasesBase
{
    public class TrabajarVenta
    {

        public static void insert_Venta(Venta oVenta)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Venta(ven_fecha, cli_dni) values (@fecha,@cli_dni)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha", oVenta.Ven_Fecha);
            cmd.Parameters.AddWithValue("@cli_dni", oVenta.Cli_DNI);
       
            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }

        public static DataTable list_Ventas()
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ";
            cmd.CommandText += " ven_nro as 'Id', ";
            cmd.CommandText += " ven_fecha as 'Fecha', ";
            cmd.CommandText += " (cli_apellido + ' ' + cli_nombre + ' - DNI: ' + V.cli_dni) as 'Cliente' ";

            cmd.CommandText += " FROM Venta as V";
            cmd.CommandText += " LEFT JOIN Cliente as C ON (C.cli_dni=V.cli_dni)";

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



        public static int get_CountIdVentas()
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Count(*) FROM Venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

       
            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return Convert.ToInt32(dt.Rows[0][0]);
        }  


    }
}
