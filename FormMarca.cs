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
    public partial class FormMarca : Form
    {
        public FormMarca()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(codigo.Text);
            Marca marcaSel = MarcasSQL.ObtenerMarca(id);
            if (marcaSel.Nombre == null)
                MessageBox.Show("No existe una Marca con ese Código", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                nombre.Text = marcaSel.Nombre;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás Seguro de eliminar ésta Marca?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = int.Parse(codigo.Text);
                int response = MarcasSQL.EliminarMarca(id);
                if (response > 0)
                {
                    MessageBox.Show("Marca Eliminada con Exito.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    codigo.Text = "";
                    nombre.Text = "";
                }
                else
                    MessageBox.Show("Marca no pudo ser Eliminada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás Seguro de Agregar ésta marca? Se le asignara un codigo automatico.", "Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string mNombre = nombre.Text;
                int response = MarcasSQL.Agregar(mNombre);
                if (response > 0)
                {
                    MessageBox.Show("Marca Agregada con Exito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    codigo.Text = "";
                    nombre.Text = "";
                }
                else
                    MessageBox.Show("Marca no pudo ser Agregada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
