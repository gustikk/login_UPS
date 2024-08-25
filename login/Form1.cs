
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

                           



namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-2PL41 5ED\\MSSQLSERVER01; database=Login; Integrated Security=True");
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualización: Nombre de la base de datos cambiado a 'Login'
                SqlConnection conexion = new SqlConnection("server=DESKTOP-2PL45ED\\MSSQLSERVER01; database=Login; Integrated Security=True");

                // Abrir la conexión a la base de datos
                conexion.Open();

                // Obtener los datos del usuario y la contraseña desde los TextBoxes
                string usuario = txtusuario.Text;
                string contraseña = txtcontraseña.Text;

                // Consulta SQL para verificar las credenciales
                string query = "SELECT COUNT(1) FROM Usuario WHERE nombre = @usuario AND contraseña = @contraseña";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Parámetros SQL para evitar inyección de código
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    // Ejecutar la consulta
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si las credenciales son correctas
                    if (count == 1)
                    {
                        MessageBox.Show("Ingreso exitoso.");
                        // Aquí puedes redirigir a la siguiente ventana o acción
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
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

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            registro formRegistro = new registro();
            formRegistro.ShowDialog(); // Muestra el formulario de registro como un diálogo modal
        }
    }
}
