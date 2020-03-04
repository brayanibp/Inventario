namespace Inventario1
{
    partial class Usuarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.accesos = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.rNom = new System.Windows.Forms.RadioButton();
            this.rCed = new System.Windows.Forms.RadioButton();
            this.refrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Usuario";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(12, 25);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(204, 20);
            this.buscar.TabIndex = 2;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(379, 51);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 3;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(379, 80);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 4;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // accesos
            // 
            this.accesos.Location = new System.Drawing.Point(379, 109);
            this.accesos.Name = "accesos";
            this.accesos.Size = new System.Drawing.Size(75, 23);
            this.accesos.TabIndex = 5;
            this.accesos.Text = "Accesos";
            this.accesos.UseVisualStyleBackColor = true;
            this.accesos.Click += new System.EventHandler(this.accesos_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(379, 138);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 6;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // rNom
            // 
            this.rNom.AutoSize = true;
            this.rNom.Location = new System.Drawing.Point(291, 26);
            this.rNom.Name = "rNom";
            this.rNom.Size = new System.Drawing.Size(62, 17);
            this.rNom.TabIndex = 9;
            this.rNom.Text = "Nombre";
            this.rNom.UseVisualStyleBackColor = true;
            // 
            // rCed
            // 
            this.rCed.AutoSize = true;
            this.rCed.Checked = true;
            this.rCed.Location = new System.Drawing.Point(227, 26);
            this.rCed.Name = "rCed";
            this.rCed.Size = new System.Drawing.Size(58, 17);
            this.rCed.TabIndex = 8;
            this.rCed.TabStop = true;
            this.rCed.Text = "Cédula";
            this.rCed.UseVisualStyleBackColor = true;
            // 
            // refrescar
            // 
            this.refrescar.Location = new System.Drawing.Point(379, 23);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(75, 23);
            this.refrescar.TabIndex = 10;
            this.refrescar.Text = "Ver Todos";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 268);
            this.Controls.Add(this.refrescar);
            this.Controls.Add(this.rNom);
            this.Controls.Add(this.rCed);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.accesos);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button accesos;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.RadioButton rNom;
        private System.Windows.Forms.RadioButton rCed;
        private System.Windows.Forms.Button refrescar;
    }
}