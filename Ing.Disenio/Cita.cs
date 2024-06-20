namespace Ing.Disenio
{
    internal class Cita
    {
        public DateTime Fecha { get; set; }
        public string descripcionCita { get; set; }

        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string TelefonoCliente { get; set; }

    }
}
