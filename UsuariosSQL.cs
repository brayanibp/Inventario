using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario1
{
    class UsuariosSQL
    {
        public static Usuario UsuarioLogueado = new Usuario();
        public static int Agregar(Usuario usuario)
        {
            //usuario.FechaNacimiento.ToString()
            int retorno = 0;
            string fecha = DateTime.Parse(usuario.FechaNacimiento).Year.ToString() + "-" + DateTime.Parse(usuario.FechaNacimiento).Month.ToString() + "-" + DateTime.Parse(usuario.FechaNacimiento).Day.ToString();
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuarios (tipo, cedula, nombre, apellido, username, direccion, fecha_nacimiento, accesos, u_password) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                usuario.Tipo, usuario.Cedula, usuario.Nombre, usuario.Apellido, usuario.Username, usuario.Direccion, fecha, usuario.Accesos, usuario.Password), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int Actualizar(int Id, Usuario usuario)
        {
            int retorno = 0;
            string fecha = DateTime.Parse(usuario.FechaNacimiento).Year.ToString() + "-" + DateTime.Parse(usuario.FechaNacimiento).Month.ToString() + "-" + DateTime.Parse(usuario.FechaNacimiento).Day.ToString();
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE usuarios SET tipo = '{0}', cedula = {1}, nombre = '{2}', apellido = '{3}', username = '{4}', direccion = '{5}', fecha_nacimiento = '{6}', accesos = '{7}', u_password = {8} WHERE id = {9}",
                usuario.Tipo, usuario.Cedula, usuario.Nombre, usuario.Apellido, usuario.Username, usuario.Direccion, fecha, usuario.Accesos, usuario.Password, Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActualizarAccesos(int Id, string accesos)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE usuarios SET accesos = '{0}' WHERE id = {1}", accesos, Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<Usuario> BuscarUsuarios(string param, string tipo)
        {
            List<Usuario> usuarios = new List<Usuario>();
            if (param == string.Empty)
            {
                tipo = "todos";
            }
            if (tipo == "cedula")
            {
                int ced = int.Parse(param);
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE cedula={0}", ced), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new Usuario(reader.GetInt32(0), char.Parse(reader.GetString(1)), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetMySqlDateTime(7).ToString(), reader.GetString(8), reader.GetString(9)));
                }
            }
            else if (tipo == "Nombre")
            {
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE Nombre LIKE '%{0}%'", param), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    usuarios.Add(new Usuario(reader.GetInt32(0), char.Parse(reader.GetString(1)), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetMySqlDateTime(7).ToString(), reader.GetString(8), reader.GetString(9)));
                }
            }
            else if (tipo == "todos")
            {
                MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM usuarios"), DbComun.GetConnection());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = reader.GetInt32(0);
                        usuario.Tipo = char.Parse(reader.GetString(1));
                        usuario.Cedula = reader.GetInt32(2);
                        usuario.Nombre = reader.GetString(3);
                        usuario.Apellido = reader.GetString(4);
                        usuario.Username = reader.GetString(5);
                        usuario.Direccion = reader.GetString(6);
                        usuario.FechaNacimiento = reader.GetMySqlDateTime(7).ToString();
                        usuario.Accesos = reader.GetString(8);
                        usuario.Password = reader.GetString(9);
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        public static Usuario ObtenerUsuario(int Id)
        {
            Usuario usuario = new Usuario();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE id = {0}", Id), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                usuario.Id = reader.GetInt32(0);
                usuario.Tipo = char.Parse(reader.GetString(1));
                usuario.Cedula = reader.GetInt32(2);
                usuario.Nombre = reader.GetString(3);
                usuario.Apellido = reader.GetString(4);
                usuario.Username = reader.GetString(5);
                usuario.Direccion = reader.GetString(6);
                usuario.FechaNacimiento = reader.GetMySqlDateTime(7).ToString();
                usuario.Accesos = reader.GetString(8);
                usuario.Password = reader.GetString(9);
            }
            return usuario;
        }

        public static int EliminarUsuario(int Id)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM usuarios WHERE id = {0}", Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static Usuario Login(string username, string password)
        {
            Usuario usuario = new Usuario();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM usuarios WHERE username = '{0}' AND u_password = '{1}'", username, password), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                usuario.Id = reader.GetInt32(0);
                usuario.Tipo = char.Parse(reader.GetString(1));
                usuario.Cedula = reader.GetInt32(2);
                usuario.Nombre = reader.GetString(3);
                usuario.Apellido = reader.GetString(4);
                usuario.Username = reader.GetString(5);
                usuario.Direccion = reader.GetString(6);
                usuario.FechaNacimiento = reader.GetMySqlDateTime(7).ToString();
                usuario.Accesos = reader.GetString(8);
                usuario.Password = reader.GetString(9);
                UsuarioLogueado = usuario;
            }
            return usuario;
        }
        public static bool confirmar_acceso(string param)
        {
            string[] accesosUser = UsuarioLogueado.Accesos.Split('.');
            bool accessGranted = false;
            for (int i = 0; i < accesosUser.Length; i++)
            {
                if (accesosUser[i] == param)
                {
                    accessGranted = true;
                }
            }
            if (!accessGranted)
            {
                MessageBox.Show("No tiene Acceso a este Formulario");
                return false;
            }
            return true;
        }
        public static Usuario getLogedUser()
        {
            return UsuarioLogueado;
        }
    }
}
