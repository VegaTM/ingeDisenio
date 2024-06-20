using Ing.Disenio.NewFolder;

namespace Ing.Disenio
{
    public partial class Form3 : Form

    {

        private static Usuario usuariolog;//variable gobal de tipo usuario para poder usar sus datos
        public Form3()//solo inicializa cosas
        {
            InitializeComponent();

        }

        public Form3(Usuario usuario)//creamos el constructor que recibe como parametro un iusuario
        {
            InitializeComponent();
            usuariolog = usuario;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (usuariolog != null)
            {
                txtBienv.Text = "Bienvenido: " + usuariolog.Name + " " + usuariolog.ApellidoPaterno;
            }

            timer1.Start();
            timer1.Interval = 1000;

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 clientes = new Form4();
            clientes.Show();
        }

        private void Servicios_Click(object sender, EventArgs e)
        {
            this.Close();
            Form5 servicio = new Form5();
            servicio.Show();
        }

        private void txtBtnClientes_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            this.Close();
            Agenda formulario4 = new Agenda();
            formulario4.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


    }
}

