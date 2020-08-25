using CapaAccesoDatos;
using CapaLogicaNegocios;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista.Bodeguero
{
    public partial class FormDespacharVenta : MetroForm
    {
        int idVenta;
        int idDespacho;
        int idTrabajador;
        //ServicioMasterBikes.ServicioClient servicio;
        DaoDespacho daoDespacho;
        DaoVenta daoVenta;
        public FormDespacharVenta()
        {
            InitializeComponent();
            //servicio = new ServicioMasterBikes.ServicioClient();
            daoVenta = new DaoVenta();
            daoDespacho = new DaoDespacho();
        }

        public FormDespacharVenta(int idVent,int idDes,int idTrab)
        {
            InitializeComponent();
            //servicio = new ServicioMasterBikes.ServicioClient();
            daoVenta = new DaoVenta();
            idVenta = idVent;
            idDespacho = idDes;
            idTrabajador = idTrab;
            daoDespacho = new DaoDespacho();
            //agregarBotonesDgDetDespacho();
            cargarDetalleDespacho();
            modificarColumnasDetDespacho();
            
        }

        private void agregarBotonesDgDetDespacho()
        {
            DataGridViewDisableButtonColumn colBtnDespachar = new DataGridViewDisableButtonColumn();
            colBtnDespachar.Name = "colBtnDespachar";
            colBtnDespachar.Text = "Despachar";
            colBtnDespachar.UseColumnTextForButtonValue = true;
            colBtnDespachar.HeaderText = "Despachar";

            grdDetDespacho.Columns.Add(colBtnDespachar);
        }

        private void modificarColumnasDetDespacho()
        {
            foreach (DataGridViewImageColumn column in grdDetDespacho.Columns.OfType<DataGridViewImageColumn>())
            {
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            grdDetDespacho.RowTemplate.Resizable = DataGridViewTriState.True;
            grdDetDespacho.RowTemplate.Height = 100;


            for (int i = 0; i < grdDetDespacho.Columns.Count; i++)
            {
                if (grdDetDespacho.Columns[i] == grdDetDespacho.Columns["imagen"])
                {
                    grdDetDespacho.Columns[i].Width = 100;
                }
                else if (grdDetDespacho.Columns[i] == grdDetDespacho.Columns["nombre"])
                {
                    grdDetDespacho.Columns[i].Width = 130;
                }
                else if (grdDetDespacho.Columns[i] == grdDetDespacho.Columns["modelo"])
                {
                    grdDetDespacho.Columns[i].Width = 65;
                }
                else
                {
                    grdDetDespacho.Columns[i].Width = 60;
                }

            }

        }

        private void cargarDetalleDespacho()
        {

            List<Cl_Detalle_Venta> listaDetVenta = daoVenta.obtenerDetalleVenta(idVenta);
            grdDetDespacho.DataSource = listaDetVenta;
            grdDetDespacho.AutoGenerateColumns = false;
            grdDetDespacho.Columns["imagen"].DisplayIndex = 0;
            grdDetDespacho.Columns["nombre"].DisplayIndex = 1;
            grdDetDespacho.Columns["modelo"].DisplayIndex = 2;
            grdDetDespacho.Columns["cantidad"].DisplayIndex = 3;
            grdDetDespacho.Columns["estado"].DisplayIndex = 4;
            grdDetDespacho.Columns["total"].DisplayIndex = 5;

            //grdDetDespacho.Columns["imagen"].Visible = true;
            grdDetDespacho.Columns["idDetalleVenta"].Visible = false;
            grdDetDespacho.Columns["idProducto"].Visible = false;   
           // grdDetDespacho.Columns["imagen"].HeaderText = "Foto";
            //grdDetDespacho.Columns["nombre"].HeaderText = "Producto";
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            int resp = daoDespacho.despacharVenta(idDespacho, idTrabajador);
            if (resp==1)
            {
                MessageBox.Show("El Producto se despacho Correctamente");
            }
            this.Close();
        }
    }
}
