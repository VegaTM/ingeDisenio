using Ing.Disenio.modelos;
using Ing.Disenio.NewFolder;

namespace Ing.Disenio
{
    public partial class Form2 : Form
    {

        Form1 form = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            CRUD nuevoCRUD = new CRUD();

            Usuario NuevoUsuario = new Usuario();//instacia de la clase
            conexionBD conectar = new conexionBD();


            NuevoUsuario.Name = txtNombre.Text;
            NuevoUsuario.ApellidoPaterno = txtAPP.Text;
            NuevoUsuario.ApellidoMaterno = txtAPM.Text;

            NuevoUsuario.Usuario_Sistema = txtUserr.Text;
            NuevoUsuario.Contrasenia = txtContra.Text;

            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            if (txtAPP.Text.Length == 0)
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            if (txtAPM.Text.Length == 0)
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            if (txtUserr.Text.Length == 0)
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }

            if (txtContra.Text.Length == 0)
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }
            if (txtContraConfirmar.Text.Length == 0)
            {
                MessageBox.Show("Completar todos los campos");
                return;
            }



            if (txtContraConfirmar.Text != txtContra.Text)
            {
                MessageBox.Show("Las contrasenias no coinciden");
            }
            else
            {
                //nuevoCRUD.RegistrarUser(NuevoUsuario);

                conectar.addUser(NuevoUsuario);

                MessageBox.Show("Usuario Registrado");

                this.Close();

                form.Show();

            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {


        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();



            form.Show();
        }
    }
}
