using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using SisLibreria.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SisLibreria.BConsultas
{
    internal class ConSp
    {
        private ConexionData conx = new ConexionData();

        public T EjecutarSP<T>(string nombreSP, params object[] parametros)
        {
            //DataTable tabla = new DataTable();
            using (var con = conx.ObtenerConexion())
            {
                using (var cmd =new MySqlCommand(nombreSP, con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    for (int i = 0; i < parametros.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@p{i + 1}", parametros[i]);
                    }

                    if (typeof(T) == typeof(DataTable))
                    {
                        DataTable tabla = new DataTable();
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabla);
                        }
                        return (T)(object)tabla;
                    }
                    else
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado == null || resultado == DBNull.Value)
                            return default(T);

                        return (T)Convert.ChangeType(resultado, typeof(T));
                    }
                }
            }
        }
    }
}
