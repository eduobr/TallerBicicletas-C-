namespace CapaVista.Vendedor
{
    partial class FormMotivoCambiarProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMotivo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnConfirmarCambio = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            // 
            // 
            // 
            this.txtMotivo.CustomButton.Image = null;
            this.txtMotivo.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtMotivo.CustomButton.Name = "";
            this.txtMotivo.CustomButton.Size = new System.Drawing.Size(137, 137);
            this.txtMotivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMotivo.CustomButton.TabIndex = 1;
            this.txtMotivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMotivo.CustomButton.UseSelectable = true;
            this.txtMotivo.CustomButton.Visible = false;
            this.txtMotivo.Lines = new string[0];
            this.txtMotivo.Location = new System.Drawing.Point(23, 49);
            this.txtMotivo.MaxLength = 32767;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.SelectionLength = 0;
            this.txtMotivo.SelectionStart = 0;
            this.txtMotivo.ShortcutsEnabled = true;
            this.txtMotivo.Size = new System.Drawing.Size(249, 139);
            this.txtMotivo.TabIndex = 0;
            this.txtMotivo.UseSelectable = true;
            this.txtMotivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMotivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Ingrese el Motivo:";
            // 
            // btnConfirmarCambio
            // 
            this.btnConfirmarCambio.Location = new System.Drawing.Point(84, 194);
            this.btnConfirmarCambio.Name = "btnConfirmarCambio";
            this.btnConfirmarCambio.Size = new System.Drawing.Size(119, 23);
            this.btnConfirmarCambio.TabIndex = 2;
            this.btnConfirmarCambio.Text = "Confirmar Cambio";
            this.btnConfirmarCambio.UseSelectable = true;
            this.btnConfirmarCambio.Click += new System.EventHandler(this.btnConfirmarCambio_Click);
            // 
            // FormMotivoCambiarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 239);
            this.Controls.Add(this.btnConfirmarCambio);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtMotivo);
            this.Name = "FormMotivoCambiarProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtMotivo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnConfirmarCambio;
    }
}