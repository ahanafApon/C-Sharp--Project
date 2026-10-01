namespace Stocky
{
    partial class Admin
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
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnLogout = new Button();
            btnReports = new Button();
            btnAddEmployee = new Button();
            btnSales = new Button();
            btnStock = new Button();
            panel2 = new Panel();
            lblUsername = new Label();
            lblDateTime = new Label();
            label2 = new Label();
            timer4 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 127);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnAddEmployee);
            panel1.Controls.Add(btnSales);
            panel1.Controls.Add(btnStock);
            panel1.Location = new Point(8, 65);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(985, 484);
            panel1.TabIndex = 1;
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
            label3.Size = new Size(159, 23);
            label3.TabIndex = 6;
            label3.Text = "Admin Dashboard";
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
            // btnReports
            // 
            btnReports.BackgroundImage = Properties.Resources.report;
            btnReports.BackgroundImageLayout = ImageLayout.Stretch;
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReports.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = SystemColors.ActiveCaption;
            btnReports.Location = new Point(521, 279);
            btnReports.Margin = new Padding(3, 4, 3, 4);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(199, 97);
            btnReports.TabIndex = 4;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = SystemColors.GradientInactiveCaption;
            btnAddEmployee.BackgroundImage = Properties.Resources.addemployee;
            btnAddEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddEmployee.Cursor = Cursors.Hand;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddEmployee.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Location = new Point(151, 279);
            btnAddEmployee.Margin = new Padding(3, 4, 3, 4);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(214, 97);
            btnAddEmployee.TabIndex = 2;
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
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
            btnSales.Location = new Point(521, 152);
            btnSales.Margin = new Padding(3, 4, 3, 4);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(199, 104);
            btnSales.TabIndex = 1;
            btnSales.UseVisualStyleBackColor = true;
            btnSales.Click += btnSales_Click;
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
            btnStock.Location = new Point(151, 152);
            btnStock.Margin = new Padding(0);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(214, 96);
            btnStock.TabIndex = 0;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(lblDateTime);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(981, 54);
            panel2.TabIndex = 1;
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
            // timer4
            // 
            timer4.Enabled = true;
            timer4.Interval = 1000;
            timer4.Tick += timer4_Tick_1;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1000, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Label lblUsername;
    }
}

