using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventario1
{
    class ProductosSQL
    {
        public static int Agregar(Producto producto)
        {
            //producto.FechaNacimiento.ToString()
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO productos (nombre,marca_id,precio,iva,unidades) VALUES ('{0}',{1},{2},{3},{4})", 
                producto.Nombre, producto.MarcaId, producto.Precio, producto.Iva, producto.Unidades), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int Actualizar(int Id, Producto producto)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE productos SET nombre = '{1}', marca_id = {2}, precio = {3}, iva = {4}, unidades = {5} WHERE id = {0}",
                Id, producto.Nombre, producto.MarcaId, producto.Precio, producto.Iva, producto.Unidades), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<Producto> BuscarProductos(string param, string tipo)
        {
            List<Producto> productos = new List<Producto>();
            if (param == string.Empty)
            {
                tipo = "todos";
            }
            if (tipo == "codigo")
            {
                if (param.All(Char.IsLetter))
                {
                    return productos;
                }
                int cod = int.Parse(param);
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM productos WHERE id={0}", cod), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDouble(3), reader.GetInt32(4), reader.GetInt32(5)));
                }
            }
            else if (tipo == "descripcion")
            {
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM productos WHERE nombre LIKE '%{0}%'", param), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    productos.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetDouble(3), reader.GetInt32(4), reader.GetInt32(5)));
                }
            }
            else if (tipo == "todos")
            {
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM productos"), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.Id = reader.GetInt32(0);
                        producto.Nombre = reader.GetString(1);
                        producto.MarcaId = reader.GetInt32(2);
                        producto.Precio = reader.GetDouble(3);
                        producto.Iva = reader.GetInt32(4);
                        producto.Unidades = reader.GetInt32(5);
                        productos.Add(producto);
                    }
                }
            }
            return productos;
        }
        public static Producto ObtenerProducto(int Id)
        {
            Producto producto = new Producto();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM productos WHERE id = {0}", Id), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            producto.Id = reader.GetInt32(0);
            producto.Nombre = reader.GetString(1);
            producto.MarcaId = reader.GetInt32(2);
            producto.Precio = reader.GetDouble(3);
            producto.Iva = reader.GetInt32(4);
            producto.Unidades = reader.GetInt32(5);
            return producto;
        }
        public static int EliminarProducto(int Id)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM productos WHERE id = {0}", Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
