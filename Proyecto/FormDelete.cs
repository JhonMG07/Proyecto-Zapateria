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
        private BindingSource bindingSource;
        public FormDelete()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
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
            string connectionString = "Data Source=Zapatería.db;Version=3;"; // Establece la cadena de conexión a tu base de datos

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Zapato WHERE id_zapato = @IdZapato"; // Sentencia DELETE para eliminar el zapato por su ID

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@IdZapato", zapatoId);
                    DialogResult result = MessageBox.Show($"¿Está seguro de eliminar el zapato ID: {zapatoId}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Zapato eliminado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró un zapato con el ID especificado.");
                    }
                }

                connection.Close();
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
