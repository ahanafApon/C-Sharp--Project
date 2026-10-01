namespace Stocky
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlLeft = new Panel();
            picboxlogo = new PictureBox();
            pnlrightfull = new Panel();
            pnlrightsub = new Panel();
            btnClear = new Button();
            btnLogin = new Button();
            pnlinput = new Panel();
            pnlInputtaker = new Panel();
            tbPassword = new TextBox();
            tbUserId = new TextBox();
            txtPassword = new Label();
            lblUserId = new Label();
            lbltitle = new Label();
            flowLayoutPanel1.SuspendLayout();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxlogo).BeginInit();
            pnlrightfull.SuspendLayout();
            pnlrightsub.SuspendLayout();
            pnlinput.SuspendLayout();
            pnlInputtaker.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.InactiveCaption;
            flowLayoutPanel1.Controls.Add(pnlLeft);
            flowLayoutPanel1.Controls.Add(pnlrightfull);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(976, 593);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.Navy;
            pnlLeft.Controls.Add(picboxlogo);
            pnlLeft.Location = new Point(3, 3);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(375, 590);
            pnlLeft.TabIndex = 0;
            // 
            // picboxlogo
            // 
            picboxlogo.BackColor = SystemColors.InactiveCaption;
            picboxlogo.ErrorImage = null;
            picboxlogo.Image = (Image)resources.GetObject("picboxlogo.Image");
            picboxlogo.InitialImage = null;
            picboxlogo.Location = new Point(13, 107);
            picboxlogo.Name = "picboxlogo";
            picboxlogo.Size = new Size(349, 369);
            picboxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxlogo.TabIndex = 0;
            picboxlogo.TabStop = false;
            // 
            // pnlrightfull
            // 
            pnlrightfull.Controls.Add(pnlrightsub);
            pnlrightfull.Location = new Point(384, 3);
            pnlrightfull.Name = "pnlrightfull";
            pnlrightfull.Size = new Size(582, 582);
            pnlrightfull.TabIndex = 1;
            // 
            // pnlrightsub
            // 
            pnlrightsub.BackColor = SystemColors.GradientInactiveCaption;
            pnlrightsub.Controls.Add(btnClear);
            pnlrightsub.Controls.Add(btnLogin);
            pnlrightsub.Controls.Add(pnlinput);
            pnlrightsub.Location = new Point(10, 50);
            pnlrightsub.Name = "pnlrightsub";
            pnlrightsub.Size = new Size(564, 483);
            pnlrightsub.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.BackColor = Color.WhiteSmoke;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(206, 412);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 35);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.TextImageRelation = TextImageRelation.ImageAboveText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = Color.WhiteSmoke;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(206, 355);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 35);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Log In\r\n";
            btnLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.CursorChanged += btnLogin_Click;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlinput
            // 
            pnlinput.BackColor = Color.LightSteelBlue;
            pnlinput.Controls.Add(pnlInputtaker);
            pnlinput.Controls.Add(lbltitle);
            pnlinput.Location = new Point(23, 57);
            pnlinput.Name = "pnlinput";
            pnlinput.Size = new Size(521, 274);
            pnlinput.TabIndex = 0;
            // 
            // pnlInputtaker
            // 
            pnlInputtaker.BackColor = SystemColors.GradientInactiveCaption;
            pnlInputtaker.Controls.Add(tbPassword);
            pnlInputtaker.Controls.Add(tbUserId);
            pnlInputtaker.Controls.Add(txtPassword);
            pnlInputtaker.Controls.Add(lblUserId);
            pnlInputtaker.Location = new Point(49, 88);
            pnlInputtaker.Name = "pnlInputtaker";
            pnlInputtaker.Size = new Size(436, 130);
            pnlInputtaker.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(133, 75);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(243, 27);
            tbPassword.TabIndex = 4;
            // 
            // tbUserId
            // 
            tbUserId.Location = new Point(134, 29);
            tbUserId.Name = "tbUserId";
            tbUserId.Size = new Size(243, 27);
            tbUserId.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(37, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(81, 20);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "Password ";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblUserId.Location = new Point(37, 29);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(63, 20);
            lblUserId.TabIndex = 1;
            lblUserId.Text = "User id ";
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.BackColor = SystemColors.GradientInactiveCaption;
            lbltitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(65, 27);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(367, 20);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Sign in with your organizational id number.";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1000, 617);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn Page";
            FormClosed += LoginPage_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxlogo).EndInit();
            pnlrightfull.ResumeLayout(false);
            pnlrightsub.ResumeLayout(false);
            pnlinput.ResumeLayout(false);
            pnlinput.PerformLayout();
            pnlInputtaker.ResumeLayout(false);
            pnlInputtaker.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlLeft;
        private PictureBox picboxlogo;
        private Panel pnlrightfull;
        private Panel pnlinput;
        private Button btnLogin;
        private Label lbltitle;
        private Panel pnlInputtaker;
        private Label txtPassword;
        private Label lblUserId;
        private TextBox tbPassword;
        private TextBox tbUserId;
        private Panel pnlrightsub;
        private Button btnClear;
    }
}
