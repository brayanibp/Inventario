﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            if(username.Text.Trim() != string.Empty && username.Text.All(Char.IsLetter))
            {
                errorLabel1.Text = "";
            } else if(username.Text.Trim() != string.Empty && !username.Text.All(Char.IsLetter))
            {
                errorLabel1.Text = "El campo usuario no admite\rnumeros ni caracteres especiales";
            }
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if (password.Text.Trim() == string.Empty || username.Text.Trim() == string.Empty)
            {
                errorLabel1.Text = "Debe llenar ambos campos";
            } else if (username.Text.Trim() != string.Empty && !username.Text.All(Char.IsLetter))
            {
                errorLabel1.Text = "El campo usuario no admite\rnumeros ni caracteres especiales";
            } else
            {
                string pUsername = username.Text.Trim();
                string pPassword = password.Text.Trim();
                Usuario UsuarioLogueado = UsuariosSQL.Login(pUsername, pPassword);
                if (UsuarioLogueado.Username == null)
                {
                    MessageBox.Show("Usuario o Contraseña invalidos.","Información",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                } else
                {
                    using (Menu menuview = new Menu(UsuarioLogueado))
                        menuview.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
