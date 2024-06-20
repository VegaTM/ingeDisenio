using Ing.Disenio.modelos;

namespace Ing.Disenio
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 menu = new Form3();
            menu.Show();
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {

            panelServicio.Show();
            conexionBD consulta = new conexionBD();
            panelServicio.DataSource = consulta.consultaServicio();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            panelServicio.Hide();
        }

        private void addServicioBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
