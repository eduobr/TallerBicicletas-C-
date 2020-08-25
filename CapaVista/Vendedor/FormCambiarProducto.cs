using CapaAccesoDatos;
using CapaLogicaNegocios;
//using CapaVista.ServicioMasterBikes;
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

namespace CapaVista.Vendedor
{
    public partial class FormCambiarProducto : MetroForm
    {
        //ServicioMasterBikes.ServicioClient servicio;
        DaoProducto daoProducto;
        List<Cl_Producto> listaProductos;
        int idProductoAntiguo;
        int idVenta;
        int idDetalleVenta;
        VendedorControl vendControl;
        int idTrabajador;
        public FormCambiarProducto(int idProd, int idDet, int idVen,VendedorControl vc,int idTrab)
        {
            InitializeComponent();
            //servicio = new ServicioClient();
            daoProducto = new DaoProducto();
            listaProductos = daoProducto.listarProductos();
            agregarColumnasCambiarProd();
            cargarProductos();
            modificarColumnas();
            idProductoAntiguo = idProd;
            idDetalleVenta = idDet;
            idVenta = idVen;
            vendControl = vc;
            idTrabajador = idTrab;
        }

        private void modificarColumnas()
        {
            foreach (DataGridViewImageColumn column in dgCambiarProd.Columns.OfType<DataGridViewImageColumn>())
            {
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }

            dgCambiarProd.RowTemplate.Resizable = DataGridViewTriState.True;
            dgCambiarProd.RowTemplate.Height = 100;

            for (int i = 0; i < dgCambiarProd.Columns.Count; i++)
            {
                if (dgCambiarProd.Columns[i] == dgCambiarProd.Columns["imagen"])
                {
                    dgCambiarProd.Columns[i].Width = 100;
                }
                else if (dgCambiarProd.Columns[i] == dgCambiarProd.Columns["nombre"])
                {
                    dgCambiarProd.Columns[i].Width = 100;
                }
                else if (dgCambiarProd.Columns[i] == dgCambiarProd.Columns["descripcion"])
                {
                    dgCambiarProd.Columns[i].Width = 150;
                }
                else if (dgCambiarProd.Columns[i] == dgCambiarProd.Columns["modelo"])
                {
                    dgCambiarProd.Columns[i].Width = 65;
                }
                else
                {
                    dgCambiarProd.Columns[i].Width = 60;
                }
            }

            /*for (int i = 0; i < dgCambiarProd.Columns.Count; i++)
            {
                if (dgCambiarProd.Columns[i].Name=="colCboCantidad")
                {
                    dgCambiarProd.Columns["colCboCantidad"].ReadOnly = false;
                }else
                {
                    dgCambiarProd.Columns[i].ReadOnly = true;
                }
            }*/

            for (int i = 0; i < dgCambiarProd.Columns.Count; i++)
            {
                if (dgCambiarProd.Columns[i].Name == "colTxtCantidad")
                {
                    dgCambiarProd.Columns["colTxtCantidad"].ReadOnly = false;
                }
                else
                {
                    dgCambiarProd.Columns[i].ReadOnly = true;
                }
            }
        }

        private void agregarColumnasCambiarProd()
        {
            DataGridViewDisableButtonColumn colBtnCambiar = new DataGridViewDisableButtonColumn();
            colBtnCambiar.Name = "colBtnCambiar";
            colBtnCambiar.Text = "Cambiar";
            colBtnCambiar.UseColumnTextForButtonValue = true;
            colBtnCambiar.HeaderText = "";


            /*DataGridViewComboBoxColumn colCboCantidad = new DataGridViewComboBoxColumn();
            colCboCantidad.Name = "colCboCantidad";
            colCboCantidad.MaxDropDownItems = 10;
            colCboCantidad.DataSource = null;
            int numero = 0;
            colCboCantidad.ValueType = numero.GetType();
            for (int i = 1; i <= 20; i++)
            {
                colCboCantidad.Items.Add(i);
            }
            colCboCantidad.DataPropertyName="colCboCantidad";*/

            DataGridViewTextBoxColumn colTxtCantidad = new DataGridViewTextBoxColumn();
            colTxtCantidad.Name = "colTxtCantidad";
            colTxtCantidad.HeaderText = "Cantidad";


            dgCambiarProd.Columns.Add(colBtnCambiar);
            //dgCambiarProd.Columns.Add(colCboCantidad);
            dgCambiarProd.Columns.Add(colTxtCantidad);


        }

        public void cargarProductos()
        {
            dgCambiarProd.DataSource = listaProductos;

            dgCambiarProd.Columns["rutaFoto"].Visible = false;
            dgCambiarProd.Columns["idProducto"].Visible = false;
            dgCambiarProd.Columns["cantidad"].Visible = false;
            dgCambiarProd.Columns["aro"].Visible = false;
            dgCambiarProd.Columns["idProveedor"].Visible = false;

            dgCambiarProd.AutoGenerateColumns = false;
            dgCambiarProd.Columns["imagen"].DisplayIndex = 0;
            dgCambiarProd.Columns["nombre"].DisplayIndex = 1;
            dgCambiarProd.Columns["modelo"].DisplayIndex = 2;
            dgCambiarProd.Columns["descripcion"].DisplayIndex = 3;
            dgCambiarProd.Columns["stock"].DisplayIndex = 4;
            dgCambiarProd.Columns["precio"].DisplayIndex = 5;
            dgCambiarProd.Columns["descuento"].DisplayIndex = 6;
            dgCambiarProd.Columns["colTxtCantidad"].DisplayIndex = 7;
            //dgCambiarProd.Columns["colCboCantidad"].DisplayIndex = 7;
            dgCambiarProd.Columns["colBtnCambiar"].DisplayIndex = 8;




            /*dgCambiarProd.Columns["colImagen"].HeaderText = "Foto";
            dgCambiarProd.Columns["nombre"].HeaderText = "Producto";*/
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

        private void dgCambiarProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                if (dgCambiarProd.Columns[e.ColumnIndex].Name == "colBtnCambiar")
                {
                    if (this.dgCambiarProd.Rows[e.RowIndex].Cells["colTxtCantidad"].Value == null)
                    {
                        foreach (DataGridViewRow row in dgCambiarProd.Rows)
                        {
                            if (row.Cells["colTxtCantidad"] != this.dgCambiarProd.Rows[e.RowIndex].Cells["colTxtCantidad"])
                            {
                                row.Cells["colTxtCantidad"].Value = null;
                            }
                        }
                        MessageBox.Show("Ingrese una Cantidad");
                    }
                    else
                    {
                        int idProductoNuevo = Convert.ToInt32(this.dgCambiarProd.Rows[e.RowIndex].Cells["idProducto"].Value);
                        int cantidad = Convert.ToInt32(this.dgCambiarProd.Rows[e.RowIndex].Cells["colTxtCantidad"].Value);
                        int precio = Convert.ToInt32(this.dgCambiarProd.Rows[e.RowIndex].Cells["precio"].Value);
                        int total = cantidad * precio;
                        MessageBox.Show(total.ToString());
                        FormMotivoCambiarProd motivo = new FormMotivoCambiarProd(this.idDetalleVenta, cantidad, this.idVenta, idProductoNuevo, this.idProductoAntiguo, total, idTrabajador, this);
                        motivo.ShowDialog();
                        /*int resp = servicio.cambiarProducto(this.idDetalleVenta,cantidad, this.idVenta, idProductoNuevo, this.idProductoAntiguo,total);
                        if (resp==1)
                        {
                            MessageBox.Show("El producto se cambio correctamente");
                            vendControl.cargarDetalleVenta(idVenta);
                            this.Close();
                            this.Dispose();
                        }else
                        {
                            MessageBox.Show("El producto no se pudo cambiar");
                        }*/
                        vendControl.cargarDetalleVenta(idVenta);

                    }
                }
                foreach (DataGridViewRow row in dgCambiarProd.Rows)
                {
                    if (row.Cells["colTxtCantidad"] != this.dgCambiarProd.Rows[e.RowIndex].Cells["colTxtCantidad"])
                    {
                        row.Cells["colTxtCantidad"].Value = null;
                    }
                }

            }
        }
    }
}
