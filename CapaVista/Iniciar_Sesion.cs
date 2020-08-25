//using CapaVista.ServicioMasterBikes;
using CapaAccesoDatos;
using CapaLogicaNegocios;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaVista
{
    public partial class Iniciar_Sesion : MetroForm
    {
        //ServicioMasterBikes.ServicioClient servicio_usuario;
        DaoUsuario daoUsuario;
        public Iniciar_Sesion()
        {
            
            InitializeComponent();
            daoUsuario = new DaoUsuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //servicio_usuario = new ServicioClient();
            string user = txtUser.Text;
            string pass = txtPass.Text;
            Cl_Usuario usuario = daoUsuario.obtenerUsuario(user, pass);
            if (usuario.user!=null && usuario.idTipoUsuario==2 || usuario.idTipoUsuario==3 || usuario.idTipoUsuario==5 || usuario.idTipoUsuario==6) 
            {
                MessageBox.Show("El usuario esta registrado");

                //RunPrincipal(usuario);
                //Thread NuevoHilo = new System.Threading.Thread(new System.Threading.ThreadStart(RunPrincipal(usuario)));
                //NuevoHilo.SetApartmentState(System.Threading.ApartmentState.STA);
                //NuevoHilo.Start();

                this.Hide();
                txtUser.Text="";
                txtPass.Text="";
                RunPrincipal(usuario,this);

                
            }else
            {
                MessageBox.Show("El usuario no existe");
            }

            /*Principal p = new Principal();
            
            p.Show();*/
        }

        private void RunPrincipal(Cl_Usuario user,Form login)
        {
            Principal p = new Principal(user,login);
            p.ShowDialog();
        }

        private void Iniciar_Sesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
