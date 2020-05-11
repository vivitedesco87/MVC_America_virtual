using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace wsAmericaV
{
    /// <summary>
    /// Descripción breve de wsAmeV
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsAmeV : System.Web.Services.WebService
    {
        string con = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        LibraryDatos.Datos d = new LibraryDatos.Datos();
        [WebMethod]
        public List<LibraryDatos.Paises> ObtenerPaises(string codigo)
        {
            d = new LibraryDatos.Datos(con);
           
          

         var  Listapaises=  d.ObtenerPaises(codigo);
           
            return Listapaises;
        }

        [WebMethod]
        public string ExisteUSuario(string mail, string pass)
        {
            d = new LibraryDatos.Datos(con);

            var ValidarDatos = d.ExisteUSuario(mail, pass);

            return ValidarDatos;

        }

        [WebMethod]
        public List<LibraryDatos.Ciudad> ObtenerCiudad(string codigo,string codPais)
        {
            d = new LibraryDatos.Datos(con);

            var ListaCiudad = d.ObtenerCiudad(codigo,codPais);

            return ListaCiudad;
        }

        [WebMethod]
        public List<LibraryDatos.Temperatura> ObtenerTemperatura(string codCiudad, string codPais)
        {

            d = new LibraryDatos.Datos(con);
            var ListaTemperatura = d.ObtenerTemperatura(codCiudad, codPais);

            return ListaTemperatura;
        }
    }
}
