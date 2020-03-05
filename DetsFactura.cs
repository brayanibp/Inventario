using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
     public class DetsFactura
    {
        private List<DetFactura> Lista = new List<DetFactura>();

        public List<DetFactura> getLista()
        {
            return this.Lista;
        }

        public void setLista(DetFactura Data)
        {
            this.Lista.Add(Data);
        }
    }
}
