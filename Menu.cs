using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Inventario inventarioview = new Inventario())
                inventarioview.ShowDialog();
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Clientes clientesview = new Clientes())
                clientesview.ShowDialog();
        }
    }
}
