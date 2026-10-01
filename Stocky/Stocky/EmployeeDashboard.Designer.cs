namespace Stocky
{
    partial class EmployeeDashboard
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
            panel2 = new Panel();
            lblUsername = new Label();
            lblDateTime = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnLogout = new Button();
            btnSales = new Button();
            btnStock = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblDateTime);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 28);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 62);
            panel2.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(98, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 2;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = SystemColors.ScrollBar;
            lblDateTime.ForeColor = SystemColors.ActiveCaptionText;
            lblDateTime.Location = new Point(738, 19);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 20);
            lblDateTime.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 19);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "Welcome,";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnStock);
            panel1.Location = new Point(8, 97);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 484);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(337, 18);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 55);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(312, 70);
            label4.Name = "label4";
            label4.Size = new Size(274, 17);
            label4.TabIndex = 7;
            label4.Text = "Manage and monitor your business efficiently";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(397, 41);
            label3.Name = "label3";
            label3.Size = new Size(188, 23);
            label3.TabIndex = 6;
            label3.Text = "Employee Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = Properties.Resources.logout;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(840, 410);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 58);
            btnLogout.TabIndex = 5;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSales
            // 
            btnSales.BackgroundImage = Properties.Resources.sales_orders;
            btnSales.BackgroundImageLayout = ImageLayout.Stretch;
            btnSales.Cursor = Cursors.Hand;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSales.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.ForeColor = SystemColors.ActiveCaption;
            btnSales.Location = new Point(534, 169);
            btnSales.Margin = new Padding(3, 4, 3, 4);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(199, 104);
            btnSales.TabIndex = 1;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click_1;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Transparent;
            btnStock.BackgroundImage = Properties.Resources.stk1;
            btnStock.BackgroundImageLayout = ImageLayout.Stretch;
            btnStock.Cursor = Cursors.Hand;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStock.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.ForeColor = SystemColors.ActiveCaption;
            btnStock.Location = new Point(186, 177);
            btnStock.Margin = new Padding(0);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(214, 96);
            btnStock.TabIndex = 0;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimizeBox = false;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDashboard";
            FormClosed += EmployeeDashboard_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lblUsername;
        private Label lblDateTime;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label3;
        private Button btnLogout;
        private Button btnSales;
        private Button btnStock;
    }
}