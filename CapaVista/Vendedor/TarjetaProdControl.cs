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
//using CapaVista.ServicioMasterBikes;
using System.IO;
using CapaAccesoDatos;

namespace CapaVista
{
    public partial class TarjetaProdControl : MetroUserControl
    {
        VendedorControl vendcontrol;
        Cl_Producto producto;
        //ServicioMasterBikes.ServicioClient servicio_imagen;
        public TarjetaProdControl(VendedorControl vc,Cl_Producto prod)
        {
            //servicio_imagen = new ServicioClient();
            InitializeComponent();
            vendcontrol = vc;
            producto = prod;
            llenarTarjeta();
        }


        private void llenarTarjeta()
        {
            lblNombreProd.Text = this.producto.nombre;
            lblModelo.Text = this.producto.modelo;
            lblPrecio.Text = "$"+this.producto.precio.ToString();
            lblStock.Text = this.producto.stock.ToString();
            //byte[] imagen = servicio_imagen.ImgToByteArray(this.producto.rutaFoto);
            picFoto.Image = ByteToImage(this.producto.imagen);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public int obtenerDatos() {
            return 1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //TarjetaCarritoProdControl tcp = new TarjetaCarritoProdControl(this.producto);
            vendcontrol.agregarCarrito(this.producto);
        }

        //Convertir el byte de imagen a una Bitmap para el picture box
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
