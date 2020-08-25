using CapaConexion;
using CapaLogicaNegocios.ServicioMasterBikes;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class DaoCompra
    {
        private Cl_Operaciones operaciones;

        public DaoCompra()
        {
            operaciones = new Cl_Operaciones();
        }

        public int insertarProdCompra(List<Cl_Producto> listaProductos, int idTrabajador,int total)
        {
            try
            {
                object[] parametros = new object[8];
                //List<int> listaIdProd = new List<int>();
                operaciones.abrirConexion();
                int idCompra = insertarCompra(idTrabajador,total);
                foreach (var item in listaProductos)
                {
                    parametros[0] = item.modelo;
                    parametros[1] = item.descripcion;
                    parametros[2] = item.rutaFoto;
                    parametros[3] = Convert.ToInt32(item.cantidad);
                    parametros[4] = Convert.ToInt32(item.aro);
                    parametros[5] = item.nombre;
                    parametros[6] = item.proveedor;
                    parametros[7] = "P_IDPRODUCTO";
                    OracleCommand cmd = operaciones.execSP("PKG_BODEGA.INSERTAR_COMPRA_PRODUCTO", parametros);
                    cmd.ExecuteNonQuery();
                    int idProducto = Convert.ToInt32(cmd.Parameters["P_IDPRODUCTO"].Value);
                    //listaIdProd.Add(idProducto);
                    insertarDetalleCompra(Convert.ToInt32(item.cantidad), Convert.ToInt32((item.precio * item.cantidad) - ((item.precio * item.cantidad) * (item.descuento / 100))), item.proveedor,idProducto, Convert.ToInt32(idCompra));
                }
                return 1;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }

        public int insertarCompra(int idTrabajador,int total)
        {
            try
            {
                object[] parametros = new object[3];
                parametros[0] = total;
                parametros[1] = idTrabajador;
                parametros[2] = "P_IDCOMPRA";
                //operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_BODEGA.INSERTAR_COMPRA_PROD_PROV", parametros);
                cmd.ExecuteNonQuery();
                int idCompra = Convert.ToInt32(cmd.Parameters["P_IDCOMPRA"].Value);
                return idCompra;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
            /*finally
            {
                operaciones.cerrarConexion();
            }*/
        }

        public void insertarDetalleCompra(int cantidad, int precio, string proveedor, int idProducto, int idCompra)
        {
            try
            {
                object[] parametros = new object[5];
                parametros[0] = cantidad;
                parametros[1] = precio;
                parametros[2] = proveedor;
                parametros[3] = idProducto;
                parametros[4] = idCompra;
                //operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_BODEGA.INSERTAR_DET_COMPRA_PROV",parametros);
                cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
            /*finally
            {
                operaciones.cerrarConexion();
            }*/
        }
    }
}
