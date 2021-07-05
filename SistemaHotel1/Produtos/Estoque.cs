using SistemaHotel1;
using SistemaHotel1.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaHotel.Produtos
{
    public partial class Estoque : Form
    {
        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;
        string ultimoIdGasto;

        private void CarregarCombobox()
        {
            con.conectar();
            sql = "SELECT * FROM fornecedores order by nome asc";
            cmd.Connection = con.conectar();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbFornecedor.DataSource = dt;
            cbFornecedor.ValueMember = "id";
            cbFornecedor.DisplayMember = "nome";

            con.desconectar();
        }

        public Estoque()
        {
            InitializeComponent();
        }

        private void habilitarCampos()
        {
            //txtProduto.Enabled = true;
            txtValor.Enabled = true;
            //txtEstoque.Enabled = true;
            cbFornecedor.Enabled = true;
            txtQuantidade.Enabled = true;
            txtQuantidade.Focus();
            btnSalvar.Enabled = true;

        }
        private void desabilitarCampos()
        {
            txtProduto.Enabled = false;
            txtValor.Enabled = false;
            txtEstoque.Enabled = false;
            cbFornecedor.Enabled = false;
            txtQuantidade.Enabled = false;
            btnSalvar.Enabled = false;
        }

        private void limparCampos()
        {
            txtProduto.Text = "";
            txtValor.Text = "";
            txtEstoque.Text = "";
            txtQuantidade.Text = "";
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();

            Program.chamadaProdutos = "estoque";
            Produto prod = new Produto();
            prod.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtProduto.Text.ToString().Trim() == "")
            {
                txtProduto.Text = "";
                MessageBox.Show("Selecione um Produto", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduto.Focus();
                return;
            }

            if (txtQuantidade.Text == "")
            {
                MessageBox.Show("Preencha a Quantidade", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantidade.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA EDITAR OS PRODUTOS
            con.conectar();
            sql = "UPDATE produtos SET fornecedor = @fornecedor, valor_compra = @valor, estoque = @estoque where id = @id";
            cmd.Connection = con.conectar();

            cmd.Parameters.AddWithValue("@estoque", Convert.ToDouble(txtQuantidade.Text) + Convert.ToDouble(txtEstoque.Text));
            cmd.Parameters.AddWithValue("@valor", txtValor.Text.Replace(",", "."));
            cmd.Parameters.AddWithValue("@fornecedor", cbFornecedor.SelectedValue);
            cmd.Parameters.AddWithValue("@id", Program.idProduto);

            cmd.ExecuteNonQuery();
            con.desconectar();



            MessageBox.Show("Lançamento Feito com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //LANÇAR O VALOR DO PEDIDO NOS GASTOS
            con.conectar();
            sql = "INSERT INTO gastos (descricao, valor, funcionario, data) VALUES (@descricao, @valor, @funcionario, curDate())";
            cmd.Connection = con.conectar();

            cmd.Parameters.AddWithValue("@descricao", "Compra de Produtos");

            cmd.Parameters.AddWithValue("@valor", Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);



            cmd.ExecuteNonQuery();
            con.desconectar();




            //RECUPERAR O ULTIMO ID DO GASTO
            SqlCommand cmdVerificar;
            SqlDataReader reader;
            con.conectar();
            cmdVerificar = new SqlCommand("SELECT id FROM gastos order by id desc LIMIT 1", con.conectar());

            reader = cmdVerificar.ExecuteReader();

            if (reader.HasRows)
            {
                //EXTRAINDO INFORMAÇÕES DA CONSULTA DO LOGIN
                while (reader.Read())
                {
                    ultimoIdGasto = Convert.ToString(reader["id"]);
                }
            }



            //LANÇAR O VALOR DO PEDIDO NAS MOVIMENTAÇÕES
            con.conectar();
            sql = "INSERT INTO movimentacoes (tipo, movimento, valor, funcionario, data, id_movimento) VALUES (@tipo, @movimento, @valor, @funcionario, curDate(), @id_movimento)";
            cmd.Connection = con.conectar();

            cmd.Parameters.AddWithValue("@tipo", "Saída");
            cmd.Parameters.AddWithValue("@movimento", "Gasto");
            cmd.Parameters.AddWithValue("@valor", Convert.ToDouble(txtValor.Text) * Convert.ToDouble(txtQuantidade.Text));
            cmd.Parameters.AddWithValue("@funcionario", Program.nomeUsuario);
            cmd.Parameters.AddWithValue("@id_movimento", ultimoIdGasto);


            cmd.ExecuteNonQuery();
            con.desconectar();

            limparCampos();
            desabilitarCampos();

        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }
    }
}
