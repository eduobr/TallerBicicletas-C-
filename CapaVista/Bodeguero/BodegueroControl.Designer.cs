namespace CapaVista.Bodeguero
{
    partial class BodegueroControl
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
            this.TCBodeguero = new MetroFramework.Controls.MetroTabControl();
            this.despacharPage = new MetroFramework.Controls.MetroTabPage();
            this.grdDespachos = new MetroFramework.Controls.MetroGrid();
            this.stockPage = new MetroFramework.Controls.MetroTabPage();
            this.comprarPage = new MetroFramework.Controls.MetroTabPage();
            this.carritoPage = new MetroFramework.Controls.MetroTabPage();
            this.lblTotalCompra = new MetroFramework.Controls.MetroLabel();
            this.btnComprar = new MetroFramework.Controls.MetroButton();
            this.TotalCompra = new MetroFramework.Controls.MetroLabel();
            this.TCBodeguero.SuspendLayout();
            this.despacharPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDespachos)).BeginInit();
            this.carritoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCBodeguero
            // 
            this.TCBodeguero.Controls.Add(this.despacharPage);
            this.TCBodeguero.Controls.Add(this.comprarPage);
            this.TCBodeguero.Controls.Add(this.stockPage);
            this.TCBodeguero.Controls.Add(this.carritoPage);
            this.TCBodeguero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCBodeguero.Location = new System.Drawing.Point(0, 0);
            this.TCBodeguero.Name = "TCBodeguero";
            this.TCBodeguero.SelectedIndex = 3;
            this.TCBodeguero.Size = new System.Drawing.Size(588, 370);
            this.TCBodeguero.TabIndex = 0;
            this.TCBodeguero.UseSelectable = true;
            // 
            // despacharPage
            // 
            this.despacharPage.AutoScroll = true;
            this.despacharPage.Controls.Add(this.grdDespachos);
            this.despacharPage.HorizontalScrollbar = true;
            this.despacharPage.HorizontalScrollbarBarColor = true;
            this.despacharPage.HorizontalScrollbarHighlightOnWheel = false;
            this.despacharPage.HorizontalScrollbarSize = 10;
            this.despacharPage.Location = new System.Drawing.Point(4, 38);
            this.despacharPage.Name = "despacharPage";
            this.despacharPage.Size = new System.Drawing.Size(580, 328);
            this.despacharPage.TabIndex = 2;
            this.despacharPage.Text = "Despachar";
            this.despacharPage.VerticalScrollbar = true;
            this.despacharPage.VerticalScrollbarBarColor = true;
            this.despacharPage.VerticalScrollbarHighlightOnWheel = false;
            this.despacharPage.VerticalScrollbarSize = 5;
            // 
            // grdDespachos
            // 
            this.grdDespachos.AllowUserToResizeColumns = false;
            this.grdDespachos.AllowUserToResizeRows = false;
            this.grdDespachos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDespachos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDespachos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDespachos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDespachos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdDespachos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDespachos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDespachos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDespachos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDespachos.EnableHeadersVisualStyles = false;
            this.grdDespachos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdDespachos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdDespachos.Location = new System.Drawing.Point(3, 3);
            this.grdDespachos.Name = "grdDespachos";
            this.grdDespachos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDespachos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdDespachos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdDespachos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDespachos.Size = new System.Drawing.Size(574, 311);
            this.grdDespachos.TabIndex = 2;
            this.grdDespachos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDespachos_CellClick);
            // 
            // stockPage
            // 
            this.stockPage.AutoScroll = true;
            this.stockPage.HorizontalScrollbar = true;
            this.stockPage.HorizontalScrollbarBarColor = true;
            this.stockPage.HorizontalScrollbarHighlightOnWheel = false;
            this.stockPage.HorizontalScrollbarSize = 10;
            this.stockPage.Location = new System.Drawing.Point(4, 38);
            this.stockPage.Name = "stockPage";
            this.stockPage.Size = new System.Drawing.Size(580, 328);
            this.stockPage.TabIndex = 1;
            this.stockPage.Text = "Revisar Stock";
            this.stockPage.VerticalScrollbar = true;
            this.stockPage.VerticalScrollbarBarColor = true;
            this.stockPage.VerticalScrollbarHighlightOnWheel = false;
            this.stockPage.VerticalScrollbarSize = 5;
            // 
            // comprarPage
            // 
            this.comprarPage.AutoScroll = true;
            this.comprarPage.HorizontalScrollbar = true;
            this.comprarPage.HorizontalScrollbarBarColor = true;
            this.comprarPage.HorizontalScrollbarHighlightOnWheel = false;
            this.comprarPage.HorizontalScrollbarSize = 10;
            this.comprarPage.Location = new System.Drawing.Point(4, 38);
            this.comprarPage.Name = "comprarPage";
            this.comprarPage.Size = new System.Drawing.Size(580, 328);
            this.comprarPage.TabIndex = 0;
            this.comprarPage.Text = "Comprar";
            this.comprarPage.VerticalScrollbar = true;
            this.comprarPage.VerticalScrollbarBarColor = true;
            this.comprarPage.VerticalScrollbarHighlightOnWheel = false;
            this.comprarPage.VerticalScrollbarSize = 5;
            // 
            // carritoPage
            // 
            this.carritoPage.AutoScroll = true;
            this.carritoPage.Controls.Add(this.lblTotalCompra);
            this.carritoPage.Controls.Add(this.btnComprar);
            this.carritoPage.Controls.Add(this.TotalCompra);
            this.carritoPage.HorizontalScrollbar = true;
            this.carritoPage.HorizontalScrollbarBarColor = true;
            this.carritoPage.HorizontalScrollbarHighlightOnWheel = false;
            this.carritoPage.HorizontalScrollbarSize = 10;
            this.carritoPage.Location = new System.Drawing.Point(4, 38);
            this.carritoPage.Name = "carritoPage";
            this.carritoPage.Size = new System.Drawing.Size(580, 328);
            this.carritoPage.TabIndex = 3;
            this.carritoPage.Text = "Carrito de Compras";
            this.carritoPage.VerticalScrollbar = true;
            this.carritoPage.VerticalScrollbarBarColor = true;
            this.carritoPage.VerticalScrollbarHighlightOnWheel = false;
            this.carritoPage.VerticalScrollbarSize = 5;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalCompra.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCompra.Location = new System.Drawing.Point(419, 309);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(0, 0);
            this.lblTotalCompra.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lblTotalCompra.TabIndex = 9;
            this.lblTotalCompra.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTotalCompra.UseCustomForeColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnComprar.Location = new System.Drawing.Point(250, 302);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseSelectable = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // TotalCompra
            // 
            this.TotalCompra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TotalCompra.AutoSize = true;
            this.TotalCompra.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TotalCompra.Location = new System.Drawing.Point(366, 309);
            this.TotalCompra.Name = "TotalCompra";
            this.TotalCompra.Size = new System.Drawing.Size(47, 19);
            this.TotalCompra.Style = MetroFramework.MetroColorStyle.Orange;
            this.TotalCompra.TabIndex = 7;
            this.TotalCompra.Text = "Total:";
            this.TotalCompra.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TotalCompra.UseStyleColors = true;
            // 
            // BodegueroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCBodeguero);
            this.Name = "BodegueroControl";
            this.Size = new System.Drawing.Size(588, 370);
            this.TCBodeguero.ResumeLayout(false);
            this.despacharPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDespachos)).EndInit();
            this.carritoPage.ResumeLayout(false);
            this.carritoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TCBodeguero;
        private MetroFramework.Controls.MetroTabPage comprarPage;
        private MetroFramework.Controls.MetroTabPage stockPage;
        private MetroFramework.Controls.MetroTabPage despacharPage;
        private MetroFramework.Controls.MetroGrid grdDespachos;
        private MetroFramework.Controls.MetroTabPage carritoPage;
        private MetroFramework.Controls.MetroLabel TotalCompra;
        private MetroFramework.Controls.MetroButton btnComprar;
        private MetroFramework.Controls.MetroLabel lblTotalCompra;
    }
}
