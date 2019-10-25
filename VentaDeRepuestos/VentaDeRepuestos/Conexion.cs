﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace VentaDeRepuestos
{
    class Conexion
    {
       // private static string conexionString = @"Data Source=DESKTOP-NQSS6M5\SQLEXPRESS;Initial Catalog=repuestos;Integrated Security=True";
        private static string conexionString = @"Data Source=DESKTOP-LBJM0PF;Initial Catalog=repuestos;Integrated Security=True";
        //obtiene la cadena de conexion del archivo App.config
        private static string con = ConfigurationManager.ConnectionStrings["conexionSQLMarvin"].ConnectionString;

        /// <summary>
        /// se conecta a la bd de forma sincrona
        /// </summary>
        /// <returns></returns>
        public static SqlConnection conectar()
        {
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            return sqlConnection;
        }
        /// <summary>
        /// se conecta de forma asyncrona a la bd
        /// </summary>
        /// <returns></returns>
        public static async Task<SqlConnection> conectarAsync()
        {
            SqlConnection sqlConnection = new SqlConnection(conexionString);
            await sqlConnection.OpenAsync();
            return sqlConnection;
        }
    }
}
