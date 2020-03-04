namespace Inventario1
{
    partial class FormProducto
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
            this.registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unidades = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.marca = new System.Windows.Forms.ComboBox();
            this.marcas = new System.Windows.Forms.Button();
            this.nMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(15, 198);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(100, 23);
            this.registrar.TabIndex = 0;
            this.registrar.Text = "Guardar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(15, 25);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 20);
            this.descripcion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(15, 87);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 20);
            this.precio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // iva
            // 
            this.iva.Location = new System.Drawing.Point(130, 87);
            this.iva.Name = "iva";
            this.iva.Size = new System.Drawing.Size(100, 20);
            this.iva.TabIndex = 8;
            this.iva.Text = "16";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "I.V.A";
            // 
            // unidades
            // 
            this.unidades.Location = new System.Drawing.Point(15, 146);
            this.unidades.Name = "unidades";
            this.unidades.Size = new System.Drawing.Size(100, 20);
            this.unidades.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unidades Existentes";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(130, 198);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(100, 23);
            this.limpiar.TabIndex = 11;
            this.limpiar.Text = "Limpiar Campos";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // marca
            // 
            this.marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marca.FormattingEnabled = true;
            this.marca.Items.AddRange(new object[] {
            "-"});
            this.marca.Location = new System.Drawing.Point(130, 24);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(34, 21);
            this.marca.TabIndex = 12;
            this.marca.SelectedIndexChanged += new System.EventHandler(this.marca_SelectedIndexChanged);
            // 
            // marcas
            // 
            this.marcas.Location = new System.Drawing.Point(130, 144);
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(100, 23);
            this.marcas.TabIndex = 13;
            this.marcas.Text = "Agregar Marca...";
            this.marcas.UseVisualStyleBackColor = true;
            this.marcas.Click += new System.EventHandler(this.marcas_Click);
            // 
            // nMarca
            // 
            this.nMarca.AutoSize = true;
            this.nMarca.Location = new System.Drawing.Point(170, 28);
            this.nMarca.Name = "nMarca";
            this.nMarca.Size = new System.Drawing.Size(45, 13);
            this.nMarca.TabIndex = 14;
            this.nMarca.Text = "MARCA";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 249);
            this.Controls.Add(this.nMarca);
            this.Controls.Add(this.marcas);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.unidades);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrar);
            this.Name = "FormProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.ComboBox marca;
        private System.Windows.Forms.Button marcas;
        private System.Windows.Forms.Label nMarca;
    }
}