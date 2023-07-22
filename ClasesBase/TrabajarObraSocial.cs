using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarObraSocial
    {

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
    }
}
