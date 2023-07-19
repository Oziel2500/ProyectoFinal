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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRedirigir_Click(object sender, EventArgs e)
        {
    
                // Crear una instancia de la FormRedirigida
                FormLibros formRedirigida = new FormLibros();

                // Mostrar la FormRedirigida utilizando el método Show()
                formRedirigida.Show();
                this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radEmpleado.Checked = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Agregar campo Contraseña a la tabla usuario
            string usuario = txtUsername.Text;
            string contraseña = txtPassword.Text;


            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingresa un nombre de usuario y contraseña válidos.");
                return;
            }
            if (radAdministrador.Checked)
            {
                //cambiar ALEJANDROMG\\SQLEXPRESS01 por el nombre de su servidor
                string connectionString = "Data Source = ALEJANDROMG\\SQLEXPRESS01; Initial Catalog = Biblioteca; User ID=Administrador;Password=Administrador; "; // Reemplaza esto con tu cadena de conexión
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Usuario AND Contraseña = @Contraseña AND ID_Usuario = 1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("hola administrador");//Formulario de los administradores
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas o usuario no es empleado.");
                        }
                    }
                }
            }
            if (radEmpleado.Checked)
            {
                //cambiar ALEJANDROMG\\SQLEXPRESS01 por el nombre de su servidor
                string connectionString = "Data Source = ALEJANDROMG\\SQLEXPRESS01; Initial Catalog = Biblioteca; User ID=Empleado;Password=Empleado; ";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Nombre = @Usuario AND Contraseña = @Contraseña AND ID_Usuario = 2"; // Verifica que el ID del usuario sea 2 (empleados)

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("¡Bienvenido, Empleado!");//Formulario del empleado
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas o usuario no es empleado.");
                        }
                    }
                }
            }
        }
    }
}
