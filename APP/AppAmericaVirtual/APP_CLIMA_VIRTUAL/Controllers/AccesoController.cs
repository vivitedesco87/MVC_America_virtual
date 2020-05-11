using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
namespace APP_CLIMA_VIRTUAL.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            ViewBag.Mail = string.Empty;
            ViewBag.Pass = string.Empty;
            ViewBag.Error = string.Empty;  
            return View();
        }

        [HttpPost]
        public ActionResult Login(string mail, string Pass)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            try
            {

                //Hacer webservices para la existencia de usuario y pass.
                var oUser = usuarioNegocio.ExisteUsuario(mail, Pass);

                    if (oUser != "OK")
                    {
                    ViewBag.Error = oUser;
                        return View();
                    }

                    Session["User"] = oUser;
             
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    

    }
}