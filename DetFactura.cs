using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    class DetFactura
    {
        public int Id { get; set; }
        public int FacturaId { get; set; }
        public int ProductoId { get; set; }
        public int Unidades { get; set; }

        public DetFactura(int Id, int FacturaId, int ProductoId, int Unidades)
        {
            this.Id = Id;
            this.FacturaId = FacturaId;
            this.ProductoId = ProductoId;
            this.Unidades = Unidades;
        }
    }
}
