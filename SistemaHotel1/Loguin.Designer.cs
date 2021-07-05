namespace SistemaHotel1 {
    partial class FrmLoguin {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoguin));
            this.pnlLoguin = new System.Windows.Forms.Panel();
            this.btnLoguin = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlLoguin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoguin
            // 
            this.pnlLoguin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLoguin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLoguin.BackgroundImage")));
            this.pnlLoguin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLoguin.Controls.Add(this.btnLoguin);
            this.pnlLoguin.Controls.Add(this.TxtUsuario);
            this.pnlLoguin.Controls.Add(this.txtSenha);
            this.pnlLoguin.Location = new System.Drawing.Point(298, 98);
            this.pnlLoguin.Name = "pnlLoguin";
            this.pnlLoguin.Size = new System.Drawing.Size(332, 340);
            this.pnlLoguin.TabIndex = 0;
            this.pnlLoguin.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLoguin_Paint);
            // 
            // btnLoguin
            // 
            this.btnLoguin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoguin.FlatAppearance.BorderSize = 0;
            this.btnLoguin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLoguin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoguin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoguin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoguin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLoguin.Location = new System.Drawing.Point(86, 279);
            this.btnLoguin.Name = "btnLoguin";
            this.btnLoguin.Size = new System.Drawing.Size(182, 49);
            this.btnLoguin.TabIndex = 3;
            this.btnLoguin.Text = "Loguin";
            this.btnLoguin.UseVisualStyleBackColor = true;
            this.btnLoguin.Click += new System.EventHandler(this.BtnLoguin_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(99, 180);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(196, 16);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(99, 237);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(196, 16);
            this.txtSenha.TabIndex = 2;
            // 
            // FrmLoguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1019, 586);
            this.Controls.Add(this.pnlLoguin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmLoguin";
            this.Text = "Loguin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLoguin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLoguin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLoguin_KeyDown);
            this.pnlLoguin.ResumeLayout(false);
            this.pnlLoguin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoguin;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLoguin;
    }
}

