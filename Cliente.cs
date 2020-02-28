using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    class Cliente
    {
        public int Id { get; set; }
        public char Tipo { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Cliente() {}

        public Cliente(int Id, char Tipo, int Cedula, string Nombre, string Apellido, string Direccion, DateTime FechaNacimiento)
        {
            this.Id = Id;
            this.Tipo = Tipo;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Direccion = Direccion;
            this.FechaNacimiento = FechaNacimiento;
        }
    }
}
