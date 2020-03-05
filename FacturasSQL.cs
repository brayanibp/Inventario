﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Inventario1
{
    class FacturasSQL
    {
        public static int Agregar(Factura factura)
        {
            int retorno = 0;
            MySqlConnection myConnection = DbComun.GetConnection();
            MySqlCommand myCommad = myConnection.CreateCommand();
            MySqlTransaction myTransaction;
            myTransaction = myConnection.BeginTransaction();
            myCommad.Connection = myConnection;
            myCommad.Transaction = myTransaction;
            string fecha = DateTime.Parse(factura.Fecha).Year.ToString() + "-" + DateTime.Parse(factura.Fecha).Month.ToString() + "-" + DateTime.Parse(factura.Fecha).Day.ToString();
            try
            {
                int id = getLastFacturaId();
                myCommad.CommandText = "INSERT INTO facturas (nro_factura, nro_control, fecha, monto_bruto, iva, estatus, responsable_id, cliente_id) VALUES ("+id.ToString()+", "+id.ToString()+", '"+fecha+"', "+factura.MontoBruto+", "+factura.Iva+", '"+factura.Estatus+"', "+factura.ResponsableId+", "+factura.ClienteId+")";
                myCommad.ExecuteNonQuery();
                List<DetFactura> detalles = factura.Detalles.getLista();
                myCommad.CommandText = "UPDATE incrementable SET inc = inc+1";
                myCommad.ExecuteNonQuery();
                for (int i = 0; i < detalles.Count; i++)
                {
                    myCommad.CommandText = "INSERT INTO facturas_det (factura_id,producto_id,unidades) VALUES ("+id.ToString()+", "+detalles[i].ProductoId.ToString()+", "+detalles[i].Unidades.ToString()+")";
                    myCommad.ExecuteNonQuery();
                }
                myTransaction.Commit();
                retorno = 1;
            } 
            catch(Exception e)
            {
                retorno = -1;
                try
                {
                    myTransaction.Rollback();
                } catch(MySqlException ex)
                {
                    if(myTransaction.Connection != null)
                    {
                        MessageBox.Show("An exception of type " + ex.GetType() + " was encountered while attempting to roll back the transaction. "+ex.Message);
                    }
                }
                MessageBox.Show("An exception of type " + e.GetType() + " was encountered while inserting the data. "+e.Message);
                MessageBox.Show("Neither record was written to database.");
            }
            finally
            {
                myConnection.Close();
            }
            return retorno;
        }

        public static int getLastFacturaId()
        {
            int id = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT inc FROM incrementable LIMIT 1"), DbComun.GetConnection());
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = reader.GetInt32(0);
            }
            return id;
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
