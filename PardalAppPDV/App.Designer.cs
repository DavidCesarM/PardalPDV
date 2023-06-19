namespace PardalAppPDV
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            sidebar = new Panel();
            sideFooter = new Panel();
            pbCirculoAzul = new PictureBox();
            sideMenu = new Panel();
            btnSideFecharCaixa = new FontAwesome.Sharp.IconButton();
            btnSideMovimentacoes = new FontAwesome.Sharp.IconButton();
            btnSideRetirada = new FontAwesome.Sharp.IconButton();
            btnSideStatus = new FontAwesome.Sharp.IconButton();
            btnSideSangria = new FontAwesome.Sharp.IconButton();
            lblSideItemSelecionado = new Label();
            btnSideDescontos = new FontAwesome.Sharp.IconButton();
            btnSideVendas = new FontAwesome.Sharp.IconButton();
            sideHeader = new Panel();
            pbLogo = new PictureBox();
            pbCirculoLaranja = new PictureBox();
            header = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnAbrirCaixa = new FontAwesome.Sharp.IconButton();
            body = new Panel();
            content = new TabControl();
            caixa = new TabPage();
            pnCaixaBody = new Panel();
            pn = new Panel();
            panel1 = new Panel();
            dgPesquisar = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            estoque = new DataGridViewTextBoxColumn();
            label5 = new Label();
            dgInfo = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            desc = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            desconto = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            pnCaixaHeader = new Panel();
            btnPesquisar = new FontAwesome.Sharp.IconButton();
            txtPesquisar = new TextBox();
            descontos = new TabPage();
            lblFecharCaixa = new Label();
            sangria = new TabPage();
            lblSangria = new Label();
            status = new TabPage();
            label1 = new Label();
            retiradas = new TabPage();
            label2 = new Label();
            movimentacoes = new TabPage();
            label3 = new Label();
            fecharcaixa = new TabPage();
            label4 = new Label();
            sidebar.SuspendLayout();
            sideFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCirculoAzul).BeginInit();
            sideMenu.SuspendLayout();
            sideHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCirculoLaranja).BeginInit();
            header.SuspendLayout();
            body.SuspendLayout();
            content.SuspendLayout();
            caixa.SuspendLayout();
            pnCaixaBody.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPesquisar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgInfo).BeginInit();
            pnCaixaHeader.SuspendLayout();
            descontos.SuspendLayout();
            sangria.SuspendLayout();
            status.SuspendLayout();
            retiradas.SuspendLayout();
            movimentacoes.SuspendLayout();
            fecharcaixa.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(sideFooter);
            sidebar.Controls.Add(sideMenu);
            sidebar.Controls.Add(sideHeader);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(220, 1000);
            sidebar.TabIndex = 0;
            // 
            // sideFooter
            // 
            sideFooter.Controls.Add(pbCirculoAzul);
            sideFooter.Dock = DockStyle.Bottom;
            sideFooter.Location = new Point(0, 746);
            sideFooter.Name = "sideFooter";
            sideFooter.Size = new Size(220, 254);
            sideFooter.TabIndex = 2;
            // 
            // pbCirculoAzul
            // 
            pbCirculoAzul.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pbCirculoAzul.Image = (Image)resources.GetObject("pbCirculoAzul.Image");
            pbCirculoAzul.Location = new Point(78, 140);
            pbCirculoAzul.Name = "pbCirculoAzul";
            pbCirculoAzul.Size = new Size(166, 174);
            pbCirculoAzul.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCirculoAzul.TabIndex = 2;
            pbCirculoAzul.TabStop = false;
            // 
            // sideMenu
            // 
            sideMenu.Controls.Add(btnSideFecharCaixa);
            sideMenu.Controls.Add(btnSideMovimentacoes);
            sideMenu.Controls.Add(btnSideRetirada);
            sideMenu.Controls.Add(btnSideStatus);
            sideMenu.Controls.Add(btnSideSangria);
            sideMenu.Controls.Add(lblSideItemSelecionado);
            sideMenu.Controls.Add(btnSideDescontos);
            sideMenu.Controls.Add(btnSideVendas);
            sideMenu.Dock = DockStyle.Top;
            sideMenu.Location = new Point(0, 213);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(220, 483);
            sideMenu.TabIndex = 1;
            // 
            // btnSideFecharCaixa
            // 
            btnSideFecharCaixa.AutoSize = true;
            btnSideFecharCaixa.BackColor = Color.Transparent;
            btnSideFecharCaixa.Dock = DockStyle.Top;
            btnSideFecharCaixa.FlatAppearance.BorderSize = 0;
            btnSideFecharCaixa.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideFecharCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideFecharCaixa.FlatStyle = FlatStyle.Flat;
            btnSideFecharCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideFecharCaixa.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideFecharCaixa.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btnSideFecharCaixa.IconColor = Color.FromArgb(11, 19, 139);
            btnSideFecharCaixa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideFecharCaixa.IconSize = 25;
            btnSideFecharCaixa.Location = new Point(0, 360);
            btnSideFecharCaixa.Name = "btnSideFecharCaixa";
            btnSideFecharCaixa.Padding = new Padding(30, 0, 0, 0);
            btnSideFecharCaixa.Size = new Size(220, 60);
            btnSideFecharCaixa.TabIndex = 11;
            btnSideFecharCaixa.Text = "Fechar Caixa";
            btnSideFecharCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideFecharCaixa.UseVisualStyleBackColor = false;
            btnSideFecharCaixa.Click += btnSideFecharCaixa_Click_1;
            btnSideFecharCaixa.MouseEnter += btnSideFecharCaixa_MouseEnter;
            btnSideFecharCaixa.MouseLeave += btnSideFecharCaixa_MouseLeave;
            // 
            // btnSideMovimentacoes
            // 
            btnSideMovimentacoes.AutoSize = true;
            btnSideMovimentacoes.BackColor = Color.Transparent;
            btnSideMovimentacoes.Dock = DockStyle.Top;
            btnSideMovimentacoes.FlatAppearance.BorderSize = 0;
            btnSideMovimentacoes.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideMovimentacoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideMovimentacoes.FlatStyle = FlatStyle.Flat;
            btnSideMovimentacoes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideMovimentacoes.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideMovimentacoes.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            btnSideMovimentacoes.IconColor = Color.FromArgb(11, 19, 139);
            btnSideMovimentacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideMovimentacoes.IconSize = 25;
            btnSideMovimentacoes.Location = new Point(0, 300);
            btnSideMovimentacoes.Name = "btnSideMovimentacoes";
            btnSideMovimentacoes.Padding = new Padding(30, 0, 0, 0);
            btnSideMovimentacoes.Size = new Size(220, 60);
            btnSideMovimentacoes.TabIndex = 10;
            btnSideMovimentacoes.Text = "Movimentações";
            btnSideMovimentacoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMovimentacoes.UseVisualStyleBackColor = false;
            btnSideMovimentacoes.Click += btnSideMovimentacoes_Click;
            btnSideMovimentacoes.MouseEnter += btnSideMovimentacoes_MouseEnter;
            btnSideMovimentacoes.MouseLeave += btnSideMovimentacoes_MouseLeave;
            // 
            // btnSideRetirada
            // 
            btnSideRetirada.AutoSize = true;
            btnSideRetirada.BackColor = Color.Transparent;
            btnSideRetirada.Dock = DockStyle.Top;
            btnSideRetirada.FlatAppearance.BorderSize = 0;
            btnSideRetirada.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideRetirada.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideRetirada.FlatStyle = FlatStyle.Flat;
            btnSideRetirada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideRetirada.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideRetirada.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            btnSideRetirada.IconColor = Color.FromArgb(11, 19, 139);
            btnSideRetirada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideRetirada.IconSize = 25;
            btnSideRetirada.Location = new Point(0, 240);
            btnSideRetirada.Name = "btnSideRetirada";
            btnSideRetirada.Padding = new Padding(30, 0, 0, 0);
            btnSideRetirada.Size = new Size(220, 60);
            btnSideRetirada.TabIndex = 9;
            btnSideRetirada.Text = "Retiradas";
            btnSideRetirada.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideRetirada.UseVisualStyleBackColor = false;
            btnSideRetirada.Click += btnSideRetirada_Click;
            btnSideRetirada.MouseEnter += btnSideRetirada_MouseEnter;
            btnSideRetirada.MouseLeave += btnSideRetirada_MouseLeave;
            // 
            // btnSideStatus
            // 
            btnSideStatus.AutoSize = true;
            btnSideStatus.BackColor = Color.Transparent;
            btnSideStatus.Dock = DockStyle.Top;
            btnSideStatus.FlatAppearance.BorderSize = 0;
            btnSideStatus.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideStatus.FlatStyle = FlatStyle.Flat;
            btnSideStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideStatus.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideStatus.IconChar = FontAwesome.Sharp.IconChar.Scroll;
            btnSideStatus.IconColor = Color.FromArgb(11, 19, 139);
            btnSideStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideStatus.IconSize = 25;
            btnSideStatus.Location = new Point(0, 180);
            btnSideStatus.Name = "btnSideStatus";
            btnSideStatus.Padding = new Padding(30, 0, 0, 0);
            btnSideStatus.Size = new Size(220, 60);
            btnSideStatus.TabIndex = 8;
            btnSideStatus.Text = "Status";
            btnSideStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideStatus.UseVisualStyleBackColor = false;
            btnSideStatus.Click += btnSideStatus_Click;
            btnSideStatus.MouseEnter += btnSideStatus_MouseEnter;
            btnSideStatus.MouseLeave += btnSideStatus_MouseLeave;
            // 
            // btnSideSangria
            // 
            btnSideSangria.AutoSize = true;
            btnSideSangria.BackColor = Color.Transparent;
            btnSideSangria.Dock = DockStyle.Top;
            btnSideSangria.FlatAppearance.BorderSize = 0;
            btnSideSangria.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideSangria.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideSangria.FlatStyle = FlatStyle.Flat;
            btnSideSangria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideSangria.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideSangria.IconChar = FontAwesome.Sharp.IconChar.Vault;
            btnSideSangria.IconColor = Color.FromArgb(11, 19, 139);
            btnSideSangria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideSangria.IconSize = 25;
            btnSideSangria.Location = new Point(0, 120);
            btnSideSangria.Name = "btnSideSangria";
            btnSideSangria.Padding = new Padding(30, 0, 0, 0);
            btnSideSangria.Size = new Size(220, 60);
            btnSideSangria.TabIndex = 7;
            btnSideSangria.Text = "Sangria";
            btnSideSangria.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideSangria.UseVisualStyleBackColor = false;
            btnSideSangria.Click += btnSideSangria_Click;
            btnSideSangria.MouseEnter += btnSideSangria_MouseEnter;
            btnSideSangria.MouseLeave += btnSideSangria_MouseLeave;
            // 
            // lblSideItemSelecionado
            // 
            lblSideItemSelecionado.BackColor = Color.Orange;
            lblSideItemSelecionado.Location = new Point(215, 0);
            lblSideItemSelecionado.Name = "lblSideItemSelecionado";
            lblSideItemSelecionado.Size = new Size(5, 60);
            lblSideItemSelecionado.TabIndex = 5;
            // 
            // btnSideDescontos
            // 
            btnSideDescontos.AutoSize = true;
            btnSideDescontos.BackColor = Color.Transparent;
            btnSideDescontos.Dock = DockStyle.Top;
            btnSideDescontos.FlatAppearance.BorderSize = 0;
            btnSideDescontos.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideDescontos.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideDescontos.FlatStyle = FlatStyle.Flat;
            btnSideDescontos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideDescontos.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideDescontos.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            btnSideDescontos.IconColor = Color.FromArgb(11, 19, 139);
            btnSideDescontos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideDescontos.IconSize = 25;
            btnSideDescontos.Location = new Point(0, 60);
            btnSideDescontos.Name = "btnSideDescontos";
            btnSideDescontos.Padding = new Padding(30, 0, 0, 0);
            btnSideDescontos.Size = new Size(220, 60);
            btnSideDescontos.TabIndex = 5;
            btnSideDescontos.Text = "Descontos";
            btnSideDescontos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideDescontos.UseVisualStyleBackColor = false;
            btnSideDescontos.Click += btnSideDescontos_Click;
            btnSideDescontos.MouseEnter += btnSideDescontos_MouseEnter;
            btnSideDescontos.MouseLeave += btnSideDescontos_MouseLeave;
            // 
            // btnSideVendas
            // 
            btnSideVendas.AutoSize = true;
            btnSideVendas.BackColor = Color.Transparent;
            btnSideVendas.Dock = DockStyle.Top;
            btnSideVendas.FlatAppearance.BorderSize = 0;
            btnSideVendas.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideVendas.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideVendas.FlatStyle = FlatStyle.Flat;
            btnSideVendas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideVendas.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideVendas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnSideVendas.IconColor = Color.FromArgb(11, 19, 139);
            btnSideVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideVendas.IconSize = 25;
            btnSideVendas.Location = new Point(0, 0);
            btnSideVendas.Name = "btnSideVendas";
            btnSideVendas.Padding = new Padding(30, 0, 0, 0);
            btnSideVendas.Size = new Size(220, 60);
            btnSideVendas.TabIndex = 4;
            btnSideVendas.Text = "Vendas";
            btnSideVendas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideVendas.UseVisualStyleBackColor = false;
            btnSideVendas.Click += btnSideCaixa_Click;
            btnSideVendas.MouseEnter += btnSideCaixa_MouseEnter;
            btnSideVendas.MouseLeave += btnSideCaixa_MouseLeave;
            // 
            // sideHeader
            // 
            sideHeader.Controls.Add(pbLogo);
            sideHeader.Controls.Add(pbCirculoLaranja);
            sideHeader.Dock = DockStyle.Top;
            sideHeader.Location = new Point(0, 0);
            sideHeader.Name = "sideHeader";
            sideHeader.Size = new Size(220, 213);
            sideHeader.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(31, 39);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(163, 143);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // pbCirculoLaranja
            // 
            pbCirculoLaranja.Image = (Image)resources.GetObject("pbCirculoLaranja.Image");
            pbCirculoLaranja.Location = new Point(-56, -43);
            pbCirculoLaranja.Name = "pbCirculoLaranja";
            pbCirculoLaranja.Size = new Size(94, 113);
            pbCirculoLaranja.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCirculoLaranja.TabIndex = 3;
            pbCirculoLaranja.TabStop = false;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(11, 19, 139);
            header.Controls.Add(iconButton1);
            header.Controls.Add(btnAbrirCaixa);
            header.Dock = DockStyle.Top;
            header.Location = new Point(220, 0);
            header.Name = "header";
            header.Size = new Size(1720, 51);
            header.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(1525, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(5, 0, 0, 0);
            iconButton1.Size = new Size(195, 51);
            iconButton1.TabIndex = 14;
            iconButton1.Text = "Cliente Final";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.BackColor = Color.Transparent;
            btnAbrirCaixa.Cursor = Cursors.Hand;
            btnAbrirCaixa.Dock = DockStyle.Left;
            btnAbrirCaixa.FlatAppearance.BorderSize = 0;
            btnAbrirCaixa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAbrirCaixa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAbrirCaixa.FlatStyle = FlatStyle.Flat;
            btnAbrirCaixa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrirCaixa.ForeColor = Color.White;
            btnAbrirCaixa.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
            btnAbrirCaixa.IconColor = Color.Red;
            btnAbrirCaixa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbrirCaixa.IconSize = 25;
            btnAbrirCaixa.Location = new Point(0, 0);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Padding = new Padding(5, 0, 0, 0);
            btnAbrirCaixa.Size = new Size(152, 51);
            btnAbrirCaixa.TabIndex = 13;
            btnAbrirCaixa.Text = "Caixa Fechado";
            btnAbrirCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAbrirCaixa.UseVisualStyleBackColor = false;
            btnAbrirCaixa.Click += btnAbrirCaixa_Click;
            // 
            // body
            // 
            body.BackColor = Color.White;
            body.Controls.Add(content);
            body.Dock = DockStyle.Fill;
            body.Location = new Point(220, 51);
            body.Name = "body";
            body.Size = new Size(1720, 949);
            body.TabIndex = 2;
            // 
            // content
            // 
            content.Controls.Add(caixa);
            content.Controls.Add(descontos);
            content.Controls.Add(sangria);
            content.Controls.Add(status);
            content.Controls.Add(retiradas);
            content.Controls.Add(movimentacoes);
            content.Controls.Add(fecharcaixa);
            content.Dock = DockStyle.Fill;
            content.Location = new Point(0, 0);
            content.Name = "content";
            content.SelectedIndex = 0;
            content.ShowToolTips = true;
            content.Size = new Size(1720, 949);
            content.TabIndex = 0;
            content.TabStop = false;
            // 
            // caixa
            // 
            caixa.BackColor = Color.White;
            caixa.Controls.Add(pnCaixaBody);
            caixa.Controls.Add(pnCaixaHeader);
            caixa.Location = new Point(4, 24);
            caixa.Name = "caixa";
            caixa.Padding = new Padding(3);
            caixa.Size = new Size(1712, 921);
            caixa.TabIndex = 3;
            // 
            // pnCaixaBody
            // 
            pnCaixaBody.BackColor = Color.White;
            pnCaixaBody.Controls.Add(pn);
            pnCaixaBody.Controls.Add(panel1);
            pnCaixaBody.Dock = DockStyle.Fill;
            pnCaixaBody.Location = new Point(3, 34);
            pnCaixaBody.Name = "pnCaixaBody";
            pnCaixaBody.Size = new Size(1706, 884);
            pnCaixaBody.TabIndex = 8;
            // 
            // pn
            // 
            pn.Dock = DockStyle.Fill;
            pn.Location = new Point(0, 740);
            pn.Name = "pn";
            pn.Size = new Size(1706, 144);
            pn.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgPesquisar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dgInfo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1706, 740);
            panel1.TabIndex = 0;
            // 
            // dgPesquisar
            // 
            dgPesquisar.AllowUserToDeleteRows = false;
            dgPesquisar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPesquisar.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgPesquisar.BorderStyle = BorderStyle.None;
            dgPesquisar.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgPesquisar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPesquisar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPesquisar.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, estoque });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgPesquisar.DefaultCellStyle = dataGridViewCellStyle2;
            dgPesquisar.Dock = DockStyle.Fill;
            dgPesquisar.Location = new Point(1021, 0);
            dgPesquisar.Name = "dgPesquisar";
            dgPesquisar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgPesquisar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgPesquisar.RowHeadersVisible = false;
            dgPesquisar.RowTemplate.Height = 25;
            dgPesquisar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPesquisar.Size = new Size(685, 740);
            dgPesquisar.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Código";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Preço";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // estoque
            // 
            estoque.HeaderText = "Estoque";
            estoque.Name = "estoque";
            estoque.ReadOnly = true;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(1011, 0);
            label5.Name = "label5";
            label5.Size = new Size(10, 740);
            label5.TabIndex = 2;
            // 
            // dgInfo
            // 
            dgInfo.AllowUserToDeleteRows = false;
            dgInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgInfo.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgInfo.BorderStyle = BorderStyle.None;
            dgInfo.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgInfo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInfo.Columns.AddRange(new DataGridViewColumn[] { codigo, desc, quantidade, preco, desconto, total });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgInfo.DefaultCellStyle = dataGridViewCellStyle5;
            dgInfo.Dock = DockStyle.Left;
            dgInfo.Location = new Point(0, 0);
            dgInfo.Name = "dgInfo";
            dgInfo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgInfo.RowHeadersVisible = false;
            dgInfo.RowTemplate.Height = 25;
            dgInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgInfo.Size = new Size(1011, 740);
            dgInfo.TabIndex = 1;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            // 
            // desc
            // 
            desc.HeaderText = "Descrição";
            desc.Name = "desc";
            desc.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.HeaderText = "Qntd.";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // preco
            // 
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // desconto
            // 
            desconto.HeaderText = "Desconto";
            desconto.Name = "desconto";
            desconto.ReadOnly = true;
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // pnCaixaHeader
            // 
            pnCaixaHeader.BackColor = Color.White;
            pnCaixaHeader.Controls.Add(btnPesquisar);
            pnCaixaHeader.Controls.Add(txtPesquisar);
            pnCaixaHeader.Dock = DockStyle.Top;
            pnCaixaHeader.Location = new Point(3, 3);
            pnCaixaHeader.Name = "pnCaixaHeader";
            pnCaixaHeader.Size = new Size(1706, 31);
            pnCaixaHeader.TabIndex = 7;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatAppearance.BorderSize = 0;
            btnPesquisar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPesquisar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnPesquisar.IconColor = Color.Black;
            btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPesquisar.IconSize = 15;
            btnPesquisar.Location = new Point(1195, -1);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(29, 24);
            btnPesquisar.TabIndex = 5;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.BackColor = Color.FromArgb(238, 238, 238);
            txtPesquisar.BorderStyle = BorderStyle.None;
            txtPesquisar.Location = new Point(1021, 0);
            txtPesquisar.Multiline = true;
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.PlaceholderText = " Pesquisar";
            txtPesquisar.Size = new Size(181, 23);
            txtPesquisar.TabIndex = 4;
            // 
            // descontos
            // 
            descontos.BackColor = Color.White;
            descontos.Controls.Add(lblFecharCaixa);
            descontos.Location = new Point(4, 24);
            descontos.Name = "descontos";
            descontos.Padding = new Padding(3);
            descontos.Size = new Size(1712, 921);
            descontos.TabIndex = 1;
            // 
            // lblFecharCaixa
            // 
            lblFecharCaixa.AutoSize = true;
            lblFecharCaixa.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecharCaixa.ForeColor = Color.FromArgb(11, 19, 139);
            lblFecharCaixa.Location = new Point(0, 0);
            lblFecharCaixa.Name = "lblFecharCaixa";
            lblFecharCaixa.Size = new Size(194, 50);
            lblFecharCaixa.TabIndex = 1;
            lblFecharCaixa.Text = "Descontos";
            // 
            // sangria
            // 
            sangria.BackColor = Color.White;
            sangria.Controls.Add(lblSangria);
            sangria.Location = new Point(4, 24);
            sangria.Name = "sangria";
            sangria.Size = new Size(1712, 921);
            sangria.TabIndex = 2;
            // 
            // lblSangria
            // 
            lblSangria.AutoSize = true;
            lblSangria.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSangria.ForeColor = Color.FromArgb(11, 19, 139);
            lblSangria.Location = new Point(0, 0);
            lblSangria.Name = "lblSangria";
            lblSangria.Size = new Size(145, 50);
            lblSangria.TabIndex = 1;
            lblSangria.Text = "Sangria";
            // 
            // status
            // 
            status.BackColor = Color.White;
            status.Controls.Add(label1);
            status.Location = new Point(4, 24);
            status.Name = "status";
            status.Size = new Size(1712, 921);
            status.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(11, 19, 139);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 51);
            label1.TabIndex = 7;
            label1.Text = "Status";
            // 
            // retiradas
            // 
            retiradas.BackColor = Color.White;
            retiradas.Controls.Add(label2);
            retiradas.Location = new Point(4, 24);
            retiradas.Name = "retiradas";
            retiradas.Size = new Size(1712, 921);
            retiradas.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(11, 19, 139);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 51);
            label2.TabIndex = 7;
            label2.Text = "Retiradas";
            // 
            // movimentacoes
            // 
            movimentacoes.BackColor = Color.White;
            movimentacoes.Controls.Add(label3);
            movimentacoes.Location = new Point(4, 24);
            movimentacoes.Name = "movimentacoes";
            movimentacoes.Size = new Size(1712, 921);
            movimentacoes.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(11, 19, 139);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(296, 51);
            label3.TabIndex = 7;
            label3.Text = "Movimentações";
            // 
            // fecharcaixa
            // 
            fecharcaixa.BackColor = Color.White;
            fecharcaixa.Controls.Add(label4);
            fecharcaixa.Location = new Point(4, 24);
            fecharcaixa.Name = "fecharcaixa";
            fecharcaixa.Size = new Size(1712, 921);
            fecharcaixa.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(11, 19, 139);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 51);
            label4.TabIndex = 7;
            label4.Text = "Fechar Caixa";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1940, 1000);
            Controls.Add(body);
            Controls.Add(header);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "App";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pardal";
            WindowState = FormWindowState.Maximized;
            FormClosed += App_FormClosed;
            Load += App_Load;
            sidebar.ResumeLayout(false);
            sideFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCirculoAzul).EndInit();
            sideMenu.ResumeLayout(false);
            sideMenu.PerformLayout();
            sideHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCirculoLaranja).EndInit();
            header.ResumeLayout(false);
            body.ResumeLayout(false);
            content.ResumeLayout(false);
            caixa.ResumeLayout(false);
            pnCaixaBody.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPesquisar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgInfo).EndInit();
            pnCaixaHeader.ResumeLayout(false);
            pnCaixaHeader.PerformLayout();
            descontos.ResumeLayout(false);
            descontos.PerformLayout();
            sangria.ResumeLayout(false);
            sangria.PerformLayout();
            status.ResumeLayout(false);
            retiradas.ResumeLayout(false);
            movimentacoes.ResumeLayout(false);
            fecharcaixa.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel sideFooter;
        private PictureBox pbCirculoAzul;
        private Panel sideMenu;
        private FontAwesome.Sharp.IconButton btnSideDescontos;
        private FontAwesome.Sharp.IconButton btnSideVendas;
        private Panel sideHeader;
        private Panel header;
        private Panel body;
        private PictureBox pbCirculoLaranja;
        private TabControl content;
        private TabPage descontos;
        private TabPage sangria;
        private Label lblFecharCaixa;
        private Label lblSangria;
        private TabPage caixa;
        private Label lblSideItemSelecionado;
        private FontAwesome.Sharp.IconButton btnSideMovimentacoes;
        private FontAwesome.Sharp.IconButton btnSideRetirada;
        private FontAwesome.Sharp.IconButton btnSideStatus;
        private FontAwesome.Sharp.IconButton btnSideSangria;
        private FontAwesome.Sharp.IconButton btnSideFecharCaixa;
        private FontAwesome.Sharp.IconButton btnAbrirCaixa;
        private TabPage status;
        private TabPage retiradas;
        private TabPage movimentacoes;
        private TabPage fecharcaixa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pnCaixaBody;
        private Panel pnCaixaHeader;
        private PictureBox pbLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private TextBox txtPesquisar;
        private Panel pn;
        private Panel panel1;
        private DataGridView dgPesquisar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn estoque;
        private Label label5;
        private DataGridView dgInfo;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn desconto;
        private DataGridViewTextBoxColumn total;
    }
}