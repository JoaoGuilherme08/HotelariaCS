namespace SistemaHotel.Relatórios {
    partial class FrmRelatorios {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorios));
            this.Exibir = new System.Windows.Forms.CheckBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.GrupoFiltros = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbJuridica = new System.Windows.Forms.RadioButton();
            this.RbFisica = new System.Windows.Forms.RadioButton();
            this.RbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RbReservas = new System.Windows.Forms.RadioButton();
            this.RbVendas = new System.Windows.Forms.RadioButton();
            this.GrupoImpressao = new System.Windows.Forms.GroupBox();
            this.RbExcel = new System.Windows.Forms.RadioButton();
            this.RbRelatorio = new System.Windows.Forms.RadioButton();
            this.GrupoOrdenar = new System.Windows.Forms.GroupBox();
            this.RbCheckout = new System.Windows.Forms.RadioButton();
            this.RbChekin = new System.Windows.Forms.RadioButton();
            this.GrupoPeriodoCheckin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCheckinAte = new System.Windows.Forms.MaskedTextBox();
            this.TxtCheckinDe = new System.Windows.Forms.MaskedTextBox();
            this.GrupoPeriodoCheckout = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtChekoutAte = new System.Windows.Forms.MaskedTextBox();
            this.TxtChekoutDe = new System.Windows.Forms.MaskedTextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GrupoFiltros.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.GrupoImpressao.SuspendLayout();
            this.GrupoOrdenar.SuspendLayout();
            this.GrupoPeriodoCheckin.SuspendLayout();
            this.GrupoPeriodoCheckout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exibir
            // 
            this.Exibir.AutoSize = true;
            this.Exibir.Location = new System.Drawing.Point(28, 449);
            this.Exibir.Name = "Exibir";
            this.Exibir.Size = new System.Drawing.Size(249, 17);
            this.Exibir.TabIndex = 16;
            this.Exibir.Text = "Exibir inclusive vendas ou reservas canceladas";
            this.Exibir.UseVisualStyleBackColor = true;
            // 
            // GrupoFiltros
            // 
            this.GrupoFiltros.Controls.Add(this.groupBox6);
            this.GrupoFiltros.Controls.Add(this.groupBox2);
            this.GrupoFiltros.Controls.Add(this.groupBox5);
            this.GrupoFiltros.Location = new System.Drawing.Point(28, 146);
            this.GrupoFiltros.Name = "GrupoFiltros";
            this.GrupoFiltros.Size = new System.Drawing.Size(441, 228);
            this.GrupoFiltros.TabIndex = 33;
            this.GrupoFiltros.TabStop = false;
            this.GrupoFiltros.Text = "Filtros (Opcionais):";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TxtCliente);
            this.groupBox6.Location = new System.Drawing.Point(18, 23);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 57);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cliente:";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(6, 19);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(186, 20);
            this.TxtCliente.TabIndex = 48;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RbJuridica);
            this.groupBox2.Controls.Add(this.RbFisica);
            this.groupBox2.Controls.Add(this.RbTodos);
            this.groupBox2.Location = new System.Drawing.Point(224, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 102);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Cliente:";
            // 
            // RbJuridica
            // 
            this.RbJuridica.AutoSize = true;
            this.RbJuridica.Location = new System.Drawing.Point(6, 75);
            this.RbJuridica.Name = "RbJuridica";
            this.RbJuridica.Size = new System.Drawing.Size(101, 17);
            this.RbJuridica.TabIndex = 37;
            this.RbJuridica.TabStop = true;
            this.RbJuridica.Text = "Pessoa Jurídica";
            this.RbJuridica.UseVisualStyleBackColor = true;
            // 
            // RbFisica
            // 
            this.RbFisica.AutoSize = true;
            this.RbFisica.Location = new System.Drawing.Point(6, 52);
            this.RbFisica.Name = "RbFisica";
            this.RbFisica.Size = new System.Drawing.Size(92, 17);
            this.RbFisica.TabIndex = 36;
            this.RbFisica.TabStop = true;
            this.RbFisica.Text = "Pessoa Física";
            this.RbFisica.UseVisualStyleBackColor = true;
            // 
            // RbTodos
            // 
            this.RbTodos.AutoSize = true;
            this.RbTodos.Location = new System.Drawing.Point(6, 29);
            this.RbTodos.Name = "RbTodos";
            this.RbTodos.Size = new System.Drawing.Size(55, 17);
            this.RbTodos.TabIndex = 35;
            this.RbTodos.TabStop = true;
            this.RbTodos.Text = "Todos";
            this.RbTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RbReservas);
            this.groupBox5.Controls.Add(this.RbVendas);
            this.groupBox5.Location = new System.Drawing.Point(18, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 102);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Origem:";
            // 
            // RbReservas
            // 
            this.RbReservas.AutoSize = true;
            this.RbReservas.Location = new System.Drawing.Point(6, 63);
            this.RbReservas.Name = "RbReservas";
            this.RbReservas.Size = new System.Drawing.Size(123, 17);
            this.RbReservas.TabIndex = 36;
            this.RbReservas.TabStop = true;
            this.RbReservas.Text = "Módulo de Reservas";
            this.RbReservas.UseVisualStyleBackColor = true;
            // 
            // RbVendas
            // 
            this.RbVendas.AutoSize = true;
            this.RbVendas.Location = new System.Drawing.Point(6, 29);
            this.RbVendas.Name = "RbVendas";
            this.RbVendas.Size = new System.Drawing.Size(119, 17);
            this.RbVendas.TabIndex = 35;
            this.RbVendas.TabStop = true;
            this.RbVendas.Text = "Módulos de Vendas";
            this.RbVendas.UseVisualStyleBackColor = true;
            // 
            // GrupoImpressao
            // 
            this.GrupoImpressao.Controls.Add(this.RbExcel);
            this.GrupoImpressao.Controls.Add(this.RbRelatorio);
            this.GrupoImpressao.Location = new System.Drawing.Point(252, 380);
            this.GrupoImpressao.Name = "GrupoImpressao";
            this.GrupoImpressao.Size = new System.Drawing.Size(217, 50);
            this.GrupoImpressao.TabIndex = 47;
            this.GrupoImpressao.TabStop = false;
            this.GrupoImpressao.Text = "Tipo de impressão";
            // 
            // RbExcel
            // 
            this.RbExcel.AutoSize = true;
            this.RbExcel.Location = new System.Drawing.Point(116, 19);
            this.RbExcel.Name = "RbExcel";
            this.RbExcel.Size = new System.Drawing.Size(51, 17);
            this.RbExcel.TabIndex = 42;
            this.RbExcel.TabStop = true;
            this.RbExcel.Text = "Excel";
            this.RbExcel.UseVisualStyleBackColor = true;
            // 
            // RbRelatorio
            // 
            this.RbRelatorio.AutoSize = true;
            this.RbRelatorio.Location = new System.Drawing.Point(6, 19);
            this.RbRelatorio.Name = "RbRelatorio";
            this.RbRelatorio.Size = new System.Drawing.Size(67, 17);
            this.RbRelatorio.TabIndex = 37;
            this.RbRelatorio.TabStop = true;
            this.RbRelatorio.Text = "Relatório";
            this.RbRelatorio.UseVisualStyleBackColor = true;
            // 
            // GrupoOrdenar
            // 
            this.GrupoOrdenar.Controls.Add(this.RbCheckout);
            this.GrupoOrdenar.Controls.Add(this.RbChekin);
            this.GrupoOrdenar.Location = new System.Drawing.Point(28, 380);
            this.GrupoOrdenar.Name = "GrupoOrdenar";
            this.GrupoOrdenar.Size = new System.Drawing.Size(218, 50);
            this.GrupoOrdenar.TabIndex = 46;
            this.GrupoOrdenar.TabStop = false;
            this.GrupoOrdenar.Text = "Ordenar por";
            // 
            // RbCheckout
            // 
            this.RbCheckout.AutoSize = true;
            this.RbCheckout.Location = new System.Drawing.Point(106, 19);
            this.RbCheckout.Name = "RbCheckout";
            this.RbCheckout.Size = new System.Drawing.Size(76, 17);
            this.RbCheckout.TabIndex = 42;
            this.RbCheckout.TabStop = true;
            this.RbCheckout.Text = "Check-Out";
            this.RbCheckout.UseVisualStyleBackColor = true;
            // 
            // RbChekin
            // 
            this.RbChekin.AutoSize = true;
            this.RbChekin.Location = new System.Drawing.Point(6, 19);
            this.RbChekin.Name = "RbChekin";
            this.RbChekin.Size = new System.Drawing.Size(68, 17);
            this.RbChekin.TabIndex = 37;
            this.RbChekin.TabStop = true;
            this.RbChekin.Text = "Check-In";
            this.RbChekin.UseVisualStyleBackColor = true;
            // 
            // GrupoPeriodoCheckin
            // 
            this.GrupoPeriodoCheckin.Controls.Add(this.label6);
            this.GrupoPeriodoCheckin.Controls.Add(this.label4);
            this.GrupoPeriodoCheckin.Controls.Add(this.TxtCheckinAte);
            this.GrupoPeriodoCheckin.Controls.Add(this.TxtCheckinDe);
            this.GrupoPeriodoCheckin.Location = new System.Drawing.Point(28, 12);
            this.GrupoPeriodoCheckin.Name = "GrupoPeriodoCheckin";
            this.GrupoPeriodoCheckin.Size = new System.Drawing.Size(297, 61);
            this.GrupoPeriodoCheckin.TabIndex = 48;
            this.GrupoPeriodoCheckin.TabStop = false;
            this.GrupoPeriodoCheckin.Text = "Período de Check-In";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "De:";
            // 
            // TxtCheckinAte
            // 
            this.TxtCheckinAte.Location = new System.Drawing.Point(191, 19);
            this.TxtCheckinAte.Mask = "00/00/0000";
            this.TxtCheckinAte.Name = "TxtCheckinAte";
            this.TxtCheckinAte.Size = new System.Drawing.Size(73, 20);
            this.TxtCheckinAte.TabIndex = 34;
            this.TxtCheckinAte.ValidatingType = typeof(System.DateTime);
            // 
            // TxtCheckinDe
            // 
            this.TxtCheckinDe.Location = new System.Drawing.Point(45, 19);
            this.TxtCheckinDe.Mask = "00/00/0000";
            this.TxtCheckinDe.Name = "TxtCheckinDe";
            this.TxtCheckinDe.Size = new System.Drawing.Size(73, 20);
            this.TxtCheckinDe.TabIndex = 33;
            this.TxtCheckinDe.ValidatingType = typeof(System.DateTime);
            // 
            // GrupoPeriodoCheckout
            // 
            this.GrupoPeriodoCheckout.Controls.Add(this.label1);
            this.GrupoPeriodoCheckout.Controls.Add(this.label2);
            this.GrupoPeriodoCheckout.Controls.Add(this.TxtChekoutAte);
            this.GrupoPeriodoCheckout.Controls.Add(this.TxtChekoutDe);
            this.GrupoPeriodoCheckout.Location = new System.Drawing.Point(28, 79);
            this.GrupoPeriodoCheckout.Name = "GrupoPeriodoCheckout";
            this.GrupoPeriodoCheckout.Size = new System.Drawing.Size(297, 61);
            this.GrupoPeriodoCheckout.TabIndex = 49;
            this.GrupoPeriodoCheckout.TabStop = false;
            this.GrupoPeriodoCheckout.Text = "Período de Check-Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Até:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "De:";
            // 
            // TxtChekoutAte
            // 
            this.TxtChekoutAte.Location = new System.Drawing.Point(191, 19);
            this.TxtChekoutAte.Mask = "00/00/0000";
            this.TxtChekoutAte.Name = "TxtChekoutAte";
            this.TxtChekoutAte.Size = new System.Drawing.Size(73, 20);
            this.TxtChekoutAte.TabIndex = 34;
            this.TxtChekoutAte.ValidatingType = typeof(System.DateTime);
            // 
            // TxtChekoutDe
            // 
            this.TxtChekoutDe.Location = new System.Drawing.Point(45, 19);
            this.TxtChekoutDe.Mask = "00/00/0000";
            this.TxtChekoutDe.Name = "TxtChekoutDe";
            this.TxtChekoutDe.Size = new System.Drawing.Size(73, 20);
            this.TxtChekoutDe.TabIndex = 33;
            this.TxtChekoutDe.ValidatingType = typeof(System.DateTime);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluir.Image")));
            this.BtnExcluir.Location = new System.Drawing.Point(388, 491);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(64, 64);
            this.BtnExcluir.TabIndex = 80;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(309, 491);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(64, 64);
            this.BtnSalvar.TabIndex = 78;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 567);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GrupoPeriodoCheckout);
            this.Controls.Add(this.GrupoPeriodoCheckin);
            this.Controls.Add(this.GrupoImpressao);
            this.Controls.Add(this.GrupoOrdenar);
            this.Controls.Add(this.GrupoFiltros);
            this.Controls.Add(this.Exibir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.GrupoFiltros.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.GrupoImpressao.ResumeLayout(false);
            this.GrupoImpressao.PerformLayout();
            this.GrupoOrdenar.ResumeLayout(false);
            this.GrupoOrdenar.PerformLayout();
            this.GrupoPeriodoCheckin.ResumeLayout(false);
            this.GrupoPeriodoCheckin.PerformLayout();
            this.GrupoPeriodoCheckout.ResumeLayout(false);
            this.GrupoPeriodoCheckout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Exibir;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox GrupoFiltros;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RbJuridica;
        private System.Windows.Forms.RadioButton RbFisica;
        private System.Windows.Forms.RadioButton RbTodos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton RbReservas;
        private System.Windows.Forms.RadioButton RbVendas;
        private System.Windows.Forms.GroupBox GrupoImpressao;
        private System.Windows.Forms.RadioButton RbExcel;
        private System.Windows.Forms.RadioButton RbRelatorio;
        private System.Windows.Forms.GroupBox GrupoOrdenar;
        private System.Windows.Forms.RadioButton RbCheckout;
        private System.Windows.Forms.RadioButton RbChekin;
        private System.Windows.Forms.GroupBox GrupoPeriodoCheckin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtCheckinAte;
        private System.Windows.Forms.MaskedTextBox TxtCheckinDe;
        private System.Windows.Forms.GroupBox GrupoPeriodoCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtChekoutAte;
        private System.Windows.Forms.MaskedTextBox TxtChekoutDe;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnSalvar;
    }
}