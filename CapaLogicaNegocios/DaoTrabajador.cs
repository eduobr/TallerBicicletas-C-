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
    public class DaoTrabajador
    {
        private Cl_Operaciones operaciones;

        public DaoTrabajador()
        {
            operaciones = new Cl_Operaciones();
        }

        public List<Cl_Trabajador> listarTrabajadores()
        {
            try
            {
                List<Cl_Trabajador> listaTrabajadores = new List<Cl_Trabajador>();
                object[] parametro = new object[1];
                parametro[0] = "P_OUT_TRABAJADORES";
                operaciones.abrirConexion();
                OracleCommand cmd = operaciones.execSP("PKG_TRABAJADORES.OBTENER_TRABAJADORES",parametro);
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cl_Trabajador trabajador = new Cl_Trabajador();
                        trabajador.idTrabajador = Convert.ToInt32(dr[0]);
                        trabajador.rut = dr[1].ToString();
                        trabajador.nombre = dr[2].ToString();
                        trabajador.cargo = dr[3].ToString();
                        trabajador.direccion = dr[4].ToString();
                        trabajador.correo = dr[5].ToString();
                        trabajador.fechaIngreso = Convert.ToDateTime(dr[6]);
                        trabajador.sueldo = Convert.ToInt32(dr[7]);
                        trabajador.estado = dr[8].ToString();
                        listaTrabajadores.Add(trabajador);
                    }
                }
                return listaTrabajadores;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public int ingresarTrabajador(Cl_Persona persona,Cl_Contrato contrato,Cl_Trabajador trabajador, Cl_Usuario usuario)
        {
            try
            {
                object[] parametros = new object[16];
                parametros[0] = persona.rut;
                parametros[1] = persona.nombre;
                parametros[2] = persona.apellido;
                parametros[3] = persona.edad;
                parametros[4] = persona.direccion;
                parametros[5] = persona.correo;
                parametros[6] = persona.idComuna;
                parametros[7] = trabajador.sueldo;

                contrato.rutaAfp = "./img/trabajadores/"+persona.rut+"/afp.png";
                File.WriteAllBytes(contrato.rutaAfp, contrato.afp);
                parametros[8] = contrato.rutaAfp;

                contrato.rutaSalud = "./img/trabajadores/"+persona.rut + "/salud.png";
                File.WriteAllBytes(contrato.rutaSalud, contrato.salud);
                parametros[9] = contrato.rutaSalud;

                contrato.rutaCarnet = "./img/trabajadores/" + persona.rut + "/carnet.png";
                File.WriteAllBytes(contrato.rutaCarnet, contrato.carnet);
                parametros[10] = contrato.rutaCarnet;

                contrato.rutaCerNacimiento = "./img/trabajadores/" + persona.rut + "/certificado-nacimiento.png";
                File.WriteAllBytes(contrato.rutaCerNacimiento, contrato.cerNacimiento);
                parametros[11] = contrato.rutaCerNacimiento;

                contrato.rutaCerResidencia = "./img/trabajadores/" + persona.rut + "/certificado-residencia.png";
                File.WriteAllBytes(contrato.rutaCerResidencia, contrato.cerResidencia);
                parametros[12] = contrato.rutaCerResidencia;

                parametros[13] = usuario.idTipoUsuario;
                parametros[14] = usuario.user;
                parametros[15] = usuario.pass;
                OracleCommand cmd = operaciones.execSP("PKG_TRABAJADORES.INGRESAR_TRABAJADOR", parametros);
                return 1;

            }
            catch
            {
                return 0;
            }
        }
    }
}