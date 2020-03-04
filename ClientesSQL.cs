using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario1
{
    class ClientesSQL
    {
        public static int Agregar(Cliente cliente)
        {
            //cliente.FechaNacimiento.ToString()
            int retorno = 0;
            string fecha = DateTime.Parse(cliente.FechaNacimiento).Year.ToString() + "-" + DateTime.Parse(cliente.FechaNacimiento).Month.ToString() + "-" + DateTime.Parse(cliente.FechaNacimiento).Day.ToString();
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO clientes (tipo, cedula, nombre, apellido, direccion, fecha_nacimiento) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                cliente.Tipo, cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.Direccion, fecha), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int Actualizar(int Id, Cliente cliente)
        {
            int retorno = 0;
            string fecha = DateTime.Parse(cliente.FechaNacimiento).Year.ToString() + "-" + DateTime.Parse(cliente.FechaNacimiento).Month.ToString() + "-" + DateTime.Parse(cliente.FechaNacimiento).Day.ToString();
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE clientes SET tipo = '{0}', cedula = {1}, nombre = '{2}', apellido = '{3}', direccion = '{4}', fecha_nacimiento = '{5}' WHERE id = {6}",
                cliente.Tipo, cliente.Cedula, cliente.Nombre, cliente.Apellido, cliente.Direccion, fecha, Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Cliente> BuscarClientes(string param, string tipo)
        {
            List<Cliente> clientes = new List<Cliente>();
            if (param == string.Empty)
            {
                tipo = "todos";
            }
            if (tipo == "cedula")
            {
                int ced = int.Parse(param);
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM clientes WHERE cedula={0}",ced), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    clientes.Add(new Cliente(reader.GetInt32(0), char.Parse(reader.GetString(1)), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetMySqlDateTime(6).ToString()));
                }
            } else if (tipo == "Nombre")
            {
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM clientes WHERE Nombre LIKE '%{0}%'", param), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    clientes.Add(new Cliente(reader.GetInt32(0), char.Parse(reader.GetString(1)), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetMySqlDateTime(6).ToString()));
                }
            } else if (tipo == "todos")
            {
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM clientes"), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = reader.GetInt32(0);
                    cliente.Tipo = char.Parse(reader.GetString(1));
                    cliente.Cedula = reader.GetInt32(2);
                    cliente.Nombre = reader.GetString(3);
                    cliente.Apellido = reader.GetString(4);
                    cliente.Direccion = reader.GetString(5);
                    cliente.FechaNacimiento = reader.GetMySqlDateTime(6).ToString();
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }

        public static Cliente ObtenerCliente(int Id)
        {
            Cliente cliente = new Cliente();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM clientes WHERE id = {0}", Id), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            cliente.Id = reader.GetInt32(0);
            cliente.Tipo = char.Parse(reader.GetString(1));
            cliente.Cedula = reader.GetInt32(2);
            cliente.Nombre = reader.GetString(3);
            cliente.Apellido = reader.GetString(4);
            cliente.Direccion = reader.GetString(5);
            cliente.FechaNacimiento = reader.GetMySqlDateTime(6).ToString();
            return cliente;
        }

        public static int EliminarCliente(int Id)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM clientes WHERE id = {0}", Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
