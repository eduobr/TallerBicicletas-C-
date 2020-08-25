using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista.ServicioMasterBikes;
using System.IO;
using CapaLogicaNegocios.ServicioMasterBikes;

namespace CapaVista.Bodeguero
{
    public partial class TarjetaProvControl : UserControl
    {
        CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto producto;
        ServicioMasterBikes.ServicioClient servicio;
        BodegueroControl bodControl;
        public TarjetaProvControl()
        {
            InitializeComponent();
        }

        public TarjetaProvControl(CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto prod,BodegueroControl bc)
        {
            InitializeComponent();
            producto = prod;
            llenarTarjeta();
            bodControl = bc;
        }

        private void llenarTarjeta()
        {
            servicio = new ServicioMasterBikes.ServicioClient();
            lblNombreProd.Text = this.producto.nombre;
            lblModelo.Text = this.producto.modelo;
            lblStock.Text = this.producto.stock.ToString();
            byte[] imagen = this.producto.imagen;
            picFoto.Image = ByteToImage(imagen);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            lblProveedor.Text = this.producto.proveedor;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //TarjetaCarritoProdControl tcp = new TarjetaCarritoProdControl(this.producto);
            bodControl.agregarCarrito(this.producto);
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
    }
}
