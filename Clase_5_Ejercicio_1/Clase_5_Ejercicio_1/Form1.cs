namespace Clase_5_Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_saludar_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre.Text;
            string apellido = tb_apellido.Text;

            FormSaludo formSaludo = new FormSaludo(nombre, apellido);
            formSaludo.ShowDialog();
            
            
        }
    }
}