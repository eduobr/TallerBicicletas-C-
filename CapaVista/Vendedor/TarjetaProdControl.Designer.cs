namespace CapaVista
{
    partial class TarjetaProdControl
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
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.lblNombreProd = new MetroFramework.Controls.MetroLabel();
            this.lblModelo = new MetroFramework.Controls.MetroLabel();
            this.lblPrecio = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(28, 32);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(114, 108);
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(90, 199);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.UseStyleColors = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNombreProd.Location = new System.Drawing.Point(4, 8);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(71, 19);
            this.lblNombreProd.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblNombreProd.TabIndex = 2;
            this.lblNombreProd.Text = "Producto";
            this.lblNombreProd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNombreProd.UseStyleColors = true;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(4, 152);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 19);
            this.lblModelo.Style = MetroFramework.MetroColorStyle.White;
            this.lblModelo.TabIndex = 3;
            this.lblModelo.Text = "metroLabel2";
            this.lblModelo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblModelo.UseStyleColors = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(4, 199);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 19);
            this.lblPrecio.Style = MetroFramework.MetroColorStyle.White;
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "precio";
            this.lblPrecio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPrecio.UseStyleColors = true;
            // 
            // MetroLabel
            // 
            this.MetroLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MetroLabel.AutoSize = true;
            this.MetroLabel.Location = new System.Drawing.Point(101, 177);
            this.MetroLabel.Name = "MetroLabel";
            this.MetroLabel.Size = new System.Drawing.Size(43, 19);
            this.MetroLabel.TabIndex = 5;
            this.MetroLabel.Text = "Stock:";
            this.MetroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroLabel.UseStyleColors = true;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStock.Location = new System.Drawing.Point(140, 177);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(25, 19);
            this.lblStock.TabIndex = 6;
            this.lblStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStock.UseStyleColors = true;
            // 
            // TarjetaProdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.MetroLabel);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.picFoto);
            this.Name = "TarjetaProdControl";
            this.Size = new System.Drawing.Size(168, 225);
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UseStyleColors = true;
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroLabel lblNombreProd;
        private MetroFramework.Controls.MetroLabel lblModelo;
        private MetroFramework.Controls.MetroLabel lblPrecio;
        private MetroFramework.Controls.MetroLabel MetroLabel;
        private MetroFramework.Controls.MetroLabel lblStock;
    }
}
