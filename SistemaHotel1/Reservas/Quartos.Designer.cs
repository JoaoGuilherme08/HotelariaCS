namespace SistemaHotel.Reservas {
    partial class FrmQuartos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuartos));
            this.DtGridQuartos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridQuartos)).BeginInit();
            this.SuspendLayout();
            // 
            // DtGridQuartos
            // 
            this.DtGridQuartos.AllowUserToAddRows = false;
            this.DtGridQuartos.AllowUserToDeleteRows = false;
            this.DtGridQuartos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DtGridQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridQuartos.Location = new System.Drawing.Point(12, 12);
            this.DtGridQuartos.Name = "DtGridQuartos";
            this.DtGridQuartos.ReadOnly = true;
            this.DtGridQuartos.Size = new System.Drawing.Size(776, 426);
            this.DtGridQuartos.TabIndex = 0;
            // 
            // FrmQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtGridQuartos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuartos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quartos";
            ((System.ComponentModel.ISupportInitialize)(this.DtGridQuartos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtGridQuartos;
    }
}