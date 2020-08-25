using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CapaConexion
{
    public class Cl_Operaciones
    {
        private OracleConnection conn;
        public Cl_Operaciones()
        {
            conn = new Cl_Conexion().obtenerConexion();
        }

        
        public void abrirConexion()
        {
            conn.Open();
        }

        
        public void cerrarConexion()
        {
            conn.Close();
        }

        
        public OracleDataReader sqlOperacion(string sql)
        {

            OracleCommand cmd = new OracleCommand(sql, conn);
            abrirConexion();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            return dr;

        }

        
        public OracleCommand execSP(string SP,params object[] parametros)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(SP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //abrirConexion();
                OracleCommandBuilder.DeriveParameters(cmd);
                int cuenta = 0;
                foreach (OracleParameter param in cmd.Parameters)
                {
                    if (param.ParameterName != "RETURN_VALUE")
                    {
                        param.Value = parametros[cuenta];
                        cuenta++;
                    }

                }
                /*foreach (string param in parametros)
                {
                    if (param.ToString()[0]=='V')
                    {
                        cmd.Parameters.Add(param.ToString(), OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                    }else
                    {
                        cmd.Parameters.Add(param);
                    }
                }*/
                //cmd.Parameters.Add(parametro.ToString(), OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                //cmd.Dispose();
                //OracleDataReader dr = cmd.ExecuteReader();
                //return dr;
                return cmd;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
    }
}
