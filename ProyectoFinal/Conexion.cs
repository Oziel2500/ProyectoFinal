using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProyectoFinal
{
    class Conexion
    {
        private string cadenaConexion;
        private SqlConnection conexion;

        public Conexion(string servidor, string baseDatos, string usuario, string contraseña)
        {
            // Cadena de conexión
            cadenaConexion = $"Data Source={servidor};Initial Catalog={baseDatos};User ID={usuario};Password={contraseña}";
            conexion = new SqlConnection(cadenaConexion);
        }

        public void AbrirConexion()
        {
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

        public SqlCommand CrearComando(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta, conexion);
            return comando;
        }

    }
}
