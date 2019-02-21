using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace EncuestasMVC
{
    public static class GlobalVariables
    {
        public static HttpClient WebApliClient = new HttpClient();
        
        static GlobalVariables()
        {
            WebApliClient.BaseAddress = new Uri("http://localhost:55039/api/"); //dirección de la api
            WebApliClient.DefaultRequestHeaders.Clear();
            WebApliClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}