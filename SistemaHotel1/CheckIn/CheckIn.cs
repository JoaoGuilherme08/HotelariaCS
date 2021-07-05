using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.NewFolder1 
{
    public partial class FrmCheckIn : Form 
    {
        public FrmCheckIn() 
        {

            InitializeComponent();
        }

        private void HabilitarCampos() 
        {
            TxtNome.Enabled = true;
            NumAcompanhantes.Enabled = true;
            NumCriancas.Enabled = true;
            CbEstacionamento.Enabled = true;
            NumVagas.Enabled = true;
            UpDownQuarto.Enabled = true;
            TxtDataCheckin.Enabled = true;
            TxtHoraCheckin.Enabled = true;
            TxtNome.Focus();
        }

        private void DesabilitarCampos() 
        {
            TxtNome.Enabled = false;
            NumAcompanhantes.Enabled = false;
            NumCriancas.Enabled = false;
            CbEstacionamento.Enabled = false;
            NumVagas.Enabled = false;
            UpDownQuarto.Enabled = false;
            TxtDataCheckin.Enabled = false;
            TxtHoraCheckin.Enabled = false;
        }

        // Limpar campos depois de salvar
        private void LimparCampos() 
        {
            TxtNome.Text = "";
            NumAcompanhantes.Text = "";
            NumCriancas.Text = "";
            NumVagas.Text = "";
            CbEstacionamento.Text = "";
            UpDownQuarto.Text = "";
            TxtDataCheckin.Text = "";
            TxtHoraCheckin.Text = "";
        }
        private void RbGrupo_CheckedChanged_1(object sender, EventArgs e) 
        {
            TxtNome.Visible = true;
            NumAcompanhantes.Enabled = true;
            NumCriancas.Enabled = true;
            CbEstacionamento.Enabled = true;
            NumVagas.Enabled = true;
            UpDownQuarto.Enabled = true;
            TxtDataCheckin.Enabled = true;
            TxtHoraCheckin.Enabled = true;

            // limpar campos

            TxtNome.Text = "";
            NumAcompanhantes.Text = "";
            NumCriancas.Text = "";
            NumVagas.Text = "";
            CbEstacionamento.Text = "";
            UpDownQuarto.Text = "";
            TxtDataCheckin.Text = "";
            TxtHoraCheckin.Text = "";
        }


        private void RbCliente_CheckedChanged(object sender, EventArgs e) 
        {
            TxtNome.Visible = true;
            NumAcompanhantes.Enabled = true;
            NumCriancas.Enabled = true;
            CbEstacionamento.Enabled = true;
            NumVagas.Enabled = true;
            UpDownQuarto.Enabled = true;
            TxtDataCheckin.Enabled = true;
            TxtHoraCheckin.Enabled = true;
            
            //limpar campos

            TxtNome.Text = "";
            NumAcompanhantes.Text = "";
            NumCriancas.Text = "";
            CbEstacionamento.Text = "";
            NumVagas.Text = "";
            UpDownQuarto.Text = "";
         
        }

        //Habilitando botão Salvar

        private void BtnNovo_Click_1(object sender, EventArgs e) 
        {
            HabilitarCampos();
            BtnSalvar.Enabled = true;
            BtnNovo.Enabled = false;
            BtnEditar.Enabled = false;
            BtnExcluir.Enabled = false;
        }

        // Verificar se um campo está vazio
        //desabilitar espaços como informações

        private void BtnSalvar_Click_1(object sender, EventArgs e) 
        {
            if (TxtNome.Text.ToString().Trim() == "")
            {
                TxtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }

            if (CbEstacionamento.Text == "") 
            {
                MessageBox.Show("Preencha o Campo Estacionamento!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpDownQuarto.Focus();
                return;
            }

            if (UpDownQuarto.Text == "") 
            {
                MessageBox.Show("Preencha a Quantidade de Quartos!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpDownQuarto.Focus();
                return;
            }

            if (TxtDataCheckin.Text == "  /  /") {
                MessageBox.Show("Preencha a Data de Check-In!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDataCheckin.Focus();
                return;
            }

            if (TxtHoraCheckin.Text == "  :") 
            {
                MessageBox.Show("Preencha a Hora de Check-In!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtHoraCheckin.Focus();
                return;
            }
          
            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();

        }

        private void BtnEditar_Click_1(object sender, EventArgs e) 
        { 
           if (TxtNome.Text.ToString().Trim() == "")
            {
                TxtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
                return;
            }

            if (CbEstacionamento.Text == "") 
            {
                MessageBox.Show("Preencha o Campo Estacionamento!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpDownQuarto.Focus();
                return;
            }

            if (UpDownQuarto.Text == "") 
            {
                MessageBox.Show("Preencha a Quantidade de Quartos!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpDownQuarto.Focus();
                return;
            }

            if (TxtDataCheckin.Text == "  /  /") {
                MessageBox.Show("Preencha a Data de Check-In!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDataCheckin.Focus();
                return;
            }
            if (TxtHoraCheckin.Text == "  :") 
            {
                MessageBox.Show("Preencha a Hora de Check-In!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtHoraCheckin.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO DE EDITAR

            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNovo.Enabled = true;
                BtnEditar.Enabled = false;
                BtnExcluir.Enabled = false;
                LimparCampos();
                DesabilitarCampos();
            }

        private void BtnExcluir_Click_1(object sender, EventArgs e) 
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {

                    //CÓDIGO DO BOTÃO DE EXCLUIR


                    MessageBox.Show("Registro Excluído com Sucesso!", "Dados Apagados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnNovo.Enabled = true;
                    BtnEditar.Enabled = false;
                    BtnExcluir.Enabled = false;
                    TxtNome.Text = "";
                    TxtNome.Enabled = false;
                }
        }

        private void FrmCheckIn_Load(object sender, EventArgs e) 
        {
            RbCliente.Checked = true;
        }

        private void DtGridCheckin_Click(object sender, EventArgs e) 
        {
            BtnEditar.Enabled = true;
            BtnExcluir.Enabled = true;
            BtnSalvar.Enabled = false;
        }

    }
}

            
