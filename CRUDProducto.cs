using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace DefinicionDatos
{
    class CRUDProducto
    {
        private MySqlConnection conex;
        //metodos de acceso a datos
        public bool InsertProd(Producto p) {
            try
            {
                conex = ConectarBD.conecta;
                if (conex == null)
                    return true;
                else
                {

                    var cadenaSql = "INSERT INTO almacencentral.producto" +
                      "(idproducto,Prod_Descripcion,Prod_PrecioVenta," +
                      "Prod_PrecioCompra,Prod_Existencia,Prod_FechaVencimiento)" +
                      "VALUES (@idproducto,@Prod_Descripcion," +
                      "@Prod_PrecioVenta,@Prod_PrecioCompra," +
                      "@Prod_Existencia,@Prod_FechaVencimiento)";
                    var comando = new MySqlCommand(cadenaSql, conex);
                    comando.Parameters.AddWithValue("@idproducto", p.NoSerie);
                    comando.Parameters.AddWithValue("@Prod_Descripcion", p.Descripcion);
                    comando.Parameters.AddWithValue("@Prod_PrecioVenta", p.PrecioVenta);
                    comando.Parameters.AddWithValue("@Prod_PrecioCompra", p.PrecioCompra);
                    comando.Parameters.AddWithValue("@Prod_Existencia", p.Existencia);
                    comando.Parameters.AddWithValue("@Prod_FechaVencimiento", p.FechaVencimiento);
                    //se abre la conexión
                    conex.Open();
                    //se ejecuta el comando con la sentencia sql 
                    var res = Convert.ToBoolean(comando.ExecuteNonQuery());
                    conex.Close();
                    return res;
                }
            }catch (MySqlException errores)
            {
                //guardar errores en un archivo de texto
                conex.Close();
                return false; 
            }
            
        }
        //el método de buscar un registro en la bse de datos
        public Producto  BuscaProducto(string id)
        {
            conex = ConectarBD.conecta;
            string cadsql = "select * from producto where idproducto=@id_producto";
            var comando = new MySqlCommand(cadsql, conex);
            comando.Parameters.AddWithValue("@id_producto", id);
            Producto  p = new Producto();
            try
            {
                conex.Open();
                var dr = comando.ExecuteReader();
                dr.Read();
                p = llenarProducto(dr);
                conex.Close();
                return p;
            }
            catch (MySqlException ERROR)
            {
                //manejar la excepcion
                conex.Close();
                return null;
            }
        }
        //método de llenar definición datos
        public Producto llenarProducto(MySqlDataReader msdr)
        {
            var p = new Producto();
            p.NoSerie  = Convert.ToString(msdr["idproducto"]);
            p.Descripcion   = Convert.ToString(msdr["Prod_Descripcion"]);
            p.PrecioVenta = Convert.ToDecimal(msdr["Prod_PrecioVenta"]);
            p.PrecioCompra = Convert.ToDecimal(msdr["Prod_PrecioCompra"]);
            p.Existencia = Convert.ToInt32(msdr["Prod_Existencia"]);
            p.FechaVencimiento = Convert.ToDateTime(msdr["Prod_FechaVencimiento"]);
            return p;
        }
        public bool ModificaProducto(Producto P, string id)
        {
            conex = ConectarBD.conecta;
            //transacciones
            MySqlTransaction transaccion = null;
            var cadsql = "update producto set idproducto=@idproducto," +
                "Prod_Descripcion=@Prod_Descripcion,Prod_PrecioVenta=@Prod_PrecioVenta," +
                "Prod_PrecioCompra = @Prod_PrecioCompra,Prod_Existencia=@Prod_Existencia," +
                "Prod_FechaVencimiento=@Prod_FechaVencimiento where" +
                " idproducto=@idproductoB";
            var comando = new MySqlCommand(cadsql, conex);
            comando.Parameters.AddWithValue("@idproducto", P.NoSerie);
            comando.Parameters.AddWithValue("@Prod_Descripcion", P.Descripcion);
            comando.Parameters.AddWithValue("@Prod_PrecioVenta", P.PrecioVenta);
            comando.Parameters.AddWithValue("@Prod_PrecioCompra", P.PrecioCompra);
            comando.Parameters.AddWithValue("@Prod_Existencia", P.Existencia);
            comando.Parameters.AddWithValue("@Prod_FechaVencimiento", P.FechaVencimiento);
            comando.Parameters.AddWithValue("@idproductoB", id);
            try
            {
                conex.Open();
                transaccion = conex.BeginTransaction();
                comando.Transaction = transaccion;
                var resultado = Convert.ToBoolean(comando.ExecuteNonQuery());
                if (resultado == false)
                    transaccion.Rollback();
                else
                    transaccion.Commit();
                return resultado;
            }
            catch (MySqlException error)
            {
                //manejar la excepcion en archivo de texto
                transaccion.Rollback();
                conex.Close();
                return false;
            }
        }
            public bool EliminaProducto(string id)
        {
           conex = ConectarBD.conecta;
            string cadsql = "delete from producto where idproducto=@id_producto";
            var comando = new MySqlCommand(cadsql, conex);
            comando.Parameters.AddWithValue("@id_producto", id);
            try
            {
                conex.Open();
                var resultado = Convert.ToBoolean(comando.ExecuteNonQuery());
                 conex.Close();
                return resultado ;
            }
            catch (MySqlException ERROR)
            {
                //manejar la excepcion
                conex.Close();
                return false;
            }
        }
    }

    
}
