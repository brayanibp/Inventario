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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
            string param = "";
            string tipo = "todos";
            this.buscarP(param, tipo);
        }
        public Inventario(string s)
        {
            InitializeComponent();
            string param = "";
            string tipo = "todos";
            this.buscarP(param, tipo);
            if (s != string.Empty)
                seleccionar.Enabled = true;
        }

        public Producto ProductoSeleccionado { get; set; }

        private void buscarP(string param, string tipo)
        {
            List<Producto> productos = ProductosSQL.BuscarProductos(param, tipo);
            if (productos.Count == 0) 
            {
                if (!rCod.Checked)
                    MessageBox.Show("No se Encontraron productos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dataGridView2.DataSource = productos;
                dataGridView2.Columns[0].HeaderText = "Código";
                dataGridView2.Columns[1].HeaderText = "Descripción";
                dataGridView2.Columns[2].HeaderText = "Marca";
                dataGridView2.Columns[3].HeaderText = "Precio";
                dataGridView2.Columns[4].HeaderText = "IVA";
                dataGridView2.Columns[5].HeaderText = "Unidades";
                dataGridView2.Columns[0].ReadOnly = true;
                dataGridView2.Columns[1].ReadOnly = true;
                dataGridView2.Columns[2].ReadOnly = true;
                dataGridView2.Columns[3].ReadOnly = true;
                dataGridView2.Columns[4].ReadOnly = true;
                dataGridView2.Columns[5].ReadOnly = true;
            }
        }

        private void refrescar_Click(object sender, EventArgs e)
        {
            string param = "";
            string tipo = "todos";
            this.buscarP(param, tipo);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using (FormProducto formProductoview = new FormProducto())
                formProductoview.ShowDialog();
            refrescar_Click(sender, e);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                ProductoSeleccionado = ProductosSQL.ObtenerProducto(id);
                using (FormProducto formProductoview = new FormProducto(ProductoSeleccionado))
                    formProductoview.ShowDialog();
                refrescar_Click(sender, e);
            }
            else
                MessageBox.Show("Debes seleccionar una fila.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string tipo = "todos";
            string param;
            if (rCod.Checked)
            {
                tipo = "codigo";
            }
            else if (rDesc.Checked)
            {
                tipo = "descripcion";
            }
            param = search.Text.Trim();
            buscarP(param, tipo);
            if (!rCod.Checked && !rDesc.Checked)
                MessageBox.Show("Debes seleccionar un filtro para la barra de busqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int response = 0;
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("¿Estás Seguro de eliminar ésta fila?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    response = ProductosSQL.EliminarProducto(id);
                    if (response > 0)
                    {
                        MessageBox.Show("Eliminación realizada con exito.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Eliminación no podido realizarse.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Debes seleccionar una fila.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                ProductoSeleccionado = ProductosSQL.ObtenerProducto(id);
                if (ProductoSeleccionado != null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selección no ha podido realizarse.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Debes seleccionar una fila.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            if (!UsuariosSQL.confirmar_acceso("Inv"))
            {
                Close();
            }
        }
    }
}
