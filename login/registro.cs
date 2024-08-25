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

namespace login
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        // Conexión a la base de datos
        SqlConnection conexion = new SqlConnection("server=DESKTOP-2PL45ED\\MSSQLSERVER01; database=Login; Integrated Security=True");

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Obtener los datos ingresados
                string usuario = txtusuario.Text;
                string contraseña = txtcontraseña.Text;

                // Consulta para insertar un nuevo usuario
                string query = "INSERT INTO Usuario (nombre, contraseña) VALUES (@nombre, @contraseña)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Añadir parámetros para evitar inyección SQL
                    cmd.Parameters.AddWithValue("@nombre", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Usuario registrado exitosamente.");

                    // Cerrar el formulario de registro
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
    }
}
