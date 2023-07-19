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
    }
}
