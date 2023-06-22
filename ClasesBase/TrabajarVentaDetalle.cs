using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVentaDetalle
    {

        public static void insert_VentaDetalle(VentaDetalle oVentaDetalle)
        {
            //Creamos la cadena de conexion
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnection);

            //Configuramos el comando
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into VentaDetalle(ven_nro, prod_codigo, det_precio, det_cantidad, det_total) values (@nro_ven,@cod_prod,@precio,@cant,@total)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nro_ven", oVentaDetalle.Ven_Nro);
            cmd.Parameters.AddWithValue("@cod_prod", oVentaDetalle.Prod_Codigo);
            cmd.Parameters.AddWithValue("@precio", oVentaDetalle.Det_Precio);
            cmd.Parameters.AddWithValue("@cant", oVentaDetalle.Det_Cantidad);
            cmd.Parameters.AddWithValue("@total", oVentaDetalle.Det_Total);

            //Abrimos la conexion
            cnn.Open();

            //Ejecutamos la consulta
            cmd.ExecuteNonQuery();

            //Cerramos la conexion
            cnn.Close();
        }



    }
}
