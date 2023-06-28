using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Search : Form
    {
        private SQLiteConnection conexion;
        public Search()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            string nombreZapato = textBoxNombreZapato.Text;

            // Realizar la búsqueda
            RealizarBusqueda(nombreZapato);
        }

        private void RealizarBusqueda(string nombreZapato)
        {
            try
            {
                // Abrir la conexión a la base de datos
                conexion.Open();

                // Consulta SQL para buscar los zapatos por nombre
                string consulta = "SELECT * FROM Zapato WHERE tipo LIKE @nombreZapato OR descripcion LIKE @nombreZapato";

                // Crear el comando SQL
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombreZapato", "%" + nombreZapato + "%");

                // Crear un adaptador de datos para llenar un DataTable
                SQLiteDataAdapter adaptador = new SQLiteDataAdapter(comando);
                DataTable tablaZapatos = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adaptador.Fill(tablaZapatos);

                // Mostrar los resultados en un control DataGridView (dataGridViewZapatos)
                dataGridViewZapatos.DataSource = tablaZapatos;

                // Cerrar la conexión a la base de datos
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            CRUD backCrud = new CRUD();
            backCrud.Show();
            this.Close();
        }
    }
}
