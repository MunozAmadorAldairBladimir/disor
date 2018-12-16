using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarGUI
{
    class BusquedaLetra
    {
        Alfabeto alfabeto = new Alfabeto();
        public char buscarLetra(char letra, int avance)
        {
            for (int i = 0; i < alfabeto.getAlfabeto().Length; i++)
            {
                if (alfabeto.getAlfabeto()[i] == ' ') return ' ';
                else if (alfabeto.getAlfabeto()[i] == letra)
                {
                    if ((i + avance) >= alfabeto.getAlfabeto().Length) return alfabeto.getAlfabeto()[(i + avance) - alfabeto.getAlfabeto().Length];
                    else return alfabeto.getAlfabeto()[i + avance];

                }
            }
            return ' ';
        }
        public char inversa(char letra, int avance)
        {
            for (int i = 0; i < alfabeto.getAlfabeto().Length; i++)
            {
                if (alfabeto.getAlfabeto()[i] == ' ')
                    return ' ';
                else if (alfabeto.getAlfabeto()[i] == letra)
                {
                    if (i - avance < 0) return alfabeto.getAlfabeto()[alfabeto.getAlfabeto().Length - avance];
                    else
                        return alfabeto.getAlfabeto()[i - avance];
                }
            }

            return ' ';
        }
    }
}
