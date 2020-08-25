
//using CapaVista.ServicioMasterBikes;
using CapaAccesoDatos;
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
    public partial class FormularioCompra : MetroForm
    {
        //ServicioMasterBikes.ServicioClient servicio_cliente;
        List<Cl_Producto> listaCarrito;
        Cl_Usuario vendedor;
        VendedorControl vendControl;
        DaoCliente daoCliente;
        DaoVenta daoVenta;
        int totalVenta;
        public FormularioCompra()
        {
            InitializeComponent();
            daoCliente = new DaoCliente();
            daoVenta = new DaoVenta();
            cargarComunas();
            cboTipoDespacho.Items.Add("Domicilio");
            cboTipoDespacho.Items.Add("Tienda");
            cboTipoPago.Items.Add("Efectivo");
            cboTipoPago.Items.Add("Credito");
            cboTipoPago.Items.Add("Debito");
        }

        public FormularioCompra(List<Cl_Producto> carrito,Cl_Usuario vend,int total,VendedorControl vc)
        {
            InitializeComponent();
            daoCliente = new DaoCliente();
            daoVenta = new DaoVenta();
            listaCarrito = carrito;
            vendedor = vend;
            vendControl = vc;
            totalVenta = total;
            cboTipoDespacho.Items.Add("Domicilio");
            cboTipoDespacho.Items.Add("Tienda");
            cboTipoPago.Items.Add("Efectivo");
            cboTipoPago.Items.Add("Credito");
            cboTipoPago.Items.Add("Debito");
            cargarComunas();
        }

        public void cargarComunas()
        {
            //servicio_cliente = new ServicioClient();
            
            List<string> listaComunas = daoCliente.obtenerComunas();
            foreach (var comuna in listaComunas)
            {
                cboComuna.Items.Add(comuna.ToString());
            }
            cboComuna.SelectedIndex = 0;
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            /*string rut = txtRut.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string direccion = txtDireccion.Text;
            string comuna = cboComuna.SelectedItem.ToString();*/
            Cl_Persona cliente = new Cl_Persona();
            if (!validarRut(txtRut.Text.ToString()))
            {
                MessageBox.Show("Ingrese un RUT Valido");
                return;
            }else
            {
                cliente.rut = txtRut.Text;
            }
            
            if (txtNombre.Text.ToString().Length<3)
            {
                MessageBox.Show("Ingrese un nombre con al menos 3 caracteres");
                return;
            }else
            {
                cliente.nombre = txtNombre.Text;
            }
            
            if (txtApellido.Text.ToString().Length<3)
            {
                MessageBox.Show("Ingrese un apellido con al menos 3 caracteres");
                return;
            }else
            {
                cliente.apellido = txtApellido.Text;
            }
            if (txtEdad.Text.ToString().Equals(""))
            {
                MessageBox.Show("Ingrese una Edad");
                return;
            }else
            {
                int edad = Convert.ToInt32(txtEdad.Text);
                if (edad>=18 && edad<=80)
                {
                    cliente.edad = Convert.ToInt32(txtEdad.Text);
                }else
                {
                    MessageBox.Show("Ingrese una edad valida");
                    return;
                }
                
            }
            if (txtDireccion.Text.ToString().Length>3)
            {
                cliente.direccion = txtDireccion.Text;
            }else
            {
                MessageBox.Show("Ingrese una direccion valida");
                return;
            }
            
            cliente.correo = txtCorreo.Text;
            cliente.comuna = cboComuna.SelectedItem.ToString();
            int despacho = 0;
            int tipoPago = 0;
            //servicio_cliente = new ServicioClient();
            if (cboTipoDespacho.SelectedItem != null)
            {
                if (cboTipoDespacho.SelectedItem.ToString().Equals("Domicilio"))
                {
                    despacho = 1;
                }else if (cboTipoDespacho.SelectedItem.ToString().Equals("Tienda"))
                {
                    despacho = 2;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de despacho");
                return;
            }
            if (cboTipoPago.SelectedItem!=null)
            {
                if (cboTipoPago.SelectedItem.ToString().Equals("Efectivo"))
                {
                    tipoPago = 1;
                }
                if (cboTipoPago.SelectedItem.ToString().Equals("Credito"))
                {
                    tipoPago = 2;
                }
                if (cboTipoPago.SelectedItem.ToString().Equals("Debito"))
                {
                    tipoPago = 3;
                }
            }else
            {
                MessageBox.Show("Seleccione un tipo de Pago");
                return;
            }

            int idVenta=daoVenta.insertarVenta(cliente,vendedor,totalVenta,despacho,tipoPago);
            foreach (var item in listaCarrito)
            {
                int totalProd = (item.precio * item.cantidad)-((item.cantidad*item.precio)*(item.descuento/100));
                int resp=daoVenta.insertarDetalleVenta(idVenta,item.cantidad,totalProd,item.idProducto);
                if (resp!=1)
                {
                    MessageBox.Show("No se pudo insertar el detalle de la venta");
                    return;
                }
            }
            MessageBox.Show("La venta fue ingresada correctamente");
            vendControl.vaciarCarrito();
            vendControl.cargarProductos();
            this.Close();
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            //servicio_cliente = new ServicioClient();
            Cl_Persona cliente = daoCliente.obtenerCliente(txtRut.Text);
            if (cliente.rut!=null)
            {
                txtNombre.Text = cliente.nombre;
                txtApellido.Text = cliente.apellido;
                txtEdad.Text = cliente.edad.ToString();
                txtDireccion.Text = cliente.direccion;
                txtCorreo.Text = cliente.correo;
                cboComuna.SelectedItem = cliente.comuna;
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtEdad.Enabled = false;
                txtDireccion.Enabled = false;
                txtCorreo.Enabled = false;
                cboComuna.Enabled = false;
            }
            else
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
                txtDireccion.Text = "";
                txtCorreo.Text = "";
                cboComuna.SelectedIndex=0;

                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtEdad.Enabled = true;
                txtDireccion.Enabled = true;
                txtCorreo.Enabled = true;
                cboComuna.Enabled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }
    }
}
