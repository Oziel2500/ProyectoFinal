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
    public partial class FormLibros : Form
    {

       // Conexion conexion;
        public FormLibros()
        {
            InitializeComponent();


            // ----------Inicializar la clase de conexión con los datos de acceso a la base de datos------------
           // string servidor = "tu_servidor";
           // string baseDatos = "Biblioteca";
           // string usuario = "tu_usuario";
           // string contraseña = "tu_contraseña";
           // conexion = new Conexion(servidor, baseDatos, usuario, contraseña);

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
            dtgLibros.Columns.Add("Cant_Ejemplares", "Cantidad Ejemplares");
            dtgLibros.Columns.Add("AnioPublicacion", "Año de Publicación");

            // Llamar al método para cargar los datos en el DataGridView
          //  CargarDatosDataGridView();

        }

        private void FormLibros_Load(object sender, EventArgs e)
        {

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

        private void CargarDatosDataGridView()
        {
            try
            {
                // -------------------Abrir la conexión a la base de datos-------------------
                //  conexion.AbrirConexion();

                // --------------------Crear el comando SQL para obtener los datos de la tabla Libros------------------
                // string consulta = "SELECT ID, ISBN, Titulo, Autor, Genero, Cant_Ejemplares, AnioPublicacion FROM Libros";
                // SqlCommand comando = conexion.CrearComando(consulta);

                // -----------Ejecutar el comando y obtener los datos en un DataTable-----------
                // DataTable dt = new DataTable();
                //SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                //adaptador.Fill(dt);

                // -------------Asignar el DataTable como fuente de datos para el DataGridView----------------
                // dtgLibros.DataSource = dt;

                // ---------------Cerrar la conexión a la base de datos-----------------
                // conexion.CerrarConexion();

                // Actualizar el DataGridView con los nuevos datos
                CargarDatosDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde la base de datos: " + ex.Message);
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

        private void dtgLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerIdLibroSeleccionado();
        }

        private void btnAltaLibro_Click_1(object sender, EventArgs e)
        {
            try
            {
                //--------- Obtener los datos del formulario-----------
                string isbn = txtISBN.Text;
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                string genero = cmbGenero.Text;
                int cantEjemplares = Convert.ToInt32(txtCantEjemplares.Text);
                int anioPublicacion = Convert.ToInt32(txtAnioPublicacion.Text);

                // ------------Abrir la conexión a la base de datos---------------
                //  conexion.AbrirConexion();

                // -------------Crear el comando SQL para la inserción--------------
                string consulta = $"INSERT INTO Libros (ISBN, Titulo, Autor, Genero, Cant_Ejemplares, AnioPublicacion) " +
                    $"VALUES ('{isbn}', '{titulo}', '{autor}', '{genero}', {cantEjemplares}, {anioPublicacion})";

                //  SqlCommand comando = conexion.CrearComando(consulta);

                // -----------Ejecutar el comando de inserción----------
                //  int filasAfectadas = comando.ExecuteNonQuery();

                // Actualizar el DataGridView con los nuevos datos
                CargarDatosDataGridView();

                //--------- Cerrar la conexión a la base de datos-----------------
                //   conexion.CerrarConexion();

                //   if (filasAfectadas > 0)
                //   {
                //       MessageBox.Show("Libro dado de alta exitosamente.");
                //      LimpiarFormulario();
                //  }
                // else
                //  {
                //      MessageBox.Show("Error al dar de alta el libro.");
                //  }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBajaLibro_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del libro a dar de baja (por ejemplo, seleccionándolo de un DataGridView)
                int idLibro = ObtenerIdLibroSeleccionado();

                //---------------- Abrir la conexión a la base de datos---------------
                //conexion.AbrirConexion();

                // Crear el comando SQL para la eliminación
                string consulta = $"DELETE FROM Libros WHERE ID = {idLibro}";

                // SqlCommand comando = conexion.CrearComando(consulta);

                // -------------------Ejecutar el comando de eliminación----------------
                //  int filasAfectadas = comando.ExecuteNonQuery();

                // ---------------Cerrar la conexión a la base de datos--------------
                // conexion.CerrarConexion();

                //  if (filasAfectadas > 0)
                {
                    //    MessageBox.Show("Libro dado de baja exitosamente.");
                    //    LimpiarFormulario();
                }
                // else
                {
                    //    MessageBox.Show("Error al dar de baja el libro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
