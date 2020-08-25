using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaAccesoDatos;
using CapaConexion;

namespace CapaLogicaNegocios
{
    public class DaoCliente
    {
        private Cl_Operaciones operaciones;

        public DaoCliente()
        {
            operaciones = new Cl_Operaciones();
        }

        public Cl_Persona obtenerCliente(string rut)
        {
            try
            {
                Cl_Persona cliente = new Cl_Persona();
                OracleDataReader dr;
                object[] parametros = new object[2];
                parametros[0] = rut;
                parametros[1] = "V_CLIENTE";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.OBTENER_CLIENTE",parametros);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cliente.rut = dr[0].ToString();
                        cliente.nombre = dr[1].ToString();
                        cliente.apellido = dr[2].ToString();
                        cliente.edad = Convert.ToInt32(dr[3]);
                        cliente.direccion = dr[4].ToString();
                        cliente.correo = dr[5].ToString();
                        cliente.comuna = dr[6].ToString();
                    }
                    dr.Dispose();
                }
                return cliente;
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

        public List<string> obtenerComunas()
        {
            try
            {
                List<string> listaComunas = new List<string>();
                OracleDataReader dr;
                object[] parametro = new object[1];
                parametro[0] = "V_COMUNAS";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_CLIENTE.OBTENER_COMUNAS",parametro);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listaComunas.Add(dr[0].ToString());
                    }
                    dr.Dispose();
                }

                return listaComunas;
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