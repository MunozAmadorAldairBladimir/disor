from alfabeto.Alfabeto import Alfabeto
from texto.textoPlano import TextoPlano
from procesar.Cifrador import Cifrador
from procesar.DesCifrador import Descifrador

alfabeto = Alfabeto()
cifrador = Cifrador(alfabeto)
descifrador = Descifrador(alfabeto)

def procesar(texto, result,cifrar,descifrar,espacios):
    if (texto.hasFocus() or espacios.hasFocus()):
        if cifrar.isChecked():
            textoPlano = texto.text()
            result.clear()
            num = espacios.text()
            if (num.isdigit()):
                espacios = int(num)
                textoCifrado = cifrador.cifrarTexto(espacios, textoPlano)
                result.appendPlainText(textoCifrado)
            else:
                result.appendPlainText("Ingrese el numero de espacios")
        elif descifrar.isChecked():
            textoCifrado = texto.text()
            result.clear()
            num = espacios.text()
            if (num.isdigit()):
                espacios = int(num)
                plainText = descifrador.descifrarTexto(espacios, textoCifrado)
                result.appendPlainText(plainText)
            else:
                result.appendPlainText("Ingrese el numero de espacios")


def procesarResultado(texto, result,cifrar,descifrar,espacios):
    if(result.hasFocus()):
        if cifrar.isChecked():
            textoCifrado = result.toPlainText()
            texto.clear()
            num = espacios.text()
            if (num.isdigit()):
                espacios = int(num)
                plainText = descifrador.descifrarTexto(espacios, textoCifrado)
                texto.setText(plainText)
            else:
                texto.setText("Ingrese el numero de espacios")
        elif descifrar.isChecked():
            textoPlano = result.toPlainText()
            texto.clear()
            num = espacios.text()
            if (num.isdigit()):
                espacios = int(num)
                textoCifrado = cifrador.cifrarTexto(espacios, textoPlano)
                texto.setText(textoCifrado)
            else:
                result.appendPlainText("Ingrese el numero de espacios")
                
                
            

