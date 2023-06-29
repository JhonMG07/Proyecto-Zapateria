using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Search : Form
    {
        private SQLiteConnection conexion;
        private List<Zapato> listaZapatos;
        public Search()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);
            this.StartPosition = FormStartPosition.CenterScreen;

            listaZapatos = new List<Zapato>();
            CargarZapatosDesdeBD();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void RealizarBusqueda(string nombreZapato)
        {
            // Crear una lista para almacenar los resultados de la búsqueda
            List<Zapato> resultados = new List<Zapato>();

            // Filtrar la lista de zapatos según el nombre
            foreach (Zapato zapato in listaZapatos)
            {
                if (zapato.Tipo.Contains(nombreZapato) || zapato.Descripcion.Contains(nombreZapato))
                {
                    resultados.Add(zapato);
                }
            }

            // Mostrar los resultados en el DataGridView (dataGridViewZapatos)
            dataGridViewZapatos.DataSource = resultados;
        }



        // Método para cargar los zapatos desde la base de datos y llenar la lista
        private void CargarZapatosDesdeBD()
        {
            try
            {
                // Abrir la conexión a la base de datos
                conexion.Open();

                // Consulta SQL para obtener los zapatos
                string consulta = "SELECT * FROM Zapato";

                // Crear el comando SQL
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

                // Ejecutar el comando y obtener un lector de datos
                SQLiteDataReader lector = comando.ExecuteReader();

                // Recorrer los resultados y agregarlos a la lista de zapatos
                while (lector.Read())
                {
                    int id = Convert.ToInt32(lector["id_zapato"]);
                    string tipo = lector["tipo"].ToString();
                    int talla = Convert.ToInt32(lector["talla"]);
                    float precio = Convert.ToSingle(lector["precio"]);
                    string descripcion = lector["descripcion"].ToString();
                    string genero = lector["genero"].ToString();

                    Zapato zapato = new Zapato(id, tipo, talla, precio, descripcion, genero);
                    listaZapatos.Add(zapato);
                }

                // Cerrar el lector de datos
                lector.Close();

                // Cerrar la conexión a la base de datos
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

      






        private void searchItem_Click(object sender, EventArgs e)
        {
            string nombreZapato = textBoxNombreZapato.Text;

            // Realizar la búsqueda
            RealizarBusqueda(nombreZapato);
        }

       

        private void regresarBtn_Click(object sender, EventArgs e)
        {
            CRUD backCrud = new CRUD();
            backCrud.Show();
            this.Close();
        }
    }
}
