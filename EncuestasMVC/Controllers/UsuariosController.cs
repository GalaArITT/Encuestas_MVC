using EncuestasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EncuestasMVC.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {

            IEnumerable<ENC_USUARIOS> modelo_Datos;
            HttpResponseMessage response = GlobalVariables.WebApliClient.GetAsync("Enc_Usuarios").Result;
            modelo_Datos = response.Content.ReadAsAsync<IEnumerable<ENC_USUARIOS>>().Result;
            return View(modelo_Datos);
        }
        public ActionResult Informacion(decimal id)
        {
            HttpResponseMessage response = GlobalVariables.WebApliClient.GetAsync("Enc_Empleados/"+ id.ToString()).Result;
            return View(response.Content.ReadAsAsync<ENC_EMPLEADOS>().Result);
        }
    }
}