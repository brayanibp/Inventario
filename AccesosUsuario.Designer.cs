namespace Inventario1
{
    partial class AccesosUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inv = new System.Windows.Forms.CheckBox();
            this.cUs = new System.Windows.Forms.CheckBox();
            this.cAc = new System.Windows.Forms.CheckBox();
            this.cCl = new System.Windows.Forms.CheckBox();
            this.lCl = new System.Windows.Forms.CheckBox();
            this.Fac = new System.Windows.Forms.CheckBox();
            this.rFa = new System.Windows.Forms.CheckBox();
            this.aFa = new System.Windows.Forms.CheckBox();
            this.guardar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.cedula = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inv
            // 
            this.Inv.AutoSize = true;
            this.Inv.Location = new System.Drawing.Point(12, 67);
            this.Inv.Name = "Inv";
            this.Inv.Size = new System.Drawing.Size(73, 17);
            this.Inv.TabIndex = 0;
            this.Inv.Text = "Inventario";
            this.Inv.UseVisualStyleBackColor = true;
            // 
            // cUs
            // 
            this.cUs.AutoSize = true;
            this.cUs.Location = new System.Drawing.Point(12, 90);
            this.cUs.Name = "cUs";
            this.cUs.Size = new System.Drawing.Size(95, 17);
            this.cUs.TabIndex = 1;
            this.cUs.Text = "Crear Usuarios";
            this.cUs.UseVisualStyleBackColor = true;
            // 
            // cAc
            // 
            this.cAc.AutoSize = true;
            this.cAc.Location = new System.Drawing.Point(12, 113);
            this.cAc.Name = "cAc";
            this.cAc.Size = new System.Drawing.Size(108, 17);
            this.cAc.TabIndex = 2;
            this.cAc.Text = "Cambiar Accesos";
            this.cAc.UseVisualStyleBackColor = true;
            // 
            // cCl
            // 
            this.cCl.AutoSize = true;
            this.cCl.Location = new System.Drawing.Point(12, 136);
            this.cCl.Name = "cCl";
            this.cCl.Size = new System.Drawing.Size(91, 17);
            this.cCl.TabIndex = 3;
            this.cCl.Text = "Crear Clientes";
            this.cCl.UseVisualStyleBackColor = true;
            // 
            // lCl
            // 
            this.lCl.AutoSize = true;
            this.lCl.Location = new System.Drawing.Point(12, 159);
            this.lCl.Name = "lCl";
            this.lCl.Size = new System.Drawing.Size(100, 17);
            this.lCl.TabIndex = 4;
            this.lCl.Text = "Listado Clientes";
            this.lCl.UseVisualStyleBackColor = true;
            // 
            // Fac
            // 
            this.Fac.AutoSize = true;
            this.Fac.Location = new System.Drawing.Point(12, 182);
            this.Fac.Name = "Fac";
            this.Fac.Size = new System.Drawing.Size(65, 17);
            this.Fac.TabIndex = 5;
            this.Fac.Text = "Facturar";
            this.Fac.UseVisualStyleBackColor = true;
            // 
            // rFa
            // 
            this.rFa.AutoSize = true;
            this.rFa.Location = new System.Drawing.Point(133, 67);
            this.rFa.Name = "rFa";
            this.rFa.Size = new System.Drawing.Size(113, 17);
            this.rFa.TabIndex = 6;
            this.rFa.Text = "Reimprimir Factura";
            this.rFa.UseVisualStyleBackColor = true;
            // 
            // aFa
            // 
            this.aFa.AutoSize = true;
            this.aFa.Location = new System.Drawing.Point(133, 90);
            this.aFa.Name = "aFa";
            this.aFa.Size = new System.Drawing.Size(95, 17);
            this.aFa.TabIndex = 7;
            this.aFa.Text = "Anular Factura";
            this.aFa.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(272, 63);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(108, 23);
            this.guardar.TabIndex = 8;
            this.guardar.Text = "Guardar Cambios";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(272, 92);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(108, 23);
            this.cancelar.TabIndex = 9;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(12, 25);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(109, 20);
            this.cedula.TabIndex = 10;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(127, 25);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 11;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cédula";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(208, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(130, 13);
            this.username.TabIndex = 13;
            this.username.Text = "NOMBRE DEL USUARIO";
            // 
            // AccesosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 240);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.aFa);
            this.Controls.Add(this.rFa);
            this.Controls.Add(this.Fac);
            this.Controls.Add(this.lCl);
            this.Controls.Add(this.cCl);
            this.Controls.Add(this.cAc);
            this.Controls.Add(this.cUs);
            this.Controls.Add(this.Inv);
            this.Name = "AccesosUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accesos de Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Inv;
        private System.Windows.Forms.CheckBox cUs;
        private System.Windows.Forms.CheckBox cAc;
        private System.Windows.Forms.CheckBox cCl;
        private System.Windows.Forms.CheckBox lCl;
        private System.Windows.Forms.CheckBox Fac;
        private System.Windows.Forms.CheckBox rFa;
        private System.Windows.Forms.CheckBox aFa;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
    }
}