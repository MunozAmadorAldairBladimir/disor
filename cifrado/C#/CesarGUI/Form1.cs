using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarGUI
{
    public partial class Form1 : Form
    {
        Desplazamiento desplazamiento = new Desplazamiento();
        Agrupacion agrupacion = new Agrupacion();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            textBox3.Text=desplazamiento.desplazar(textBox1.Text+e.KeyChar, int.Parse(textBox2.Text));
            textBox4.Text = agrupacion.reverso(textBox1.Text + e.KeyChar);
            textBox6.Text = agrupacion.agrupacionInversa(textBox1.Text + e.KeyChar, int.Parse(textBox5.Text));
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
