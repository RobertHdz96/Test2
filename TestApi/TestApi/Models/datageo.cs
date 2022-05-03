using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApi.Data;

namespace TestApi.Models
{
    public class Datageo
    {
        public int idgeo { get; set; }

        public static Respuesta ObtenerUser(Datageo usergeo)
        {
            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@idgeo", usergeo.idgeo)
            };

            return DBDatos.BuscarUser("SP_GET_GEO", parametros);
        }
    }
}
