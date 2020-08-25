using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CapaAccesoDatos;
using CapaConexion;

namespace CapaLogicaNegocios
{
    public class DaoUsuario
    {
        private Cl_Operaciones operaciones;

        public DaoUsuario()
        {
            operaciones = new Cl_Operaciones();
        }

        public Cl_Usuario obtenerUsuario(string user, string pass)
        {
            try
            {
                Cl_Usuario usuario = new Cl_Usuario();
                OracleDataReader dr;
                object[] parametros = new object[3];
                parametros[0] = user;
                parametros[1] = pass;
                parametros[2] = "V_USUARIO";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_USUARIO.OBTENER_USUARIO", parametros);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        usuario.idUsuario = Convert.ToInt32(dr[0]);
                        usuario.user = dr[1].ToString();
                        if (dr[2]==null)
                        {
                            usuario.idTipoUsuario = 0;
                        }else
                        {
                            usuario.idTipoUsuario = Convert.ToInt32(dr[2]);
                        }
                        if (dr[3]==null)
                        {
                            usuario.idTrabajador = 0;
                        }else
                        {
                            usuario.idTrabajador = Convert.ToInt32(dr[3]);
                        }
                        
                    }
                    dr.Dispose();
                }
                return usuario;
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