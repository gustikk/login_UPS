
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
                // Actualizaci�n: Nombre de la base de datos cambiado a 'Login'
                SqlConnection conexion = new SqlConnection("server=DESKTOP-2PL45ED\\MSSQLSERVER01; database=Login; Integrated Security=True");

                // Abrir la conexi�n a la base de datos
                conexion.Open();

                // Obtener los datos del usuario y la contrase�a desde los TextBoxes
                string usuario = txtusuario.Text;
                string contrase�a = txtcontrase�a.Text;

                // Consulta SQL para verificar las credenciales
                string query = "SELECT COUNT(1) FROM Usuario WHERE nombre = @usuario AND contrase�a = @contrase�a";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Par�metros SQL para evitar inyecci�n de c�digo
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contrase�a", contrase�a);

                    // Ejecutar la consulta
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si las credenciales son correctas
                    if (count == 1)
                    {
                        MessageBox.Show("Ingreso exitoso.");
                        // Aqu� puedes redirigir a la siguiente ventana o acci�n
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contrase�a incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexi�n
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            registro formRegistro = new registro();
            formRegistro.ShowDialog(); // Muestra el formulario de registro como un di�logo modal
        }
    }
}
