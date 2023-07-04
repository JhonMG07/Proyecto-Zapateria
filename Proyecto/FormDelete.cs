using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormDelete : Form
    {
      
        List<Zapato> zapatos;
        private BindingSource bindingSource;
        string cadenaConexion;
        public FormDelete()
        {
            InitializeComponent();
            cadenaConexion = "Data Source=Zapatería.db;Version=3;";
            this.StartPosition = FormStartPosition.CenterScreen;
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
            zapatos = new List<Zapato>();
            CargarZapatosDesdeBD();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("Ingresa el id del zapato a Eliminar");
                return;
            }
            int zapatoId = Convert.ToInt32(txt_id.Text); // Reemplaza esto con tu lógica para obtener el ID

            // Crea una instancia del contexto de la base de datos

            using (SQLiteConnection connection = new SQLiteConnection(cadenaConexion))
            {
                connection.Open();

                string sql = "DELETE FROM Zapato WHERE id_zapato = @IdZapato"; // Sentencia DELETE para eliminar el zapato por su ID

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@IdZapato", zapatoId);
                    DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el zapato ID: {zapatoId}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes && BusquedaBinarioZapato(zapatoId))
                    {
                        dataGridView1.DataSource = null;
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Zapato eliminado exitosamente.");
                        dataGridView1.DataSource = zapatos;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un zapato con el ID especificado.");
                    }
                }
                
                connection.Close();
            }

        }

        private bool BusquedaBinarioZapato(int targetId)
        {
            int left = 0;
            int right = zapatos.Count - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (zapatos[middle].Id_zapato == targetId)
                {
                    zapatos.RemoveAt(middle);
                    return true;
                }
                else if (zapatos[middle].Id_zapato < targetId)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return false; // Zapato no encontrado
        }
        private void CargarZapatosDesdeBD()
        {
            try
            {
                SQLiteConnection conexion = new SQLiteConnection(cadenaConexion);
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
        private void button2_Click(object sender, EventArgs e)
        {
            CRUD backCrud = new CRUD();
            backCrud.Show();
            this.Close();

        }
    }
}
