using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaHotel.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;

namespace SistemaHotel.Cadastros
{
    public partial class FrmHospedes : Form
    {

        Controle control = new Controle();
        SistemaHotel.DAL.Hosp dadosHosp = new SistemaHotel.DAL.Hosp();

        public FrmHospedes()
        {
            InitializeComponent();
        }

        private void DesabilitarEdicaoUser()
        {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            TxtTelefone.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnNovo.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            TxtTelefone.Enabled = false;
        }

        private void LimparCampos()
        {
            TxtNome.Text = "";
            TxtCPF.Text = "";
            TxtEndereco.Text = "";
            TxtTelefone.Text = "";
        }

        private void HabilitarEdicaoUser()
        {
            TxtNome.Enabled = true;
            TxtCPF.Enabled = true;
            TxtEndereco.Enabled = true;
            TxtTelefone.Enabled = true;
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            BtnEditar.Enabled = true;
        }

        private void LimparCamposUsers()
        {
            TxtNome.Text = "";
            TxtCPF.Text = "";
            TxtEndereco.Text = "";
            TxtTelefone.Text = "";
            dadosHosp.Id = 0;
        }

        private bool SalvarNovoHosp()
        {
            dadosHosp.Nome = TxtNome.Text;
            dadosHosp.Cpf = TxtCPF.Text;
            dadosHosp.Endereco = TxtEndereco.Text;
            dadosHosp.Telefone = TxtTelefone.Text;
            return control.SalvarNovoHosp(dadosHosp);
        }
        private bool SalvarEdicaoHosp()
        {
            dadosHosp.Nome = TxtNome.Text;
            dadosHosp.Cpf = TxtCPF.Text;
            dadosHosp.Endereco = TxtEndereco.Text;
            dadosHosp.Telefone = TxtTelefone.Text;
            return control.SalvarEdicaoHosp(dadosHosp);
        }
        private void FormatarDtGridUser()
        {
            //dtGridUser.Columns[0].HeaderText = "Nome";  //Cabeçaho
            //dtGridUser.Columns[0].Width = 50; // Definir Largura
            /*
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string status = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value.ToString());
                if (status == "1")
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.LightSalmon;
                else
                    dataGridView1.Rows[i].Cells[0].Style.BackColor = Color.Aquamarine;
            }
            */
        }

        public void Listar()
        {
            try
            {
                Grid.DataSource = control.listarHospede();
                FormatarDtGridUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados do hospede " + ex.Message);
            }          
            pictureBox1.Visible = true;
            RelLbl.Visible = true;
        }

        private void BtnNovo_Click_1(object sender, EventArgs e)
        {
            LimparCamposUsers();
            HabilitarEdicaoUser();
        }

        public bool ValidarCamposHosp()
        {
            if (TxtNome.Text.ToString().Trim() == "")
            {
                TxtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNome.Focus();
            }

            if (TxtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCPF.Focus();
            }

            return true;
        }


        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {

            if (ValidarCamposHosp())//mensagem de sucesso
            {
                if (dadosHosp.Id == 0) // se igual a zero é um Novo registro
                {
                    if (SalvarNovoHosp())
                    {
                        BtnEditar.PerformClick(); //simula um click no botão cancelar
                        MessageBox.Show("Hospede Inserido com Sucesso!", "ATENÇÃO");
                    }
                    else
                        MessageBox.Show("Erro ao Inserir Hospede!", "ATENÇÃO");
                }
                else //atualização
                {
                    if (SalvarEdicaoHosp())
                    {
                        BtnEditar.PerformClick(); //simula um click no botão cancelar
                        MessageBox.Show("Alteração salvo com  Sucesso!", "ATENÇÃO");
                    }
                    else
                        MessageBox.Show("Erro ao atualizar dados do Hospede!", "ATENÇÃO");
                }
            }

        }

        private void Grid_Click(object sender, EventArgs e)
        {
            BtnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            BtnSalvar.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            TxtNome.Enabled = false;
            TxtTelefone.Enabled = false;

        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            LimparCamposUsers();
            DesabilitarEdicaoUser();
            Listar();
            // Carrega o ID para validar se é edição
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            LimparCamposUsers();
            DesabilitarEdicaoUser();           
        }
        private void carregarDadosForm()
        {
            TxtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            TxtCPF.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            TxtTelefone.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            TxtEndereco.Text = Grid.CurrentRow.Cells[4].Value.ToString();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarDadosForm();
            dadosHosp.Id = 0;
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarDadosForm();
            HabilitarEdicaoUser();
            // Carrega o ID para validar se é edição
            dadosHosp.Id = (int)Grid.CurrentRow.Cells[0].Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            string dados = "";
            string nomeArquivo = @"C:\cSharp\hospedes.pdf";
            FileStream arqPDF = new FileStream(nomeArquivo, System.IO.FileMode.Create); // OpenOrCreate
            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, arqPDF);

            doc.Open();

            //criando o objeto
            string simg = "https://w7.pngwing.com/pngs/552/954/png-transparent-hotel-ligarb-tourism-travel-agency-hotel.png";
            Image img = Image.GetInstance(simg);
            img.ScaleAbsolute(100, 50);
            doc.Add(img);

            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;

            paragrafo1.Add("ATLANTIC HOTEL\n");
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("RELATÓRIO DE HÓSPEDES\n");
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("\n");
            doc.Add(paragrafo1);

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Add("\n");

            PdfPTable tabela = new PdfPTable(5);
            tabela.WidthPercentage = 100;

            tabela.AddCell("ID");
            tabela.AddCell("Nome");
            tabela.AddCell("Cpf");
            tabela.AddCell("Endereco");
            tabela.AddCell("Telefone");

            DataTable dtUsuarios = control.listarHospede();
            for (int i = 0; i < dtUsuarios.Rows.Count; i++)
            {
                tabela.AddCell(dtUsuarios.Rows[i].Field<Int32>("Id").ToString());
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Nome"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Cpf"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Endereco"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Telefone"));
            }
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            //abrir o arquivo pdf
            System.Diagnostics.Process.Start("C:\\Program Files\\Internet Explorer\\iexplore.exe", "C:\\cSharp\\hospedes.pdf");
        }
    }
}

