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
    public partial class FormProducto : Form
    {
        public string accion { get; set; } = "registrar";
        public Producto ProductoSeleccionado { get; set; }
        public FormProducto()
        {
            InitializeComponent();
            cargar_marcas();
        }
        public FormProducto(Producto producto)
        {
            InitializeComponent();
            cargar_marcas();
            ProductoSeleccionado = producto;
            descripcion.Text = ProductoSeleccionado.Nombre;
            marca.Text = ProductoSeleccionado.MarcaId.ToString();
            precio.Text = ProductoSeleccionado.Precio.ToString();
            iva.Text = ProductoSeleccionado.Iva.ToString();
            unidades.Text = ProductoSeleccionado.Unidades.ToString();
            accion = "modificar";
        }
        public void cargar_marcas()
        {
            List<Marca> marcas = MarcasSQL.getMarcas();
            for (int i = 0; i<marcas.Count; i++)
            {
                marca.Items.Add(marcas[i].Id);
            }
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            descripcion.Text = "";
            marca.SelectedIndex = 0;
            precio.Text = "";
            iva.Text = "16";
            unidades.Text = "";
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (descripcion.Text.Trim() == string.Empty || marca.Text.Trim() == string.Empty || precio.Text.Trim() == string.Empty || iva.Text.Trim() == string.Empty
                || unidades.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!precio.Text.All(Char.IsDigit) || !iva.Text.All(Char.IsDigit) || !unidades.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Los campos Precio, IVA e Unidades solo aceptan números.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (int.Parse(precio.Text.Trim()) <= 0 || int.Parse(iva.Text.Trim()) <= 0 || int.Parse(unidades.Text.Trim()) <= 0)
            {
                MessageBox.Show("Los campos Precio, IVA e Unidades solo aceptan números mayores a 0.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Producto producto = new Producto();
            producto.Nombre = descripcion.Text.Trim();
            producto.MarcaId = int.Parse(marca.Text.Trim());
            producto.Precio = double.Parse(precio.Text.Trim());
            producto.Iva = int.Parse(iva.Text.Trim());
            producto.Unidades = int.Parse(unidades.Text.Trim());
            int response = 0;
            if (accion == "registrar")
            {
                response = ProductosSQL.Agregar(producto);
            }
            else
            {
                response = ProductosSQL.Actualizar(ProductoSeleccionado.Id, producto);
            }
            if (response > 0)
            {
                MessageBox.Show("Datos Guardados con Exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Producto no ha podido ser guardado.", "Algo a ido mal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void marcas_Click(object sender, EventArgs e)
        {
            using (FormMarca formMarcaview = new FormMarca())
                formMarcaview.ShowDialog();
            cargar_marcas();
        }

        private void marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (marca.Text == "-")
            {
                return;
            }
            int id = int.Parse(marca.Text);
            Marca marcaSel = MarcasSQL.ObtenerMarca(id);
            nMarca.Text = marcaSel.Nombre;
        }
    }
}
