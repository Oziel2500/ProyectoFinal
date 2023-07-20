using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    public partial class Cubiculo_Individual : Form
    {
        string connectionString = "Data Source = ALEJANDROMG\\SQLEXPRESS01; Initial Catalog = Biblioteca; User ID=Administrador;Password=Administrador; ";
        private Conexion conexionSQL;
        public bool c1, c2, c3, c4, c5, c6;
        public Cubiculo_Individual()
        {
            InitializeComponent();

        }

        private void Cubiculo4_Click(object sender, EventArgs e)
        {
            txtCubiculo.Text = "4";
            c1 = false; c2 = false; c3 = false; c4 = true; c5 = false; c6 = false;
        }

        private void Cubiculo1_Click(object sender, EventArgs e)
        {
            txtCubiculo.Text = "1";
            c1 = true; c2 = false; c3 = false; c4 = false; c5 = false; c6 = false;
        }

        private void Cubiculo2_Click(object sender, EventArgs e)
        {
            txtCubiculo.Text = "2";
            c1 = false; c2 = true; c3 = false; c4 = false; c5 = false; c6 = false;
        }

        private void Cubiculo_Individual_Load(object sender, EventArgs e)
        {
            string servidor = "NombreServidor";
            string baseDatos = "NombreBaseDatos";
            string usuario = "NombreUsuario";
            string contraseña = "ContraseñaUsuario";

            conexionSQL = new Conexion(servidor, baseDatos, usuario, contraseña);
        }

        private void rdbRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            grpbRegistrar.Enabled = true;
            btnLiberar.Enabled = false;
        }

        private void rdbLiberar_CheckedChanged(object sender, EventArgs e)
        {
            grpbRegistrar.Enabled = false;
            btnLiberar.Enabled = true;
        }

        private void Cubiculo3_Click(object sender, EventArgs e)
        {
            txtCubiculo.Text = "3";
            c1 = false; c2 = false; c3 = true; c4 = false; c5 = false; c6 = false;
        }

        private void Cubiculo5_Click(object sender, EventArgs e)
        {
            txtCubiculo.Text = "5";
            c1 = false; c2 = false; c3 = false; c4 = false; c5 = true; c6 = false;
        }

        private void Cubiculo6_Click(object sender, EventArgs e)
        {
            txtCubiculo.Text = "6";
            c1 = false; c2 = false; c3 = false; c4 = false; c5 = false; c6 = true;
        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            int Cubiculo = 0;
            //sintaxis para consultas, en la base de datos
            // conexionSQL.AbrirConexion();
            if (c1)
            {
                Cubiculo1.BackColor = Color.Green;
                Cubiculo = 1;
            }
            if (c2)
            {
                Cubiculo2.BackColor = Color.Green;
                Cubiculo = 2;
            }
            if (c3)
            {
                Cubiculo3.BackColor = Color.Green;
                Cubiculo = 3;
            }
            if (c4)
            {
                Cubiculo4.BackColor = Color.Green;
                Cubiculo = 4;
            }
            if (c5)
            {
                Cubiculo5.BackColor = Color.Green;
                Cubiculo = 5;
            }
            if (c6)
            {
                Cubiculo6.BackColor = Color.Green;
                Cubiculo = 6;
            }

            //string consulta = $"UPDATE Cubiculo_Individual SET FECHA_FIN = {DateTime.Now} WHERE ID_Cubiculo = {Cubiculo} ";
            //SqlCommand comando = conexionSQL.CrearComando(consulta);

            //SqlDataReader reader = comando.ExecuteReader();

            //reader.Read();
            //reader.Close();
            //conexionSQL.CerrarConexion();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //conexionSQL.AbrirConexion();

            //string consulta = $"INSERT INTO Cubiculo_Individual VALUES({txtCubiculo},{txtId_Usuario},{DateTime.Now},{null}";
            //SqlCommand comando = conexionSQL.CrearComando(consulta);

            //SqlDataReader reader = comando.ExecuteReader();

            //reader.Read();
            //reader.Close();

            //conexionSQL.CerrarConexion();
            if (c1)
            { Cubiculo1.BackColor = Color.Red; }
            if (c2)
            { Cubiculo2.BackColor = Color.Red; }
            if (c3)
            { Cubiculo3.BackColor = Color.Red; }
            if (c4)
            { Cubiculo4.BackColor = Color.Red; }
            if (c5)
            { Cubiculo5.BackColor = Color.Red; }
            if (c6)
            { Cubiculo6.BackColor = Color.Red; }
        }
    }
}
