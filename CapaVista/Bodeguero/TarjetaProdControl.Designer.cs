namespace CapaVista.Bodeguero
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
            this.lblNombreProd = new MetroFramework.Controls.MetroLabel();
            this.lblStock = new MetroFramework.Controls.MetroLabel();
            this.lblModelo = new MetroFramework.Controls.MetroLabel();
            this.MetroLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(25, 28);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(114, 108);
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblNombreProd.Location = new System.Drawing.Point(13, 6);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(71, 19);
            this.lblNombreProd.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblNombreProd.TabIndex = 3;
            this.lblNombreProd.Text = "Producto";
            this.lblNombreProd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNombreProd.UseStyleColors = true;
            // 
            // lblStock
            // 
            this.lblStock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(62, 186);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 19);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            this.lblStock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblStock.UseStyleColors = true;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(13, 151);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(83, 19);
            this.lblModelo.Style = MetroFramework.MetroColorStyle.White;
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "metroLabel2";
            this.lblModelo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblModelo.UseStyleColors = true;
            // 
            // MetroLabel
            // 
            this.MetroLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MetroLabel.AutoSize = true;
            this.MetroLabel.Location = new System.Drawing.Point(13, 186);
            this.MetroLabel.Name = "MetroLabel";
            this.MetroLabel.Size = new System.Drawing.Size(43, 19);
            this.MetroLabel.Style = MetroFramework.MetroColorStyle.Green;
            this.MetroLabel.TabIndex = 9;
            this.MetroLabel.Text = "Stock:";
            this.MetroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MetroLabel.UseStyleColors = true;
            // 
            // TarjetaProdControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MetroLabel);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.picFoto);
            this.Name = "TarjetaProdControl";
            this.Size = new System.Drawing.Size(168, 225);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private MetroFramework.Controls.MetroLabel lblNombreProd;
        private MetroFramework.Controls.MetroLabel lblStock;
        private MetroFramework.Controls.MetroLabel lblModelo;
        private MetroFramework.Controls.MetroLabel MetroLabel;
    }
}
