namespace SistemaHotel.CheckIn {
    partial class FrmCheckout {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheckout));
            this.label14 = new System.Windows.Forms.Label();
            this.UpDownQuarto = new System.Windows.Forms.DomainUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.CbPagamento = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UpDownDias = new System.Windows.Forms.NumericUpDown();
            this.NumCriancas = new System.Windows.Forms.NumericUpDown();
            this.NumAcompanhantes = new System.Windows.Forms.NumericUpDown();
            this.NumVagas = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.CbEstacionamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DtGridCheckin = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtHoraCheckout = new System.Windows.Forms.MaskedTextBox();
            this.TxtHoraCheckin = new System.Windows.Forms.MaskedTextBox();
            this.TxtDataCheckout = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDataCheckin = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RbGrupo = new System.Windows.Forms.RadioButton();
            this.RbCliente = new System.Windows.Forms.RadioButton();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCriancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAcompanhantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridCheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 108;
            this.label14.Text = "Quarto:";
            // 
            // UpDownQuarto
            // 
            this.UpDownQuarto.Enabled = false;
            this.UpDownQuarto.Items.Add("Quarto 101");
            this.UpDownQuarto.Items.Add("Quarto 102");
            this.UpDownQuarto.Items.Add("Quarto 103");
            this.UpDownQuarto.Items.Add("Quarto 104");
            this.UpDownQuarto.Items.Add("Quarto 105");
            this.UpDownQuarto.Location = new System.Drawing.Point(361, 130);
            this.UpDownQuarto.Name = "UpDownQuarto";
            this.UpDownQuarto.Size = new System.Drawing.Size(120, 20);
            this.UpDownQuarto.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.TxtValor);
            this.panel1.Controls.Add(this.CbPagamento);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(607, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 244);
            this.panel1.TabIndex = 102;
            // 
            // TxtValor
            // 
            this.TxtValor.Enabled = false;
            this.TxtValor.Location = new System.Drawing.Point(22, 68);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(59, 20);
            this.TxtValor.TabIndex = 73;
            // 
            // CbPagamento
            // 
            this.CbPagamento.Enabled = false;
            this.CbPagamento.FormattingEnabled = true;
            this.CbPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Cheque",
            "Depósito"});
            this.CbPagamento.Location = new System.Drawing.Point(22, 152);
            this.CbPagamento.Name = "CbPagamento";
            this.CbPagamento.Size = new System.Drawing.Size(204, 21);
            this.CbPagamento.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Forma de Pagamento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Valor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(98, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pagamento:";
            // 
            // UpDownDias
            // 
            this.UpDownDias.Enabled = false;
            this.UpDownDias.Location = new System.Drawing.Point(717, 49);
            this.UpDownDias.Name = "UpDownDias";
            this.UpDownDias.Size = new System.Drawing.Size(49, 20);
            this.UpDownDias.TabIndex = 101;
            // 
            // NumCriancas
            // 
            this.NumCriancas.Enabled = false;
            this.NumCriancas.Location = new System.Drawing.Point(243, 86);
            this.NumCriancas.Name = "NumCriancas";
            this.NumCriancas.Size = new System.Drawing.Size(47, 20);
            this.NumCriancas.TabIndex = 100;
            // 
            // NumAcompanhantes
            // 
            this.NumAcompanhantes.Enabled = false;
            this.NumAcompanhantes.Location = new System.Drawing.Point(120, 88);
            this.NumAcompanhantes.Name = "NumAcompanhantes";
            this.NumAcompanhantes.Size = new System.Drawing.Size(43, 20);
            this.NumAcompanhantes.TabIndex = 99;
            // 
            // NumVagas
            // 
            this.NumVagas.Enabled = false;
            this.NumVagas.Location = new System.Drawing.Point(243, 129);
            this.NumVagas.Name = "NumVagas";
            this.NumVagas.Size = new System.Drawing.Size(47, 20);
            this.NumVagas.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(197, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "Vagas:";
            // 
            // CbEstacionamento
            // 
            this.CbEstacionamento.Enabled = false;
            this.CbEstacionamento.FormattingEnabled = true;
            this.CbEstacionamento.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.CbEstacionamento.Location = new System.Drawing.Point(119, 129);
            this.CbEstacionamento.Name = "CbEstacionamento";
            this.CbEstacionamento.Size = new System.Drawing.Size(61, 21);
            this.CbEstacionamento.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Estacionamento:";
            // 
            // DtGridCheckin
            // 
            this.DtGridCheckin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DtGridCheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridCheckin.Location = new System.Drawing.Point(12, 170);
            this.DtGridCheckin.Name = "DtGridCheckin";
            this.DtGridCheckin.Size = new System.Drawing.Size(517, 174);
            this.DtGridCheckin.TabIndex = 94;
            this.DtGridCheckin.Click += new System.EventHandler(this.DtGridCheckin_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(680, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Dias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Hora:";
            // 
            // TxtHoraCheckout
            // 
            this.TxtHoraCheckout.Enabled = false;
            this.TxtHoraCheckout.Location = new System.Drawing.Point(607, 93);
            this.TxtHoraCheckout.Mask = "00:00";
            this.TxtHoraCheckout.Name = "TxtHoraCheckout";
            this.TxtHoraCheckout.Size = new System.Drawing.Size(42, 20);
            this.TxtHoraCheckout.TabIndex = 90;
            this.TxtHoraCheckout.ValidatingType = typeof(System.DateTime);
            // 
            // TxtHoraCheckin
            // 
            this.TxtHoraCheckin.Enabled = false;
            this.TxtHoraCheckin.Location = new System.Drawing.Point(607, 49);
            this.TxtHoraCheckin.Mask = "90:00";
            this.TxtHoraCheckin.Name = "TxtHoraCheckin";
            this.TxtHoraCheckin.Size = new System.Drawing.Size(42, 20);
            this.TxtHoraCheckin.TabIndex = 89;
            this.TxtHoraCheckin.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDataCheckout
            // 
            this.TxtDataCheckout.Enabled = false;
            this.TxtDataCheckout.Location = new System.Drawing.Point(473, 90);
            this.TxtDataCheckout.Mask = "00/00/0000";
            this.TxtDataCheckout.Name = "TxtDataCheckout";
            this.TxtDataCheckout.Size = new System.Drawing.Size(73, 20);
            this.TxtDataCheckout.TabIndex = 88;
            this.TxtDataCheckout.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Check-Out:";
            // 
            // TxtDataCheckin
            // 
            this.TxtDataCheckin.Enabled = false;
            this.TxtDataCheckin.Location = new System.Drawing.Point(473, 49);
            this.TxtDataCheckin.Mask = "00/00/0000";
            this.TxtDataCheckin.Name = "TxtDataCheckin";
            this.TxtDataCheckin.Size = new System.Drawing.Size(73, 20);
            this.TxtDataCheckin.TabIndex = 86;
            this.TxtDataCheckin.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Check-In:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Crianças:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Acompanhantes:";
            // 
            // RbGrupo
            // 
            this.RbGrupo.AutoSize = true;
            this.RbGrupo.Location = new System.Drawing.Point(218, 26);
            this.RbGrupo.Name = "RbGrupo";
            this.RbGrupo.Size = new System.Drawing.Size(54, 17);
            this.RbGrupo.TabIndex = 82;
            this.RbGrupo.TabStop = true;
            this.RbGrupo.Text = "Grupo";
            this.RbGrupo.UseVisualStyleBackColor = true;
            this.RbGrupo.CheckedChanged += new System.EventHandler(this.RbGrupo_CheckedChanged);
            // 
            // RbCliente
            // 
            this.RbCliente.AutoSize = true;
            this.RbCliente.Location = new System.Drawing.Point(145, 26);
            this.RbCliente.Name = "RbCliente";
            this.RbCliente.Size = new System.Drawing.Size(57, 17);
            this.RbCliente.TabIndex = 81;
            this.RbCliente.TabStop = true;
            this.RbCliente.Text = "Cliente";
            this.RbCliente.UseVisualStyleBackColor = true;
            this.RbCliente.CheckedChanged += new System.EventHandler(this.RbCliente_CheckedChanged_1);
            // 
            // TxtNome
            // 
            this.TxtNome.Enabled = false;
            this.TxtNome.Location = new System.Drawing.Point(119, 49);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(186, 20);
            this.TxtNome.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Nome:";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.Location = new System.Drawing.Point(341, 350);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(64, 64);
            this.BtnExcluir.TabIndex = 107;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.Enabled = false;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.Location = new System.Drawing.Point(257, 350);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(64, 64);
            this.BtnEditar.TabIndex = 106;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.Enabled = false;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(171, 350);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(64, 64);
            this.BtnSalvar.TabIndex = 105;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNovo.FlatAppearance.BorderSize = 0;
            this.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNovo.Image")));
            this.BtnNovo.Location = new System.Drawing.Point(85, 350);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(64, 64);
            this.BtnNovo.TabIndex = 104;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 47);
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.UpDownQuarto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpDownDias);
            this.Controls.Add(this.NumCriancas);
            this.Controls.Add(this.NumAcompanhantes);
            this.Controls.Add(this.NumVagas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CbEstacionamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtGridCheckin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtHoraCheckout);
            this.Controls.Add(this.TxtHoraCheckin);
            this.Controls.Add(this.TxtDataCheckout);
            this.Controls.Add(this.label5);
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
            this.Name = "FrmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-Out";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCriancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAcompanhantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumVagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridCheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DomainUpDown UpDownQuarto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.ComboBox CbPagamento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown UpDownDias;
        private System.Windows.Forms.NumericUpDown NumCriancas;
        private System.Windows.Forms.NumericUpDown NumAcompanhantes;
        private System.Windows.Forms.NumericUpDown NumVagas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbEstacionamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DtGridCheckin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtHoraCheckout;
        private System.Windows.Forms.MaskedTextBox TxtHoraCheckin;
        private System.Windows.Forms.MaskedTextBox TxtDataCheckout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtDataCheckin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbGrupo;
        private System.Windows.Forms.RadioButton RbCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
    }
}