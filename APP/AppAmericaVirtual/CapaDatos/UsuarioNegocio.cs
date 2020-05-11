using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  public  class UsuarioNegocio
    {
        wsAmericaVirtual.wsAmeV wsAme = new wsAmericaVirtual.wsAmeV();
        public string ExisteUsuario(string mail, string pass)
        {
            string respuestaExiste = string.Empty;
            try
            {
                 respuestaExiste = wsAme.ExisteUSuario(mail, pass);
                return respuestaExiste;
                
            }
            catch (Exception ex)
            {

                return respuestaExiste;
            }
      

        }

    }
}
