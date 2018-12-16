from alfabeto.Alfabeto import Alfabeto
from texto.textoPlano import TextoPlano
from procesar.Cifrador import Cifrador
from procesar.DesCifrador import Descifrador

alfabeto = Alfabeto()
cifrador = Cifrador(alfabeto)
descifrador = Descifrador(alfabeto)

def procesar(texto, result,espacios,transpuesta,transpuestaA,grupos):
            textoPlano = texto.text()
            result.clear()
            textoCifrado = cifrador.cifrarTexto(espacios.value(), textoPlano)
            result.appendPlainText(textoCifrado)
            transponer(texto,transpuesta)
            transponerAgrupado(texto,transpuestaA,grupos)

def transponer(texto,result):
    textoPlano = texto.text()
    result.clear()
    result.appendPlainText(textoPlano[::-1])

def transponerAgrupado(texto,result,grupos):
    grupo = grupos.value()
    caracteres = tuple(texto.text())
    textoAgrupado = ""
    textoCifrado = ""
    if grupo == 1:
        transponer(texto,result)
    else:
        for indice in range(1,len(caracteres)+1):
            if(grupo != 0 and indice % grupo == 0):
                textoAgrupado = textoAgrupado + str(caracteres[indice-1])
                textoCifrado = textoCifrado + textoAgrupado[::-1]
                result.clear()
                result.appendPlainText(textoCifrado)
                textoAgrupado = ""
            else:
                textoAgrupado = textoAgrupado + str(caracteres[indice-1])
                result.clear()
                result.appendPlainText(textoCifrado + textoAgrupado)

