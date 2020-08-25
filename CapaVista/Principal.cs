using CapaAccesoDatos;
using CapaVista.Bodeguero;
using CapaVista.Cajero;
//using CapaVista.ServicioMasterBikes;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Principal : MetroForm
    {
        Form iniciar_sesion;
        public Principal()
        {
            InitializeComponent();
            VendedorControl vc = new VendedorControl();
            metroPanel1.Controls.Add(vc);
            vc.Dock = DockStyle.Fill;
        }
        public Principal(Cl_Usuario usuario,Form login)
        {
            InitializeComponent();
            iniciar_sesion = login;
            if (usuario.idTipoUsuario==5)
            {
                VendedorControl vc = new VendedorControl(usuario);
                metroPanel1.Controls.Add(vc);
                vc.Dock = DockStyle.Fill;
            }
            if (usuario.idTipoUsuario==6)
            {
                CajeroControl cj = new CajeroControl();
                metroPanel1.Controls.Add(cj);
                cj.Dock = DockStyle.Fill;
            }
            if (usuario.idTipoUsuario==3)
            {
                BodegueroControl bc = new BodegueroControl(usuario);
                metroPanel1.Controls.Add(bc);
                bc.Dock = DockStyle.Fill;

            }
            MessageBox.Show(usuario.user.ToString());

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            Iniciar_Sesion login = new Iniciar_Sesion();
            login.Show();
            //Application.Exit();
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha desconectado Correctamente");
            this.Close();
            //Application.Run(new Iniciar_Sesion());
        }
    }
}
