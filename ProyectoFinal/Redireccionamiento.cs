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
            Libros formLibros = new Libros();
            formLibros.Show();
            
        }

        private void btnCubiculo_Individual_Click(object sender, EventArgs e)
        {
            // Redirigir al formulario de Cubículos Individuales
            Cubiculo_Individual formCubiculoIndividual = new Cubiculo_Individual();
            formCubiculoIndividual.Show();
           
        }

        private void btnCubiculoEquipo_Click(object sender, EventArgs e)
        {
            Cubiculo_Equipo formCubiculoEquipo = new Cubiculo_Equipo();
            formCubiculoEquipo.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.Show();
        }
    }
}
