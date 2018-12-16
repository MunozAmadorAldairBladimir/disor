using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace JuegoVida
{
    public partial class frmPrincipal : Form
    {
        private int margenH = 20;
        private int margenV = 20;
        
        private int filas = 110;
        private int columnas = 110;

        private int anchoCelda = 4;

        private bool[,] estado;

        delegate bool CalcularNuevoEstadoCelula(int fila, int columna);
        CalcularNuevoEstadoCelula calcularNuevoEstado;

        public frmPrincipal()
        {
            InitializeComponent();

            //Para evitar parpadeo al repintar la ventana
            this.SetStyle(
            ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.ResizeRedraw,
            true);

            //Se actualiza el estilo de dibujo del control
            this.UpdateStyles();

            //Establecemos el tamaño de la ventana
            SetClientSizeCore((2 * margenH) + (columnas * anchoCelda),
                  (2 * margenV) + (filas * anchoCelda));

            //Se inicializa la matriz de células
            estado = new bool[filas, columnas];

            //Reglas por defecto
            calcularNuevoEstado = calcularEstado23_3;
        }

        private bool calcularEstado23_3(int fila, int columna)
        {
            bool res = false;

            //Número de vecinos vivos
            int numVecinosVivos = contarVecinosVivos(fila, columna);

            //Copiamos el estado anterior
            res = estado[fila, columna];

            //Aplicamos reglas:

            //Una célula muerta pasa a viva si tiene 3 vecinas vivas
            if (numVecinosVivos == 3)
                res = true;

            //Si una célula no tiene 2 ó 3 vecinas muere o permanece muerta
            if (numVecinosVivos != 2 && 
                numVecinosVivos != 3)
                res = false;

            return res;
        }

        private bool calcularEstado34_34(int fila, int columna)
        {
            bool res = false;

            //Número de vecinos vivos
            int numVecinosVivos = contarVecinosVivos(fila, columna);

            //Copiamos el estado anterior
            res = estado[fila, columna];

            //Aplicamos reglas:

            //Una célula muerta pasa a viva si tiene 3 o 4 vecinas vivas
            if (numVecinosVivos == 3 || 
                numVecinosVivos == 4)
                res = true;

            //Si una célula no tiene 3 ó 4 vecinas muere o permanece muerta
            if (numVecinosVivos != 3 && 
                numVecinosVivos != 4)
                res = false;

            return res;
        }

        private bool calcularEstado1358_357(int fila, int columna)
        {
            bool res = false;

            //Número de vecinos vivos
            int numVecinosVivos = contarVecinosVivos(fila, columna);

            //Copiamos el estado anterior
            res = estado[fila, columna];

            //Aplicamos reglas:

            //Una célula muerta pasa a viva si tiene 3,5 o 7 vecinas vivas
            if (numVecinosVivos == 3 || 
                numVecinosVivos == 5 || 
                numVecinosVivos == 7)
                res = true;

            //Si una célula no tiene 1,3,5 o 8 vecinas muere o permanece muerta
            if (numVecinosVivos != 1 && 
                numVecinosVivos != 3 && 
                numVecinosVivos != 5 && 
                numVecinosVivos != 8)
                res = false;

            return res;
        }

        private int contarVecinosVivos(int fila, int columna)
        {
            int res = 0;

            //Cuenta las células vivas que rodean a la celula situada en [fila,columna]
            for (int i = -1; i <= 1; i++)
                for (int j = -1; j <= 1; j++)
                    if (i != 0 || j != 0)
                        if (estado[(filas + fila + i)%filas, (columnas + columna + j)%columnas] == true)
                            res++;

            return res;
        }

        private void inicializarAleatorio()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);

            //Se inicializa la matriz de células con valores aleatorios
            for (int i = 0; i < filas; i++)
                for (int j = 0; j < columnas; j++)
                    estado[i, j] = (rand.Next(0, 100) >= 90);
        }

        private void frmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Se dibuja la matriz de células
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Rectangle rect = 
                        new Rectangle(margenH + (anchoCelda * j),
                                      margenV + 10 + (anchoCelda * i),
                                      anchoCelda,
                                      anchoCelda);

                    g.DrawRectangle(Pens.Gray, rect);

                    if (estado[i, j])
                    {
                        g.FillRectangle(Brushes.Black, rect);
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool[,] estadoAux = new bool[filas, columnas];

            backgroundWorker1.ReportProgress(0);

            Thread.Sleep(1000);

            while (true)
            {
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        estadoAux[i, j] = calcularNuevoEstado(i, j);
                    }
                }

                estado = (bool[,])estadoAux.Clone();

                backgroundWorker1.ReportProgress(0);

                Thread.Sleep(50);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Refresh();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAcerca frm = new FrmAcerca();
            frm.ShowDialog();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Inicializamos la matriz de células
            inicializarAleatorio();

            //Se inicia la ejecución
            backgroundWorker1.RunWorkerAsync();
        }

        private void reglas1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reglas1ToolStripMenuItem.Checked = true;
            reglas2ToolStripMenuItem.Checked = false;
            reglas3ToolStripMenuItem.Checked = false;

            //Se establen las reglas según la opción seleccionada del menú
            calcularNuevoEstado = calcularEstado23_3;
        }

        private void reglas2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reglas1ToolStripMenuItem.Checked = false;
            reglas2ToolStripMenuItem.Checked = true;
            reglas3ToolStripMenuItem.Checked = false;

            //Se establen las reglas según la opción seleccionada del menú
            calcularNuevoEstado = calcularEstado34_34;
        }

        private void reglas3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reglas1ToolStripMenuItem.Checked = false;
            reglas2ToolStripMenuItem.Checked = false;
            reglas3ToolStripMenuItem.Checked = true;

            //Se establen las reglas según la opción seleccionada del menú
            calcularNuevoEstado = calcularEstado1358_357;
        }
    }
}
