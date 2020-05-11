using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class CiudadNegocio
    {
        wsAmericaVirtual.wsAmeV wsAme = new wsAmericaVirtual.wsAmeV();
        public wsAmericaVirtual.Ciudad[] ObtenerCiudad(string codigo,string codPais)
        {
            wsAmericaVirtual.Ciudad[] listaCiudades = { };
         
            try
            {
                listaCiudades = wsAme.ObtenerCiudad(codigo,codPais);
                return listaCiudades;

            }
            catch (Exception ex)
            {
                wsAmericaVirtual.Ciudad paises = new wsAmericaVirtual.Ciudad();
                paises.Codigo = "Error";
                paises.Descrip = ex.Message;
                listaCiudades.ToList().Add(paises);
                return listaCiudades;

            }


        }
    }
}
