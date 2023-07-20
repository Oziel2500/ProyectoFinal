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
    public partial class Libros : Form
    {
        string idgenero = "";
        int generos = 0;
        private DataTable dtLibros;
        private string connectionString = "Data Source = ALEJANDROMG\\SQLEXPRESS01; Initial Catalog = Biblioteca; User ID=Administrador;Password=Administrador; ";

        public Libros()
        {
            InitializeComponent();
            dtLibros = new DataTable();

            // Configurar el DataGridView
            dtgLibros.AutoGenerateColumns = false;
            dtgLibros.AllowUserToAddRows = false;
            dtgLibros.AllowUserToDeleteRows = false;
            dtgLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Agregar las columnas al DataGridView
            dtgLibros.Columns.Add("ID", "ID");
            dtgLibros.Columns.Add("ISBN", "ISBN");
            dtgLibros.Columns.Add("Titulo", "Título");
            dtgLibros.Columns.Add("Autor", "Autor");
            dtgLibros.Columns.Add("Genero", "Género");
            dtgLibros.Columns.Add("IdGenero", "IdGenero");
            dtgLibros.Columns.Add("Cant_Ejemplares", "Cantidad Ejemplares");
            dtgLibros.Columns.Add("AnioPublicacion", "Año de Publicación");

            dtgLibros.Columns["ID"].DataPropertyName = "ID";
            dtgLibros.Columns["ISBN"].DataPropertyName = "ISBN";
            dtgLibros.Columns["Titulo"].DataPropertyName = "Titulo";
            dtgLibros.Columns["Autor"].DataPropertyName = "Autor";
            dtgLibros.Columns["Genero"].DataPropertyName = "Genero";
            dtgLibros.Columns["IdGenero"].DataPropertyName = "IdGenero";
            dtgLibros.Columns["Cant_Ejemplares"].DataPropertyName = "Cant_Ejemplares";
            dtgLibros.Columns["AnioPublicacion"].DataPropertyName = "AnioPublicacion";

            // Llamar al método para cargar los datos en el DataGridView
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Libros";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            dtLibros.Clear();
                            adapter.Fill(dtLibros);
                        }
                    }
                }

                dtgLibros.DataSource = dtLibros; // Sin DefaultView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde la base de datos: " + ex.Message);
            }
        }

        private int ObtenerIdLibroSeleccionado()
        {
            int idLibroSeleccionado = 0;

            try
            {
                // Verificar si hay alguna fila seleccionada en el DataGridView
                if (dtgLibros.SelectedRows.Count > 0)
                {
                    // Obtener el valor del ID de la columna "ID" de la fila seleccionada
                    idLibroSeleccionado = Convert.ToInt32(dtgLibros.SelectedRows[0].Cells["ID"].Value);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un libro de la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el ID del libro seleccionado: " + ex.Message);
            }

            return idLibroSeleccionado;
        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(cmbGenero.Text) ||
                string.IsNullOrWhiteSpace(txtCantEjemplares.Text) ||
                string.IsNullOrWhiteSpace(txtAnioPublicacion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Validar que la cantidad de ejemplares y el año de publicación sean números válidos
            if (!int.TryParse(txtCantEjemplares.Text, out int cantEjemplares) ||
                !int.TryParse(txtAnioPublicacion.Text, out int anioPublicacion))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la cantidad de ejemplares y el año de publicación.");
                return;
            }

            // Obtener el ID de género según el género seleccionado
            idgenero = cmbGenero.Text;
            switch (idgenero)
            {
                case "Terror": generos = 6; break;
                case "Comedia": generos = 7; break;
                case "Romance": generos = 8; break;
                case "Ciencia ficcion": generos = 9; break;
                case "Aventura": generos = 10; break;
            }


            // Verificar que se haya seleccionado un género válido

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear el comando SQL para la inserción
                    string consulta = $"INSERT INTO Libros (ISBN, Titulo, Autor, Genero, Id_Genero, Cant_Ejemplares, AnioPublicacion) VALUES " +
                                      $"('{txtISBN.Text}', '{txtTitulo.Text}', '{txtAutor.Text}', '{cmbGenero.Text}', {generos}, {cantEjemplares}, {anioPublicacion})";

                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        // Ejecutar el comando de inserción
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Libro dado de alta exitosamente.");
                            LimpiarFormulario();
                            CargarDatosDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Error al dar de alta el libro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            cmbGenero.SelectedIndex = -1;
            txtCantEjemplares.Text = "";
            txtAnioPublicacion.Text = "";
        }

        private void btnBajaLibro_Click(object sender, EventArgs e)
        {
            // Obtener el ID del libro a dar de baja
            int idLibro = ObtenerIdLibroSeleccionado();

            // Verificar que se haya seleccionado un libro válido
            if (idLibro == 0)
            {
                MessageBox.Show("Por favor, seleccione un libro de la lista.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Crear el comando SQL para la eliminación
                    string consulta = $"DELETE FROM Libros WHERE ID = {idLibro}";

                    using (SqlCommand comando = new SqlCommand(consulta, connection))
                    {
                        // Ejecutar el comando de eliminación
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Libro dado de baja exitosamente.");
                            CargarDatosDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Error al dar de baja el libro.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
