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
           
            VisualGraphs.RoundBoders(this);
            VisualGraphs.RoundBoders(logo);
            VisualGraphs.RoundBoders(logoShadow);
            VisualGraphs.RoundBoders(pnBoasvindas, true, false, true, false);
         
            lblSenha.Location = new Point(3, 320);
            lblListraSenha.Width = 0;

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
            lblNome.Location = new Point(3, 268);

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

            lblSenha.Location = new Point(3, 320);

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
