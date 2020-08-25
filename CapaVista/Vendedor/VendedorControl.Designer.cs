namespace CapaVista
{
    partial class VendedorControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendedorControl));
            this.TCVendedor = new MetroFramework.Controls.MetroTabControl();
            this.venderPage = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.rdbDescendente = new MetroFramework.Controls.MetroRadioButton();
            this.rdbAcendente = new MetroFramework.Controls.MetroRadioButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.chkPrecio = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.carritoPage = new MetroFramework.Controls.MetroTabPage();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.btnComprar = new MetroFramework.Controls.MetroButton();
            this.TotalCompra = new MetroFramework.Controls.MetroLabel();
            this.lblTotalCompra = new MetroFramework.Controls.MetroLabel();
            this.ventasPage = new MetroFramework.Controls.MetroTabPage();
            this.grdVentas = new MetroFramework.Controls.MetroGrid();
            this.detalleVentaPage = new MetroFramework.Controls.MetroTabPage();
            this.grdDetalleVenta = new MetroFramework.Controls.MetroGrid();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.menuPanel = new MetroFramework.Controls.MetroPanel();
            this.btnVentas = new MetroFramework.Controls.MetroButton();
            this.btnVender = new MetroFramework.Controls.MetroButton();
            this.TCVendedor.SuspendLayout();
            this.venderPage.SuspendLayout();
            this.carritoPage.SuspendLayout();
            this.ventasPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).BeginInit();
            this.detalleVentaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleVenta)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCVendedor
            // 
            this.TCVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TCVendedor.Controls.Add(this.venderPage);
            this.TCVendedor.Controls.Add(this.carritoPage);
            this.TCVendedor.Controls.Add(this.ventasPage);
            this.TCVendedor.Controls.Add(this.detalleVentaPage);
            this.TCVendedor.Location = new System.Drawing.Point(0, 3);
            this.TCVendedor.Name = "TCVendedor";
            this.TCVendedor.SelectedIndex = 1;
            this.TCVendedor.ShowToolTips = true;
            this.TCVendedor.Size = new System.Drawing.Size(544, 320);
            this.TCVendedor.TabIndex = 0;
            this.TCVendedor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TCVendedor.UseSelectable = true;
            // 
            // venderPage
            // 
            this.venderPage.AutoScroll = true;
            this.venderPage.Controls.Add(this.metroButton1);
            this.venderPage.Controls.Add(this.rdbDescendente);
            this.venderPage.Controls.Add(this.rdbAcendente);
            this.venderPage.Controls.Add(this.metroCheckBox1);
            this.venderPage.Controls.Add(this.chkPrecio);
            this.venderPage.Controls.Add(this.metroLabel1);
            this.venderPage.Controls.Add(this.txtBuscarProducto);
            this.venderPage.HorizontalScrollbar = true;
            this.venderPage.HorizontalScrollbarBarColor = true;
            this.venderPage.HorizontalScrollbarHighlightOnWheel = false;
            this.venderPage.HorizontalScrollbarSize = 10;
            this.venderPage.Location = new System.Drawing.Point(4, 38);
            this.venderPage.Name = "venderPage";
            this.venderPage.Size = new System.Drawing.Size(536, 278);
            this.venderPage.TabIndex = 0;
            this.venderPage.Text = "Vender";
            this.venderPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.venderPage.VerticalScrollbar = true;
            this.venderPage.VerticalScrollbarBarColor = true;
            this.venderPage.VerticalScrollbarHighlightOnWheel = true;
            this.venderPage.VerticalScrollbarSize = 5;
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroButton1.Location = new System.Drawing.Point(349, 11);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(91, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Buscar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(349, 37);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(91, 15);
            this.rdbDescendente.TabIndex = 7;
            this.rdbDescendente.Text = "Descendente";
            this.rdbDescendente.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdbDescendente.UseSelectable = true;
            this.rdbDescendente.Visible = false;
            // 
            // rdbAcendente
            // 
            this.rdbAcendente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdbAcendente.AutoSize = true;
            this.rdbAcendente.Location = new System.Drawing.Point(258, 37);
            this.rdbAcendente.Name = "rdbAcendente";
            this.rdbAcendente.Size = new System.Drawing.Size(85, 15);
            this.rdbAcendente.TabIndex = 6;
            this.rdbAcendente.Text = "Ascendente";
            this.rdbAcendente.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rdbAcendente.UseSelectable = true;
            this.rdbAcendente.Visible = false;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(138, 37);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(52, 15);
            this.metroCheckBox1.TabIndex = 5;
            this.metroCheckBox1.Text = "Stock";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.Visible = false;
            // 
            // chkPrecio
            // 
            this.chkPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkPrecio.AutoSize = true;
            this.chkPrecio.Location = new System.Drawing.Point(196, 37);
            this.chkPrecio.Name = "chkPrecio";
            this.chkPrecio.Size = new System.Drawing.Size(56, 15);
            this.chkPrecio.TabIndex = 4;
            this.chkPrecio.Text = "Precio";
            this.chkPrecio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkPrecio.UseSelectable = true;
            this.chkPrecio.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 12);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Buscar Producto";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.Visible = false;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscarProducto.Location = new System.Drawing.Point(138, 11);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(205, 20);
            this.txtBuscarProducto.TabIndex = 2;
            this.txtBuscarProducto.Visible = false;
            // 
            // carritoPage
            // 
            this.carritoPage.AutoScroll = true;
            this.carritoPage.Controls.Add(this.metroScrollBar1);
            this.carritoPage.Controls.Add(this.btnComprar);
            this.carritoPage.Controls.Add(this.TotalCompra);
            this.carritoPage.Controls.Add(this.lblTotalCompra);
            this.carritoPage.HorizontalScrollbar = true;
            this.carritoPage.HorizontalScrollbarBarColor = false;
            this.carritoPage.HorizontalScrollbarHighlightOnWheel = false;
            this.carritoPage.HorizontalScrollbarSize = 0;
            this.carritoPage.Location = new System.Drawing.Point(4, 38);
            this.carritoPage.Margin = new System.Windows.Forms.Padding(0);
            this.carritoPage.Name = "carritoPage";
            this.carritoPage.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.carritoPage.Size = new System.Drawing.Size(536, 278);
            this.carritoPage.TabIndex = 3;
            this.carritoPage.Text = "Carrito de Compras";
            this.carritoPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.carritoPage.VerticalScrollbar = true;
            this.carritoPage.VerticalScrollbarBarColor = true;
            this.carritoPage.VerticalScrollbarHighlightOnWheel = false;
            this.carritoPage.VerticalScrollbarSize = 10;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(526, -15);
            this.metroScrollBar1.Maximum = 1000;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 10;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 310);
            this.metroScrollBar1.TabIndex = 8;
            this.metroScrollBar1.UseSelectable = true;
            this.metroScrollBar1.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComprar.Location = new System.Drawing.Point(240, 255);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 2;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseSelectable = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // TotalCompra
            // 
            this.TotalCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalCompra.AutoSize = true;
            this.TotalCompra.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TotalCompra.Location = new System.Drawing.Point(346, 259);
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.Size = new System.Drawing.Size(47, 19);
            this.TotalCompra.Style = MetroFramework.MetroColorStyle.Orange;
            this.TotalCompra.TabIndex = 6;
            this.TotalCompra.Text = "Total:";
            this.TotalCompra.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TotalCompra.UseStyleColors = true;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalCompra.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCompra.Location = new System.Drawing.Point(399, 259);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(0, 0);
            this.lblTotalCompra.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lblTotalCompra.TabIndex = 7;
            this.lblTotalCompra.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTotalCompra.UseCustomForeColor = true;
            // 
            // ventasPage
            // 
            this.ventasPage.Controls.Add(this.grdVentas);
            this.ventasPage.HorizontalScrollbarBarColor = true;
            this.ventasPage.HorizontalScrollbarHighlightOnWheel = false;
            this.ventasPage.HorizontalScrollbarSize = 10;
            this.ventasPage.Location = new System.Drawing.Point(4, 38);
            this.ventasPage.Name = "ventasPage";
            this.ventasPage.Size = new System.Drawing.Size(536, 278);
            this.ventasPage.TabIndex = 2;
            this.ventasPage.Text = "Ventas";
            this.ventasPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ventasPage.VerticalScrollbarBarColor = true;
            this.ventasPage.VerticalScrollbarHighlightOnWheel = false;
            this.ventasPage.VerticalScrollbarSize = 10;
            // 
            // grdVentas
            // 
            this.grdVentas.AllowUserToResizeColumns = false;
            this.grdVentas.AllowUserToResizeRows = false;
            this.grdVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.grdVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdVentas.EnableHeadersVisualStyles = false;
            this.grdVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.grdVentas.Location = new System.Drawing.Point(16, 20);
            this.grdVentas.Name = "grdVentas";
            this.grdVentas.ReadOnly = true;
            this.grdVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVentas.Size = new System.Drawing.Size(504, 236);
            this.grdVentas.TabIndex = 2;
            this.grdVentas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.grdVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVentas_CellClick);
            // 
            // detalleVentaPage
            // 
            this.detalleVentaPage.Controls.Add(this.grdDetalleVenta);
            this.detalleVentaPage.Controls.Add(this.btnAtras);
            this.detalleVentaPage.HorizontalScrollbarBarColor = true;
            this.detalleVentaPage.HorizontalScrollbarHighlightOnWheel = false;
            this.detalleVentaPage.HorizontalScrollbarSize = 10;
            this.detalleVentaPage.Location = new System.Drawing.Point(4, 38);
            this.detalleVentaPage.Name = "detalleVentaPage";
            this.detalleVentaPage.Size = new System.Drawing.Size(536, 278);
            this.detalleVentaPage.TabIndex = 4;
            this.detalleVentaPage.Text = "Detalle Venta";
            this.detalleVentaPage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.detalleVentaPage.VerticalScrollbarBarColor = true;
            this.detalleVentaPage.VerticalScrollbarHighlightOnWheel = false;
            this.detalleVentaPage.VerticalScrollbarSize = 10;
            // 
            // grdDetalleVenta
            // 
            this.grdDetalleVenta.AllowUserToResizeRows = false;
            this.grdDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.grdDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdDetalleVenta.ColumnHeadersHeight = 20;
            this.grdDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetalleVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdDetalleVenta.EnableHeadersVisualStyles = false;
            this.grdDetalleVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDetalleVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.grdDetalleVenta.Location = new System.Drawing.Point(14, 34);
            this.grdDetalleVenta.Name = "grdDetalleVenta";
            this.grdDetalleVenta.ReadOnly = true;
            this.grdDetalleVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdDetalleVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDetalleVenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleVenta.Size = new System.Drawing.Size(506, 235);
            this.grdDetalleVenta.TabIndex = 3;
            this.grdDetalleVenta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.grdDetalleVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleVenta_CellClick);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(14, 5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnCarrito
            // 
            this.btnCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarrito.BackColor = System.Drawing.Color.Black;
            this.btnCarrito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarrito.BackgroundImage")));
            this.btnCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCarrito.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(395, 3);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(149, 37);
            this.btnCarrito.TabIndex = 4;
            this.btnCarrito.Text = "Carrito de Compras";
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.Controls.Add(this.btnVentas);
            this.menuPanel.Controls.Add(this.btnVender);
            this.menuPanel.Controls.Add(this.btnCarrito);
            this.menuPanel.HorizontalScrollbarBarColor = true;
            this.menuPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.menuPanel.HorizontalScrollbarSize = 10;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(548, 43);
            this.menuPanel.TabIndex = 5;
            this.menuPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.menuPanel.VerticalScrollbarBarColor = true;
            this.menuPanel.VerticalScrollbarHighlightOnWheel = false;
            this.menuPanel.VerticalScrollbarSize = 10;
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(117, 3);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(107, 37);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVentas.UseSelectable = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(4, 3);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(107, 37);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnVender.UseSelectable = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // VendedorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.TCVendedor);
            this.Name = "VendedorControl";
            this.Size = new System.Drawing.Size(547, 326);
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TCVendedor.ResumeLayout(false);
            this.venderPage.ResumeLayout(false);
            this.venderPage.PerformLayout();
            this.carritoPage.ResumeLayout(false);
            this.carritoPage.PerformLayout();
            this.ventasPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).EndInit();
            this.detalleVentaPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleVenta)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TCVendedor;
        private MetroFramework.Controls.MetroTabPage venderPage;
        private MetroFramework.Controls.MetroTabPage ventasPage;
        private System.Windows.Forms.Button btnCarrito;
        private MetroFramework.Controls.MetroPanel menuPanel;
        private MetroFramework.Controls.MetroButton btnVentas;
        private MetroFramework.Controls.MetroButton btnVender;
        private MetroFramework.Controls.MetroGrid grdVentas;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage detalleVentaPage;
        private MetroFramework.Controls.MetroGrid grdDetalleVenta;
        private System.Windows.Forms.Button btnAtras;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroRadioButton rdbDescendente;
        private MetroFramework.Controls.MetroRadioButton rdbAcendente;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox chkPrecio;
        private MetroFramework.Controls.MetroTabPage carritoPage;
        private MetroFramework.Controls.MetroButton btnComprar;
        private MetroFramework.Controls.MetroLabel TotalCompra;
        private MetroFramework.Controls.MetroLabel lblTotalCompra;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
    }
}
