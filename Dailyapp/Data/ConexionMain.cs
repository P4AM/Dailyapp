using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Dailyapp.Data
{
    internal class ConexionMain
    {
        public static String conexion = "Data Source = 192.168.0.101; Initial Catalog = ;Integrate Security = False; User Id = dailyadmin; Password = 12345678";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void Abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
