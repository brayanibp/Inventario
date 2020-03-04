using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Marca() { }
        public Marca(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
