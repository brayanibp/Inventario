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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        public int idClient { get; set; }
        public string accion { get; set; } = "registrar";
        public Clientes(Cliente cliente)
        {
            InitializeComponent();
            idClient = cliente.Id;
            tipo.Text = cliente.Tipo.ToString();
            cedula.Text = cliente.Cedula.ToString();
            nombre.Text = cliente.Nombre;
            apellido.Text = cliente.Apellido;
            if (cliente.FechaNacimiento == "00/00/0000")
                dateTimePicker1.Value = DateTime.Now;
            else
                dateTimePicker1.Value = DateTime.Parse(cliente.FechaNacimiento.Substring(3,2)+"/"+ cliente.FechaNacimiento.Substring(0,2)+"/"+cliente.FechaNacimiento.Substring(6,4));
            direccion.Text = cliente.Direccion;
            accion = "modificar";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            tipo.SelectedIndex = 0;
            cedula.Text = "";
            nombre.Text = "";
            apellido.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            direccion.Text = "";
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (tipo.Text.Trim() == string.Empty || cedula.Text.Trim() == string.Empty || nombre.Text.Trim() == string.Empty || apellido.Text.Trim() == string.Empty
                || direccion.Text.Trim() == string.Empty || dateTimePicker1.Value.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe llenar todos los campos.","Ha ocurrido algo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            } else if (!cedula.Text.All(Char.IsDigit))
            {
                MessageBox.Show("El campo cédula solo acepta números.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (!nombre.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Los campos nombre y apellido solo aceptan letras.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Cliente cliente = new Cliente();
            cliente.Tipo = char.Parse(tipo.Text.Trim());
            cliente.Cedula = int.Parse(cedula.Text.Trim());
            cliente.Nombre = nombre.Text.Trim();
            cliente.Apellido = apellido.Text.Trim();
            cliente.Direccion = direccion.Text.Trim();
            cliente.FechaNacimiento = dateTimePicker1.Value.ToString();
            int response = 0;
            if (accion == "registrar")
            {
                response = ClientesSQL.Agregar(cliente);
            } else
            {
                response = ClientesSQL.Actualizar(idClient, cliente);
            }
            if (response > 0)
            {
                MessageBox.Show("Datos Guardados con Exito.","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cliente no ha podido ser guardado.", "Algo a ido mal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
