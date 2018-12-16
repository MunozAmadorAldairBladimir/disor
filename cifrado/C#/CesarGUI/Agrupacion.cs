using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarGUI
{
    class Agrupacion
    {
        public String reverso(String cadena)
        {

            char[] charArray = cadena.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public String agrupacionInversa(String cadena, int separacion)
        {
            String cadenaDividida = "";
            String token = "";
            //separacion++;
            if (separacion != 0)
            {
                for (int i = 0; i <= cadena.Length; i += separacion)
                {
                    token = "";
                    for (int j = i; j <= (i + (separacion - 1)); j++)
                    {
                        if (j < cadena.Length)
                        {
                            token += cadena[j];
                        }
                    }
                    cadenaDividida += reverso(token) + " ";
                }

            }


            return cadenaDividida;
        }
    }
}
