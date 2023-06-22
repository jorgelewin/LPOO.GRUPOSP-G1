using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {

        public static void insert_Producto(Producto oProducto)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertProducto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prod_codigo", oProducto.Prod_Codigo);
            cmd.Parameters.AddWithValue("@prod_categoria", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@prod_descripcion", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@prod_precio", oProducto.Prod_Precio);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }

        public static void update_Producto(Producto oProducto)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "updateProducto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prod_codigo", oProducto.Prod_Codigo);
            cmd.Parameters.AddWithValue("@prod_categoria", oProducto.Prod_Categoria);
            cmd.Parameters.AddWithValue("@prod_descripcion", oProducto.Prod_Descripcion);
            cmd.Parameters.AddWithValue("@prod_precio", oProducto.Prod_Precio);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }

        public static void delete_Producto_SP(string prod_Codigo)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "deleteProducto_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@prod_codigo", prod_Codigo);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        
        }

        public static DataTable search_ProductosOrdenados(string sPattern, int orden)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "searchProductosOrder_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.Parameters.AddWithValue("@orderSelect", orden);

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;
        }

        public static DataTable list_Productos()
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listProductos_sp";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return dt;
        }

        public static DataTable list_ComboProductos()
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT prod_codigo, (prod_descripcion + ' - Precio: ' + CONVERT(varchar,prod_precio)) as producto FROM Producto";
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



        public static DataTable list_ProductosVendidosPorCliente(string cli_dni)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listDetalleVentaPorCliente_sp";
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


        public static DataTable list_ProductosVendidosPorRangoDeFechas(DateTime fechadesde, DateTime fechahasta)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listDetalleVentaPorRangoDeFecha_sp";
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

        public static decimal traer_Precio(string cod_Producto)
        {

            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT prod_precio FROM Producto WHERE prod_codigo=@codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", cod_Producto);

            //Configuramos el adaptador entre la app y la bd
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //Creamos un DataTable
            DataTable dt = new DataTable();

            //Llenamos el DataTable con los datos de la consulta
            da.Fill(dt); //El metodo Fill es el que realmente trae los datos de la BD

            return Convert.ToDecimal(dt.Rows[0][0]);
        } 
    }
}
