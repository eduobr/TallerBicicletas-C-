using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;
using CapaLogicaNegocios;
using MetroFramework.Controls;
using CapaVista.Bodeguero;

namespace CapaVista.Cajero
{
    public partial class CajeroControl : MetroUserControl
    {
        DaoVenta daoVenta;
        public CajeroControl()
        {
            daoVenta = new DaoVenta();
            InitializeComponent();
            agregarBotonesDgVenta();
            cargarVentas();
            cargarComprobantes();
            
        }

        private void cargarComprobantes()
        {
            List<Cl_Comprobante> listaComprobantes = daoVenta.obtenerComprobantes();
            grdComprobantes.DataSource = listaComprobantes;

        }

        private void cargarVentas()
        {
            List<Cl_Venta> listaVentas = daoVenta.obtenerVentas();
            grdVentas.DataSource = listaVentas;
            grdVentas.AutoGenerateColumns = false;

            for (int i = 0; i < grdVentas.Columns.Count; i++)
            {
                if (grdVentas.Columns[i] == grdVentas.Columns["nombreCompleto"])
                {
                    grdVentas.Columns[i].Width = 130;
                }else if (grdVentas.Columns[i] == grdVentas.Columns["fecha"])
                {
                    grdVentas.Columns[i].Width = 100;
                }
                else
                {
                    grdVentas.Columns[i].Width = 60;
                }
            }
            grdVentas.Columns["idVenta"].DisplayIndex = 0;
            grdVentas.Columns["nombreCompleto"].DisplayIndex = 1;
            grdVentas.Columns["fecha"].DisplayIndex = 2;

            grdVentas.Columns["estado"].DisplayIndex = 3;
            grdVentas.Columns["tipoPago"].DisplayIndex = 4;
            grdVentas.Columns["total"].DisplayIndex = 5;
            grdVentas.Columns["idCliente"].DisplayIndex = 6;
            grdVentas.Columns["idTrabajador"].DisplayIndex = 7;
            grdVentas.Columns["colBtnPagar"].DisplayIndex = 8;


            grdVentas.Columns["idCliente"].Visible = false;
            grdVentas.Columns["idTrabajador"].Visible = false;
            grdVentas.Columns["cantidad"].Visible = false;
            //grdVentas.Columns["colBtnPagar"].Width = 100;
        }

        public void agregarBotonesDgVenta()
        {
            DataGridViewButtonColumn colBtPagar = new DataGridViewButtonColumn();
            colBtPagar.Name = "colBtnPagar";
            colBtPagar.HeaderText = "Pagar";
            colBtPagar.Text = "Pagar";
            colBtPagar.UseColumnTextForButtonValue = true;

            grdVentas.Columns.Add(colBtPagar);
            colBtPagar.FlatStyle = FlatStyle.Flat;
            
        }

        private void grdVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                string estado = grdVentas.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                if (this.grdVentas.Columns[e.ColumnIndex].Name == "colBtnPagar" && estado!="Anulado" && estado!="Pagado")
                {
                    int idVenta = Convert.ToInt32(this.grdVentas.Rows[e.RowIndex].Cells["idVenta"].Value);
                    //FormDespacharVenta despachar = new FormDespacharVenta(idVentam);
                    //despachar.ShowDialog(); 
                    Comprobante pagar = new Comprobante(idVenta);
                    pagar.ShowDialog();
                    cargarVentas();
                    cargarComprobantes();
                }
            }
        }

    }
}
