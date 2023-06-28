using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Proyecto
{
    public partial class CRUD : Form
    {
        
        public CRUD()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void individualReadItem_Click(object sender, EventArgs e)
        {
            FormReadIndividual formReadIndividual = new FormReadIndividual();
            formReadIndividual.MdiParent = this;
            formReadIndividual.Show();
        }

        private void searchItem_Click(object sender, EventArgs e)
        {
            Search searchWindow = new Search();
            searchWindow.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (resultado == DialogResult.Yes)
            {
                // Cerrar la aplicación
                Application.Exit();
            }
        }
    }
}
