using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using CapaAccesoDatos;
using System.IO;

namespace CapaVista.Bodeguero
{
    public partial class TarjetaProdControl : MetroUserControl
    {
        Cl_Producto producto;
        ServicioMasterBikes.ServicioClient servicio;
        public TarjetaProdControl()
        {
            InitializeComponent();
        }

        public TarjetaProdControl(Cl_Producto prod)
        {
            InitializeComponent();
            producto = prod;
            llenarTarjeta();
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
