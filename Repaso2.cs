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
    public partial class Repaso2 : Form
    {
        public Repaso2(Inicio_form.datos informacion)
        {
            InitializeComponent();
            label2.Text = informacion.nombre;
        }

        private void Repaso2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
