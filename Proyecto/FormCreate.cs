using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormCreate : Form
    {
        private SQLiteConnection conexion;
        private BindingSource bindingSource;
        private SQLiteDataAdapter dataAdapter;
        private DataTable dataTable;

        public FormCreate()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);
            this.StartPosition = FormStartPosition.CenterScreen;
            bindingSource = new BindingSource();
            dataGridViewCreate.DataSource = bindingSource;
            LoadZapatosData();
        }

        private void LoadZapatosData()
        {
            try
            {
                conexion.Open();
                string consulta = "SELECT * FROM Zapato";
                dataAdapter = new SQLiteDataAdapter(consulta, conexion);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIDCreate.Text) &&
               !string.IsNullOrWhiteSpace(textBoxTipoCreate.Text) &&
               !string.IsNullOrWhiteSpace(textBoxTallaCreate.Text) &&
               !string.IsNullOrWhiteSpace(textBoxPrecioCreate.Text) &&
               !string.IsNullOrWhiteSpace(richTextBoxDescripcionCreate.Text))
            {
                int id = int.Parse(textBoxIDCreate.Text);
                string tipo = textBoxTipoCreate.Text;
                int talla = int.Parse(textBoxTallaCreate.Text);
                float precio = float.Parse(textBoxPrecioCreate.Text);
                string descripcion = richTextBoxDescripcionCreate.Text;
                string genero = textBoxGeneroCreate.Text;

                try
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Zapato (id_zapato, tipo, talla, precio, descripcion, genero) " +
                                      "VALUES (@id, @tipo, @talla, @precio, @descripcion, @genero)";

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        comando.Parameters.AddWithValue("@tipo", tipo);
                        comando.Parameters.AddWithValue("@talla", talla);
                        comando.Parameters.AddWithValue("@precio", precio);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@genero", genero);

                        comando.ExecuteNonQuery();
                    }

                    conexion.Close();

                    MessageBox.Show("Zapato creado y guardado en la base de datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el zapato en la base de datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos");
            }
            LoadZapatosData();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            CRUD backCrud = new CRUD();
            backCrud.Show();
            this.Close();

        }
    }
    }
