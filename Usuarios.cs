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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            string param = "";
            string tipo = "todos";
            this.buscarU(param, tipo);
        }

        public Usuario UsuarioSeleccionado { get; set; }

        private void buscarU(string param, string tipo)
        {
            List<Usuario> usuarios = UsuariosSQL.BuscarUsuarios(param, tipo);
            dataGridView1.DataSource = usuarios;
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Tipo";
            dataGridView1.Columns[2].HeaderText = "Cédula";
            dataGridView1.Columns[3].HeaderText = "Nombre";
            dataGridView1.Columns[4].HeaderText = "Apellido";
            dataGridView1.Columns[5].HeaderText = "Nombre de Usuario";
            dataGridView1.Columns[6].HeaderText = "Fecha de Nacimiento";
            dataGridView1.Columns[7].HeaderText = "Dirección";
            dataGridView1.Columns[8].HeaderText = "Accesos";
            dataGridView1.Columns[9].HeaderText = "Contraseña";
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;
            dataGridView1.Columns[6].ReadOnly = true;
            dataGridView1.Columns[7].ReadOnly = true;
            dataGridView1.Columns[8].ReadOnly = true;
            dataGridView1.Columns[9].ReadOnly = true;
        }

        private void accesos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                UsuarioSeleccionado = UsuariosSQL.ObtenerUsuario(id);
                using (AccesosUsuario accesosUsuarioview = new AccesosUsuario(UsuarioSeleccionado))
                    accesosUsuarioview.ShowDialog();
                refrescar_Click(sender, e);
            }
            else
                MessageBox.Show("Debes seleccionar una fila.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void refrescar_Click(object sender, EventArgs e)
        {
            string param = "";
            string tipo = "todos";
            this.buscarU(param, tipo);
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            string tipo = "todos";
            string param;
            if (rCed.Checked)
            {
                tipo = "cedula";
            }
            else if (rNom.Checked)
            {
                tipo = "Nombre";
            }
            param = buscar.Text.Trim();
            buscarU(param, tipo);
            if (!rCed.Checked && !rNom.Checked)
                MessageBox.Show("Debes seleccionar un filtro para la barra de busqueda.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            using (FormUsuario formUsuarioview = new FormUsuario())
                formUsuarioview.ShowDialog();
            refrescar_Click(sender, e);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                UsuarioSeleccionado = UsuariosSQL.ObtenerUsuario(id);
                using (FormUsuario formUsuarioview = new FormUsuario(UsuarioSeleccionado))
                    formUsuarioview.ShowDialog();
                refrescar_Click(sender, e);
            }
            else
                MessageBox.Show("Debes seleccionar una fila.", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int response = 0;
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                if (MessageBox.Show("¿Estás Seguro de eliminar ésta fila?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    response = UsuariosSQL.EliminarUsuario(id);
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
    }
}
