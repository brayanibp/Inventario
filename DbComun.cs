using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inventario1
{
     public class DbComun
    {
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost; database=inventariodb; Uid=root; pwd=123456");
            connection.Open();
            return connection;
        }
    }
}
