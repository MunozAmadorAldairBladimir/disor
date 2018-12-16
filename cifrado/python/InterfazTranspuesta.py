import sys
from PyQt5.QtWidgets import QApplication,QDialog,QMainWindow,QPushButton,QLabel
from PyQt5 import uic
from procesar import funcionesInterfazTranspuesta

class VentanaTranspuesta(QMainWindow):

    def __init__(self):
        QMainWindow.__init__(self)
        uic.loadUi("InterfazTranspuesta.ui",self)
        self.texto = self.lineText
        self.espacios = self.spinDesplazamiento
        self.grupos = self.spinGrupo
        self.result = self.plainResultado
        self.resultAgrupado = self.plainTranspuestaA
        self.transpuesta = self.plainTranspuesta
        self.texto.cursorPositionChanged.connect(lambda: funcionesInterfazTranspuesta.procesar(self.texto,self.result,self.espacios,self.transpuesta,self.resultAgrupado,self.grupos))
        self.espacios.valueChanged.connect(lambda: funcionesInterfazTranspuesta.procesar(self.texto,self.result,self.espacios,self.transpuesta,self.resultAgrupado,self.grupos))
        self.grupos.valueChanged.connect(lambda: funcionesInterfazTranspuesta.transponerAgrupado(self.texto,self.resultAgrupado,self.grupos))












