namespace Inventario1
{
    partial class ReimpresionFactura
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rNroFac = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refrescar = new System.Windows.Forms.Button();
            this.reimprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 20);
            this.textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(234, 34);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cédula Cliente";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rNroFac
            // 
            this.rNroFac.AutoSize = true;
            this.rNroFac.Location = new System.Drawing.Point(326, 34);
            this.rNroFac.Name = "rNroFac";
            this.rNroFac.Size = new System.Drawing.Size(84, 17);
            this.rNroFac.TabIndex = 2;
            this.rNroFac.TabStop = true;
            this.rNroFac.Text = "Nro. Factura";
            this.rNroFac.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 177);
            this.dataGridView1.TabIndex = 3;
            // 
            // refrescar
            // 
            this.refrescar.Location = new System.Drawing.Point(416, 68);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(75, 23);
            this.refrescar.TabIndex = 4;
            this.refrescar.Text = "Refrescar Lista";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // reimprimir
            // 
            this.reimprimir.Location = new System.Drawing.Point(416, 97);
            this.reimprimir.Name = "reimprimir";
            this.reimprimir.Size = new System.Drawing.Size(75, 23);
            this.reimprimir.TabIndex = 5;
            this.reimprimir.Text = "Reimprimir";
            this.reimprimir.UseVisualStyleBackColor = true;
            this.reimprimir.Click += new System.EventHandler(this.reimprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // ReimpresionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 257);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reimprimir);
            this.Controls.Add(this.refrescar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rNroFac);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "ReimpresionFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reimpresión Factura";
            this.Load += new System.EventHandler(this.ReimpresionFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rNroFac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.Button reimprimir;
        private System.Windows.Forms.Label label1;
    }
}