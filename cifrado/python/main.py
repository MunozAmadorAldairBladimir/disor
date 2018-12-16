from InterfazTranspuesta import VentanaTranspuesta
from alfabeto.Alfabeto import Alfabeto
from texto.textoPlano import TextoPlano
from procesar.Cifrador import Cifrador
from texto.textoCifrado import TextoCifrado
from procesar.DesCifrador import Descifrador
from InterfazCesar import Ventana
from PyQt5.QtWidgets import QApplication
import sys

class Main:
    alfabeto = Alfabeto()
    textoPlano = TextoPlano("holaPerm'_")
    texto = ""
    texto2 = ""
    #print(alfabeto.obtenerPosicion('a'))
    cifrador = Cifrador(alfabeto)
    descifrador = Descifrador(alfabeto)

    app = QApplication(sys.argv)
    ventana = VentanaTranspuesta()
    ventana.show()
    app.exec_()

    '''for caracater in textoPlano.getCaracteres():
        print(cifrador.cifrarCaracter(2, caracater),"-->",caracater)
        texto = texto + cifrador.cifrarCaracter(120, caracater)

    print(texto)

    textoCifrado = TextoCifrado(texto)

    for caracater in textoCifrado.getCaracteres():
        texto2 = texto2 + descifrador.descifrarCaracter(120, caracater)

    print(texto2)'''
