using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaHotel.Cadastros;
using SistemaHotel.Control;
using SistemaHotel.DAL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace SistemaHotel1.Cadastros
{
    public partial class FrmFuncionarios : Form
    {
        Controle control = new Controle();
        SistemaHotel.DAL.Func dadosUser = new SistemaHotel.DAL.Func();
        Func dadosFunc = new Func();

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            TxtNome.Enabled = true;
            TxtCPF.Enabled = true;
            TxtEndereco.Enabled = true;
            CbCargo.Enabled = true;
            TxtTelefone.Enabled = true;
            BtnEditar.Enabled = true;
            TxtNome.Focus();
        }

        private void DesabilitarCampos()
        {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            CbCargo.Enabled = false;
            TxtTelefone.Enabled = false;
        }

        // Text -> recebe o texto em vazio ""
        private void LimparCampos()
        {
            TxtNome.Text = "";
            TxtCPF.Text = "";
            TxtEndereco.Text = "";
            TxtTelefone.Text = "";
        }    

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            HabilitarEdicaoUser();
        }

        public bool ValidarCamposUser()
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {                      
            if (ValidarCamposUser())
            {
                if (dadosFunc.Id == 0) 
                {
                    if (SalvarNovoFunc())
                    {
                        BtnEditar.PerformClick(); 
                        MessageBox.Show("Funcionário Inserido com Sucesso!", "ATENÇÃO");
                    }
                    else
                        MessageBox.Show("Erro ao Inserir Usuário!", "ATENÇÃO");
                }
                else 
                {
                    if (SalvarEdicaoFunc())
                    {
                        BtnEditar.PerformClick(); 
                        MessageBox.Show("Alteração salvo com  Sucesso!", "ATENÇÃO");
                    }
                    else
                        MessageBox.Show("Erro ao atualizar dados do Usuário!", "ATENÇÃO");
                }
            }

        }

        private bool SalvarEdicaoFunc()
        {
            dadosFunc.Nome = TxtNome.Text;
            dadosFunc.Cpf = TxtCPF.Text;
            dadosFunc.Endereco = TxtEndereco.Text;
            dadosFunc.Cargo = CbCargo.Text;
            dadosFunc.Telefone = TxtTelefone.Text;
            return control.SalvarEdicaoFunc(dadosFunc);
        }

        private bool SalvarNovoFunc()
        {
            dadosFunc.Nome = TxtNome.Text;
            dadosFunc.Cpf = TxtCPF.Text;
            dadosFunc.Endereco = TxtEndereco.Text;
            dadosFunc.Cargo = CbCargo.Text;
            dadosFunc.Telefone = TxtTelefone.Text;
            return control.SalvarNovoFunc(dadosFunc);
        }

        public void Listar()
        {
            try
            {
                Grid.DataSource = control.listarFuncionarios();
                FormatarDtGridUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados do funcionário " + ex.Message);
            }
            pictureBox1.Visible = true;
            RelLbl.Visible = true;
        }

        private void FormatarDtGridUser()
        {
            //dtGridUser.Columns[0].HeaderText = "Nome";  //Cabeçaho
            //dtGridUser.Columns[0].Width = 50; // Definir Largura



            /*for (int i=0; i< dtGridUser.Rows.Count; i++)
            {
                string status = Convert.ToString(dtGridUser.Rows[i].Cells[2].Value.ToString());
                if ( status == "1")
                    dtGridUser.Rows[i].Cells[0].Style.BackColor = Color.LightSalmon;
                else
                    dtGridUser.Rows[i].Cells[0].Style.BackColor = Color.Aquamarine;
            }*/
        }

        private void Grid_Click(object sender, EventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnSalvar.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            TxtNome.Enabled = false;
            TxtrCa.Enabled = false;
            TxtTelefone.Enabled = false;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            LimparCamposUsers();
            DesabilitarEdicaoUser();
            Listar();
            // Carrega o ID para validar se é edição

        }

        private void carregarDadosForm()
        {
            //Pega o dados da segunda coluna
            TxtNome.Text = Grid.CurrentRow.Cells[1].Value.ToString();
            TxtCPF.Text = Grid.CurrentRow.Cells[2].Value.ToString();
            TxtTelefone.Text = Grid.CurrentRow.Cells[3].Value.ToString();
            TxtEndereco.Text = Grid.CurrentRow.Cells[4].Value.ToString();
            CbCargo.Text = Grid.CurrentRow.Cells[5].Value.ToString();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarDadosForm();
            dadosFunc.Id = 0;
        }

        private void LimparCamposUsers()
        {
            TxtNome.Text = "";
            TxtCPF.Text = "";
            TxtEndereco.Text = "";
            TxtTelefone.Text = "";
            CbCargo.Text = "";
            // usado no botão Novo e Salvar para controlar se é Insert ou Update
            dadosFunc.Id = 0;
        }

        private void DesabilitarEdicaoUser()
        {
            TxtNome.Enabled = false;
            TxtCPF.Enabled = false;
            TxtEndereco.Enabled = false;
            TxtTelefone.Enabled = false;
            CbCargo.Enabled = false;
            BtnNovo.Enabled = true;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCamposUsers();
            DesabilitarEdicaoUser();
        }
        private void HabilitarEdicaoUser()
        {
            TxtNome.Enabled = true;
            TxtCPF.Enabled = true;
            TxtEndereco.Enabled = true;
            TxtTelefone.Enabled = true;
            CbCargo.Enabled = true;
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            carregarDadosForm();
            HabilitarEdicaoUser();
            // Carrega o ID para validar se é edição
            dadosFunc.Id = (int)Grid.CurrentRow.Cells[0].Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            string dados = "";
            string nomeArquivo = @"C:\cSharp\funcionarios.pdf";
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
            paragrafo1.Add("RELATÓRIO DE FUNCIONÁRIOS\n");
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("\n");
            doc.Add(paragrafo1);

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Add("\n");
                
            PdfPTable tabela = new PdfPTable(6);
            tabela.WidthPercentage = 100;

            tabela.AddCell("ID");
            tabela.AddCell("Nome");
            tabela.AddCell("Cpf");
            tabela.AddCell("Endereco");
            tabela.AddCell("Telefone");
            tabela.AddCell("Cargo");

            DataTable dtUsuarios = control.listarFuncionarios();
            for (int i = 0; i < dtUsuarios.Rows.Count; i++)
            {
                tabela.AddCell(dtUsuarios.Rows[i].Field<Int32>("Id").ToString());
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Nome"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Cpf"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Endereco"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Telefone"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Cargo"));
            }
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            //abrir o arquivo pdf
            System.Diagnostics.Process.Start("C:\\Program Files\\Internet Explorer\\iexplore.exe", "C:\\cSharp\\funcionarios.pdf");
        }
    }
}


