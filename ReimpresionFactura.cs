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
    public partial class ReimpresionFactura : Form
    {
        public ReimpresionFactura()
        {
            InitializeComponent();
        }

        private void ReimpresionFactura_Load(object sender, EventArgs e)
        {
            if (!UsuariosSQL.confirmar_acceso("rFa"))
            {
                Close();
            }
        }
        private void buscarF(string param, string tipo)
        {
            List<Factura> facturas = FacturasSQL.BuscarFacturas(param, tipo);
            dataGridView1.DataSource = facturas;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Tipo";
            dataGridView1.Columns[2].HeaderText = "Cédula";
            dataGridView1.Columns[3].HeaderText = "Nombre";
            dataGridView1.Columns[4].HeaderText = "Apellido";
            dataGridView1.Columns[5].HeaderText = "Dirección";
            dataGridView1.Columns[6].HeaderText = "Fecha de Nacimiento";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
        }
        private void reimprimir_Click(object sender, EventArgs e)
        {
            using (FacturaReporte facturaDocview = new FacturaReporte())
                facturaDocview.ShowDialog();
        }
        private void refrescar_Click(object sender, EventArgs e)
        {
            string param = "";
            string tipo = "todos";
            this.buscarF(param, tipo);
        }
    }
}
