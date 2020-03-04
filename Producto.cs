using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MarcaId { get; set; }
        public double Precio { get; set; }
        public int Iva { get; set; }
        public int Unidades { get; set; }

        public Producto() { }

        public Producto(int id, string nombre, int marcaId, double precio, int iva, int unidades)
        {
            Id = id;
            Nombre = nombre;
            MarcaId = marcaId;
            Precio = precio;
            Iva = iva;
            Unidades = unidades;
        }
    }
}
