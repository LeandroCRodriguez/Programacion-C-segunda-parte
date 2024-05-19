using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FormDatos : Form
    {
        public FormDatos(Ingresante ingresante)
        {
            InitializeComponent();
            MostrarDatos(ingresante);
        }

        private void MostrarDatos(Ingresante ingresante)
        {
            lb_nombre.Text = ingresante.Mostrar();
        }
        private void FormDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
