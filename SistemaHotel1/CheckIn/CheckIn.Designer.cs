namespace SistemaHotel.NewFolder1 {
    partial class FrmCheckIn {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckIn));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.RbCliente = new System.Windows.Forms.RadioButton();
            this.RbGrupo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDataCheckin = new System.Windows.Forms.MaskedTextBox();
            this.TxtHoraCheckin = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtGridCheckin = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.CbEstacionamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NumVagas = new System.Windows.Forms.NumericUpDown();
            this.NumAcompanhantes = new System.Windows.Forms.NumericUpDown();
            this.NumCriancas = new System.Windows.Forms.NumericUpDown();
            this.UpDownQuarto = new System.Windows.Forms.DomainUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAcompanhantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCriancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(119, 59);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(186, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // RbCliente
            // 
            this.RbCliente.AutoSize = true;
            this.RbCliente.Location = new System.Drawing.Point(145, 36);
            this.RbCliente.Name = "RbCliente";
            this.RbCliente.Size = new System.Drawing.Size(57, 17);
            this.RbCliente.TabIndex = 3;
            this.RbCliente.TabStop = true;
            this.RbCliente.Text = "Cliente";
            this.RbCliente.UseVisualStyleBackColor = true;
            this.RbCliente.CheckedChanged += new System.EventHandler(this.RbCliente_CheckedChanged);
            // 
            // RbGrupo
            // 
            this.RbGrupo.AutoSize = true;
            this.RbGrupo.Location = new System.Drawing.Point(218, 36);
            this.RbGrupo.Name = "RbGrupo";
            this.RbGrupo.Size = new System.Drawing.Size(54, 17);
            this.RbGrupo.TabIndex = 4;
            this.RbGrupo.TabStop = true;
            this.RbGrupo.Text = "Grupo";
            this.RbGrupo.UseVisualStyleBackColor = true;
            this.RbGrupo.CheckedChanged += new System.EventHandler(this.RbGrupo_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Acompanhantes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Crianças:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Check-In:";
            // 
            // TxtDataCheckin
            // 
            this.TxtDataCheckin.Enabled = false;
            this.TxtDataCheckin.Location = new System.Drawing.Point(473, 59);
            this.TxtDataCheckin.Mask = "00/00/0000";
            this.TxtDataCheckin.Name = "TxtDataCheckin";
            this.TxtDataCheckin.Size = new System.Drawing.Size(73, 20);
            this.TxtDataCheckin.TabIndex = 11;
            this.TxtDataCheckin.ValidatingType = typeof(System.DateTime);
            // 
            // TxtHoraCheckin
            // 
            this.TxtHoraCheckin.Enabled = false;
            this.TxtHoraCheckin.Location = new System.Drawing.Point(473, 96);
            this.TxtHoraCheckin.Mask = "90:00";
            this.TxtHoraCheckin.Name = "TxtHoraCheckin";
            this.TxtHoraCheckin.Size = new System.Drawing.Size(42, 20);
            this.TxtHoraCheckin.TabIndex = 14;
            this.TxtHoraCheckin.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hora:";
            // 
            // DtGridCheckin
            // 
            this.DtGridCheckin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DtGridCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridCheckin.Location = new System.Drawing.Point(12, 180);
            this.DtGridCheckin.Name = "DtGridCheckin";
            this.DtGridCheckin.Size = new System.Drawing.Size(517, 174);
            this.DtGridCheckin.TabIndex = 20;
            this.DtGridCheckin.Click += new System.EventHandler(this.DtGridCheckin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Estacionamento:";
            // 
            // CbEstacionamento
            // 
            this.CbEstacionamento.Enabled = false;
            this.CbEstacionamento.FormattingEnabled = true;
            this.CbEstacionamento.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.CbEstacionamento.Location = new System.Drawing.Point(119, 139);
            this.CbEstacionamento.Name = "CbEstacionamento";
            this.CbEstacionamento.Size = new System.Drawing.Size(61, 21);
            this.CbEstacionamento.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Vagas:";
            // 
            // NumVagas
            // 
            this.NumVagas.Enabled = false;
            this.NumVagas.Location = new System.Drawing.Point(243, 139);
            this.NumVagas.Name = "NumVagas";
            this.NumVagas.Size = new System.Drawing.Size(47, 20);
            this.NumVagas.TabIndex = 25;
            // 
            // NumAcompanhantes
            // 
            this.NumAcompanhantes.Enabled = false;
            this.NumAcompanhantes.Location = new System.Drawing.Point(120, 98);
            this.NumAcompanhantes.Name = "NumAcompanhantes";
            this.NumAcompanhantes.Size = new System.Drawing.Size(43, 20);
            this.NumAcompanhantes.TabIndex = 26;
            // 
            // NumCriancas
            // 
            this.NumCriancas.Enabled = false;
            this.NumCriancas.Location = new System.Drawing.Point(243, 96);
            this.NumCriancas.Name = "NumCriancas";
            this.NumCriancas.Size = new System.Drawing.Size(47, 20);
            this.NumCriancas.TabIndex = 27;
            // 
            // UpDownQuarto
            // 
            this.UpDownQuarto.Enabled = false;
            this.UpDownQuarto.Items.Add("Quarto 101");
            this.UpDownQuarto.Items.Add("Quarto 102");
            this.UpDownQuarto.Items.Add("Quarto 103");
            this.UpDownQuarto.Items.Add("Quarto 104");
            this.UpDownQuarto.Items.Add("Quarto 105");
            this.UpDownQuarto.Location = new System.Drawing.Point(361, 140);
            this.UpDownQuarto.Name = "UpDownQuarto";
            this.UpDownQuarto.Size = new System.Drawing.Size(120, 20);
            this.UpDownQuarto.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 77;
            this.label14.Text = "Quarto:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.Location = new System.Drawing.Point(341, 360);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(64, 64);
            this.BtnExcluir.TabIndex = 76;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(257, 360);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(64, 64);
            this.BtnEditar.TabIndex = 75;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(171, 360);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(64, 64);
            this.BtnSalvar.TabIndex = 74;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.Location = new System.Drawing.Point(85, 360);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(64, 64);
            this.BtnNovo.TabIndex = 73;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 47);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.UpDownQuarto);
            this.Controls.Add(this.NumCriancas);
            this.Controls.Add(this.NumAcompanhantes);
            this.Controls.Add(this.NumVagas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbEstacionamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtGridCheckin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtHoraCheckin);
            this.Controls.Add(this.TxtDataCheckin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RbGrupo);
            this.Controls.Add(this.RbCliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.FrmCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAcompanhantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCriancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RbCliente;
        private System.Windows.Forms.RadioButton RbGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtDataCheckin;
        private System.Windows.Forms.MaskedTextBox TxtHoraCheckin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DtGridCheckin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbEstacionamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NumVagas;
        private System.Windows.Forms.NumericUpDown NumAcompanhantes;
        private System.Windows.Forms.NumericUpDown NumCriancas;
        private System.Windows.Forms.DomainUpDown UpDownQuarto;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Label label14;
    }
}