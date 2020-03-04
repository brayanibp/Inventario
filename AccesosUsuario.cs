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
    public partial class AccesosUsuario : Form
    {
        public AccesosUsuario()
        {
            InitializeComponent();
        }
        public Usuario UsuarioSeleccionado { get; set; }
        public AccesosUsuario(Usuario usuario)
        {
            InitializeComponent();
            UsuarioSeleccionado = usuario;
            cedula.Text = usuario.Cedula.ToString();
            username.Text = usuario.Username;
            string[] accesos = usuario.Accesos.Split('.');
            for (int i = 0; i<accesos.Length; i++) {
                if (accesos[i] == "Inv")
                {
                    Inv.Checked = true;
                }
                if (accesos[i] == "cUs")
                {
                    cUs.Checked = true;
                }
                if (accesos[i] == "cAc")
                {
                    cAc.Checked = true;
                }
                if (accesos[i] == "cCl")
                {
                    cCl.Checked = true;
                }
                if (accesos[i] == "lCl")
                {
                    lCl.Checked = true;
                }
                if (accesos[i] == "Fac")
                {
                    Fac.Checked = true;
                }
                if (accesos[i] == "rFa")
                {
                    rFa.Checked = true;
                }
                if (accesos[i] == "aFa")
                {
                    aFa.Checked = true;
                }
            }
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuariosSQL.BuscarUsuarios(cedula.Text.Trim(), "cedula");
            username.Text = usuarios[0].Username;
            UsuarioSeleccionado = usuarios[0];
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            List<string> accesos = new List<string>();
            string accesos_cadena = "";
            if (Inv.Checked)
            {
                accesos.Add("Inv");
            }
            if (cUs.Checked)
            {
                accesos.Add("cUs");
            }
            if (cAc.Checked)
            {
                accesos.Add("cAc");
            }
            if (cCl.Checked)
            {
                accesos.Add("cCl");
            }
            if (lCl.Checked)
            {
                accesos.Add("lCl");
            }
            if (Fac.Checked)
            {
                accesos.Add("Fac");
            }
            if (rFa.Checked)
            {
                accesos.Add("rFa");
            }
            if (aFa.Checked)
            {
                accesos.Add("aFa");
            }
            for (int i = 0; i<accesos.Count; i++)
            {
                accesos_cadena += accesos[i].Trim() + ".";
            }
            int response = UsuariosSQL.ActualizarAccesos(UsuarioSeleccionado.Id, accesos_cadena);
            if (response > 0)
            {
                MessageBox.Show("Accesos de Usuario actualizados con Exito.","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Accesos de Usuario no han podido ser actualizados con Exito.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
