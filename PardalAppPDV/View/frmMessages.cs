using PardalAppPDV.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PardalAppPDV.View
{

    public partial class frmMessages : Form
    {
        static private int h = 90;
        static private int time = 0;


        public frmMessages()
        {
            InitializeComponent();


        }


        private void frmMessages_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }


        static public void ShowMsg(string msg, string type, Form parent, int w = 380, int h = 90,
            string position = "bot-right", int padX = 10, int padY = 10, int duration = 1500)
        {
            time = duration;
            frmMessages frmMsg = new frmMessages();
            frmMsg.Size = new Size(w, h);
            frmMsg.btnIcon.IconColor = Color.White;
            frmMsg.lblMsg.Text = msg;
            VisualGraphs.RoundBoders(frmMsg);
            frmMsg.TopLevel = false;
            parent.Controls.Add(frmMsg);
            parent.Tag = msg;
            frmMsg.BringToFront();


            switch (position)
            {
                case "top-left":
                    frmMsg.Left = 10;
                    frmMsg.Top = 10;
                    break;

                case "top-right":
                    frmMsg.Left = (parent.Width - frmMsg.Width) - padX;
                    frmMsg.Top = padY;
                    break;

                case "bot-left":
                    frmMsg.Left = padX;
                    frmMsg.Top = (parent.Height - frmMsg.Height) - padY;
                    break;

                case "bot-right":
                    frmMsg.Left = (parent.Width - frmMsg.Width) - padX;
                    frmMsg.Top = (parent.Height - frmMsg.Height) - padY;
                    break;

                case "mid-top":
                    frmMsg.Left = ((parent.Width / 2) - (frmMsg.Width / 2));
                    frmMsg.Top = padY;
                    break;

                case "mid-bot":
                    frmMsg.Left = ((parent.Width / 2) - (frmMsg.Width / 2));
                    frmMsg.Top = (parent.Height - frmMsg.Height) - padY;
                    break;

                case "mid-left":
                    frmMsg.Left = padX;
                    frmMsg.Top = (parent.Height / 2) - (frmMsg.Height / 2);
                    break;

                case "mid-right":
                    frmMsg.Left = (parent.Width - frmMsg.Width) - padX;
                    frmMsg.Top = (parent.Height / 2) - (frmMsg.Height / 2);
                    break;

                case "center":
                    frmMsg.Left = (parent.Width / 2) - (frmMsg.Width / 2);
                    frmMsg.Top = (parent.Height / 2) - (frmMsg.Height / 2);
                    break;
            }



            switch (type)
            {
                case "sucess":


                    frmMsg.btnIcon.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    frmMsg.BackColor = Color.SeaGreen;



                    break;

                case "error":

                    frmMsg.btnIcon.IconChar = FontAwesome.Sharp.IconChar.Bomb;
                    frmMsg.BackColor = Color.Red;


                    break;

                case "warning":

                    frmMsg.btnIcon.IconChar = FontAwesome.Sharp.IconChar.Warning;
                    frmMsg.BackColor = Color.Purple;


                    break;

            }
           
           
            frmMsg.Show();
        }


        private void btnIcon_Click(object sender, EventArgs e)
        {

        }
        int tempo = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo += 1000;

            if (tempo >= time)
            {
                this.Close();
                timer1.Stop();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
    }
}
