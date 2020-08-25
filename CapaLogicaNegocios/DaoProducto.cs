using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using CapaConexion;

namespace CapaLogicaNegocios
{
    public class DaoProducto
    {
        private Cl_Operaciones operaciones;
        ServicioMasterBikes.ServicioClient servicio;

        public DaoProducto()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Cl_Producto> listarProductos()
        {
            servicio = new ServicioMasterBikes.ServicioClient();
            List<Cl_Producto> listaProd;
            OracleDataReader dr;
            try
            {
                listaProd = new List<Cl_Producto>();
                object[] parametro = new object[1];
                parametro[0] = "V_PROD";
                //string parametro = "V_PROD";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_PRODUCTOS.OBTENER_PRODUCTOS", parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cl_Producto producto = new Cl_Producto();
                        int idProducto = Convert.ToInt32(dr["IDPRODUCTO"]);
                        producto.idProducto = idProducto;
                        producto.nombre = dr["NOMBRE"].ToString();
                        producto.modelo = dr["MODELO"].ToString();
                        producto.descripcion = dr["DESCRIPCION"].ToString();
                        producto.rutaFoto = dr["FOTO"].ToString();
                        producto.precio = Convert.ToInt32(dr["PRECIO"]);
                        producto.descuento = Convert.ToInt32(dr["DESCUENTO"]);
                        producto.stock = servicio.obtenerStock(idProducto);//Convert.ToInt32(dr["STOCK"]);
                        producto.imagen = servicio.ImgToByteArray(producto.rutaFoto);
                        //Si la base de datos lo envia como null lo cambia a 0
                        producto.aro = Convert.ToInt32(dr["ARO"]);
                        listaProd.Add(producto);
                    }
                }
                dr.Dispose();
                return listaProd;
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

    }
}
