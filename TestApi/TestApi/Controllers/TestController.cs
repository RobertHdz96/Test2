using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Configuration;

namespace TestApi.Controllers
{
    public class TestController : ApiController
    {
        // USUARIOS
        [Route("api/GetUser")]
        [HttpGet]
        public dynamic GetUser(Models.Datauser DataUser)
        {
            return Models.Datauser.ObtenerUser(DataUser);
        }


        // GEOREFERENCIAS
        [Route("api/GetGeo")]
        [HttpGet]
        public dynamic ObtenerGeo(Models.Datageo Datageo)
        {
            return Models.Datageo.ObtenerUser(Datageo);
        }

    }
}