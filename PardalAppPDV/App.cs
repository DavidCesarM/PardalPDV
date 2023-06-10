using FontAwesome.Sharp;
using PardalAppPDV.View;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PardalAppPDV
{
    public partial class App : Form
    {


        public static IconButton btnAbrirCaixa_;

        //PrivateFontCollection font = new PrivateFontCollection();
        //font.AddFontFile(@"C:\Users\david\Desktop\Projeto\PardalAppPDV\PardalAppPDV\Fonts\Picole-stencil.ttf");

        public App()
        {

            InitializeComponent();
            content.ItemSize = new Size(0, 1);
            content.Appearance = TabAppearance.FlatButtons;
            content.SizeMode = TabSizeMode.Fixed;


        }



        private void App_Load(object sender, EventArgs e)
        {


            dgInfosCaixa.EnableHeadersVisualStyles = false;

            //dgInfosCaixa.ForeColor = Color.White;
            lblSideItemSelecionado.BringToFront();

          // dgInfosCaixa.Font = new Font("Segoe UI", 30);
            frmMessages.ShowMsg("Logado com suceso! Bem Vindo!", "sucess", this, 400, duration: 3000);

            btnAbrirCaixa_ = btnAbrirCaixa;


        }

        private void App_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSideCaixa_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = 0;
            content.SelectedIndex = 0;
        }

        private void btnSideDescontos_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = 60;
            content.SelectedIndex = 1;
        }

        private void btnSideSangria_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = 120;
            content.SelectedIndex = 2;

        }

        private void btnSideStatus_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = 180;
            content.SelectedIndex = 3;
        }

        private void btnSideRetirada_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = 240;
            content.SelectedIndex = 4;
        }

        private void btnSideMovimentacoes_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = 300;
            content.SelectedIndex = 5;
        }

        private void btnSideFecharCaixa_Click_1(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = 360;
            content.SelectedIndex = 6;
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            AbrirCaixa abrirCaixa = new AbrirCaixa();

            abrirCaixa.TopLevel = false;

            this.Controls.Add(abrirCaixa);
            abrirCaixa.BringToFront();

            abrirCaixa.Show();
        }
        private void btnSideCaixa_MouseEnter(object sender, EventArgs e)
        {
            btnSideCaixa.ForeColor = Color.White;
            btnSideCaixa.IconColor = Color.White;
        }

        private void btnSideCaixa_MouseLeave(object sender, EventArgs e)
        {
            btnSideCaixa.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideCaixa.IconColor = Color.FromArgb(11, 19, 139);
        }

        private void btnSideDescontos_MouseEnter(object sender, EventArgs e)
        {
            btnSideDescontos.ForeColor = Color.White;
            btnSideDescontos.IconColor = Color.White;
        }

        private void btnSideDescontos_MouseLeave(object sender, EventArgs e)
        {
            btnSideDescontos.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideDescontos.IconColor = Color.FromArgb(11, 19, 139);
        }

        private void btnSideSangria_MouseEnter(object sender, EventArgs e)
        {
            btnSideSangria.ForeColor = Color.White;
            btnSideSangria.IconColor = Color.White;
        }

        private void btnSideSangria_MouseLeave(object sender, EventArgs e)
        {
            btnSideSangria.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideSangria.IconColor = Color.FromArgb(11, 19, 139);
        }

        private void btnSideStatus_MouseEnter(object sender, EventArgs e)
        {
            btnSideStatus.ForeColor = Color.White;
            btnSideStatus.IconColor = Color.White;
        }

        private void btnSideStatus_MouseLeave(object sender, EventArgs e)
        {
            btnSideStatus.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideStatus.IconColor = Color.FromArgb(11, 19, 139);
        }

        private void btnSideRetirada_MouseEnter(object sender, EventArgs e)
        {
            btnSideRetirada.ForeColor = Color.White;
            btnSideRetirada.IconColor = Color.White;
        }

        private void btnSideRetirada_MouseLeave(object sender, EventArgs e)
        {
            btnSideRetirada.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideRetirada.IconColor = Color.FromArgb(11, 19, 139);
        }

        private void btnSideMovimentacoes_MouseEnter(object sender, EventArgs e)
        {
            btnSideMovimentacoes.ForeColor = Color.White;
            btnSideMovimentacoes.IconColor = Color.White;
        }

        private void btnSideMovimentacoes_MouseLeave(object sender, EventArgs e)
        {
            btnSideMovimentacoes.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideMovimentacoes.IconColor = Color.FromArgb(11, 19, 139);
        }

        private void btnSideFecharCaixa_MouseEnter(object sender, EventArgs e)
        {
            btnSideFecharCaixa.ForeColor = Color.White;
            btnSideFecharCaixa.IconColor = Color.White;
        }

        private void btnSideFecharCaixa_MouseLeave(object sender, EventArgs e)
        {
            btnSideFecharCaixa.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideFecharCaixa.IconColor = Color.FromArgb(11, 19, 139);
        }
    }
}