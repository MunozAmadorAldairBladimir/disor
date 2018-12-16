import sys
from PyQt5.QtWidgets import QApplication,QDialog,QMainWindow,QPushButton,QLabel
from PyQt5 import uic
from procesar import funcionesInterfaz

class Ventana(QMainWindow):

    def __init__(self):
        QMainWindow.__init__(self)
        uic.loadUi("InterfazCesar.ui",self)
        self.texto = self.e_Texto
        self.espacios = self.e_Espacios
        self.cifrar = self.radioCifrar
        self.descifrar = self.radioDescifrar
        self.result = self.resultado
        self.texto.cursorPositionChanged.connect(lambda: funcionesInterfaz.procesar(self.texto,self.result,self.cifrar,self.descifrar,self.espacios))
        self.espacios.cursorPositionChanged.connect(lambda: funcionesInterfaz.procesar(self.texto,self.result,self.cifrar,self.descifrar,self.espacios))
        self.result.cursorPositionChanged.connect(lambda: funcionesInterfaz.procesarResultado(self.texto,self.result,self.cifrar,self.descifrar,self.espacios))

#self.result.toPlainText()












