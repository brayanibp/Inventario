namespace Inventario1
{
    partial class AnularFactura
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
            this.anular = new System.Windows.Forms.Button();
            this.nro_factura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // anular
            // 
            this.anular.Location = new System.Drawing.Point(118, 23);
            this.anular.Name = "anular";
            this.anular.Size = new System.Drawing.Size(75, 23);
            this.anular.TabIndex = 0;
            this.anular.Text = "Anular";
            this.anular.UseVisualStyleBackColor = true;
            this.anular.Click += new System.EventHandler(this.anular_Click);
            // 
            // nro_factura
            // 
            this.nro_factura.Location = new System.Drawing.Point(12, 25);
            this.nro_factura.Name = "nro_factura";
            this.nro_factura.Size = new System.Drawing.Size(100, 20);
            this.nro_factura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nro. Factura";
            // 
            // AnularFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 67);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nro_factura);
            this.Controls.Add(this.anular);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(220, 106);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(220, 106);
            this.Name = "AnularFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnularFactura";
            this.Load += new System.EventHandler(this.AnularFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anular;
        private System.Windows.Forms.TextBox nro_factura;
        private System.Windows.Forms.Label label1;
    }
}