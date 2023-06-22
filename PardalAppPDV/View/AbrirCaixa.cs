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

        App app = new App();

        public AbrirCaixa()
        {
            InitializeComponent();
            this.Left = (app.Width / 2) - (this.Width / 2);
            this.Top = (app.Height / 2) - (this.Height / 2);
        }

        private void AbrirCaixa_Load(object sender, EventArgs e)
        {
           
           
            VisualGraphs.RoundBoders(this);
        }

        private void btnAbrirCaixa_Click(object sender, EventArgs e)
        {
            App.btnAbrirCaixa_.IconColor = Color.PaleGreen;

            App.btnAbrirCaixa_.Text = "Caixa Aberto - Pronto para vender";
            this.Close();
        }
    }
}
