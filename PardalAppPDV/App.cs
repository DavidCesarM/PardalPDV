using FontAwesome.Sharp;
using PardalAppPDV.Controller;
using PardalAppPDV.View;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PardalAppPDV
{
    public partial class App : Form
    {


        internal static IconButton? btnAbrirCaixa_;
        Controler c = new Controler();
        double v;
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
            setSizeAndLocationsOfControls();

            dgInfo.EnableHeadersVisualStyles = false;
            dgPesquisar.EnableHeadersVisualStyles = false;
            dgPagamento.EnableHeadersVisualStyles = false;
            // VisualGraphs.RoundBoders(pnparcelasBorder);
            //pnParcelasHolder.BringToFront();
            lblSideItemSelecionado.BringToFront();
            frmMessages.ShowMsg("Logado com suceso! Bem Vindo!", "sucess", this, 400, duration: 3000);
            lblSideItemSelecionado.Location = new Point(sideMenu.Width - lblSideItemSelecionado.Width, 0);
            pbLogo.Location = new Point(Convert.ToInt32((sideHeader.Width / 2) - (pbLogo.Width / 2)), Convert.ToInt32((sideHeader.Height / 2) - (pbLogo.Height / 2)));
            btnAbrirCaixa_ = btnAbrirCaixa;
            cbFormaPagamento.SelectedIndex = 0;

        }


        private void setSizeAndLocationsOfControls()
        {

            //############################## SIDE MENU SIZES ############################################################
            sidebar.Size = new Size(Maths.percent(this.Width, 15), this.Height);

            sideMenu.Size = new Size(sidebar.Width, Maths.percent(sidebar.Height, 70));
            sideHeader.Size = new Size(sidebar.Width, Maths.percent(sidebar.Height, 20));

            /* foreach (Control c in sideMenu.Controls)
             {
                 c.Size = new Size(sideMenu.Width, Maths.percent(sideMenu.Height, 10));
             }
             lblSideItemSelecionado.Size = new Size(5, btnSideVendas.Height);
            */

            sideFooter.Size = new Size(sidebar.Width, Maths.percent(sidebar.Height, 15));
            //##########################################################################################

            //############################## HEADER #############################################################
            header.Height = Maths.percent(this.Height, 5);
            pbLogo.Location = new Point((sideHeader.Width / 2) - (pbLogo.Width / 2), (sideHeader.Height / 2) - (pbLogo.Height / 2));

            pnPesquisar.Location = new Point(dgPesquisar.Left, 0);
            pnPesquisar.Width = dgPesquisar.Width;
            pnTroco.Left = (pnFinalizarVendas.Width - pnTroco.Width) - 15;

            pnParcelasHolder.Left = (pnFormaPag.Left + pnFormaPag.Width) + 10;


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
            lblSideItemSelecionado.Top = lblSideItemSelecionado.Height * 1;
            content.SelectedIndex = 1;
        }

        private void btnSideSangria_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = lblSideItemSelecionado.Height * 2;
            content.SelectedIndex = 2;

        }

        private void btnSideStatus_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = lblSideItemSelecionado.Height * 3;
            content.SelectedIndex = 3;
        }

        private void btnSideRetirada_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = lblSideItemSelecionado.Height * 4;
            content.SelectedIndex = 4;
        }

        private void btnSideMovimentacoes_Click(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = lblSideItemSelecionado.Height * 5;
            content.SelectedIndex = 5;
        }

        private void btnSideFecharCaixa_Click_1(object sender, EventArgs e)
        {
            lblSideItemSelecionado.Top = lblSideItemSelecionado.Height * 6;
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
            btnSideVendas.ForeColor = Color.White;
            btnSideVendas.IconColor = Color.White;
        }

        private void btnSideCaixa_MouseLeave(object sender, EventArgs e)
        {
            btnSideVendas.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideVendas.IconColor = Color.FromArgb(11, 19, 139);
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

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFormaPagamento.Text == "Cart�o")
            {

                pnParcelasHolder.Visible = true;
            }
            else
            {
                pnParcelasHolder.Visible = false;
                txtParcelas.Text = "";
                lblValorParcelas.Text = "0";

            }



        }

        private void txtRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se j� existe alguma v�rgula na string
                if (txtRecebido.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            //aceita apenas n�meros, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void txtParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnLan�ar_Click(object sender, EventArgs e)
        {

        }
    }
}