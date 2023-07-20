using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Redireccionamiento : Form
    {
        public Redireccionamiento()
        {
            InitializeComponent();
        }

        private void btnAltasBajasLibros_Click(object sender, EventArgs e)
        {
            // Redirigir al formulario de Alta y Bajas de Libros
            FormLibros formLibros = new FormLibros();
            formLibros.Show();
            this.Hide();
        }

        private void btnCubiculo_Individual_Click(object sender, EventArgs e)
        {
            // Redirigir al formulario de Cubículos Individuales
            Cubiculo_Individual formCubiculoIndividual = new Cubiculo_Individual();
            formCubiculoIndividual.Show();
            this.Hide();
        }

        private void btnCubiculoEquipo_Click(object sender, EventArgs e)
        {
            Cubiculo_Equipo formCubiculoEquipo = new Cubiculo_Equipo();
            formCubiculoEquipo.Show();
            this.Hide();
        }
    }
}
