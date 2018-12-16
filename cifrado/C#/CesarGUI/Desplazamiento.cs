using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarGUI
{
    class Desplazamiento
    {

        BusquedaLetra busquedaLetra = new BusquedaLetra();
        public String desplazar(String cadena, int avance)
        {
            String texto = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsUpper(cadena[i])) texto += busquedaLetra.buscarLetra(cadena[i], avance);
                else texto += busquedaLetra.buscarLetra((cadena[i] + "").ToUpper()[0], avance).ToString().ToLower();
            }
            return texto;
        }


        public String desplazarInversa(String cadena, int avance)
        {

            String texto = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                if (char.IsUpper(cadena[i])) texto += busquedaLetra.inversa(cadena[i], avance);
                else
                    texto += (busquedaLetra.inversa((cadena[i] + "").ToUpper()[0], avance) + "").ToLower();
            }
            return texto;
        }
    }
}
