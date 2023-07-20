using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Prestamo : Form
    {
        string connectionString = "Data Source = ALEJANDROMG\\SQLEXPRESS01; Initial Catalog = Biblioteca; User ID=Administrador;Password=Administrador; "; // Reemplaza esto con tu cadena de conexión
        private DataTable dtLibros;
        private DataTable dtUsuarios;
        private DataTable dtPrestamos;
        public Prestamo()
        {
            InitializeComponent();
            dtLibros = new DataTable();
            dtUsuarios = new DataTable();
            dtPrestamos = new DataTable();
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            int idLibro = ObtenerIdLibroSeleccionado();
            int idUsuario = ObtenerIdUsuarioSeleccionado();

            if (idLibro == -1 || idUsuario == -1)
            {
                MessageBox.Show("Selecciona un libro y un usuario válidos.");
                return;
            }
            else
            {
                DateTime fechaPrestamo = dtpFechaPrestamo.Value;
                DateTime fechaEntrega = dtpFechaEntrega.Value;

                RegistrarPrestamo(idLibro, idUsuario, fechaPrestamo, fechaEntrega);
                MessageBox.Show("Préstamo registrado correctamente.");
                LimpiarCampos();
            }
          
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            ActualizarListaLibros();
            CargarLibros();

            ActualizarListaUsuarios();
            CargarUsuarios();
            ActualizarListaPrestamos();
        }
        private void ActualizarListaPrestamos()
        {
            ObtenerPrestamos();
            dgvPrestamos.DataSource = dtPrestamos;
        }
        private void ObtenerPrestamos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id_Prestamo, ID_Libro, ID_Usuario, Fecha_Prestamo, Fecha_Entrega FROM Prestamo";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dtPrestamos.Clear();
                        adapter.Fill(dtPrestamos);
                    }
                }
            }
        }
        private void ActualizarListaLibros()
        {
            ObtenerLibros();
            dgvLibros.DataSource = dtLibros;
        }

        private void CargarLibros()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, Titulo FROM Libros";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dtLibros.Clear();
                        adapter.Fill(dtLibros);
                    }
                }
            }

            // Llenar el ComboBox o ListBox con los libros
            // Por ejemplo, si tienes un ComboBox llamado cmbLibros:
            cmbLibros.DataSource = dtLibros;
            cmbLibros.DisplayMember = "Titulo";
            cmbLibros.ValueMember = "ID";
        }

        private int ObtenerIdLibroSeleccionado()
        {
            if (cmbLibros.SelectedItem != null)
            {
                DataRowView selectedBook = cmbLibros.SelectedItem as DataRowView;
                return Convert.ToInt32(selectedBook["ID"]);
            }

            return -1; // Si no se ha seleccionado ningún libro válido, retorna -1
        }

        private void ActualizarListaUsuarios()
        {
            ObtenerUsuarios();
            dgvUsuarios.DataSource = dtUsuarios;
        }

        private void CargarUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Usuario, Nombre FROM Usuarios";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dtUsuarios.Clear();
                        adapter.Fill(dtUsuarios);
                    }
                }
            }

            // Llenar el ComboBox o ListBox con los usuarios
            // Por ejemplo, si tienes un ComboBox llamado cmbUsuarios:
            cmbUsuarios.DataSource = dtUsuarios;
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.ValueMember = "ID_Usuario";
        }

        private int ObtenerIdUsuarioSeleccionado()
        {
            if (cmbUsuarios.SelectedItem != null)
            {
                DataRowView selectedUser = cmbUsuarios.SelectedItem as DataRowView;
                return Convert.ToInt32(selectedUser["ID_Usuario"]);
            }

            return -1; // Si no se ha seleccionado ningún usuario válido, retorna -1
        }

        private void ObtenerLibros()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID, Titulo FROM Libros";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dtLibros.Clear();
                        adapter.Fill(dtLibros);
                    }
                }
            }
        }

        private void ObtenerUsuarios()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ID_Usuario, Nombre FROM Usuarios";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        dtUsuarios.Clear();
                        adapter.Fill(dtUsuarios);
                    }
                }
            }
        }

        private void RegistrarPrestamo(int idLibro, int idUsuario, DateTime fechaPrestamo, DateTime fechaEntrega)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Prestamo (ID_Libro, ID_Usuario, Fecha_Prestamo, Fecha_Entrega) VALUES (@IDLibro, @IDUsuario, @FechaPrestamo, @FechaEntrega)";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@IDLibro", idLibro);
                    cmd.Parameters.AddWithValue("@IDUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                    cmd.Parameters.AddWithValue("@FechaEntrega", fechaEntrega);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void LimpiarCampos()
        {
            cmbLibros.SelectedIndex = -1;
            cmbUsuarios.SelectedIndex = -1;
            dtpFechaPrestamo.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;
        }
    }
}
