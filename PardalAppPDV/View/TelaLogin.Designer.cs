namespace PardalAppPDV.View
{
    partial class TelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            pnLoginHolder = new Panel();
            pnloginBot = new Panel();
            pnButtonsLoginHolder = new Panel();
            btnLogar = new FontAwesome.Sharp.IconButton();
            btnSair = new FontAwesome.Sharp.IconButton();
            lblListraNome = new Label();
            lblNome = new Label();
            lblListraSenha = new Label();
            lblListraCinzaSenha = new Label();
            lblListraCinzaNome = new Label();
            lblSenha = new Label();
            txtNome = new TextBox();
            txtSenha = new TextBox();
            logo = new PictureBox();
            logoShadow = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            pnTitulo = new Panel();
            pbCoracao = new PictureBox();
            pbTitulo = new PictureBox();
            bpFlakes4 = new FontAwesome.Sharp.IconPictureBox();
            pbFlakes3 = new FontAwesome.Sharp.IconPictureBox();
            pbFlakes2 = new FontAwesome.Sharp.IconPictureBox();
            pbFlakes1 = new FontAwesome.Sharp.IconPictureBox();
            pbOndasAmarelas = new PictureBox();
            pnLogin = new Panel();
            pnFlakesHolder = new Panel();
            pbFlakes5 = new FontAwesome.Sharp.IconPictureBox();
            pbFlakes6 = new FontAwesome.Sharp.IconPictureBox();
            pbFlakes7 = new FontAwesome.Sharp.IconPictureBox();
            pbFlakes8 = new FontAwesome.Sharp.IconPictureBox();
            pbCupcake = new PictureBox();
            pnLoginHolder.SuspendLayout();
            pnloginBot.SuspendLayout();
            pnButtonsLoginHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoShadow).BeginInit();
            pnTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoracao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bpFlakes4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOndasAmarelas).BeginInit();
            pnLogin.SuspendLayout();
            pnFlakesHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFlakes5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCupcake).BeginInit();
            SuspendLayout();
            // 
            // pnLoginHolder
            // 
            pnLoginHolder.Controls.Add(pnloginBot);
            pnLoginHolder.Controls.Add(logo);
            pnLoginHolder.Controls.Add(logoShadow);
            pnLoginHolder.Location = new Point(151, 137);
            pnLoginHolder.Name = "pnLoginHolder";
            pnLoginHolder.Size = new Size(277, 403);
            pnLoginHolder.TabIndex = 3;
            // 
            // pnloginBot
            // 
            pnloginBot.Controls.Add(pnButtonsLoginHolder);
            pnloginBot.Controls.Add(lblListraNome);
            pnloginBot.Controls.Add(lblNome);
            pnloginBot.Controls.Add(lblListraSenha);
            pnloginBot.Controls.Add(lblListraCinzaSenha);
            pnloginBot.Controls.Add(lblListraCinzaNome);
            pnloginBot.Controls.Add(lblSenha);
            pnloginBot.Controls.Add(txtNome);
            pnloginBot.Controls.Add(txtSenha);
            pnloginBot.Location = new Point(0, 213);
            pnloginBot.Name = "pnloginBot";
            pnloginBot.Size = new Size(277, 190);
            pnloginBot.TabIndex = 84;
            // 
            // pnButtonsLoginHolder
            // 
            pnButtonsLoginHolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pnButtonsLoginHolder.Controls.Add(btnLogar);
            pnButtonsLoginHolder.Controls.Add(btnSair);
            pnButtonsLoginHolder.Location = new Point(30, 114);
            pnButtonsLoginHolder.Name = "pnButtonsLoginHolder";
            pnButtonsLoginHolder.Size = new Size(211, 52);
            pnButtonsLoginHolder.TabIndex = 89;
            // 
            // btnLogar
            // 
            btnLogar.BackColor = Color.FromArgb(76, 195, 223);
            btnLogar.Cursor = Cursors.Hand;
            btnLogar.FlatAppearance.BorderColor = Color.White;
            btnLogar.FlatAppearance.MouseOverBackColor = Color.DarkOrange;
            btnLogar.FlatStyle = FlatStyle.Flat;
            btnLogar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogar.ForeColor = Color.White;
            btnLogar.IconChar = FontAwesome.Sharp.IconChar.IceCream;
            btnLogar.IconColor = Color.White;
            btnLogar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogar.IconSize = 20;
            btnLogar.Location = new Point(3, 5);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(93, 44);
            btnLogar.TabIndex = 77;
            btnLogar.Text = "Entrar";
            btnLogar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogar.UseVisualStyleBackColor = false;
            btnLogar.Click += btnLogar_Click_1;
            btnLogar.MouseEnter += btnLogar_MouseEnter;
            btnLogar.MouseLeave += btnLogar_MouseLeave;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSair.BackColor = SystemColors.Window;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderColor = Color.Red;
            btnSair.FlatAppearance.MouseDownBackColor = Color.LightSalmon;
            btnSair.FlatAppearance.MouseOverBackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSair.ForeColor = Color.Red;
            btnSair.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnSair.IconColor = Color.Red;
            btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSair.IconSize = 25;
            btnSair.Location = new Point(115, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(93, 44);
            btnSair.TabIndex = 78;
            btnSair.Text = "Sair";
            btnSair.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click_1;
            btnSair.MouseEnter += btnSair_MouseEnter;
            btnSair.MouseLeave += btnSair_MouseLeave;
            // 
            // lblListraNome
            // 
            lblListraNome.BackColor = Color.Navy;
            lblListraNome.ForeColor = Color.Cornsilk;
            lblListraNome.Location = new Point(2, 45);
            lblListraNome.MaximumSize = new Size(274, 20);
            lblListraNome.Name = "lblListraNome";
            lblListraNome.Size = new Size(274, 2);
            lblListraNome.TabIndex = 88;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.ForeColor = Color.DarkOrange;
            lblNome.Location = new Point(-1, 4);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 20);
            lblNome.TabIndex = 79;
            lblNome.Text = "Nome";
            lblNome.Visible = false;
            // 
            // lblListraSenha
            // 
            lblListraSenha.BackColor = Color.Navy;
            lblListraSenha.ForeColor = Color.Cornsilk;
            lblListraSenha.Location = new Point(2, 100);
            lblListraSenha.MaximumSize = new Size(274, 20);
            lblListraSenha.Name = "lblListraSenha";
            lblListraSenha.Size = new Size(274, 2);
            lblListraSenha.TabIndex = 87;
            // 
            // lblListraCinzaSenha
            // 
            lblListraCinzaSenha.BackColor = SystemColors.AppWorkspace;
            lblListraCinzaSenha.ForeColor = Color.Cornsilk;
            lblListraCinzaSenha.Location = new Point(2, 100);
            lblListraCinzaSenha.MaximumSize = new Size(274, 20);
            lblListraCinzaSenha.Name = "lblListraCinzaSenha";
            lblListraCinzaSenha.Size = new Size(274, 2);
            lblListraCinzaSenha.TabIndex = 85;
            // 
            // lblListraCinzaNome
            // 
            lblListraCinzaNome.BackColor = SystemColors.AppWorkspace;
            lblListraCinzaNome.ForeColor = Color.Cornsilk;
            lblListraCinzaNome.Location = new Point(-2, 45);
            lblListraCinzaNome.MaximumSize = new Size(274, 20);
            lblListraCinzaNome.Name = "lblListraCinzaNome";
            lblListraCinzaNome.Size = new Size(274, 2);
            lblListraCinzaNome.TabIndex = 84;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.DarkOrange;
            lblSenha.Location = new Point(2, 56);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(51, 20);
            lblSenha.TabIndex = 80;
            lblSenha.Text = "Senha";
            lblSenha.Visible = false;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.White;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.ControlDarkDark;
            txtNome.Location = new Point(2, 22);
            txtNome.MaximumSize = new Size(274, 20);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(274, 20);
            txtNome.TabIndex = 0;
            txtNome.Enter += txtNome_Enter_1;
            txtNome.Leave += txtNome_Leave_1;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.White;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.ForeColor = SystemColors.ControlDarkDark;
            txtSenha.Location = new Point(2, 79);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(274, 20);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.Enter += txtSenha_Enter_1;
            txtSenha.Leave += txtSenha_Leave_1;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(49, 3);
            logo.Name = "logo";
            logo.Size = new Size(172, 173);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 83;
            logo.TabStop = false;
            // 
            // logoShadow
            // 
            logoShadow.BackColor = Color.FromArgb(224, 224, 224);
            logoShadow.Location = new Point(57, 13);
            logoShadow.Name = "logoShadow";
            logoShadow.Size = new Size(172, 171);
            logoShadow.SizeMode = PictureBoxSizeMode.StretchImage;
            logoShadow.TabIndex = 83;
            logoShadow.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1;
            timer3.Tick += timer3_Tick;
            // 
            // timer5
            // 
            timer5.Interval = 1;
            timer5.Tick += timer5_Tick;
            // 
            // pnTitulo
            // 
            pnTitulo.BackColor = Color.FromArgb(255, 120, 0);
            pnTitulo.Controls.Add(pbCoracao);
            pnTitulo.Controls.Add(pbTitulo);
            pnTitulo.Controls.Add(bpFlakes4);
            pnTitulo.Controls.Add(pbFlakes3);
            pnTitulo.Controls.Add(pbFlakes2);
            pnTitulo.Controls.Add(pbFlakes1);
            pnTitulo.Controls.Add(pbOndasAmarelas);
            pnTitulo.Dock = DockStyle.Right;
            pnTitulo.Location = new Point(580, 0);
            pnTitulo.Name = "pnTitulo";
            pnTitulo.Size = new Size(580, 700);
            pnTitulo.TabIndex = 87;
            // 
            // pbCoracao
            // 
            pbCoracao.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbCoracao.Image = (Image)resources.GetObject("pbCoracao.Image");
            pbCoracao.Location = new Point(393, 350);
            pbCoracao.Name = "pbCoracao";
            pbCoracao.Size = new Size(211, 190);
            pbCoracao.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCoracao.TabIndex = 86;
            pbCoracao.TabStop = false;
            // 
            // pbTitulo
            // 
            pbTitulo.Image = (Image)resources.GetObject("pbTitulo.Image");
            pbTitulo.Location = new Point(60, 293);
            pbTitulo.Name = "pbTitulo";
            pbTitulo.Size = new Size(504, 60);
            pbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitulo.TabIndex = 85;
            pbTitulo.TabStop = false;
            // 
            // bpFlakes4
            // 
            bpFlakes4.BackColor = Color.Transparent;
            bpFlakes4.ForeColor = Color.FromArgb(255, 152, 0);
            bpFlakes4.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            bpFlakes4.IconColor = Color.FromArgb(255, 152, 0);
            bpFlakes4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bpFlakes4.IconSize = 39;
            bpFlakes4.Location = new Point(6, 123);
            bpFlakes4.Name = "bpFlakes4";
            bpFlakes4.Size = new Size(39, 43);
            bpFlakes4.SizeMode = PictureBoxSizeMode.StretchImage;
            bpFlakes4.TabIndex = 24;
            bpFlakes4.TabStop = false;
            // 
            // pbFlakes3
            // 
            pbFlakes3.BackColor = Color.Transparent;
            pbFlakes3.ForeColor = Color.FromArgb(255, 152, 0);
            pbFlakes3.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            pbFlakes3.IconColor = Color.FromArgb(255, 152, 0);
            pbFlakes3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbFlakes3.IconSize = 47;
            pbFlakes3.Location = new Point(6, 64);
            pbFlakes3.Name = "pbFlakes3";
            pbFlakes3.Size = new Size(53, 47);
            pbFlakes3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlakes3.TabIndex = 22;
            pbFlakes3.TabStop = false;
            // 
            // pbFlakes2
            // 
            pbFlakes2.BackColor = Color.Transparent;
            pbFlakes2.ForeColor = Color.FromArgb(255, 152, 0);
            pbFlakes2.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            pbFlakes2.IconColor = Color.FromArgb(255, 152, 0);
            pbFlakes2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbFlakes2.IconSize = 82;
            pbFlakes2.Location = new Point(60, 84);
            pbFlakes2.Name = "pbFlakes2";
            pbFlakes2.Size = new Size(88, 82);
            pbFlakes2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlakes2.TabIndex = 21;
            pbFlakes2.TabStop = false;
            // 
            // pbFlakes1
            // 
            pbFlakes1.BackColor = Color.Transparent;
            pbFlakes1.ForeColor = Color.FromArgb(255, 152, 0);
            pbFlakes1.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            pbFlakes1.IconColor = Color.FromArgb(255, 152, 0);
            pbFlakes1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbFlakes1.IconSize = 138;
            pbFlakes1.Location = new Point(29, -39);
            pbFlakes1.Name = "pbFlakes1";
            pbFlakes1.Size = new Size(138, 141);
            pbFlakes1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlakes1.TabIndex = 20;
            pbFlakes1.TabStop = false;
            // 
            // pbOndasAmarelas
            // 
            pbOndasAmarelas.Dock = DockStyle.Bottom;
            pbOndasAmarelas.Image = (Image)resources.GetObject("pbOndasAmarelas.Image");
            pbOndasAmarelas.Location = new Point(0, 642);
            pbOndasAmarelas.Name = "pbOndasAmarelas";
            pbOndasAmarelas.Size = new Size(580, 58);
            pbOndasAmarelas.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOndasAmarelas.TabIndex = 4;
            pbOndasAmarelas.TabStop = false;
            // 
            // pnLogin
            // 
            pnLogin.Controls.Add(pnFlakesHolder);
            pnLogin.Controls.Add(pbCupcake);
            pnLogin.Controls.Add(pnLoginHolder);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.Location = new Point(0, 0);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(580, 700);
            pnLogin.TabIndex = 88;
            // 
            // pnFlakesHolder
            // 
            pnFlakesHolder.Controls.Add(pbFlakes5);
            pnFlakesHolder.Controls.Add(pbFlakes6);
            pnFlakesHolder.Controls.Add(pbFlakes7);
            pnFlakesHolder.Controls.Add(pbFlakes8);
            pnFlakesHolder.Location = new Point(434, 12);
            pnFlakesHolder.Name = "pnFlakesHolder";
            pnFlakesHolder.Size = new Size(146, 241);
            pnFlakesHolder.TabIndex = 84;
            // 
            // pbFlakes5
            // 
            pbFlakes5.BackColor = Color.White;
            pbFlakes5.ForeColor = Color.FromArgb(153, 221, 237);
            pbFlakes5.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            pbFlakes5.IconColor = Color.FromArgb(153, 221, 237);
            pbFlakes5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbFlakes5.IconSize = 138;
            pbFlakes5.Location = new Point(65, 3);
            pbFlakes5.Name = "pbFlakes5";
            pbFlakes5.Size = new Size(138, 141);
            pbFlakes5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlakes5.TabIndex = 77;
            pbFlakes5.TabStop = false;
            // 
            // pbFlakes6
            // 
            pbFlakes6.BackColor = Color.White;
            pbFlakes6.ForeColor = Color.FromArgb(153, 221, 237);
            pbFlakes6.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            pbFlakes6.IconColor = Color.FromArgb(153, 221, 237);
            pbFlakes6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbFlakes6.IconSize = 82;
            pbFlakes6.Location = new Point(66, 150);
            pbFlakes6.Name = "pbFlakes6";
            pbFlakes6.Size = new Size(88, 82);
            pbFlakes6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlakes6.TabIndex = 78;
            pbFlakes6.TabStop = false;
            // 
            // pbFlakes7
            // 
            pbFlakes7.BackColor = Color.White;
            pbFlakes7.ForeColor = Color.FromArgb(153, 221, 237);
            pbFlakes7.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            pbFlakes7.IconColor = Color.FromArgb(153, 221, 237);
            pbFlakes7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbFlakes7.IconSize = 47;
            pbFlakes7.Location = new Point(6, 97);
            pbFlakes7.Name = "pbFlakes7";
            pbFlakes7.Size = new Size(53, 47);
            pbFlakes7.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlakes7.TabIndex = 79;
            pbFlakes7.TabStop = false;
            // 
            // pbFlakes8
            // 
            pbFlakes8.BackColor = Color.White;
            pbFlakes8.ForeColor = Color.FromArgb(153, 221, 237);
            pbFlakes8.IconChar = FontAwesome.Sharp.IconChar.Snowflake;
            pbFlakes8.IconColor = Color.FromArgb(153, 221, 237);
            pbFlakes8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbFlakes8.IconSize = 39;
            pbFlakes8.Location = new Point(32, 157);
            pbFlakes8.Name = "pbFlakes8";
            pbFlakes8.Size = new Size(39, 43);
            pbFlakes8.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFlakes8.TabIndex = 80;
            pbFlakes8.TabStop = false;
            // 
            // pbCupcake
            // 
            pbCupcake.Image = (Image)resources.GetObject("pbCupcake.Image");
            pbCupcake.Location = new Point(-26, 355);
            pbCupcake.Name = "pbCupcake";
            pbCupcake.Size = new Size(174, 185);
            pbCupcake.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCupcake.TabIndex = 83;
            pbCupcake.TabStop = false;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1160, 700);
            Controls.Add(pnLogin);
            Controls.Add(pnTitulo);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            pnLoginHolder.ResumeLayout(false);
            pnloginBot.ResumeLayout(false);
            pnloginBot.PerformLayout();
            pnButtonsLoginHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoShadow).EndInit();
            pnTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCoracao).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bpFlakes4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOndasAmarelas).EndInit();
            pnLogin.ResumeLayout(false);
            pnFlakesHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFlakes5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFlakes8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCupcake).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnLoginHolder;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnLogar;
        private Label lblSenha;
        private Label lblNome;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtSenha;
        private System.Windows.Forms.Timer timer2;
        private PictureBox logo;
        private PictureBox logoShadow;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer5;
        private Label lblListraCinzaSenha;
        private Label lblListraCinzaNome;
        private Label lblListraSenha;
        private TextBox txtNome;

        private Panel pnTitulo;
        private PictureBox pbTitulo;
        private FontAwesome.Sharp.IconPictureBox bpFlakes4;
        private FontAwesome.Sharp.IconPictureBox pbFlakes3;
        private FontAwesome.Sharp.IconPictureBox pbFlakes2;
        private FontAwesome.Sharp.IconPictureBox pbFlakes1;
        private PictureBox pbOndasAmarelas;
        private Panel pnLogin;
        private PictureBox pbCupcake;
        private PictureBox pbCoracao;
        private Panel pnFlakesHolder;
        private FontAwesome.Sharp.IconPictureBox pbFlakes5;
        private FontAwesome.Sharp.IconPictureBox pbFlakes6;
        private FontAwesome.Sharp.IconPictureBox pbFlakes7;
        private FontAwesome.Sharp.IconPictureBox pbFlakes8;
        private Panel pnloginBot;
        private Label lblListraNome;
        private Panel pnButtonsLoginHolder;
    }
}