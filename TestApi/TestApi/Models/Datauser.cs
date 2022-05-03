using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApi.Data;

namespace TestApi.Models
{
    public class Datauser
    {
        public int idusuario { get; set; }
        public string contraseña { get; set; }

        public static Respuesta ObtenerUser(Datauser userdata)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@idusuario", userdata.idusuario),
                new Parametro("@contraseña", userdata.contraseña)
            };

            return DBDatos.BuscarUser("SP_GET_USER", parametros);
        }


    }
}