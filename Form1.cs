using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencia_.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {
            respuesta.Text = Int64.Parse(numero_uno.Text) + Int64.Parse(numero_dos.Text) + "";
        }

        private void restar_Click(object sender, EventArgs e)
        {
            respuesta.Text = Int64.Parse(numero_uno.Text) - Int64.Parse(numero_dos.Text) + "";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            respuesta.Text = Int64.Parse(numero_uno.Text) * Int64.Parse(numero_dos.Text) + "";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            respuesta.Text = Int64.Parse(numero_uno.Text) / Int64.Parse(numero_dos.Text) + "";
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            respuesta.Text = "0";
            numero_uno.Text = "";
            numero_dos.Text = "";
        }
    }
}
