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
    public partial class AnularFactura : Form
    {
        public AnularFactura()
        {
            InitializeComponent();
        }

        private void AnularFactura_Load(object sender, EventArgs e)
        {
            if (!UsuariosSQL.confirmar_acceso("aFa"))
            {
                Close();
            }
        }

        private void anular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás Seguro de Anular ésta Factura?", "Anulación de Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int response = FacturasSQL.AnularFactura(int.Parse(nro_factura.Text));
                if (response > 0)
                {
                    MessageBox.Show("Factura " + nro_factura.Text + " Factura Anulada con Exito.", "Anulación de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Anulación de Factura " + nro_factura.Text + " Fallida.", "Anulación de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Factura " + nro_factura.Text + " Anulación Cancelada.", "Anulación de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
