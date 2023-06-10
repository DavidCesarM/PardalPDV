namespace PardalAppPDV.View
{
    partial class AbrirCaixa
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
            lblUser = new Label();
            lblHora = new Label();
            lblData = new Label();
            pnHeader = new Panel();
            pnBody = new Panel();
            panel1 = new Panel();
            btnAbrirCaixa = new FontAwesome.Sharp.IconButton();
            pnSaldo = new Panel();
            label1 = new Label();
            pbIconCash = new FontAwesome.Sharp.IconButton();
            pnHeader.SuspendLayout();
            pnBody.SuspendLayout();
            panel1.SuspendLayout();
            pnSaldo.SuspendLayout();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(10, 0, 0, 0);
            lblUser.Size = new Size(290, 62);
            lblUser.TabIndex = 0;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            lblHora.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHora.ForeColor = Color.White;
            lblHora.Location = new Point(296, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(153, 31);
            lblHora.TabIndex = 1;
            lblHora.Text = "11 : 00";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblData
            // 
            lblData.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(296, 31);
            lblData.Name = "lblData";
            lblData.Size = new Size(153, 31);
            lblData.TabIndex = 2;
            lblData.Text = "12 / 06 / 2023";
            lblData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnHeader
            // 
            pnHeader.BackColor = Color.BlueViolet;
            pnHeader.Controls.Add(lblUser);
            pnHeader.Controls.Add(lblData);
            pnHeader.Controls.Add(lblHora);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(449, 62);
            pnHeader.TabIndex = 3;
            // 
            // pnBody
            // 
            pnBody.Controls.Add(panel1);
            pnBody.Controls.Add(pnSaldo);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 62);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(449, 379);
            pnBody.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAbrirCaixa);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 60);
            panel1.TabIndex = 3;
            // 
            // btnAbrirCaixa
            // 
            btnAbrirCaixa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAbrirCaixa.FlatAppearance.BorderSize = 0;
            btnAbrirCaixa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAbrirCaixa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAbrirCaixa.FlatStyle = FlatStyle.Flat;
            btnAbrirCaixa.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            btnAbrirCaixa.IconColor = Color.Black;
            btnAbrirCaixa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAbrirCaixa.IconSize = 30;
            btnAbrirCaixa.ImageAlign = ContentAlignment.BottomCenter;
            btnAbrirCaixa.Location = new Point(311, 13);
            btnAbrirCaixa.Name = "btnAbrirCaixa";
            btnAbrirCaixa.Size = new Size(135, 35);
            btnAbrirCaixa.TabIndex = 1;
            btnAbrirCaixa.Text = "Abrir Caixa";
            btnAbrirCaixa.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAbrirCaixa.UseVisualStyleBackColor = true;
            btnAbrirCaixa.Click += btnAbrirCaixa_Click;
            // 
            // pnSaldo
            // 
            pnSaldo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnSaldo.Controls.Add(label1);
            pnSaldo.Controls.Add(pbIconCash);
            pnSaldo.Location = new Point(302, 6);
            pnSaldo.Name = "pnSaldo";
            pnSaldo.Size = new Size(144, 44);
            pnSaldo.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(47, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 44);
            label1.TabIndex = 1;
            label1.Text = "1000";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbIconCash
            // 
            pbIconCash.Dock = DockStyle.Left;
            pbIconCash.FlatAppearance.BorderSize = 0;
            pbIconCash.FlatAppearance.MouseDownBackColor = Color.Transparent;
            pbIconCash.FlatAppearance.MouseOverBackColor = Color.Transparent;
            pbIconCash.FlatStyle = FlatStyle.Flat;
            pbIconCash.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            pbIconCash.IconColor = Color.Black;
            pbIconCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pbIconCash.IconSize = 30;
            pbIconCash.ImageAlign = ContentAlignment.BottomCenter;
            pbIconCash.Location = new Point(0, 0);
            pbIconCash.Name = "pbIconCash";
            pbIconCash.Size = new Size(47, 44);
            pbIconCash.TabIndex = 0;
            pbIconCash.UseVisualStyleBackColor = true;
            // 
            // AbrirCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(449, 441);
            Controls.Add(pnBody);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AbrirCaixa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AbrirCaixa";
            Load += AbrirCaixa_Load;
            pnHeader.ResumeLayout(false);
            pnBody.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnSaldo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblUser;
        private Label lblHora;
        private Label lblData;
        private Panel pnHeader;
        private Panel pnBody;
        private Panel pnSaldo;
        private Label label1;
        private FontAwesome.Sharp.IconButton pbIconCash;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAbrirCaixa;
    }
}