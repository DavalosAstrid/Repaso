using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso
{
    public partial class Inicio_form : Form
    {
        public Inicio_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public struct datos
            {
        public string nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos informacion;
            informacion.nombre = textBox1.Text;
            Repaso2 obj = new Repaso2(informacion);
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = (MessageBox.Show("Desea salir","salir", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk));
        }
    }
}
