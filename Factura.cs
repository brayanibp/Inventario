using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    class Factura
    {
        public int Id { get; set; }
        public int NroFactura { get; set; }
        public int NroControl { get; set; }
        public DateTime Fecha { get; set; }
        public double MontoBruto { get; set; }
        public int Iva { get; set; }
        public double Total { get; set; }
        public char Estatus { get; set; }
        public DetsFactura Detalles { get; set; }

        public Factura() { }
        
        public Factura(int Id, int NroFactura, int NroControl, DateTime Fecha, double MontoBruto, int Iva, double Total, char Estatus, DetsFactura Detalles)
        {
            this.Id = Id;
            this.NroFactura = NroFactura;
            this.NroControl = NroControl;
            this.Fecha = Fecha;
            this.MontoBruto = MontoBruto;
            this.Iva = Iva;
            this.Total = Total;
            this.Estatus = Estatus;
            this.Detalles = Detalles;
        }
    }
}
