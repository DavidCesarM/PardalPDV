using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Text;


namespace PardalAppPDV.View
{
    public partial class TelaLogin : Form
    {

        public TelaLogin()
        {
            InitializeComponent();

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

            setSizeAndPointsOfControls();

            VisualGraphs.RoundBoders(this);
            VisualGraphs.RoundBoders(logo);
            VisualGraphs.RoundBoders(logoShadow);
            VisualGraphs.RoundBoders(pnTitulo, true, false, true, false);

            lblSenha.Location = new Point(3, txtSenha.Top);
            lblListraSenha.Width = 0;
            pnLoginHolder.BringToFront();

        }

        private void setSizeAndPointsOfControls()
        {
            double h = System.Windows.SystemParameters.FullPrimaryScreenHeight;
            double w = System.Windows.SystemParameters.FullPrimaryScreenWidth;

            this.Size = new Size(Maths.percent(w, 60), Maths.percent(70, h));
            pnLogin.Width = Maths.percent(this.Width, 50);
            pnTitulo.Width = Maths.percent(this.Width, 50);

            pbTitulo.Size = new Size(Maths.percent(this.Width, 40), Maths.percent(this.Height, 8));
            pbTitulo.Location = new Point(Convert.ToInt32((pnTitulo.Width / 2) - (pbTitulo.Width / 2)), Convert.ToInt32(((pnTitulo.Height / 2) - (pbTitulo.Height / 2))));


            pnFlakesHolder.Location = new Point(Convert.ToInt32((pnLogin.Width - pnFlakesHolder.Width) + 10), 0);

            pbCoracao.Size = new Size(Maths.percent(pnTitulo.Width, 40), Maths.percent(pnTitulo.Height, 30));
            pbCoracao.Location = new Point((pnTitulo.Width - pbCoracao.Width) + (pbCoracao.Width * 10) / 100, pbTitulo.Top + pbTitulo.Height);
            pnLoginHolder.Location = new Point(Convert.ToInt32((pnLogin.Width / 2) - (pnLoginHolder.Width / 2)), Convert.ToInt32((pnLogin.Height / 2) - (pnLoginHolder.Height / 2)));

            pbCupcake.Size = new Size(Maths.percent(pnLogin.Width, 35), Maths.percent(pnLogin.Height, 30));
            pbCupcake.Location = new Point(pnLoginHolder.Left-pbCupcake.Width, pbOndasCinzas.Top-pbCupcake.Height);

            this.Location = new Point(Convert.ToInt32((w / 2) - (this.Width / 2)), Convert.ToInt32((h / 2) - (this.Height / 2)));
        }


        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        //#################Eventos MouseEnter e Mouse Leave dos botões############################

        private void btnLogar_MouseEnter(object sender, EventArgs e)
        {
            shadowBtnEntrar.BackColor = Color.FromArgb(11, 19, 139);
        }
        private void btnLogar_MouseLeave(object sender, EventArgs e)
        {
            shadowBtnEntrar.BackColor = Color.White;
        }
        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.White;
            btnSair.IconColor = Color.White;
            btnSair.FlatAppearance.BorderColor = Color.White;
            shadowBtnSair.BackColor = Color.Brown;
        }
        private void btnSair_MouseLeave(object sender, EventArgs e)
        {

            btnSair.ForeColor = Color.Red;
            btnSair.IconColor = Color.Red;
            btnSair.FlatAppearance.BorderColor = Color.Red;
            shadowBtnSair.BackColor = Color.White;
        }

        //##############################################################################################

        private void btnLogar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == "David" && txtSenha.Text == "123")
            {
                App app = new App();
                this.Hide();

                app.ShowDialog();
            }
            else
            {

                frmMessages.ShowMsg("Nome ou Senha incorreto(s)", "error", this);
            }
        }

        private void txtNome_Enter_1(object sender, EventArgs e)
        {

            lblNome.Visible = true;
            lblListraNome.BackColor = Color.DarkOrange;

            txtNome.ForeColor = Color.DarkOrange;
            timer1.Start();
            timer3.Start();
        }

        private void txtNome_Leave_1(object sender, EventArgs e)
        {
            lblNome.Visible = false;
            lblListraNome.Width = 0;
            timer3.Stop();
            txtNome.ForeColor = SystemColors.ControlDarkDark;
            lblNome.Location = new Point(3, txtNome.Top);

        }

        private void txtSenha_Enter_1(object sender, EventArgs e)
        {
            lblSenha.Visible = true;

            lblListraSenha.BackColor = Color.DarkOrange;

            txtSenha.ForeColor = Color.DarkOrange;
            timer2.Start();
            timer5.Start();
        }

        private void txtSenha_Leave_1(object sender, EventArgs e)
        {
            lblSenha.Visible = false;
            lblListraSenha.Width = 0;
            timer5.Stop();
            txtSenha.ForeColor = SystemColors.ControlDarkDark;

            lblSenha.Location = new Point(3, txtSenha.Top);

        }
        //#########################################################################################################
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNome.Top -= 2;



            if (lblNome.Top <= txtNome.Top - lblNome.Height)
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblSenha.Top -= 2;

            if (lblSenha.Top <= txtSenha.Top - lblSenha.Height)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblListraNome.Width += 10;

            if (lblListraNome.Width >= lblListraNome.MaximumSize.Width)
            {
                timer3.Stop();
            }
        }



        private void timer5_Tick(object sender, EventArgs e)
        {
            lblListraSenha.Width += 10;

            if (lblListraSenha.Width >= lblListraSenha.MaximumSize.Width)
            {
                timer5.Stop();
            }

        }


    }
}
