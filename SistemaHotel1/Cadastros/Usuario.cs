using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotel1;
using SistemaHotel.Control;
using iTextSharp.text;
using System.IO;
using Image = iTextSharp.text.Image;
using iTextSharp.text.pdf;

namespace SistemaHotel.Cadastros
{
    public partial class FrmUsuario : Form
    {
        Controle control = new Controle();
        SistemaHotel.DAL.User dadosUser = new SistemaHotel.DAL.User();

        public FrmUsuario()
        {
            InitializeComponent();
        }
        private bool SalvarNovoUser()
        {
            dadosUser.Nome = TxtLoguin.Text;
            dadosUser.Nomever = TxtNome.Text;
            dadosUser.Senha = TxtSenha.Text;
            dadosUser.Status = txtStatus.Text;
            return control.SalvarNovoUser(dadosUser);
        }
        private bool SalvarEdicaoUser()
        {
            dadosUser.Nome = TxtLoguin.Text;
            dadosUser.Nomever = TxtNome.Text;
            dadosUser.Status = txtStatus.Text;
            return control.SalvarEdicaoUser(dadosUser);
        }
        // Text -> recebe o texto em vazio ""
        private void FrmUsuario_Load_1(object sender, EventArgs e)
        {
            
        }
        public void Listar()
        {
            try
            {
                dataGridView1.DataSource = control.listarUsuarios();
                FormatarDtGridUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados do usuário " + ex.Message);
            }          
            pictureBox1.Visible = true;
            RelLbl.Visible = true;
        }
        private bool ValidarCamposUser()
        {
            if (String.IsNullOrEmpty(TxtNome.Text))
            {
                MessageBox.Show("Favor informar o Nome do Usuário!", "ATENÇÃO");
                TxtNome.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(txtStatus.Text))
            {
                MessageBox.Show("Favor escolhe o Status!", "ATENÇÃO");
                txtStatus.Focus();
                return false;

            }

            if (dadosUser.Id == 0) // novo usuário
            {
                if (String.IsNullOrEmpty(TxtSenha.Text))
                {
                    MessageBox.Show("Favor informar a senha!", "ATENÇÃO");
                    TxtSenha.Focus();
                    return false;
                }
                else if (!(TxtSenha.Text == TxtConfirmarSenha.Text))
                {
                    MessageBox.Show("Senha não são iguais!", "ATENÇÃO");
                    TxtSenha.Focus();
                    return false;
                }
            }
            return true;
        }

        // DataGrid 
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

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparCamposUsers();
            HabilitarEdicaoUser();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {          
            if (ValidarCamposUser())//mensagem de sucesso
            {
                if (dadosUser.Id == 0) // se igual a zero é um Novo registro
                {
                    if (SalvarNovoUser())
                    {
                        BtnEditar.PerformClick(); //simula um click no botão cancelar
                        MessageBox.Show("Usuário Inserido com Sucesso!", "ATENÇÃO");
                    }
                    else
                        MessageBox.Show("Erro ao Inserir Usuário!", "ATENÇÃO");
                }
                else //atualização
                {
                    if (SalvarEdicaoUser())
                    {
                        BtnEditar.PerformClick(); //simula um click no botão cancelar
                        MessageBox.Show("Alteração salvo com  Sucesso!", "ATENÇÃO");
                    }
                    else
                        MessageBox.Show("Erro ao atualizar dados do Usuário!", "ATENÇÃO");
                }
            }
        }
        private void carregarDadosForm()
        {
            TxtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TxtLoguin.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtStatus.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void HabilitarEdicaoUser()
        {
            TxtNome.Enabled = true;
            TxtLoguin.Enabled = true;
            TxtSenha.Enabled = true;
            TxtConfirmarSenha.Enabled = true;
            txtStatus.Enabled = true;
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            BtnEditar.Enabled = true;
        }

        private void LimparCamposUsers()
        {
            TxtNome.Text = "";
            TxtLoguin.Text = "";
            TxtSenha.Text = "";
            TxtConfirmarSenha.Text = "";
            // usado no botão Novo e Salvar para controlar se é Insert ou Update
            dadosUser.Id = 0;
        }

        private void DesabilitarEdicaoUser()
        {
            TxtNome.Enabled = false;
            TxtLoguin.Enabled = false;
            TxtSenha.Enabled = false;
            TxtConfirmarSenha.Enabled = false;
            txtStatus.Enabled = false;
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            LimparCamposUsers();
            DesabilitarEdicaoUser();
            Listar();
            // Carrega o ID para validar se é edição
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCamposUsers();
            DesabilitarEdicaoUser();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            carregarDadosForm();
            dadosUser.Id = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
            carregarDadosForm();
            HabilitarEdicaoUser();
            TxtSenha.Enabled = false;
            TxtConfirmarSenha.Enabled = false;
            // Carrega o ID para validar se é edição
            dadosUser.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
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
            paragrafo1.Add("RELATÓRIO DE USUÁRIOS\n");
            paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
            paragrafo1.Add("\n");
            doc.Add(paragrafo1);

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Add("\n");

            PdfPTable tabela = new PdfPTable(4);
            tabela.WidthPercentage = 100;

            tabela.AddCell("ID");
            tabela.AddCell("Nome");
            tabela.AddCell("Login");
            tabela.AddCell("Status");

            DataTable dtUsuarios = control.listarUsuarios();
            for (int i = 0; i < dtUsuarios.Rows.Count; i++)
            {
                tabela.AddCell(dtUsuarios.Rows[i].Field<Int32>("Id").ToString());
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Nome"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Usuario"));
                tabela.AddCell(dtUsuarios.Rows[i].Field<string>("Status"));
            }
            doc.Add(tabela);
            doc.Add(paragrafo2);
            doc.Close();

            //abrir o arquivo pdf
            System.Diagnostics.Process.Start("C:\\Program Files\\Internet Explorer\\iexplore.exe", "C:\\cSharp\\hospedes.pdf");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            BtnEditar.Enabled = true;
            BtnSalvar.Enabled = false;
            TxtNome.Enabled = false;
            txtStatus.Enabled = false;
            TxtLoguin.Enabled = false;
        }
    }
}
    