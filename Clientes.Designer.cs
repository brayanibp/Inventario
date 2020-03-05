namespace Inventario1
{
    partial class Clientes
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
            this.cedula = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.direccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(46, 25);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(98, 20);
            this.cedula.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(12, 79);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(132, 20);
            this.nombre.TabIndex = 1;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(156, 79);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(132, 20);
            this.apellido.TabIndex = 2;
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(12, 261);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 23);
            this.registrar.TabIndex = 3;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(93, 261);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(107, 23);
            this.limpiar.TabIndex = 4;
            this.limpiar.Text = "Limpiar Formulario";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cédula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // tipo
            // 
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "-",
            "V",
            "E",
            "J"});
            this.tipo.Location = new System.Drawing.Point(12, 25);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(32, 21);
            this.tipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dirección";
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(12, 188);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(276, 20);
            this.direccion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "DD/MM/YYYY";
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 296);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cedula);
            this.MaximumSize = new System.Drawing.Size(320, 335);
            this.MinimumSize = new System.Drawing.Size(320, 335);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}