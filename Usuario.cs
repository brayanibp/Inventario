using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    class Usuario
    {
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Accesos { get; set; }
        public string Password { get; set; }

        public Usuario(int id, int cedula, string nombre, string apellido, DateTime fechaNacimiento, string direccion, string accesos, string password)
        {
            Id = id;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Accesos = accesos;
            Password = password;
        }
    }
}
