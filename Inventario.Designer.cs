namespace Inventario1
{
    partial class Inventario
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refrescar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rDesc = new System.Windows.Forms.RadioButton();
            this.rCod = new System.Windows.Forms.RadioButton();
            this.seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(458, 86);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(458, 115);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 2;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(458, 144);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(12, 51);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(260, 20);
            this.search.TabIndex = 4;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Producto";
            // 
            // refrescar
            // 
            this.refrescar.Location = new System.Drawing.Point(458, 57);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(75, 23);
            this.refrescar.TabIndex = 6;
            this.refrescar.Text = "Ver todos";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(440, 233);
            this.dataGridView2.TabIndex = 7;
            // 
            // rDesc
            // 
            this.rDesc.AutoSize = true;
            this.rDesc.Location = new System.Drawing.Point(346, 52);
            this.rDesc.Name = "rDesc";
            this.rDesc.Size = new System.Drawing.Size(81, 17);
            this.rDesc.TabIndex = 11;
            this.rDesc.Text = "Descripción";
            this.rDesc.UseVisualStyleBackColor = true;
            // 
            // rCod
            // 
            this.rCod.AutoSize = true;
            this.rCod.Checked = true;
            this.rCod.Location = new System.Drawing.Point(282, 52);
            this.rCod.Name = "rCod";
            this.rCod.Size = new System.Drawing.Size(58, 17);
            this.rCod.TabIndex = 10;
            this.rCod.TabStop = true;
            this.rCod.Text = "Código";
            this.rCod.UseVisualStyleBackColor = true;
            // 
            // seleccionar
            // 
            this.seleccionar.Enabled = false;
            this.seleccionar.Location = new System.Drawing.Point(458, 173);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(75, 23);
            this.seleccionar.TabIndex = 12;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // Inventario
            // 
            this.ClientSize = new System.Drawing.Size(545, 331);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.rDesc);
            this.Controls.Add(this.rCod);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.refrescar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.agregar);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton rDesc;
        private System.Windows.Forms.RadioButton rCod;
        private System.Windows.Forms.Button seleccionar;
    }
}