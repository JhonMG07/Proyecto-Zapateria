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
        private ListaDoblementeEnlazada zapatos;
        private int indiceActual;
        private bool columnasAgregadas;
        public FormReadIndividual()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //Crear la conexión con SQLite
            string cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);

            zapatos = new ListaDoblementeEnlazada();
            indiceActual = -1;
            columnasAgregadas = false;
            cargarZapatosDesdeBD();
            mostrarPrimerRegistroEnDataGridView();
        }

        private void mostrarPrimerRegistroEnDataGridView()
        {
            // Mostrar el primer registro en el DataGridView
            if (zapatos.primero != null)
            {
                indiceActual = zapatos.primero.id_zapato;
                mostrarRegistroEnDataGridView(indiceActual);
            }
        }

        private void mostrarRegistroEnDataGridView(int indiceActual)
        {
            try
            {
                // Limpiar el DataGridView
                dataGridViewIndividual.Rows.Clear();

                // Abrir la conexión a la base de datos
                conexion.Open();

                // Consulta SQL para obtener el zapato por su ID
                string consulta = $"SELECT * FROM Zapato WHERE id_zapato = {indiceActual}";

                // Crear el comando SQL
                SQLiteCommand comando = new SQLiteCommand(consulta, conexion);

                // Ejecutar el comando y obtener un lector de datos
                SQLiteDataReader lector = comando.ExecuteReader();

                // Verificar si se encontró un registro
                if (lector.Read())
                {
                    int id = Convert.ToInt32(lector["id_zapato"]);
                    string tipo = lector["tipo"].ToString();
                    int talla = Convert.ToInt32(lector["talla"]);
                    float precio = Convert.ToSingle(lector["precio"]);
                    string descripcion = lector["descripcion"].ToString();
                    string genero = lector["genero"].ToString();

                    // Agregar el registro al DataGridView
                    dataGridViewIndividual.Rows.Add(id, tipo, talla, precio, descripcion, genero);
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

        private void cargarZapatosDesdeBD()
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

                // Verificar si las columnas ya se han agregado
                if (!columnasAgregadas)
                {
                    // Agregar las columnas al DataGridView
                    dataGridViewIndividual.Columns.Add("id", "ID");
                    dataGridViewIndividual.Columns.Add("tipo", "Tipo");
                    dataGridViewIndividual.Columns.Add("talla", "Talla");
                    dataGridViewIndividual.Columns.Add("precio", "Precio");
                    dataGridViewIndividual.Columns.Add("descripcion", "Descripción");
                    dataGridViewIndividual.Columns.Add("genero", "Género");

                    columnasAgregadas = true;
                }

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
                    zapatos.agregarUltimoDato(zapato.Id_zapato);
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
            Nodo nodoActual = zapatos.obtenerNodoPorId(indiceActual);
            if (nodoActual.anterior != null && nodoActual.anterior != null)
            {
                indiceActual = nodoActual.anterior.id_zapato;
                mostrarRegistroEnDataGridView(indiceActual);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Nodo nodoActual = zapatos.obtenerNodoPorId(indiceActual);
            if (nodoActual.siguiente != null && nodoActual.siguiente != null)
            {
                indiceActual = nodoActual.siguiente.id_zapato;
                mostrarRegistroEnDataGridView(indiceActual);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (zapatos.primero != null)
            {
                indiceActual = zapatos.primero.id_zapato;
                mostrarRegistroEnDataGridView(indiceActual);
            }
        }

        private void btnÚltimo_Click(object sender, EventArgs e)
        {
            if (zapatos.ultimo != null)
            {
                indiceActual = zapatos.ultimo.id_zapato;
                mostrarRegistroEnDataGridView(indiceActual);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            CRUD backCRUD = new CRUD();
            backCRUD.Show();
            this.Close();
        }
    }
}
