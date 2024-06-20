using Ing.Disenio.modelos;
using Ing.Disenio.NewFolder;

namespace Ing.Disenio
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conexionBD conexion = new conexionBD();
            string usuar = boxUS.Text.Trim();
            string passw = boxPss.Text.Trim();

            Usuario usuariologueado = conexion.VerificarUsuario(usuar, passw);

            if (usuariologueado != null)
            {
                this.Hide();
                Form3 inicio = new Form3(usuariologueado);
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
        }


        private void boxPss_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void txtNom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
