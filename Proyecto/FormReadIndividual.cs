using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private ZapatoContext context;
        public FormReadIndividual()
        {
            InitializeComponent();
        }

        private void FormReadIndividual_Load(object sender, EventArgs e)
        {
            context = new ZapatoContext();

            //Load the student
            //context.Zapatos.Load();

            // Bind the student data to the DataGridView
            //dataGridViewIndividual.DataSource = context.Students.Local.ToBindingList();
        }
    }
}
