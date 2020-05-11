using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class TemperaturaNegocio
    {
        wsAmericaVirtual.wsAmeV wsAme = new wsAmericaVirtual.wsAmeV();
        public wsAmericaVirtual.Temperatura[] ObtenerTemperatura(string codCiudad,string codPais)
        {
            wsAmericaVirtual.Temperatura[] listaTemperatura = { };
            string respuestaExiste = string.Empty;
            try
            {
                listaTemperatura = wsAme.ObtenerTemperatura(codCiudad,codPais);
                return listaTemperatura;

            }
            catch (Exception ex)
            {
                wsAmericaVirtual.Temperatura temp = new wsAmericaVirtual.Temperatura();
                temp.Error = "Error";
                temp.Descrip = ex.Message;
                listaTemperatura.ToList().Add(temp);
                return listaTemperatura;

            }


        }
    }
}
