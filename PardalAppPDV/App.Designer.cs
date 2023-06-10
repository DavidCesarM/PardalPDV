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
            btnSideCaixa = new FontAwesome.Sharp.IconButton();
            sideHeader = new Panel();
            pbCirculoLaranja = new PictureBox();
            pbLogo = new PictureBox();
            header = new Panel();
            btnAbrirCaixa = new FontAwesome.Sharp.IconButton();
            body = new Panel();
            content = new TabControl();
            caixa = new TabPage();
            pnCaixaFooter = new Panel();
            pnCaixaBody = new Panel();
            dgInfosCaixa = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dataHora = new DataGridViewTextBoxColumn();
            nome = new DataGridViewTextBoxColumn();
            formaDePag = new DataGridViewTextBoxColumn();
            produto = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            pnCaixaHeader = new Panel();
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            sidebar.SuspendLayout();
            sideFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCirculoAzul).BeginInit();
            sideMenu.SuspendLayout();
            sideHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCirculoLaranja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            header.SuspendLayout();
            body.SuspendLayout();
            content.SuspendLayout();
            caixa.SuspendLayout();
            pnCaixaBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgInfosCaixa).BeginInit();
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
            pbCirculoAzul.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            sideMenu.Controls.Add(btnSideCaixa);
            sideMenu.Dock = DockStyle.Top;
            sideMenu.Location = new Point(0, 213);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(220, 446);
            sideMenu.TabIndex = 1;
            // 
            // btnSideFecharCaixa
            // 
            btnSideFecharCaixa.BackColor = Color.Transparent;
            btnSideFecharCaixa.Dock = DockStyle.Top;
            btnSideFecharCaixa.FlatAppearance.BorderSize = 0;
            btnSideFecharCaixa.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideFecharCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideFecharCaixa.FlatStyle = FlatStyle.Flat;
            btnSideFecharCaixa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideFecharCaixa.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideFecharCaixa.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            btnSideFecharCaixa.IconColor = Color.FromArgb(11, 19, 139);
            btnSideFecharCaixa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideFecharCaixa.IconSize = 25;
            btnSideFecharCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideFecharCaixa.Location = new Point(0, 360);
            btnSideFecharCaixa.Name = "btnSideFecharCaixa";
            btnSideFecharCaixa.Padding = new Padding(30, 0, 0, 0);
            btnSideFecharCaixa.Size = new Size(220, 60);
            btnSideFecharCaixa.TabIndex = 11;
            btnSideFecharCaixa.Text = "Fechar Caixa";
            btnSideFecharCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnSideFecharCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideFecharCaixa.UseVisualStyleBackColor = false;
            btnSideFecharCaixa.Click += btnSideFecharCaixa_Click_1;
            btnSideFecharCaixa.MouseEnter += btnSideFecharCaixa_MouseEnter;
            btnSideFecharCaixa.MouseLeave += btnSideFecharCaixa_MouseLeave;
            // 
            // btnSideMovimentacoes
            // 
            btnSideMovimentacoes.BackColor = Color.Transparent;
            btnSideMovimentacoes.Dock = DockStyle.Top;
            btnSideMovimentacoes.FlatAppearance.BorderSize = 0;
            btnSideMovimentacoes.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideMovimentacoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideMovimentacoes.FlatStyle = FlatStyle.Flat;
            btnSideMovimentacoes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideMovimentacoes.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideMovimentacoes.IconChar = FontAwesome.Sharp.IconChar.Running;
            btnSideMovimentacoes.IconColor = Color.FromArgb(11, 19, 139);
            btnSideMovimentacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideMovimentacoes.IconSize = 25;
            btnSideMovimentacoes.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideMovimentacoes.Location = new Point(0, 300);
            btnSideMovimentacoes.Name = "btnSideMovimentacoes";
            btnSideMovimentacoes.Padding = new Padding(30, 0, 0, 0);
            btnSideMovimentacoes.Size = new Size(220, 60);
            btnSideMovimentacoes.TabIndex = 10;
            btnSideMovimentacoes.Text = "Movimentações";
            btnSideMovimentacoes.TextAlign = ContentAlignment.MiddleRight;
            btnSideMovimentacoes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideMovimentacoes.UseVisualStyleBackColor = false;
            btnSideMovimentacoes.Click += btnSideMovimentacoes_Click;
            btnSideMovimentacoes.MouseEnter += btnSideMovimentacoes_MouseEnter;
            btnSideMovimentacoes.MouseLeave += btnSideMovimentacoes_MouseLeave;
            // 
            // btnSideRetirada
            // 
            btnSideRetirada.BackColor = Color.Transparent;
            btnSideRetirada.Dock = DockStyle.Top;
            btnSideRetirada.FlatAppearance.BorderSize = 0;
            btnSideRetirada.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideRetirada.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideRetirada.FlatStyle = FlatStyle.Flat;
            btnSideRetirada.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideRetirada.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideRetirada.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            btnSideRetirada.IconColor = Color.FromArgb(11, 19, 139);
            btnSideRetirada.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideRetirada.IconSize = 25;
            btnSideRetirada.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideRetirada.Location = new Point(0, 240);
            btnSideRetirada.Name = "btnSideRetirada";
            btnSideRetirada.Padding = new Padding(30, 0, 0, 0);
            btnSideRetirada.Size = new Size(220, 60);
            btnSideRetirada.TabIndex = 9;
            btnSideRetirada.Text = "Retiradas";
            btnSideRetirada.TextAlign = ContentAlignment.MiddleRight;
            btnSideRetirada.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideRetirada.UseVisualStyleBackColor = false;
            btnSideRetirada.Click += btnSideRetirada_Click;
            btnSideRetirada.MouseEnter += btnSideRetirada_MouseEnter;
            btnSideRetirada.MouseLeave += btnSideRetirada_MouseLeave;
            // 
            // btnSideStatus
            // 
            btnSideStatus.BackColor = Color.Transparent;
            btnSideStatus.Dock = DockStyle.Top;
            btnSideStatus.FlatAppearance.BorderSize = 0;
            btnSideStatus.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideStatus.FlatStyle = FlatStyle.Flat;
            btnSideStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideStatus.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideStatus.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btnSideStatus.IconColor = Color.FromArgb(11, 19, 139);
            btnSideStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideStatus.IconSize = 25;
            btnSideStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideStatus.Location = new Point(0, 180);
            btnSideStatus.Name = "btnSideStatus";
            btnSideStatus.Padding = new Padding(30, 0, 0, 0);
            btnSideStatus.Size = new Size(220, 60);
            btnSideStatus.TabIndex = 8;
            btnSideStatus.Text = "Status";
            btnSideStatus.TextAlign = ContentAlignment.MiddleRight;
            btnSideStatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideStatus.UseVisualStyleBackColor = false;
            btnSideStatus.Click += btnSideStatus_Click;
            btnSideStatus.MouseEnter += btnSideStatus_MouseEnter;
            btnSideStatus.MouseLeave += btnSideStatus_MouseLeave;
            // 
            // btnSideSangria
            // 
            btnSideSangria.BackColor = Color.Transparent;
            btnSideSangria.Dock = DockStyle.Top;
            btnSideSangria.FlatAppearance.BorderSize = 0;
            btnSideSangria.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideSangria.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideSangria.FlatStyle = FlatStyle.Flat;
            btnSideSangria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideSangria.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideSangria.IconChar = FontAwesome.Sharp.IconChar.Vault;
            btnSideSangria.IconColor = Color.FromArgb(11, 19, 139);
            btnSideSangria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideSangria.IconSize = 25;
            btnSideSangria.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideSangria.Location = new Point(0, 120);
            btnSideSangria.Name = "btnSideSangria";
            btnSideSangria.Padding = new Padding(30, 0, 0, 0);
            btnSideSangria.Size = new Size(220, 60);
            btnSideSangria.TabIndex = 7;
            btnSideSangria.Text = "Sangria";
            btnSideSangria.TextAlign = ContentAlignment.MiddleRight;
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
            btnSideDescontos.BackColor = Color.Transparent;
            btnSideDescontos.Dock = DockStyle.Top;
            btnSideDescontos.FlatAppearance.BorderSize = 0;
            btnSideDescontos.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideDescontos.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideDescontos.FlatStyle = FlatStyle.Flat;
            btnSideDescontos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideDescontos.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideDescontos.IconChar = FontAwesome.Sharp.IconChar.Percentage;
            btnSideDescontos.IconColor = Color.FromArgb(11, 19, 139);
            btnSideDescontos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideDescontos.IconSize = 25;
            btnSideDescontos.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideDescontos.Location = new Point(0, 60);
            btnSideDescontos.Name = "btnSideDescontos";
            btnSideDescontos.Padding = new Padding(30, 0, 0, 0);
            btnSideDescontos.Size = new Size(220, 60);
            btnSideDescontos.TabIndex = 5;
            btnSideDescontos.Text = "Descontos";
            btnSideDescontos.TextAlign = ContentAlignment.MiddleRight;
            btnSideDescontos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideDescontos.UseVisualStyleBackColor = false;
            btnSideDescontos.Click += btnSideDescontos_Click;
            btnSideDescontos.MouseEnter += btnSideDescontos_MouseEnter;
            btnSideDescontos.MouseLeave += btnSideDescontos_MouseLeave;
            // 
            // btnSideCaixa
            // 
            btnSideCaixa.BackColor = Color.Transparent;
            btnSideCaixa.Dock = DockStyle.Top;
            btnSideCaixa.FlatAppearance.BorderSize = 0;
            btnSideCaixa.FlatAppearance.MouseDownBackColor = Color.Orange;
            btnSideCaixa.FlatAppearance.MouseOverBackColor = Color.FromArgb(11, 19, 139);
            btnSideCaixa.FlatStyle = FlatStyle.Flat;
            btnSideCaixa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideCaixa.ForeColor = Color.FromArgb(11, 19, 139);
            btnSideCaixa.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnSideCaixa.IconColor = Color.FromArgb(11, 19, 139);
            btnSideCaixa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSideCaixa.IconSize = 25;
            btnSideCaixa.ImageAlign = ContentAlignment.MiddleLeft;
            btnSideCaixa.Location = new Point(0, 0);
            btnSideCaixa.Name = "btnSideCaixa";
            btnSideCaixa.Padding = new Padding(30, 0, 0, 0);
            btnSideCaixa.Size = new Size(220, 60);
            btnSideCaixa.TabIndex = 4;
            btnSideCaixa.Text = "Caixa";
            btnSideCaixa.TextAlign = ContentAlignment.MiddleRight;
            btnSideCaixa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSideCaixa.UseVisualStyleBackColor = false;
            btnSideCaixa.Click += btnSideCaixa_Click;
            btnSideCaixa.MouseEnter += btnSideCaixa_MouseEnter;
            btnSideCaixa.MouseLeave += btnSideCaixa_MouseLeave;
            // 
            // sideHeader
            // 
            sideHeader.Controls.Add(pbCirculoLaranja);
            sideHeader.Controls.Add(pbLogo);
            sideHeader.Dock = DockStyle.Top;
            sideHeader.Location = new Point(0, 0);
            sideHeader.Name = "sideHeader";
            sideHeader.Size = new Size(220, 213);
            sideHeader.TabIndex = 0;
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
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(26, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(145, 130);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // header
            // 
            header.BackColor = Color.FromArgb(0, 161, 201);
            header.Controls.Add(btnAbrirCaixa);
            header.Dock = DockStyle.Top;
            header.Location = new Point(220, 0);
            header.Name = "header";
            header.Size = new Size(1720, 51);
            header.TabIndex = 1;
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
            caixa.Controls.Add(pnCaixaFooter);
            caixa.Controls.Add(pnCaixaBody);
            caixa.Controls.Add(pnCaixaHeader);
            caixa.Location = new Point(4, 24);
            caixa.Name = "caixa";
            caixa.Padding = new Padding(3);
            caixa.Size = new Size(1712, 921);
            caixa.TabIndex = 3;
            // 
            // pnCaixaFooter
            // 
            pnCaixaFooter.BackColor = Color.White;
            pnCaixaFooter.Dock = DockStyle.Bottom;
            pnCaixaFooter.Location = new Point(3, 818);
            pnCaixaFooter.Name = "pnCaixaFooter";
            pnCaixaFooter.Size = new Size(1706, 100);
            pnCaixaFooter.TabIndex = 9;
            // 
            // pnCaixaBody
            // 
            pnCaixaBody.BackColor = SystemColors.WindowFrame;
            pnCaixaBody.Controls.Add(dgInfosCaixa);
            pnCaixaBody.Dock = DockStyle.Fill;
            pnCaixaBody.Location = new Point(3, 53);
            pnCaixaBody.Name = "pnCaixaBody";
            pnCaixaBody.Size = new Size(1706, 865);
            pnCaixaBody.TabIndex = 8;
            // 
            // dgInfosCaixa
            // 
            dgInfosCaixa.AllowUserToDeleteRows = false;
            dgInfosCaixa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgInfosCaixa.BackgroundColor = Color.White;
            dgInfosCaixa.BorderStyle = BorderStyle.None;
            dgInfosCaixa.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgInfosCaixa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgInfosCaixa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgInfosCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInfosCaixa.Columns.AddRange(new DataGridViewColumn[] { id, dataHora, nome, formaDePag, produto, descricao });
            dgInfosCaixa.Dock = DockStyle.Fill;
            dgInfosCaixa.Location = new Point(0, 0);
            dgInfosCaixa.Name = "dgInfosCaixa";
            dgInfosCaixa.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 19, 139);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgInfosCaixa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgInfosCaixa.RowHeadersVisible = false;
            dgInfosCaixa.RowTemplate.Height = 25;
            dgInfosCaixa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgInfosCaixa.Size = new Size(1706, 865);
            dgInfosCaixa.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // dataHora
            // 
            dataHora.HeaderText = "Data / Hora";
            dataHora.Name = "dataHora";
            dataHora.ReadOnly = true;
            // 
            // nome
            // 
            nome.HeaderText = "Nome";
            nome.Name = "nome";
            nome.ReadOnly = true;
            // 
            // formaDePag
            // 
            formaDePag.HeaderText = "Forma de Pagamento";
            formaDePag.Name = "formaDePag";
            formaDePag.ReadOnly = true;
            // 
            // produto
            // 
            produto.HeaderText = "Produto";
            produto.Name = "produto";
            produto.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // pnCaixaHeader
            // 
            pnCaixaHeader.BackColor = Color.White;
            pnCaixaHeader.Controls.Add(textBox3);
            pnCaixaHeader.Controls.Add(textBox2);
            pnCaixaHeader.Controls.Add(textBox1);
            pnCaixaHeader.Dock = DockStyle.Top;
            pnCaixaHeader.Location = new Point(3, 3);
            pnCaixaHeader.Name = "pnCaixaHeader";
            pnCaixaHeader.Size = new Size(1706, 50);
            pnCaixaHeader.TabIndex = 7;
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
            // textBox1
            // 
            textBox1.Location = new Point(29, 21);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Pesquisar";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(347, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(241, 21);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
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
            sideHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCirculoLaranja).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            header.ResumeLayout(false);
            body.ResumeLayout(false);
            content.ResumeLayout(false);
            caixa.ResumeLayout(false);
            pnCaixaBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgInfosCaixa).EndInit();
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
        private FontAwesome.Sharp.IconButton btnSideCaixa;
        private Panel sideHeader;
        private Panel header;
        private Panel body;
        private PictureBox pbLogo;
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
        private Panel pnCaixaFooter;
        private DataGridView dgInfosCaixa;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataHora;
        private DataGridViewTextBoxColumn nome;
        private DataGridViewTextBoxColumn formaDePag;
        private DataGridViewTextBoxColumn produto;
        private DataGridViewTextBoxColumn descricao;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}