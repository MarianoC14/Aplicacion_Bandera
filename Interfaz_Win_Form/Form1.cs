using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_clases;

namespace Interfaz_Win_Form
{
    public partial class Form1 : Form
    {
        Class1 nueva_clase = new Class1();
        Class2 nuevaClase = new Class2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_CambiarTexto_Click(object sender, EventArgs e)
        {
            //Instrucciones para que el Texto del label sea "HOLA"
            lbl_Texto.Text = "HOLA";
        }

        private void btn_CambiarTexto_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_CambiarTexto_MouseHover(object sender, EventArgs e)
        {
            lbl_Texto.Text = "Adios";
        }

        private void btn_CambiarTexto_MouseLeave(object sender, EventArgs e)
        {
            lbl_Texto.Text = "---";
        }
    }
}
