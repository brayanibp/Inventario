using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    class DocFac
    {
        public int Id { get; set; }
        public int NroFactura { get; set; }
        public int NroControl { get; set; }
        public string Fecha { get; set; }
        public double MontoBruto { get; set; }
        public int PorceIva { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public char Estatus { get; set; }
        public int ResponsableId { get; set; }
        public int ClienteId { get; set; }
        public int CedulaCliente { get; set; }
        public string NombreCliente { get; set; }
        public DetsFactura Detalles { get; set; }
        public DocFac() { }

        public DocFac(int id, int nroFactura, int nroControl, string fecha, double montoBruto, int porceIva, double iva, double total, char estatus, int responsableId, int clienteId, int cedulaCliente, string nombreCliente, DetsFactura detalles)
        {
            Id = id;
            NroFactura = nroFactura;
            NroControl = nroControl;
            Fecha = fecha;
            MontoBruto = montoBruto;
            PorceIva = porceIva;
            Iva = iva;
            Total = total;
            Estatus = estatus;
            ResponsableId = responsableId;
            ClienteId = clienteId;
            CedulaCliente = cedulaCliente;
            NombreCliente = nombreCliente;
            Detalles = detalles;
        }
    }
}
