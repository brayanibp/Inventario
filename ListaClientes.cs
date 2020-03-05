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
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
            string param = "";
            string tipo = "todos";
            this.buscarC(param, tipo);
        }
        public ListaClientes(string action)
        {
            InitializeComponent();
            string param = "";
            string tipo = "todos";
            this.buscarC(param, tipo);
            if (action != "default")
                seleccionar.Enabled = true;
        }
        public Cliente ClienteSeleccionado { get; set; }

        private void buscarC(string param, string tipo)
        {
            List<Cliente> clientes = ClientesSQL.BuscarClientes(param, tipo);
            dataGridView1.DataSource = clientes;
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

        private void refrescar_Click(object sender, EventArgs e)
        {
            string param = "";
            string tipo = "todos";
            this.buscarC(param, tipo);
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            string tipo = "todos";
            string param;
            if (rCed.Checked)
            {
                tipo = "cedula";
            } else if (rNom.Checked)
            {
                tipo = "Nombre";
            }
            param = buscar.Text.Trim();
            buscarC(param, tipo);
            if (!rCed.Checked && !rNom.Checked)
                MessageBox.Show("Debes seleccionar un filtro para la barra de busqueda.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClientesSQL.ObtenerCliente(id);
                using (Clientes clientesview = new Clientes(ClienteSeleccionado))
                    clientesview.ShowDialog();
                refrescar_Click(sender, e);
            }
            else
                MessageBox.Show("Debes seleccionar una fila.","Modificar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using (Clientes clientesview = new Clientes())
                clientesview.ShowDialog();
            refrescar_Click(sender,e);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int response = 0;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("¿Estás Seguro de eliminar ésta fila?","Eliminación",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    response = ClientesSQL.EliminarCliente(id);
                    if (response > 0)
                    {
                        MessageBox.Show("Eliminación realizada con exito.", "Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refrescar_Click(sender, e);
                    } else
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
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSeleccionado = ClientesSQL.ObtenerCliente(id);
                if (ClienteSeleccionado != null)
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

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            if (!UsuariosSQL.confirmar_acceso("lCl"))
            {
                Close();
            }
        }
    }
}
