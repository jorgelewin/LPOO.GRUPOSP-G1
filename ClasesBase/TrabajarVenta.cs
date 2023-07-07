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

        public static void delete_Venta(int ven_nro)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "deleteVenta_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@ven_nro", ven_nro);

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

        public static DataTable list_VentasPorCliente(string cli_dni)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listVentasporCliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cli_dni", cli_dni);

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;
        }

        public static DataTable list_VentasPorRangoDeFechas(DateTime fechadesde, DateTime fechahasta)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listVentasPorRangoDeFechas_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@fecha_Desde", fechadesde);
            cmd.Parameters.AddWithValue("@fecha_Hasta", fechahasta);

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;
        }


        public static int get_TotalVentasPorCliente(string cli_dni)
        {
            //Variable para retornar el total de los alquileres
            int cantidadVentas;

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getCountVentasPorCliente_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Parametro de Entrada
            cmd.Parameters.AddWithValue("@cli_dni", cli_dni);

            //Parametro de Salida
            cmd.Parameters.Add("@total", SqlDbType.Int);
            cmd.Parameters["@total"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Obtengo el total de los alquileres realizados por Edificio
            cantidadVentas = (int)cmd.Parameters["@total"].Value;

            return cantidadVentas;
        }


        public static int get_TotalVentasPorRangoDeFechas(DateTime fechadesde, DateTime fechahasta)
        {
            //Variable para retornar el total de los alquileres
            int cantidadVentas;

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "getCountVentasPorFecha_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Parametro de Entrada
            cmd.Parameters.AddWithValue("@fecha_Desde", fechadesde);
            cmd.Parameters.AddWithValue("@fecha_Hasta", fechahasta);

            //Parametro de Salida
            cmd.Parameters.Add("@total", SqlDbType.Int);
            cmd.Parameters["@total"].Direction = ParameterDirection.Output;

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            //Obtengo el total de los alquileres realizados por Edificio
            cantidadVentas = (int)cmd.Parameters["@total"].Value;

            return cantidadVentas;
        }

        public static int get_CountIdVentas()
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT MAX(ven_nro) FROM Venta";
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
