using CapaLogicaNegocios;
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

namespace CapaVista.Cajero
{
    public partial class Comprobante : MetroForm
    {
        int idVenta;
        public Comprobante()
        {
            InitializeComponent();
            cboTipoComprobante.Items.Add("Boleta");
            cboTipoComprobante.Items.Add("Factura");
        }

        public Comprobante(int idVen)
        {
            InitializeComponent();
            cboTipoComprobante.Items.Add("Boleta");
            cboTipoComprobante.Items.Add("Factura");
            idVenta = idVen;
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            int tipoComprobante = 0;
            DaoVenta daoVenta = new DaoVenta();
            if (cboTipoComprobante.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de Comprobante");
                return;
            }

            if (cboTipoComprobante.SelectedItem.ToString().Equals("Boleta"))
            {
                tipoComprobante = 1;

            }else
            {
                tipoComprobante = 2;
            }
            int resp = daoVenta.pagarProducto(idVenta,2);
            if (resp==1)
            {
                MessageBox.Show("Se pago la Venta");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el pago de la venta");
            }
        }
    }
}
