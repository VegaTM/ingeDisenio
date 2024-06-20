using Ing.Disenio.modelos;

namespace Ing.Disenio
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 menu = new Form3();
            menu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            tablaClientes.Show();
            conexionBD consulta = new conexionBD();
            tablaClientes.DataSource = consulta.consultaCliente();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tablaClientes.Hide();
            panelRegistro.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelRegistro.Show();
        }

        private void registroCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente();
            conexionBD conectar = new conexionBD();

            nuevoCliente.NombreCliente = boxName.Text;
            nuevoCliente.emailCliente = boxEmail.Text;
            nuevoCliente.telefonoCliente = boxTelefono.Text;
            nuevoCliente.DireccionCliente = boxDireccion.Text;

            if (boxName.Text.Length == 0)
            {
                MessageBox.Show("Llene todos los campos requeridos");
                return;
            }

            if (boxTelefono.Text.Length == 0)
            {
                MessageBox.Show("Llene todos los campos requeridos");
                return;
            }


            else
            {
                conectar.addCliente(nuevoCliente);
                MessageBox.Show("Cliente registrado");

                panelRegistro.Hide();
            }

        }

        private void tablaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
