using Logica;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
            string nombre = tb_nombre.Text;
            string direccion = tb_Direccion.Text;
            int edad = (int)num_edad.Value;
            string genero = "";
            foreach (RadioButton rb in gb_genero.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    // Si encontramos el radioButton seleccionado, asignamos su texto a la variable genero
                    genero = rb.Text;                    
                }
            }
            List<string> cursosAux = new List<string>();
            foreach (CheckBox cb in gb_cursos.Controls.OfType<CheckBox>())
            {
                if(cb.Checked)
                {
                    cursosAux.Add(cb.Text);
                }
            }
            
            string paisSeleccionado = lb_paises.SelectedItem.ToString();
            
            Ingresante UnIngresante = new Ingresante(cursosAux,direccion,edad,genero,nombre,paisSeleccionado);            
            FormDatos formDatos = new FormDatos(UnIngresante);
            formDatos.ShowDialog();
        }
    }
}