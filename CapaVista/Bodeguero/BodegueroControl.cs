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
using CapaLogicaNegocios;

namespace CapaVista.Bodeguero
{
    public partial class BodegueroControl : MetroUserControl
    {
        ServicioMasterBikes.ServicioClient servicio;
        Cl_Usuario bodeguero;
        List<CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto> listaCarrito=new List<CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto>();

        public BodegueroControl(Cl_Usuario bod)
        {
            InitializeComponent();
            cargarProdProv();
            cargarStock();
            cargarDespachos();
            agregarBotonesDgDespacho();
            bodeguero = bod;

        }

        private void cargarProdProv()
        {
            List<UserControl> tarjetaProvControl = new List<UserControl>();
            if (tarjetaProvControl != null)
            {
                foreach (UserControl item in this.comprarPage.Controls.OfType<UserControl>())
                {
                    //DO NOT REMOVE COMPONENT IN THIS LOOP BECAUSE
                    //YOU DECREASE THE .Controls  ARRAY AND YOU WILL HAVE AN ERROR 
                    tarjetaProvControl.Add(item);
                    //MessageBox.Show(item.Name);
                }
                foreach (UserControl item in tarjetaProvControl)
                {
                    item.Dispose();
                }
            }
            servicio = new ServicioMasterBikes.ServicioClient();
            IEnumerable<CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto> listaProd = servicio.obtenerProdProv();
            int x = 5;
            int y = 5;
            foreach (var prod in listaProd)
            {
                TarjetaProvControl tp = new TarjetaProvControl(prod,this);
                tp.Location = new Point(x, y);
                x += 185;
                if (x > 650)
                {
                    x = 5;
                    y += 260;
                }
                comprarPage.Controls.Add(tp);
            }
        }

        public void agregarCarrito(CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto prod)
        {
            bool existe = false;
            TarjetaCarritoBod tcp = new TarjetaCarritoBod(prod, this);
            //tcp.Name = "Control"+prod.nombre.ToString()+prod.idProducto.ToString();
            tcp.Dock = DockStyle.Top;


            foreach (var item in listaCarrito)
            {

                if (prod.idProducto == item.idProducto)
                {
                    existe = true;
                    MessageBox.Show("El ya se encuentra agregado");
                }
            }

            if (existe == false)
            {
                listaCarrito.Add(prod);
                carritoPage.Controls.Add(tcp);
                calcularTotalCompra();
            }
        }

        public List<CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto> obtenerListaCarrito()
        {
            if (listaCarrito == null)
            {
                listaCarrito = new List<CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto>();
            }
            return listaCarrito;
        }

        public void modificarListaCarrito(List<CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto> lista)
        {
            listaCarrito = lista;
            calcularTotalCompra();
        }

        public void vaciarCarrito()
        {
            List<UserControl> carritoControl = new List<UserControl>();
            foreach (UserControl item in this.carritoPage.Controls.OfType<UserControl>())
            {
                //DO NOT REMOVE COMPONENT IN THIS LOOP BECAUSE
                //YOU DECREASE THE .Controls  ARRAY AND YOU WILL HAVE AN ERROR 
                carritoControl.Add(item);
                //MessageBox.Show(item.Name);
            }
            foreach (UserControl item in carritoControl)
            {
                item.Dispose();
            }
            listaCarrito = new List<CapaLogicaNegocios.ServicioMasterBikes.Cl_Producto>();
            lblTotalCompra.Text = "$0";
            //MessageBox.Show(carritoPage.Controls.Count.ToString());
            //carritoPage.Dispose();
        }

        public void calcularTotalCompra()
        {
            int total = 0;
            foreach (var item in listaCarrito)
            {

                total += item.precio * item.cantidad;
            }
            lblTotalCompra.Text = "$" + total.ToString();
        }

        private void agregarBotonesDgDespacho()
        {
            DataGridViewDisableButtonColumn colBtnDetalle = new DataGridViewDisableButtonColumn();
            colBtnDetalle.Name = "colBtnDetalle";
            colBtnDetalle.Text = "Ver Detalle";
            colBtnDetalle.UseColumnTextForButtonValue = true;
            colBtnDetalle.HeaderText = "";

            grdDespachos.Columns.Add(colBtnDetalle);
        }

        private void cargarDespachos()
        {
            DaoDespacho daoDespacho = new DaoDespacho();
            grdDespachos.DataSource = daoDespacho.obtenerDespacho();
            grdDespachos.Columns["idDespacho"].Visible = false;
            grdDespachos.Columns["idVenta"].Visible = false;
        }

        private void cargarStock()
        {
            
            List<UserControl> tarjetaProdControl = new List<UserControl>();
            if (tarjetaProdControl != null)
            {
                foreach (UserControl item in this.stockPage.Controls.OfType<UserControl>())
                {
                    //DO NOT REMOVE COMPONENT IN THIS LOOP BECAUSE
                    //YOU DECREASE THE .Controls  ARRAY AND YOU WILL HAVE AN ERROR 
                    tarjetaProdControl.Add(item);
                    //MessageBox.Show(item.Name);
                }
                foreach (UserControl item in tarjetaProdControl)
                {
                    item.Dispose();
                }
            }
            DaoProducto daoProducto=new DaoProducto();
            List<Cl_Producto> listaProd = daoProducto.listarProductos();
            int x = 5;
            int y = 50;
            foreach (var prod in listaProd)
            {
                TarjetaProdControl tp = new TarjetaProdControl(prod);
                tp.Location = new Point(x, y);
                x += 175;
                if (x > 650)
                {
                    x = 5;
                    y += 230;
                }
                stockPage.Controls.Add(tp);
            }
        }

        private void grdDespachos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (this.grdDespachos.Columns[e.ColumnIndex].Name == "colBtnDetalle")
                {
                    int idVenta = Convert.ToInt32(this.grdDespachos.Rows[e.RowIndex].Cells["idVenta"].Value);
                    int idDespacho = Convert.ToInt32(this.grdDespachos.Rows[e.RowIndex].Cells["idDespacho"].Value);
                    FormDespacharVenta despachar = new FormDespacharVenta(idVenta,idDespacho,bodeguero.idTrabajador);
                    despachar.ShowDialog();
                    cargarDespachos();
                }
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("El total de la compra es: " + lblTotalCompra.Text + "\n¿Esta seguro que desea continuar?", "Confirmar Compra", MessageBoxButtons.OKCancel);
            if (respuesta == DialogResult.Cancel)
            {
                return;
            }
            int total = 0;
            DaoCompra daoCompra = new DaoCompra();
            //int resp = daoCompra.insertarCompra(1, total,bodeguero.idTrabajador);
            foreach (var item in listaCarrito)
            {
                if (item.cantidad > item.stock)
                {
                    MessageBox.Show("La cantidad del producto: " + item.nombre + " super al stock");
                    return;
                }
                total += (item.precio * item.cantidad) - ((item.precio * item.cantidad) * (item.descuento / 100));
            }
            int resp = daoCompra.insertarProdCompra(listaCarrito, bodeguero.idTrabajador,total);
            if (resp==1)
            {
                MessageBox.Show("Se inserto la compra correctamente");
            }

        }
    }
}
