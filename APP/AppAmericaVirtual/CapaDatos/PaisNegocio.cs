using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class PaisNegocio
    {

        wsAmericaVirtual.wsAmeV wsAme = new wsAmericaVirtual.wsAmeV();
        public wsAmericaVirtual.Paises[] ObtenerPais(string codigo)
        {
            wsAmericaVirtual.Paises[] listaPaises = { };
            string respuestaExiste = string.Empty;
            try
            {
                listaPaises = wsAme.ObtenerPaises(codigo);
                return listaPaises;

            }
            catch (Exception ex)
            {
                wsAmericaVirtual.Paises paises = new wsAmericaVirtual.Paises();
                paises.Codigo = "Error";
                paises.Descrip = ex.Message;
                listaPaises.ToList().Add(paises);
                return listaPaises;
               
            }


        }
    }
}
