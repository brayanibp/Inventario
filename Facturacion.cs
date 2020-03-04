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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        public static Usuario Responsable { get; set; }
        public static Cliente ClienteSeleccionado { get; set; }
        public static List<Producto> ProductosSeleccionados = new List<Producto>();
        public static Factura FacturaActual { get; set; }

        private void seleccionar_cliente_Click(object sender, EventArgs e)
        {
            using (ListaClientes listaClientesview = new ListaClientes())
                listaClientesview.ShowDialog();
        }

        private void agregar_producto_Click(object sender, EventArgs e)
        {
            using (Inventario inventarioview = new Inventario())
                inventarioview.ShowDialog();
        }

        private void reimpresion_Click(object sender, EventArgs e)
        {
            using (ReimpresionFactura reimpresionview = new ReimpresionFactura())
                reimpresionview.ShowDialog();
        }

        private void anulacion_Click(object sender, EventArgs e)
        {
            using (AnularFactura anulacionview = new AnularFactura())
                anulacionview.ShowDialog();
        }
    }
}
