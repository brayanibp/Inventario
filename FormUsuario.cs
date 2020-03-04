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
    public partial class FormUsuario : Form
    {
        public string accion { get; set; } = "registrar";
        public FormUsuario()
        {
            InitializeComponent();
            if (accion == "registrar")
            {
                setAccesos.Enabled = false;
            }
        }

        public int idUser { get; set; }
        public Usuario usuarioSeleccionado { get; set; }

        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            usuarioSeleccionado = usuario;
            idUser = usuario.Id;
            tipo.Text = usuario.Tipo.ToString();
            cedula.Text = usuario.Cedula.ToString();
            nombre.Text = usuario.Nombre;
            username.Text = usuario.Username;
            password.Text = usuario.Password;
            apellido.Text = usuario.Apellido;
            if (usuario.FechaNacimiento == "00/00/0000")
                dateTimePicker1.Value = DateTime.Now;
            else
                dateTimePicker1.Value = DateTime.Parse(usuario.FechaNacimiento.Substring(3, 2) + "/" + usuario.FechaNacimiento.Substring(0, 2) + "/" + usuario.FechaNacimiento.Substring(6, 4));
            direccion.Text = usuario.Direccion;
            accion = "modificar";
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            if (tipo.Text.Trim() == string.Empty || cedula.Text.Trim() == string.Empty || nombre.Text.Trim() == string.Empty || apellido.Text.Trim() == string.Empty
                || username.Text.Trim() == string.Empty || password.Text.Trim() == string.Empty || direccion.Text.Trim() == string.Empty 
                || dateTimePicker1.Value.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Debe llenar todos los campos.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!cedula.Text.All(Char.IsDigit))
            {
                MessageBox.Show("El campo cédula solo acepta números.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!nombre.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Los campos nombre y apellido solo aceptan letras.", "Ha ocurrido algo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Usuario usuario = new Usuario();
            usuario.Tipo = char.Parse(tipo.Text.Trim());
            usuario.Cedula = int.Parse(cedula.Text.Trim());
            usuario.Nombre = nombre.Text.Trim();
            usuario.Apellido = apellido.Text.Trim();
            usuario.Username = username.Text.Trim();
            usuario.Direccion = direccion.Text.Trim();
            usuario.FechaNacimiento = dateTimePicker1.Value.ToString();
            usuario.Accesos = "Inv.";
            usuario.Password = password.Text.Trim();
            int response = 0;
            if (accion == "registrar")
            {
                response = UsuariosSQL.Agregar(usuario);
            }
            else
            {
                response = UsuariosSQL.Actualizar(idUser, usuario);
            }
            if (response > 0)
            {
                MessageBox.Show("Datos Guardados con Exito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no ha podido ser guardado.", "Algo a ido mal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void setAccesos_Click(object sender, EventArgs e)
        {
            using (AccesosUsuario accesosUsuarioview = new AccesosUsuario(usuarioSeleccionado))
                accesosUsuarioview.ShowDialog();
        }
    }
}
