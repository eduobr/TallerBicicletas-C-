namespace CapaVista.Cajero
{
    partial class CajeroControl
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
            this.TCCajero = new MetroFramework.Controls.MetroTabControl();
            this.VentasCajeroPage = new MetroFramework.Controls.MetroTabPage();
            this.grdVentas = new MetroFramework.Controls.MetroGrid();
            this.boletasPage = new MetroFramework.Controls.MetroTabPage();
            this.grdComprobantes = new MetroFramework.Controls.MetroGrid();
            this.TCCajero.SuspendLayout();
            this.VentasCajeroPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).BeginInit();
            this.boletasPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComprobantes)).BeginInit();
            this.SuspendLayout();
            // 
            // TCCajero
            // 
            this.TCCajero.Controls.Add(this.VentasCajeroPage);
            this.TCCajero.Controls.Add(this.boletasPage);
            this.TCCajero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCCajero.Location = new System.Drawing.Point(0, 0);
            this.TCCajero.Name = "TCCajero";
            this.TCCajero.SelectedIndex = 0;
            this.TCCajero.Size = new System.Drawing.Size(357, 270);
            this.TCCajero.TabIndex = 0;
            this.TCCajero.UseSelectable = true;
            // 
            // VentasCajeroPage
            // 
            this.VentasCajeroPage.Controls.Add(this.grdVentas);
            this.VentasCajeroPage.HorizontalScrollbarBarColor = true;
            this.VentasCajeroPage.HorizontalScrollbarHighlightOnWheel = false;
            this.VentasCajeroPage.HorizontalScrollbarSize = 10;
            this.VentasCajeroPage.Location = new System.Drawing.Point(4, 38);
            this.VentasCajeroPage.Name = "VentasCajeroPage";
            this.VentasCajeroPage.Size = new System.Drawing.Size(349, 228);
            this.VentasCajeroPage.TabIndex = 0;
            this.VentasCajeroPage.Text = "Ver Ventas";
            this.VentasCajeroPage.VerticalScrollbarBarColor = true;
            this.VentasCajeroPage.VerticalScrollbarHighlightOnWheel = false;
            this.VentasCajeroPage.VerticalScrollbarSize = 10;
            // 
            // grdVentas
            // 
            this.grdVentas.AllowUserToResizeRows = false;
            this.grdVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdVentas.EnableHeadersVisualStyles = false;
            this.grdVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdVentas.Location = new System.Drawing.Point(26, 14);
            this.grdVentas.Name = "grdVentas";
            this.grdVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVentas.Size = new System.Drawing.Size(305, 185);
            this.grdVentas.TabIndex = 2;
            this.grdVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVentas_CellClick);
            // 
            // boletasPage
            // 
            this.boletasPage.Controls.Add(this.grdComprobantes);
            this.boletasPage.HorizontalScrollbarBarColor = true;
            this.boletasPage.HorizontalScrollbarHighlightOnWheel = false;
            this.boletasPage.HorizontalScrollbarSize = 10;
            this.boletasPage.Location = new System.Drawing.Point(4, 38);
            this.boletasPage.Name = "boletasPage";
            this.boletasPage.Size = new System.Drawing.Size(349, 228);
            this.boletasPage.TabIndex = 1;
            this.boletasPage.Text = "Ver Boletas";
            this.boletasPage.VerticalScrollbarBarColor = true;
            this.boletasPage.VerticalScrollbarHighlightOnWheel = false;
            this.boletasPage.VerticalScrollbarSize = 10;
            // 
            // grdComprobantes
            // 
            this.grdComprobantes.AllowUserToResizeColumns = false;
            this.grdComprobantes.AllowUserToResizeRows = false;
            this.grdComprobantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdComprobantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdComprobantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdComprobantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdComprobantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdComprobantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdComprobantes.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdComprobantes.EnableHeadersVisualStyles = false;
            this.grdComprobantes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdComprobantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdComprobantes.Location = new System.Drawing.Point(3, 3);
            this.grdComprobantes.Name = "grdComprobantes";
            this.grdComprobantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdComprobantes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdComprobantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdComprobantes.Size = new System.Drawing.Size(343, 222);
            this.grdComprobantes.TabIndex = 2;
            // 
            // CajeroControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TCCajero);
            this.Name = "CajeroControl";
            this.Size = new System.Drawing.Size(357, 270);
            this.TCCajero.ResumeLayout(false);
            this.VentasCajeroPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVentas)).EndInit();
            this.boletasPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdComprobantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TCCajero;
        private MetroFramework.Controls.MetroTabPage VentasCajeroPage;
        private MetroFramework.Controls.MetroGrid grdVentas;
        private MetroFramework.Controls.MetroTabPage boletasPage;
        private MetroFramework.Controls.MetroGrid grdComprobantes;
    }
}
