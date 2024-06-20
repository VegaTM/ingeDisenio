using Ing.Disenio.NewFolder;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ing.Disenio.modelos
{
    internal class conexionBD
    {
        private readonly string _conexion = @"Data Source=DESKTOP-TTES6G6\SQLEXPRESS;Initial Catalog=ClientesIng;Integrated Security=True;";
        SqlDataAdapter adapter;
        public conexionBD(string url)
        {
            _conexion = url;

        }

        public conexionBD() { }

        public void addUser(Usuario usuario)
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();
                using (var cmd = new SqlCommand("insert into Usuarios (NameUsuario,ApellidoPaterno," +
                    "ApellidoMaterno,Usuario_Sistema,Contrasenia) values " +
                    "(@NameUsuario,@ApellidoPaterno,@ApellidoMaterno,@Usuario_Sistema,@Contrasenia);", conexion))
                {
                    cmd.Parameters.AddWithValue("@NameUsuario", usuario.Name);
                    cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
                    cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
                    cmd.Parameters.AddWithValue("@Usuario_Sistema", usuario.Usuario_Sistema);
                    cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Usuario VerificarUsuario(string usuarioSistema, string contrasenia)
        {
            Usuario usuario = null;

            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();
                using (var cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Usuario_Sistema = @Usuario_Sistema AND Contrasenia = @Contrasenia", conexion))
                {
                    cmd.Parameters.AddWithValue("@Usuario_Sistema", usuarioSistema);
                    cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                Name = reader["NameUsuario"].ToString(),
                                ApellidoPaterno = reader["ApellidoPaterno"].ToString(),
                                ApellidoMaterno = reader["ApellidoMaterno"].ToString(),
                                Usuario_Sistema = reader["Usuario_Sistema"].ToString(),
                                Contrasenia = reader["Contrasenia"].ToString()
                            };
                        }
                    }
                }
            }

            return usuario;
        }

        public DataTable consultaCliente()
        {
            DataTable tabla = new DataTable();
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();

                adapter = new SqlDataAdapter("SELECT * FROM Cliente", conexion);
                adapter.Fill(tabla);
                conexion.Close();

            }

            return tabla;
        }

        public DataTable consultaNombre() {
            DataTable tabla = new DataTable();
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();

                adapter = new SqlDataAdapter("SELECT NombreCliente FROM Cliente", conexion);
                adapter.Fill(tabla);
                conexion.Close();

            }

            return tabla;
        }

        public void addCliente(Cliente cliente)
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();
                using (var cmd = new SqlCommand("insert into Cliente (NombreCliente,EmailCliente," +
                    "TelefonoCliente,DireccionCliente) values " +
                    "(@NombreCliente,@EmailCliente,@TelefonoCliente,@DireccionCliente);", conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreCliente", cliente.NombreCliente);
                    cmd.Parameters.AddWithValue("@EmailCliente", cliente.emailCliente);
                    cmd.Parameters.AddWithValue("@TelefonoCliente", cliente.telefonoCliente);
                    cmd.Parameters.AddWithValue("@DireccionCliente", cliente.DireccionCliente);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void addCita(Cita cita)
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();
                using (var cmd = new SqlCommand("INSERT INTO Cita (Fecha, ClienteId) VALUES (@Fecha, @ClienteId);", conexion))
                {
                    cmd.Parameters.AddWithValue("@Fecha", cita.Fecha);
                    cmd.Parameters.AddWithValue("@ClienteId", cita.ClienteId);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public DataTable consultaCita()
        {
            DataTable tabla = new DataTable();
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();

                adapter = new SqlDataAdapter("SELECT * FROM Cita", conexion);
                adapter.Fill(tabla);
                conexion.Close();

            }

            return tabla;
        }

        public DataTable consultaServicio() 
        {
            DataTable consulta = new DataTable();
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Open();

                adapter = new SqlDataAdapter("SELECT * FROM Servicio", conexion);
                adapter.Fill(consulta);
                conexion.Close();

            }

            return consulta;
        }
    }
}