using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Entero n1,n2,n3,n4;

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.descargar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = new Entero();
            n2 = new Entero();
            n3 = new Entero();
            n4 = new Entero();
        }
        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n2.cargar(int.Parse(textBox1.Text));
        }
        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            n3.cargar(int.Parse(textBox1.Text));
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.ejercicio9(n2, n3, n4);
        }
        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n2.descargar());
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n3.descargar());
        }

        private void descargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n4.descargar());
        }

        private void ejercicio8ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio8(n2, n3));
        }

        private void ejercicio9ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n1.ejercicio9(n2, n3, n4);
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.ejercicio10(n2, n3, n4);
        }
        private void ejercicio15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.ejercicio15(n2);
        }       
        private void ejercicio14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.ejercicio14(n2);
        }      
        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio3(n2));
        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio4(n2));
        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio5());
        }

        private void ejercicio6ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio6());
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio7());
        }

        private void ejercicio11ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio11());
        }

        private void ejercicio12ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio12());
        }

        private void ejercicio13ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            n1.ejercicio13(n2);
        }
        private void cargarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            n4.cargar(int.Parse(textBox1.Text));
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Concat(n1.ejercicio8(n2,n3));
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            n1.cargar(int.Parse(textBox1.Text));

        }
        
    }
}
