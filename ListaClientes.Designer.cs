namespace Inventario1
{
    partial class ListaClientes
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
            this.agregar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rCed = new System.Windows.Forms.RadioButton();
            this.rNom = new System.Windows.Forms.RadioButton();
            this.refrescar = new System.Windows.Forms.Button();
            this.seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(449, 65);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(449, 94);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 2;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(449, 123);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(12, 39);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(294, 20);
            this.buscar.TabIndex = 4;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Cliente";
            // 
            // rCed
            // 
            this.rCed.AutoSize = true;
            this.rCed.Checked = true;
            this.rCed.Location = new System.Drawing.Point(312, 39);
            this.rCed.Name = "rCed";
            this.rCed.Size = new System.Drawing.Size(58, 17);
            this.rCed.TabIndex = 6;
            this.rCed.TabStop = true;
            this.rCed.Text = "Cédula";
            this.rCed.UseVisualStyleBackColor = true;
            // 
            // rNom
            // 
            this.rNom.AutoSize = true;
            this.rNom.Location = new System.Drawing.Point(376, 39);
            this.rNom.Name = "rNom";
            this.rNom.Size = new System.Drawing.Size(62, 17);
            this.rNom.TabIndex = 7;
            this.rNom.TabStop = true;
            this.rNom.Text = "Nombre";
            this.rNom.UseVisualStyleBackColor = true;
            // 
            // refrescar
            // 
            this.refrescar.Location = new System.Drawing.Point(449, 36);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(75, 23);
            this.refrescar.TabIndex = 8;
            this.refrescar.Text = "Ver Todos";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // seleccionar
            // 
            this.seleccionar.Enabled = false;
            this.seleccionar.Location = new System.Drawing.Point(449, 152);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(75, 23);
            this.seleccionar.TabIndex = 9;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 252);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.refrescar);
            this.Controls.Add(this.rNom);
            this.Controls.Add(this.rCed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.ListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rCed;
        private System.Windows.Forms.RadioButton rNom;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.Button seleccionar;
    }
}