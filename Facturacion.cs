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

        public Usuario Responsable = UsuariosSQL.getLogedUser();
        public Cliente ClienteSeleccionado { get; set; }
        public List<Producto> ProductosSeleccionados = new List<Producto>();
        public Factura FacturaActual { get; set; }
        public DetsFactura DetallesFactura { get; set; }
        public void refrescar_tabla()
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = ProductosSeleccionados;
            dataGridView1.Columns[0].Frozen = true;
            dataGridView1.Columns[1].Frozen = true;
            dataGridView1.Columns[2].Frozen = true;
            dataGridView1.Columns[3].Frozen = true;
            dataGridView1.Columns[0].DataPropertyName = "Id";
            dataGridView1.Columns[1].DataPropertyName = "Nombre";
            dataGridView1.Columns[2].DataPropertyName = "Precio";
            dataGridView1.Columns[3].DataPropertyName = "Unidades";
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Descripción";
            dataGridView1.Columns[2].HeaderText = "Precio Unitario";
            dataGridView1.Columns[3].HeaderText = "Unidades";
            double subTotal = 0;
            double cIva = 0;
            for (int i = 0; i<dataGridView1.Rows.Count; i++)
            {
                subTotal += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                cIva += double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * 0.16;
            }
            sub_total.Text = subTotal.ToString();
            iva.Text = cIva.ToString();
            total.Text = (subTotal + cIva).ToString();
        }
        private void seleccionar_cliente_Click(object sender, EventArgs e)
        {
            ListaClientes listaClientesview = new ListaClientes("seleccionar");
            listaClientesview.ShowDialog();
            if (listaClientesview.ClienteSeleccionado != null)
            {
                ClienteSeleccionado = listaClientesview.ClienteSeleccionado;
                cedula_cliente.Text = ClienteSeleccionado.Cedula.ToString();
                agregar_producto.Enabled = true;
                agregar_producto.Visible = true;
                seleccionar_cliente.Enabled = false;
            }
        }

        private void agregar_producto_Click(object sender, EventArgs e)
        {
            Inventario inventarioview = new Inventario("seleccionar");
            inventarioview.ShowDialog();
            if (inventarioview.ProductoSeleccionado != null)
            {
                Producto producto = inventarioview.ProductoSeleccionado;
                producto.Unidades = 1;
                for (int i = 0; i<ProductosSeleccionados.Count; i++)
                {
                    if (producto.Id == ProductosSeleccionados[i].Id)
                    {
                        MessageBox.Show("No se puede agregar dos veces el mismo producto, aumente la cantidad de unidades a llevar","Información",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                }
                ProductosSeleccionados.Add(producto);
                refrescar_tabla();
            } else
            {
                MessageBox.Show("Algo ha sucedido");
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            refrescar_tabla();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            cedula_cliente.Text = "";
            total.Text = "0.00";
            sub_total.Text = "0.00";
            iva.Text = "0.00";
            agregar_producto.Enabled = false;
            seleccionar_cliente.Enabled = true;
            ProductosSeleccionados = null;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            if (!UsuariosSQL.confirmar_acceso("Fac"))
            {
                Close();
            } else
            {
                username.Text = Responsable.Username;
            }
        }

        private void facturar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            DetsFactura DetallesFactura = new DetsFactura();
            for (int i = 0; i<dataGridView1.Rows.Count; i++)
            {
                DetFactura detFactura = new DetFactura();
                detFactura.ProductoId = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                detFactura.Unidades = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                DetallesFactura.setLista(detFactura);
            }
            factura.NroFactura = 0;
            factura.NroControl = 0;
            factura.Fecha = DateTime.Now.ToString();
            factura.MontoBruto = double.Parse(sub_total.Text);
            factura.Iva = 16;
            factura.Estatus = 'C';
            factura.ResponsableId = Responsable.Id;
            factura.ClienteId = ClienteSeleccionado.Id;
            factura.Detalles = DetallesFactura;
        }
    }
}
