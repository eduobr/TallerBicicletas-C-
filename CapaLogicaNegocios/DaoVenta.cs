using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using CapaAccesoDatos;
using CapaConexion;

namespace CapaLogicaNegocios
{
    public class DaoVenta
    {
        public Cl_Operaciones operaciones;
        ServicioMasterBikes.ServicioClient servicio;

        public DaoVenta()
        {
            operaciones = new Cl_Operaciones();
        }

        public int insertarVenta(Cl_Persona cliente, Cl_Usuario usuario,int totalVenta,int despacho,int tipoPago)
        {
            try
            {
                string rut = cliente.rut;
                string nombre = cliente.nombre;
                string apellido = cliente.apellido;
                int edad = cliente.edad;
                string direccion = cliente.direccion;
                string correo = cliente.correo;
                string comuna = cliente.comuna;
                int tipoDespacho = despacho;
                object[] parametros = new object[12];
                parametros[0] = null;
                parametros[1] = rut;
                parametros[2] = nombre;
                parametros[3] = apellido;
                parametros[4] = edad;
                parametros[5] = correo;
                parametros[6] = comuna;
                parametros[7] = totalVenta;
                parametros[8] = direccion;
                parametros[9] = tipoDespacho;
                parametros[10] = tipoPago;
                parametros[11] = "P_IDVENTA";

                if (usuario.idTipoUsuario == 5)
                {
                    parametros[0] = usuario.idTrabajador;
                }
                operaciones.abrirConexion();

                OracleCommand cmd = operaciones.execSP("PKG_VENTA.INSERTAR_VENTA", parametros);
                cmd.ExecuteNonQuery();
                int idVenta = Convert.ToInt32(cmd.Parameters["P_IDVENTA"].Value);
                //int idVenta = Convert.ToInt32(dr[0]);
                return idVenta;
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

        public int insertarDetalleVenta(int idVenta, int cantidad, int total, int idProducto)
        {
            try
            {
                object[] parametros = new object[4];
                parametros[0] = idVenta;
                parametros[1] = cantidad;
                parametros[2] = total;
                parametros[3] = idProducto;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.INSERTAR_DETALLE_VENTA", parametros);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return 0;
            }
            finally
            {
                operaciones.cerrarConexion();
            }
        }

        public List<Cl_Venta> obtenerVentas()
        {
            try
            {
                List<Cl_Venta> listaVentas = new List<Cl_Venta>();
                object[] parametros = new object[3];
                parametros[1] = "V_VENTA";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.OBTENER_VENTA", parametros);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cl_Venta venta = new Cl_Venta();
                        venta.idVenta = Convert.ToInt32(dr[0]);
                        venta.nombreCompleto = dr[1].ToString();
                        venta.fecha = Convert.ToDateTime(dr[2]);
                        venta.estado = dr[3].ToString();
                        venta.cantidad = Convert.ToInt32(dr[4]);
                        venta.total = Convert.ToInt32(dr[5]);
                        venta.idTrabajador = Convert.ToInt32(dr[6]);
                        venta.idCliente = Convert.ToInt32(dr[7]);
                        venta.tipoPago = dr[8].ToString();
                        listaVentas.Add(venta);
                    }
                }
                return listaVentas;
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

        public List<Cl_Detalle_Venta> obtenerDetalleVenta(int idVenta)
        {
            try
            {
                List<Cl_Detalle_Venta> listaDetVenta = new List<Cl_Detalle_Venta>();
                servicio = new ServicioMasterBikes.ServicioClient();
                object[] parametros = new object[2];
                parametros[0] = idVenta;
                parametros[1] = "V_VENTA";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.OBTENER_DET_VENTA", parametros);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cl_Detalle_Venta detalle = new Cl_Detalle_Venta();
                        detalle.imagen = servicio.ImgToByteArray(dr[0].ToString());
                        detalle.nombre = dr[1].ToString();
                        detalle.modelo = dr[2].ToString();
                        detalle.estado = dr[3].ToString();
                        detalle.cantidad = Convert.ToInt32(dr[4]);
                        detalle.total = Convert.ToInt32(dr[5]);
                        detalle.idProducto = Convert.ToInt32(dr[6]);
                        detalle.idDetalleVenta = Convert.ToInt32(dr[7]);
                        listaDetVenta.Add(detalle);
                    }
                }

                return listaDetVenta;
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

        public int modificarDetalleVenta(int idProducto, int idDetalle, int estado)
        {
            try
            {
                object[] parametros = new object[3];
                parametros[0] = idProducto;
                parametros[1] = idDetalle;
                parametros[2] = estado;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.MODIFICAR_DET_VENTA",parametros);
                cmd.ExecuteNonQuery();
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

        public int anularVenta(int idVenta)
        {
            try
            {
                object[] parametro = new object[1];
                parametro[0] = idVenta;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.ANULAR_VENTA",parametro);
                cmd.ExecuteNonQuery();
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

        public int cambiarProducto(int idDetalle,int cantidad, int idVenta, int idProductoNuevo, int idProductoAntiguo, int total,string motivo,int idTrabajador)
        {
            try
            {
                object[] parametros = new object[8];
                parametros[0] = idDetalle;
                parametros[1] = cantidad;
                parametros[2] = idVenta;
                parametros[3] = idProductoNuevo;
                parametros[4] = idProductoAntiguo;
                parametros[5] = total;
                parametros[6] = motivo;
                parametros[7] = idTrabajador;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.CAMBIAR_PRODUCTO", parametros);
                cmd.ExecuteNonQuery();
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

        public int pagarProducto(int idVenta, int tipoComprobante)
        {
            try
            {
                object[] parametros = new object[2];
                parametros[0] = idVenta;
                parametros[1] = tipoComprobante;
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.PAGAR_VENTA",parametros);
                cmd.ExecuteNonQuery();
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

        public List<Cl_Comprobante> obtenerComprobantes()
        {
            try
            {
                List<Cl_Comprobante> listaComprobantes = new List<Cl_Comprobante>();
                object[] parametro = new object[1];
                parametro[0] = "V_COMPROBANTE";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_VENTA.OBTENER_COMPROBANTES",parametro);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cl_Comprobante comprobante = new Cl_Comprobante();
                        comprobante.rut = dr[0].ToString();
                        comprobante.nombre = dr[1].ToString();
                        comprobante.fecha = Convert.ToDateTime(dr[2]);
                        comprobante.tipoComprobante = dr[3].ToString();
                        listaComprobantes.Add(comprobante);
                    }
                }
                return listaComprobantes;
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