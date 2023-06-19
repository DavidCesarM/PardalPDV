using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PardalAppPDV.View
{
    public partial class AbrirCaixa : Form
    {


        public AbrirCaixa()
        {
            InitializeComponent();
        }

        private void AbrirCaixa_Load(object sender, EventArgs e)
        {
            App app = new App();
            this.Left = (app.Width / 2) - (this.Width / 2);
            this.Top = (app.Height / 2) - (this.Height / 2);
            VisualGraphs.RoundBoders(this);
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            App.btnAbrirCaixa_.IconColor = Color.PaleGreen;

            App.btnAbrirCaixa_.Text = "Caixa Aberto";
            this.Close();
        }
    }
}
