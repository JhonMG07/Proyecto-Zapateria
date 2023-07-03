using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormUpdate : Form
    {
        private SQLiteConnection conexion;
        private BindingSource bindingSource;
        private SQLiteDataAdapter dataAdapter;
        private DataTable dataTable;
        private Zapato zapatoEncontrado;

        public FormUpdate()
        {
            InitializeComponent();
            string cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            conexion = new SQLiteConnection(cadenaConexion);
            bindingSource = new BindingSource();
            dataGridViewUpdate.DataSource = bindingSource;
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIDUpdate.Text))
            {
                int idBuscar = int.Parse(textBoxIDUpdate.Text);
                try
                {
                    conexion.Open();
                    string consulta = "SELECT * FROM Zapato WHERE id_zapato = @idBuscar";
                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@idBuscar", idBuscar);
                        using (SQLiteDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                int id = Convert.ToInt32(lector["id_zapato"]);
                                string tipo = lector["tipo"].ToString();
                                int talla = Convert.ToInt32(lector["talla"]);
                                float precio = Convert.ToSingle(lector["precio"]);
                                string descripcion = lector["descripcion"].ToString();
                                string genero = lector["genero"].ToString();

                                zapatoEncontrado = new Zapato(id, tipo, talla, precio, descripcion, genero);

                                // Mostrar los datos en los TextBox y RichTextBox
                                textBoxIDUpdate.Text = zapatoEncontrado.Id_zapato.ToString();
                                textBoxTipoUpdate.Text = zapatoEncontrado.Tipo;
                                textBoxTallaUpdate.Text = zapatoEncontrado.Talla.ToString();
                                textBoxPrecioUpdate.Text = zapatoEncontrado.Precio.ToString();
                                richTextBoxDescripcionUpdate.Text = zapatoEncontrado.Descripcion;
                                textBoxGeneroUpdate.Text = zapatoEncontrado.Genero;
                            }
                            else
                            {
                                MessageBox.Show("Zapato no encontrado");
                            }
                        }
                    }
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el ID del zapato a buscar");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (zapatoEncontrado != null)
            {
                // Actualizar los datos del zapato encontrado
                zapatoEncontrado.Tipo = textBoxTipoUpdate.Text;
                zapatoEncontrado.Talla = int.Parse(textBoxTallaUpdate.Text);

                // Redondear el precio a dos decimales
                float precio = float.Parse(textBoxPrecioUpdate.Text);
                zapatoEncontrado.Precio = (float)Math.Round(precio, 2);

                zapatoEncontrado.Descripcion = richTextBoxDescripcionUpdate.Text;
                zapatoEncontrado.Genero = textBoxGeneroUpdate.Text;

                try
                {
                    conexion.Open();
                    string consulta = "UPDATE Zapato SET tipo = @tipo, talla = @talla, precio = @precio, " +
                                      "descripcion = @descripcion, genero = @genero WHERE id_zapato = @id";

                    using (SQLiteCommand comando = new SQLiteCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@tipo", zapatoEncontrado.Tipo);
                        comando.Parameters.AddWithValue("@talla", zapatoEncontrado.Talla);
                        comando.Parameters.AddWithValue("@precio", zapatoEncontrado.Precio);
                        comando.Parameters.AddWithValue("@descripcion", zapatoEncontrado.Descripcion);
                        comando.Parameters.AddWithValue("@genero", zapatoEncontrado.Genero);
                        comando.Parameters.AddWithValue("@id", zapatoEncontrado.Id_zapato);

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();

                    MessageBox.Show("Zapato actualizado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el zapato: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Primero realice una búsqueda de zapato");
            }
            LoadZapatosData();
        }
    }
}
