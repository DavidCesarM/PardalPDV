namespace PardalAppPDV.View
{
    partial class frmMessages
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
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblMsg = new Label();
            btnClose = new FontAwesome.Sharp.IconButton();
            btnIcon = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 10);
            panel1.TabIndex = 5;
            // 
            // lblMsg
            // 
            lblMsg.Dock = DockStyle.Fill;
            lblMsg.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg.ForeColor = Color.White;
            lblMsg.Location = new Point(82, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(245, 80);
            lblMsg.TabIndex = 11;
            lblMsg.Text = "Message Text";
            lblMsg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 35;
            btnClose.Location = new Point(327, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 80);
            btnClose.TabIndex = 10;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnIcon
            // 
            btnIcon.BackColor = Color.Transparent;
            btnIcon.Dock = DockStyle.Left;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIcon.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.ForeColor = Color.White;
            btnIcon.IconChar = FontAwesome.Sharp.IconChar.None;
            btnIcon.IconColor = Color.White;
            btnIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIcon.IconSize = 55;
            btnIcon.Location = new Point(0, 0);
            btnIcon.Name = "btnIcon";
            btnIcon.Size = new Size(82, 80);
            btnIcon.TabIndex = 9;
            btnIcon.UseVisualStyleBackColor = false;
            // 
            // frmMessages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(380, 90);
            Controls.Add(lblMsg);
            Controls.Add(btnClose);
            Controls.Add(btnIcon);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMessages";
            StartPosition = FormStartPosition.Manual;
            Text = "frmMessages";
            Load += frmMessages_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label lblMsg;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnIcon;
    }
}