using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class READ : Form
    {
        private SQLiteConnection conexion;
        List<Zapato> zapatos;
        public READ()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);
            this.StartPosition = FormStartPosition.CenterScreen;
            zapatos = new List<Zapato>();
            CargarZapatosDesdeBD();
    }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD backCrud = new CRUD();
            backCrud.Show();
            this.Close();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (cmbOption.SelectedItem != null)
            {
                dataGridView1.DataSource = "";
                // Tu código aquí
                if (cmbOption.SelectedIndex == 0)
                {
                    BubbleSortNombres();
                }
                if (cmbOption.SelectedIndex == 1)
                {
                    selectionSort();
                }
                if (cmbOption.SelectedIndex == 2)
                {
                    insertionSort();
                }
                dataGridView1.DataSource = zapatos;
            }
            else
            {
                // No hay opción seleccionada
                MessageBox.Show("Seleccione al menos una opción!", "Advertencia");
            }

        }
        private void selectionSort()
        {
            for (int i = 0; i < zapatos.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < zapatos.Count; j++)
                {
                    if (zapatos[j].Talla < zapatos[minIndex].Talla)
                    {
                        minIndex = j;
                    }
                }
                // Intercambiar zapatos[i] y zapatos[minIndex]
                Zapato temp = zapatos[i];
                zapatos[i] = zapatos[minIndex];
                zapatos[minIndex] = temp;
            }
        }

        private void BubbleSortNombres()
        {

            for (int i = 0; i < zapatos.Count - 1; i++)
            {
                for (int j = 0; j < zapatos.Count - i - 1; j++)
                {
                    if (string.Compare(zapatos[j].Tipo, zapatos[j + 1].Tipo) > 0)
                    {
                        // Intercambiar zapatos[j] y zapatos[j + 1]
                        Zapato temp = zapatos[j];
                        zapatos[j] = zapatos[j + 1];
                        zapatos[j + 1] = temp;
                    }
                }
            }

        }
        private void insertionSort()
        {
            for (int i = 1; i < zapatos.Count; i++)
            {
                Zapato key = zapatos[i];
                int j = i - 1;
                while (j >= 0 && zapatos[j].Precio > key.Precio)
                {
                    zapatos[j + 1] = zapatos[j];
                    j = j - 1;
                }
                zapatos[j + 1] = key;
            }
        }

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
                    zapatos.Add(zapato);
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

    }
}
