using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaAccesoDatos;
using CapaConexion;
using Oracle.DataAccess.Client;

namespace CapaLogicaNegocios
{
    public class DaoDespacho
    {
        private Cl_Operaciones operaciones;

        public DaoDespacho()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Cl_Despacho> obtenerDespacho()
        {
            List<Cl_Despacho> listaDespacho;
            object[] parametro = new object[1];
            try
            {
                listaDespacho = new List<Cl_Despacho>();
                parametro[0] = "V_DESPACHO";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_DESPACHO.OBTENER_DESPACHOS", parametro);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cl_Despacho despacho = new Cl_Despacho();
                        despacho.idDespacho = Convert.ToInt32(dr[0]);
                        despacho.rut = dr[1].ToString();
                        despacho.nombre = dr[2].ToString();
                        despacho.direccion = dr[3].ToString();
                        despacho.comuna = dr[4].ToString();
                        despacho.fechaPedido = Convert.ToDateTime(dr[5]);
                        despacho.estado = dr[6].ToString();
                        despacho.idVenta = Convert.ToInt32(dr[7]);
                        listaDespacho.Add(despacho);
                    }
                }
                return listaDespacho;
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

        public int despacharVenta(int idDespacho,int idTrabajador)
        {
            try
            {
                operaciones.abrirConexion();
                object[] parametros = new object[2];
                parametros[0] = idDespacho;
                parametros[1] = idTrabajador;
                OracleCommand cmd = operaciones.execSP("PKG_DESPACHO.DESPACHAR", parametros);
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
    }
}