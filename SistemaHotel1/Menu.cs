using SistemaHotel.Cadastros;
using SistemaHotel.CheckIn;
using SistemaHotel.NewFolder1;
using SistemaHotel.Produtos;
using SistemaHotel.Relatórios;
using SistemaHotel.Reservas;
using SistemaHotel1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel1
{
    public partial class FrmMenu : Form 
    {

        SqlDataReader dr;
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();


        public FrmMenu() 
        {
            InitializeComponent();
        }
        //arrumando inicialização

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);

        //Fazer logout
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            this.Close();
            //Tira o FormPrincipal que estava aberto da memória.
            this.Dispose();
            //Chama o FormLogin, após ter fechado o FormPrincipal.
            FrmLoguin login = new FrmLoguin();
            login.ShowDialog();
        }

        //painéis
        private void FrmMenu_Load(object sender, EventArgs e) 
        {           
            lblNome.Text = loginDaoComando.Nome;
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();
            form.Show();
        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {
            Produto prod = new Produto();
            prod.Show();
        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void label1_Click(object sender, EventArgs e)
        {
#pragma warning restore IDE1006 // Estilos de Nomenclatura

        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void label3_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {
            DateTime agora = DateTime.Now;

        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FrmCheckIn form = new FrmCheckIn();
            form.Show();
        }

        private void MenuReservas_Click(object sender, EventArgs e) 
        {
            SistemaHotel.Reservas.FrmQuartos form = new SistemaHotel.Reservas.FrmQuartos();
                form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            lblHoraa.Text = DateTime.Now.ToString("HH.mm.ss");
            lblDataa.Text = DateTime.Now.ToShortDateString();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Estoque form = new Estoque();
            form.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FrmUsuario form = new FrmUsuario();
            form.Show();
        }

        private void BtnProdutos_Click(object sender, EventArgs e) 
        {
            Produto prod = new Produto();
            prod.Show();
        }

        private void button4_Click(object sender, EventArgs e) 
        {
            FrmCheckIn form = new FrmCheckIn();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            FrmQuartos form = new FrmQuartos();
            form.Show();
        }

        private void BtnRelaórios_Click(object sender, EventArgs e) 
        {
            FrmRelatorios form = new FrmRelatorios();
            form.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            //Tira o FormPrincipal que estava aberto da memória.
            this.Dispose();
            //Chama o FormLogin, após ter fechado o FormPrincipal.
            FrmLoguin login = new FrmLoguin();
            login.ShowDialog();
        }

        private void MenuRelatorios_Click(object sender, EventArgs e) 
        {
            FrmRelatorios form = new FrmRelatorios();
            form.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            FrmCheckout form = new FrmCheckout();
            form.Show();
        }

        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmHospedes form = new FrmHospedes();
            form.Show();
        }

        private void icoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icoRestaurar.Visible = true;
            icoMaximizar.Visible = false;
        }

        private void icoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            icoRestaurar.Visible = false;
            icoMaximizar.Visible = true;
        }

        private void icoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            this.WindowState = FormWindowState.Normal;
            icoRestaurar.Visible = false;
            icoMaximizar.Visible = true;
        }
    }
}
