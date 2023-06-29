using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormReadIndividual : Form
    {
        private SQLiteConnection conexion;
        //private ListaDoblementeEnlazada<Zapato> listaZapatos;
        private LinkedList<Zapato> listaZapatos;
        public FormReadIndividual()
        {
            InitializeComponent();
            //Crear la conexión con SQLite
            string cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);

            listaZapatos = new LinkedList<Zapato>();
            CargarZapatosDesdeBD();

            this.StartPosition = FormStartPosition.CenterScreen;
        }
        // Método para cargar los zapatos desde la base de datos y llenar la lista
        private void FormReadIndividual_Load(object sender, EventArgs e)
        {
            dataGridViewIndividual.DataSource = listaZapatos.ToList();
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
                    listaZapatos.AddLast(zapato);
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {

        }
    }
}
