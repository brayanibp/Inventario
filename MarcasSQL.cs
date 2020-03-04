using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventario1
{
    class MarcasSQL
    {
        public static int Agregar(string marca)
        {
            //marca.FechaNacimiento.ToString()
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO marcas (nombre) VALUES ('{0}')", marca), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static Marca ObtenerMarca(int Id)
        {
            Marca marca = new Marca();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM marcas WHERE id = {0}", Id), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                marca.Id = reader.GetInt32(0);
                marca.Nombre = reader.GetString(1);
            }
            return marca;
        }
        public static List<Marca> getMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM marcas"), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = reader.GetInt32(0);
                    marca.Nombre = reader.GetString(1);
                    marcas.Add(marca);
                }   
            }
            return marcas;
        }
        public static int EliminarMarca(int Id)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM marcas WHERE id = {0}", Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
