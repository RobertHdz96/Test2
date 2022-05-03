using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TestApi.Data
{
    public class DBDatos
    {
        public static Respuesta BuscarUser(string nombreProcedimiento, List<Parametro> parametros, string stringConexion = "")
        {
            Respuesta respuesta = new Respuesta();
            respuesta.message = "";
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["stringConnection"].ConnectionString);
            conexion.Open();

            try
            {
                SqlCommand cmd = new SqlCommand(nombreProcedimiento, conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        cmd.Parameters.AddWithValue(parametro.Nombre, parametro.Valor);
                    }
                }

                int e = cmd.ExecuteNonQuery();

                respuesta.exito = e > 0 ? true : false;
                respuesta.message = e > 0 ? "Se encontró usuario" : "No se encontró Usuario";

                 
            }
            catch (Exception EX)
            {
                respuesta.exito = false;
                respuesta.message = EX.Message;
            }
            finally
            {
                conexion.Close();
            }

            return respuesta;
        }
    }
}