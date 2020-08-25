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
    public partial class TarjetaCarritoProdControl : MetroUserControl
    {
        Cl_Producto producto;
        VendedorControl vendControl;
        //ServicioMasterBikes.ServicioClient servicio_imagen;
        public TarjetaCarritoProdControl(Cl_Producto prod, VendedorControl vc)
        {
            //servicio_imagen = new ServicioClient();
            InitializeComponent();
            lblNombreProd.Text = prod.nombre;
            lblModelo.Text = prod.modelo;
            lblDescripcion.Text = prod.descripcion;
            lblPrecio.Text = prod.precio.ToString();
            txtCantidad.Text = Convert.ToString(1);
            prod.cantidad = Convert.ToInt32(txtCantidad.Text);
            lblTotal.Text = "$"+prod.precio.ToString();
            //byte[] imagen = servicio_imagen.ImgToByteArray(prod.rutaFoto);
            picFoto.Image = ByteToImage(prod.imagen);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            producto = prod;
            vendControl = vc;
            
            //idCarrito = id;
        }

        private void btnEliminarVend_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(this.producto.idProducto.ToString());
            List<Cl_Producto> lista= vendControl.obtenerListaCarrito();
            lista.Remove(this.producto);
            vendControl.modificarListaCarrito(lista);
            this.Parent.Controls.Remove(this);
           
            //vendedorControl.eliminarCarrito(this.producto);
            //MessageBox.Show(this.idCarrito.ToString());
        }

        private void txtCantVend_Leave(object sender, EventArgs e)
        {
            List<Cl_Producto> lista = vendControl.obtenerListaCarrito();
            if (this.txtCantidad.Text=="" || this.txtCantidad.Text=="0")
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a 0");
                this.txtCantidad.Focus();
                return;
            }

            foreach (var item in lista)
            {
                if (item.idProducto == this.producto.idProducto)
                {
                    item.cantidad = Convert.ToInt32(this.txtCantidad.Text);
                }
            }
            vendControl.modificarListaCarrito(lista);
        }

        private void txtCantidadVend_KeyUp(object sender, KeyEventArgs e)
        {
            string cantidad = this.txtCantidad.Text;
            if (cantidad=="")
            {
                cantidad = Convert.ToString(0);
            }
            lblTotal.Text = "$"+Convert.ToString(this.producto.precio * Convert.ToInt32(cantidad));
        }

        //Para que el txtCantidad no acepte numeros o texto
        private void txtCantidadVend_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
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
