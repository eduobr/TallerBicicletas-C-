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
using CapaVista.Vendedor;
using System.IO;
using CapaLogicaNegocios;
using CapaAccesoDatos;

namespace CapaVista
{
    public partial class VendedorControl : MetroUserControl
    {
        //ServicioMasterBikes.ServicioClient servicio;
        List<Cl_Producto> listaCarrito = new List<Cl_Producto>();
        Cl_Usuario vendedor;
        DaoProducto daoProducto;
        DaoVenta daoVenta;
        public int idVentaDetalleVenta;

        public VendedorControl()
        {
            InitializeComponent();
            daoProducto =  new DaoProducto();
            daoVenta = new DaoVenta();
            cargarProductos();
            cargarVentas();
            agregarBotonesDgVenta();
            agregarBotonesDgDetalleVenta();
        }
        public VendedorControl(Cl_Usuario vend)
        {
            InitializeComponent();
            daoProducto = new DaoProducto();
            daoVenta = new DaoVenta();
            vendedor = vend;
            cargarProductos();
            cargarVentas();
            agregarBotonesDgVenta();
            agregarBotonesDgDetalleVenta();
            TCVendedor.SelectedTab = venderPage;
        }

        public void cargarProductos()
        {
            List<UserControl> tarjetaProdControl = new List<UserControl>();
            if (tarjetaProdControl!=null)
            {
                foreach (UserControl item in this.venderPage.Controls.OfType<UserControl>())
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
            //servicio = new ServicioClient();
            List<Cl_Producto> listaProd = daoProducto.listarProductos();
            int x = 5;
            int y = 50;
            foreach (var prod in listaProd)
            {
                TarjetaProdControl tp = new TarjetaProdControl(this, prod);
                tp.Location = new Point(x, y);
                x += 175;
                if (x > 650)
                {
                    x = 5;
                    y += 230;
                }
                venderPage.Controls.Add(tp);
            }
        }

        public void agregarBotonesDgDetalleVenta()
        {
            //agregar botones al iniciar el programa
            //crear boton imagen
            DataGridViewImageColumn colImagen = new DataGridViewImageColumn();
            colImagen.Name = "colImagen";
            colImagen.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //crear boton cambiar
            DataGridViewDisableButtonColumn colBtnCambiar = new DataGridViewDisableButtonColumn();
            colBtnCambiar.Name = "colBtnCambiar";
            colBtnCambiar.Text = "Cambiar";
            colBtnCambiar.UseColumnTextForButtonValue = true;
            colBtnCambiar.HeaderText = "";

            DataGridViewDisableButtonColumn colBtnAnular = new DataGridViewDisableButtonColumn();
            colBtnAnular.Name = "colBtnAnular";
            colBtnAnular.Text = "Anular";
            colBtnAnular.UseColumnTextForButtonValue = true;
            colBtnAnular.HeaderText = "";

            //agregar boton imagen
            grdDetalleVenta.Columns.Add(colImagen);

            //agregar boton cambiar
            grdDetalleVenta.Columns.Add(colBtnCambiar);

            //agregar boton modificar
            grdDetalleVenta.Columns.Add(colBtnAnular);

            
            
        }

        //agrega los botones editar venta y anular venta al data grid Venta
        public void agregarBotonesDgVenta()
        {
            DataGridViewButtonColumn colBtnAnular = new DataGridViewButtonColumn();
            colBtnAnular.Name = "colBtnAnular";
            colBtnAnular.HeaderText = "Anular Venta";
            colBtnAnular.Text = "Anular";
            colBtnAnular.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn colBtnDetalle = new DataGridViewButtonColumn();
            colBtnDetalle.Name = "colBtnDetalle";
            colBtnDetalle.HeaderText = "Ver Detalle";
            colBtnDetalle.Text = "Ver Detalle";
            colBtnDetalle.UseColumnTextForButtonValue = true;

            grdVentas.Columns.Add(colBtnAnular);
            colBtnAnular.FlatStyle = FlatStyle.Flat;
            grdVentas.Columns["colBtnAnular"].DisplayIndex = 8;

            grdVentas.Columns.Add(colBtnDetalle);
            colBtnDetalle.FlatStyle = FlatStyle.Flat;
            grdVentas.Columns["colBtnDetalle"].DisplayIndex = 9;
        }

        public void cargarVentas()
        {
            //por cada vez que se carga las ventas se agregan controles 

            List<Cl_Venta> listaVentas=daoVenta.obtenerVentas();
            grdVentas.DataSource = listaVentas;
            grdVentas.AutoGenerateColumns = false;
            grdVentas.Columns["idVenta"].DisplayIndex = 0;
            grdVentas.Columns["nombreCompleto"].DisplayIndex = 1;
            grdVentas.Columns["fecha"].DisplayIndex = 2;
            
            grdVentas.Columns["estado"].DisplayIndex = 3;
            grdVentas.Columns["cantidad"].DisplayIndex = 4;
            grdVentas.Columns["total"].DisplayIndex = 5;
            grdVentas.Columns["idCliente"].DisplayIndex = 6;
            grdVentas.Columns["idTrabajador"].DisplayIndex = 7;
            

            grdVentas.Columns["idCliente"].Visible = false;
            grdVentas.Columns["idTrabajador"].Visible = false;
            grdVentas.Columns["tipoPago"].Visible = false;
        }

        //Eliminar desde el Designer
        /*private void metroButton1_Click(object sender, EventArgs e)*/
        

        public void agregarCarrito(Cl_Producto prod)
        {
            bool existe = false;
            TarjetaCarritoProdControl tcp = new TarjetaCarritoProdControl(prod,this);
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

            if (existe==false)
            {
                listaCarrito.Add(prod);
                carritoPage.Controls.Add(tcp);
                calcularTotalCompra();
            }
        }

        public List<Cl_Producto> obtenerListaCarrito()
        {
            if (listaCarrito==null)
            {
                listaCarrito = new List<Cl_Producto>();
            }
            return listaCarrito;
        }

        public void modificarListaCarrito(List<Cl_Producto>lista)
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
            listaCarrito = new List<Cl_Producto>();
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
            lblTotalCompra.Text = "$"+total.ToString();
        }
    

    /*private void metroButton2_Click(object sender, EventArgs e)*/
    

    private void btnVender_Click(object sender, EventArgs e)
    {
        TCVendedor.SelectedTab = venderPage;
            cargarProductos();
    }

    private void btnVentas_Click(object sender, EventArgs e)
    {
        TCVendedor.SelectedTab = ventasPage;
            cargarVentas();
        }

    private void btnCarrito_Click(object sender, EventArgs e)
    {
        TCVendedor.SelectedTab = carritoPage;
    }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            
            if (listaCarrito.Count>0)
            {
                DialogResult respuesta = MessageBox.Show("El total de la compra es: "+lblTotalCompra.Text+"\n¿Esta seguro que desea continuar?","Confirmar Compra", MessageBoxButtons.OKCancel);
                if (respuesta==DialogResult.Cancel)
                {
                    return;
                }
                int total = 0;
                foreach (var item in listaCarrito)
                {
                    if (item.cantidad>item.stock)
                    {
                        MessageBox.Show("La cantidad del producto: "+item.nombre +" super al stock");
                        return;
                    }
                    total += (item.precio * item.cantidad) - ((item.precio *item.cantidad)*(item.descuento/100));
                }
                FormularioCompra compra = new FormularioCompra(listaCarrito,vendedor,total,this); 
                compra.ShowDialog();
            }else
            {
                MessageBox.Show("Debe almenos haber agregado un producto al carrito");
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            TCVendedor.SelectedTab = ventasPage;
            cargarVentas();
        }

        private void grdVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex>=0 && e.RowIndex>=0)
            {
                string estado = grdVentas.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                    
                if (this.grdVentas.Columns[e.ColumnIndex].Name == "colBtnDetalle")
                {
                    int idVenta = Convert.ToInt32(this.grdVentas.Rows[e.RowIndex].Cells["idVenta"].Value);
                    idVentaDetalleVenta = idVenta;
                    cargarDetalleVenta(idVentaDetalleVenta);
                }
                if (this.grdVentas.Columns[e.ColumnIndex].Name == "colBtnAnular" && estado != "Anulado")
                {
                    int idVenta = Convert.ToInt32(this.grdVentas.Rows[e.RowIndex].Cells["idVenta"].Value);
                    
                    int resp = daoVenta.anularVenta(idVenta);
                    if (resp==1)
                    {
                        MessageBox.Show("La venta se anulo correctamente");
                    }else
                    {
                        MessageBox.Show("No se pudo anular la venta");
                    }
                    
                    //guardar la celda selecciona y luego de cargar las ventas setearla
                    
                    cargarVentas();
                }
            }
        }

        public void cargarDetalleVenta(int idVenta)
        {
            List<Cl_Detalle_Venta> listaDetVenta = daoVenta.obtenerDetalleVenta(idVenta);

            TCVendedor.SelectedTab = detalleVentaPage;

            grdDetalleVenta.RowTemplate.Resizable = DataGridViewTriState.True;
            grdDetalleVenta.RowTemplate.Height = 100;
            grdDetalleVenta.DataSource = listaDetVenta;

            grdDetalleVenta.Columns["imagen"].Visible = false;
            for (int i = 0; i < grdDetalleVenta.Columns.Count; i++)
            {
                if (grdDetalleVenta.Columns[i] == grdDetalleVenta.Columns["colImagen"])
                {
                    grdDetalleVenta.Columns[i].Width = 100;
                }
                else if (grdDetalleVenta.Columns[i] == grdDetalleVenta.Columns["nombre"])
                {
                    grdDetalleVenta.Columns[i].Width = 130;
                }
                else if (grdDetalleVenta.Columns[i] == grdDetalleVenta.Columns["modelo"])
                {
                    grdDetalleVenta.Columns[i].Width = 65;
                }
                else
                {
                    grdDetalleVenta.Columns[i].Width = 60;
                }

            }

            for (int i = 0; i < grdDetalleVenta.RowCount; i++)
            {
                grdDetalleVenta.Rows[i].Cells["colImagen"].Value = ByteToImage(listaDetVenta.ElementAt(i).imagen);
            }

            grdDetalleVenta.Columns["idDetalleVenta"].Visible = false;
            grdDetalleVenta.Columns["idProducto"].Visible = false;

            grdDetalleVenta.Columns["colImagen"].DisplayIndex = 0;
            grdDetalleVenta.Columns["nombre"].DisplayIndex = 1;
            grdDetalleVenta.Columns["modelo"].DisplayIndex = 2;
            grdDetalleVenta.Columns["cantidad"].DisplayIndex = 3;
            grdDetalleVenta.Columns["estado"].DisplayIndex = 4;
            grdDetalleVenta.Columns["total"].DisplayIndex = 5;

            grdDetalleVenta.Columns["colImagen"].HeaderText = "Foto";
            grdDetalleVenta.Columns["nombre"].HeaderText = "Producto";

            foreach (DataGridViewRow row in grdDetalleVenta.Rows)
            {
                if (row.Cells["estado"].Value.ToString() == "Anulado")
                {
                    ((DataGridViewDisableButtonCell)row.Cells["colBtnCambiar"]).Enabled=false;
                    ((DataGridViewDisableButtonCell)row.Cells["colBtnAnular"]).Enabled = false;
                }
            }


        }

        

        private void grdDetalleVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex>=0 && e.RowIndex>=0)
            {
                Boolean modificado = false;
                string estado = grdDetalleVenta.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                int idDetalleVenta = Convert.ToInt32(this.grdDetalleVenta.Rows[e.RowIndex].Cells["idDetalleVenta"].Value);
                int idProducto = Convert.ToInt32(this.grdDetalleVenta.Rows[e.RowIndex].Cells["idProducto"].Value);

                if (grdDetalleVenta.Columns[e.ColumnIndex].Name=="colBtnAnular" && estado!="Anulado")
                {
                    int resp = daoVenta.modificarDetalleVenta(idProducto,idDetalleVenta,7);

                    if (resp==1)
                    {
                        MessageBox.Show("Se anulo la venta del producto");
                        modificado = true;
                    }
                }
                if (grdDetalleVenta.Columns[e.ColumnIndex].Name == "colBtnCambiar")
                {
                    //string estado = grdDetalleVenta.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                    if (estado == "En Espera" || estado=="Pagado" || estado=="Nuevo")
                    {
                        FormCambiarProducto cambiarProd = new FormCambiarProducto(idProducto,idDetalleVenta,this.idVentaDetalleVenta,this,vendedor.idTrabajador);
                        cambiarProd.ShowDialog();
                        modificado = true;
                    }
                }
                if (modificado==true)
                {
                    cargarDetalleVenta(idVentaDetalleVenta);
                }
            }
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
