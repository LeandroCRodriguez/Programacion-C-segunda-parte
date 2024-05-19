using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_5_Ejercicio_1
{
    public partial class FormSaludo : Form
    {
        string titulo;
        string mensaje;
        public FormSaludo(string titulo, string mensaje)
        {
            InitializeComponent();
            this.titulo = titulo;
            this.mensaje = mensaje;
        }

        private void FormSaludo_Load(object sender, EventArgs e)
        {

            this.lb_mensaje.Text = "Soy " + this.mensaje;
            this.lb_titulo.Text = this.titulo;
        }
    }
}
