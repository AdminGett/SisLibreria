using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisLibreria.Conexion
{
 
    public class ConexionData
    {
        //MySqlConnection cn = new MySqlConnection();
        // "100.117.188.127"; === Ip de puente fuera de red 
        static string host = "192.168.101.102";
        static string db = "SisLibreria";
        static string user = "robin";
        static string pass = "Sisar@2026.";
        static string port = "3306";
        private string CConexion = $"Server={host};Port={port};Uid={user};Pwd={pass};Database={db};CheckParameters=false;";
        //"server="+ host + ";"+"port="+ port + ";"+"user id="+ user + ";"+"password="+ pass + ";"+"database="+db+";";
        public MySqlConnection ObtenerConexion()
        {
            var cn = new MySqlConnection(CConexion); ;
            try
            {
                cn.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("no se pudo conectar a la base dedatos");
            }
            return cn;
        }
    }
}
