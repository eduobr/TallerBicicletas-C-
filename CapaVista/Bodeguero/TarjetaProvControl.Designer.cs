namespace CapaVista.Bodeguero
{
    partial class TarjetaProvControl
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
            this.MetroLabel = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblModelo = new MetroFramework.Controls.MetroLabel();
            this.lblNombreProd = new MetroFramework.Controls.MetroLabel();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblProveedor = new MetroFramework.Controls.MetroLabel();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // MetroLabel
            // 
            this.MetroLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MetroLabel.AutoSize = true;
            this.MetroLabel.Location = new System.Drawing.Point(16, 178);
            this.MetroLabel.Name = "MetroLabel";
            this.MetroLabel.Size = new System.Drawing.Size(43, 19);
            this.MetroLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.MetroLabel.TabIndex = 14;
            this.MetroLabel.Text = "Stock:";
            this.MetroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroLabel.UseStyleColors = true;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(65, 178);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 19);
            this.lblStock.TabIndex = 13;
            this.lblStock.Text = "Stock:";
            this.lblStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStock.UseStyleColors = true;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(16, 150);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 19);
            this.lblModelo.Style = MetroFramework.MetroColorStyle.White;
            this.lblModelo.TabIndex = 12;
            this.lblModelo.Text = "metroLabel2";
            this.lblModelo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblModelo.UseStyleColors = true;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNombreProd.Location = new System.Drawing.Point(16, 4);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(71, 19);
            this.lblNombreProd.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblNombreProd.TabIndex = 11;
            this.lblNombreProd.Text = "Producto";
            this.lblNombreProd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNombreProd.UseStyleColors = true;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(28, 26);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(114, 108);
            this.picFoto.TabIndex = 10;
            this.picFoto.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 203);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Proveedor:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(88, 203);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(83, 19);
            this.lblProveedor.TabIndex = 16;
            this.lblProveedor.Text = "metroLabel2";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(48, 226);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // TarjetaProvControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MetroLabel);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.picFoto);
            this.Name = "TarjetaProvControl";
            this.Size = new System.Drawing.Size(174, 252);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel MetroLabel;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblModelo;
        private MetroFramework.Controls.MetroLabel lblNombreProd;
        private System.Windows.Forms.PictureBox picFoto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblProveedor;
        private MetroFramework.Controls.MetroButton btnAgregar;
    }
}
