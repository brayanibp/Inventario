using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario1
{
    public class Usuario
    {
        public int Id { get; set; }
        public char Tipo { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Accesos { get; set; }
        public string Password { get; set; }

        public Usuario() { }

        public Usuario(int id, char tipo, int cedula, string nombre, string apellido, string username, string fechaNacimiento, string direccion, string accesos, string password)
        {
            Id = id;
            Tipo = tipo;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Username = username;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Accesos = accesos;
            Password = password;
        }
    }
}
