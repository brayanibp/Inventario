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

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ListaClientes listaClientesview = new ListaClientes())
                listaClientesview.ShowDialog();
        }

        private void accesosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AccesosUsuario accesosUsuarioview = new AccesosUsuario())
                accesosUsuarioview.ShowDialog();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Usuarios usuariosview = new Usuarios())
                usuariosview.ShowDialog();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Facturacion facturacionview = new Facturacion())
                facturacionview.ShowDialog();
        }

        private void reimprimirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReimpresionFactura reimpresionview = new ReimpresionFactura())
                reimpresionview.ShowDialog();
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AnularFactura anulacionview = new AnularFactura())
                anulacionview.ShowDialog();
        }
    }
}
