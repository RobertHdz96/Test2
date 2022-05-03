using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Data
{
    public class RespuestaGeo
    {
        public string status { get; set; }
        public bool exito { get; set; }
        public string message { get; set; }
        public dynamic result { get; set; }
        public string latitud { get; set; }
        public string longuitud { get; set; }
    }
}