using Ing.Disenio.modelos;
using System.Data;
using System.Data.SqlClient;

namespace Ing.Disenio
{
    public partial class Agenda : Form
    {
        private List<Cliente> clientes;
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            registroCita.Hide();
            conexionBD consulta = new conexionBD();
            boxID.DataSource = consulta.consultaCliente();
            boxID.DisplayMember = "Cliente";
            boxID.ValueMember = "NombreCliente";

        }

       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            registroCita.Visible = false;
            panelCitas.Show();
            conexionBD consulta = new conexionBD();
            panelCitas.DataSource = consulta.consultaCita();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelCitas.Hide();
            registroCita.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 menui = new Form3();
            menui.Show();
        }

        private void boxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (boxID.SelectedIndex != -1)
            //{
            //    int clienteId = (int)boxID.SelectedItem;
            //    var clienteSeleccionado = clientes.FirstOrDefault(c => c.IDCliente == clienteId);

            //                      }
            
        }

        private void btnEnviarRegistro_Click(object sender, EventArgs e)
        {
            Cita nuevaCita = new Cita();
            conexionBD conectar = new conexionBD();

            // Asignar la fecha seleccionada
            nuevaCita.Fecha = boxDay.Value;

            // Obtener el ClienteId seleccionado del ComboBox
            if (boxID.SelectedItem != null)
            {
                DataRowView selectedClient = (DataRowView)boxID.SelectedItem;
                nuevaCita.ClienteId = (int)selectedClient["IDCliente"];
            }
            else
            {
                MessageBox.Show("Seleccione un cliente válido.");
                return;
            }

            // Validar que todos los campos requeridos están llenos
            if (string.IsNullOrWhiteSpace(boxID.Text))
            {
                MessageBox.Show("Llene todos los campos requeridos");
                return;
            }

            // Agregar la nueva cita a la base de datos
            conectar.addCita(nuevaCita);
            MessageBox.Show("Cita Registrada");
            registroCita.Hide();
        }

    }

    //private void ResaltarDiasConCitas()
    //{
    //    // Obtener las fechas de las citas
    //    var fechasCitas = citas.Select(c => c.Fecha.Date).Distinct().ToList();

    //    // Resaltar las fechas en el calendario
    //    monthCalendar1.BoldedDates = fechasCitas.ToArray();
    //}
}

