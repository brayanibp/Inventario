using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventario1
{
    class FacturasSQL
    {
        public static int Agregar(Factura factura)
        {
            //public void RunTransaction(string myConnString)
            //{
            //    MySqlConnection myConnection = new MySqlConnection(myConnString);
            //    myConnection.Open();
            //
            //    MySqlCommand myCommand = myConnection.CreateCommand();
            //    MySqlTransaction myTrans;
            //
            //    // Start a local transaction
            //    myTrans = myConnection.BeginTransaction();
            //    // Must assign both transaction object and connection
            //    // to Command object for a pending local transaction
            //    myCommand.Connection = myConnection;
            //    myCommand.Transaction = myTrans;
            //
            //    try
            //    {
            //        myCommand.CommandText = "insert into Test (id, desc) VALUES (100, 'Description')";
            //        myCommand.ExecuteNonQuery();
            //        myCommand.CommandText = "insert into Test (id, desc) VALUES (101, 'Description')";
            //        myCommand.ExecuteNonQuery();
            //        myTrans.Commit();
            //        Console.WriteLine("Both records are written to database.");
            //    }
            //    catch (Exception e)
            //    {
            //        try
            //        {
            //            myTrans.Rollback();
            //        }
            //        catch (SqlException ex)
            //        {
            //            if (myTrans.Connection != null)
            //            {
            //                Console.WriteLine("An exception of type " + ex.GetType() +
            //                " was encountered while attempting to roll back the transaction.");
            //            }
            //        }
            //
            //        Console.WriteLine("An exception of type " + e.GetType() +
            //        " was encountered while inserting the data.");
            //        Console.WriteLine("Neither record was written to database.");
            //    }
            //    finally
            //    {
            //        myConnection.Close();
            //    }
            //}
            //MySqlCommand mycommand = 
            int retorno = 0;
            string fecha = DateTime.Parse(factura.Fecha).Year.ToString() + "-" + DateTime.Parse(factura.Fecha).Month.ToString() + "-" + DateTime.Parse(factura.Fecha).Day.ToString();
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO usuarios (nro_factura, nro_control, fecha, monto_bruto, iva, estatus, responsable_id, cliente_id) VALUES ({0},{1},'{2}',{3},{4},'{5}',{6},{7})",
                factura.NroFactura, factura.NroControl, fecha, factura.MontoBruto, factura.Iva, factura.Estatus, factura.ResponsableId, factura.ClienteId), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int AnularFactura(int Id)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE usuarios SET estatus = 'A' WHERE id = {0}", Id), DbComun.GetConnection());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static Factura ObtenerUsuario(int nro_factura, int nro_control)
        {
            Factura factura = new Factura();
            DetsFactura detsfactura = new DetsFactura();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM facturas WHERE nro_factura = {0} AND nro_control = {1}", nro_factura, nro_control), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                factura.Id = reader.GetInt32(0);
                factura.NroFactura = reader.GetInt32(1);
                factura.NroControl = reader.GetInt32(2);
                factura.Fecha = reader.GetMySqlDateTime(3).ToString();
                factura.MontoBruto = reader.GetDouble(4);
                factura.Iva = reader.GetInt32(5);
                factura.Estatus = reader.GetChar(6);
                factura.ResponsableId = reader.GetInt32(7);
                factura.ClienteId = reader.GetInt32(8);
                factura.Detalles = ObtenerDetalles(factura.Id);
            }
            return factura;
        }
        public static DetsFactura ObtenerDetalles(int facturaId)
        {
            DetsFactura detalles = new DetsFactura();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT * FROM facturas_det WHERE factura_id = {0}", facturaId), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DetFactura detalle = new DetFactura(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3));
                    detalles.setLista(detalle);
                }
            }
            return detalles;
        }
    }
}
