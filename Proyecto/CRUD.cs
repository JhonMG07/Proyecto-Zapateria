using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void individualReadItem_Click(object sender, EventArgs e)
        {
            FormReadIndividual formReadIndividual = new FormReadIndividual();
            formReadIndividual.MdiParent = this;
            formReadIndividual.Show();
        }
    }
}
