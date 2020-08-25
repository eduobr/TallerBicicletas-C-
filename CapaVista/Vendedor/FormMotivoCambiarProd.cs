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

namespace CapaVista.Vendedor
{
    public partial class FormMotivoCambiarProd : MetroForm
    {
        int idDetalleVenta;
        int cantidad;
        int idVenta;
        int idProdNuevo;
        int idProdAntiguo;
        int total;
        int idTrabajador;
        FormCambiarProducto formcambiarProd;
        ServicioMasterBikes.ServicioClient servicio;
        public FormMotivoCambiarProd(int DetVenta, int cant, int venta, int prodNuevo, int prodAntiguo,int tot, int trabajador,FormCambiarProducto cambiarProd)
        {
            InitializeComponent();
            idDetalleVenta = DetVenta;
            cantidad = cant;
            idVenta = venta;
            idProdNuevo = prodNuevo;
            idProdAntiguo = prodAntiguo;
            total = tot;
            idTrabajador = trabajador;
            formcambiarProd = cambiarProd;
            servicio = new ServicioMasterBikes.ServicioClient();
        }

        private void btnConfirmarCambio_Click(object sender, EventArgs e)
        {
            DaoVenta daoVenta = new DaoVenta();
            string motivo = txtMotivo.Text;
            int resp = daoVenta.cambiarProducto(this.idDetalleVenta, this.cantidad, this.idVenta, this.idProdNuevo, this.idProdAntiguo, this.total,motivo, this.idTrabajador);
            if (resp==1)
            {
                MessageBox.Show("Producto Cambiado");
                this.formcambiarProd.Close();
                this.formcambiarProd.Dispose();
                this.Close();
                this.Dispose();
            }
        }
    }
}
