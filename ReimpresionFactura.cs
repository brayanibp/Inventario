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
    public partial class ReimpresionFactura : Form
    {
        public ReimpresionFactura()
        {
            InitializeComponent();
        }

        private void ReimpresionFactura_Load(object sender, EventArgs e)
        {
            if (!UsuariosSQL.confirmar_acceso("rFa"))
            {
                Close();
            }
        }
    }
}
