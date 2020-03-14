using Microsoft.Reporting.WinForms;
using System;
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
    public partial class FacturaReporte : Form
    {
        public FacturaReporte()
        {
            InitializeComponent();
        }

        private void FacturaReporte_Load(object sender, EventArgs e)
        {
            DocFac factura = FacturasSQL.ImpresionFactura();
            ReportDataSource dataReport = new ReportDataSource("DataFactura",factura);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario1.Factura.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dataReport);
            reportViewer1.RefreshReport();
        }
    }
}
