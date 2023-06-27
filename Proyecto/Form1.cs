using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        private SQLiteConnection conexion;

        public Form1()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=Users.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            // Verificar los datos de inicio de sesión
            if (VerificarCredenciales(usuario, contraseña))
            {
                Form2 formulario2 = new Form2();
                formulario2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    

    private bool VerificarCredenciales(string usuario, string contraseña)
    {
        try
        {
            // Abrir la conexión a la base de datos
            conexion.Open();

            // Consulta SQL para verificar las credenciales
            string consulta = "SELECT COUNT(*) FROM users WHERE nombre = @usuario AND contraseña = @contraseña";

            // Crear el comando SQL
            SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contraseña", contraseña);

            // Ejecutar la consulta y obtener el resultado
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            // Cerrar la conexión a la base de datos
            conexion.Close();

            // Verificar si se encontró una coincidencia
            if (resultado > 0)
            {
                return true; // Credenciales correctas
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }

        return false; // Credenciales incorrectas
    }
 }
}




