using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
namespace APP_CLIMA_VIRTUAL.Controllers
{

    public class HomeController : Controller
    {

        PaisNegocio pais = new PaisNegocio();
        CiudadNegocio ciudad = new CiudadNegocio();
        TemperaturaNegocio temp = new TemperaturaNegocio();
        public ActionResult Index()
        {
            var listaPaises = pais.ObtenerPais(string.Empty);
            var listaCiudad = ciudad.ObtenerCiudad(string.Empty, "arg");
            var listaTemp = temp.ObtenerTemperatura("bs", "arg");
            ViewBag.Pais = listaPaises;
            ViewBag.Ciudad = listaCiudad;
            ViewBag.ListaTemp = listaTemp;

            return View();
        }
       
         [HttpGet]
        public JsonResult CargarCiudades(string codPais)
        {
            var listaCiudad = ciudad.ObtenerCiudad(string.Empty, codPais);

            return Json(listaCiudad, JsonRequestBehavior.AllowGet);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}