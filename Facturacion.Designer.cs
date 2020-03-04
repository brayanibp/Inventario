namespace Inventario1
{
    partial class Facturacion
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
            this.facturar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.reimpresion = new System.Windows.Forms.Button();
            this.anulacion = new System.Windows.Forms.Button();
            this.seleccionar_cliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.agregar_producto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.sub_total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // facturar
            // 
            this.facturar.Location = new System.Drawing.Point(12, 356);
            this.facturar.Name = "facturar";
            this.facturar.Size = new System.Drawing.Size(85, 23);
            this.facturar.TabIndex = 0;
            this.facturar.Text = "Facturar";
            this.facturar.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(103, 356);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(115, 23);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar Campos";
            this.limpiar.UseVisualStyleBackColor = true;
            // 
            // reimpresion
            // 
            this.reimpresion.Location = new System.Drawing.Point(224, 356);
            this.reimpresion.Name = "reimpresion";
            this.reimpresion.Size = new System.Drawing.Size(106, 23);
            this.reimpresion.TabIndex = 2;
            this.reimpresion.Text = "Reimprimir Factura";
            this.reimpresion.UseVisualStyleBackColor = true;
            this.reimpresion.Click += new System.EventHandler(this.reimpresion_Click);
            // 
            // anulacion
            // 
            this.anulacion.Location = new System.Drawing.Point(336, 356);
            this.anulacion.Name = "anulacion";
            this.anulacion.Size = new System.Drawing.Size(85, 23);
            this.anulacion.TabIndex = 3;
            this.anulacion.Text = "Anular Factura";
            this.anulacion.UseVisualStyleBackColor = true;
            this.anulacion.Click += new System.EventHandler(this.anulacion_Click);
            // 
            // seleccionar_cliente
            // 
            this.seleccionar_cliente.Location = new System.Drawing.Point(128, 24);
            this.seleccionar_cliente.Name = "seleccionar_cliente";
            this.seleccionar_cliente.Size = new System.Drawing.Size(85, 23);
            this.seleccionar_cliente.TabIndex = 4;
            this.seleccionar_cliente.Text = "Seleccionar...";
            this.seleccionar_cliente.UseVisualStyleBackColor = true;
            this.seleccionar_cliente.Click += new System.EventHandler(this.seleccionar_cliente_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cedula Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario Encargado";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(250, 29);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(141, 13);
            this.username.TabIndex = 8;
            this.username.Text = "NOMBRE DE USUARIO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 159);
            this.dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Articulos Seleccionados";
            // 
            // agregar_producto
            // 
            this.agregar_producto.Location = new System.Drawing.Point(145, 71);
            this.agregar_producto.Name = "agregar_producto";
            this.agregar_producto.Size = new System.Drawing.Size(88, 23);
            this.agregar_producto.TabIndex = 11;
            this.agregar_producto.Text = "Agregar...";
            this.agregar_producto.UseVisualStyleBackColor = true;
            this.agregar_producto.Click += new System.EventHandler(this.agregar_producto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sub Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOTAL:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.total.Location = new System.Drawing.Point(104, 304);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(36, 16);
            this.total.TabIndex = 15;
            this.total.Text = "0.00";
            // 
            // sub_total
            // 
            this.sub_total.AutoSize = true;
            this.sub_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_total.ForeColor = System.Drawing.SystemColors.GrayText;
            this.sub_total.Location = new System.Drawing.Point(104, 277);
            this.sub_total.Name = "sub_total";
            this.sub_total.Size = new System.Drawing.Size(36, 16);
            this.sub_total.TabIndex = 14;
            this.sub_total.Text = "0.00";
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 409);
            this.Controls.Add(this.total);
            this.Controls.Add(this.sub_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.agregar_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.seleccionar_cliente);
            this.Controls.Add(this.anulacion);
            this.Controls.Add(this.reimpresion);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.facturar);
            this.Name = "Facturacion";
            this.Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button facturar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button reimpresion;
        private System.Windows.Forms.Button anulacion;
        private System.Windows.Forms.Button seleccionar_cliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button agregar_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label sub_total;
    }
}