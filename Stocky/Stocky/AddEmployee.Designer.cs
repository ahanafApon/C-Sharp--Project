namespace Stocky
{
    partial class AddEmployee
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
            panel1 = new Panel();
            btnShow = new Button();
            btnSearch = new Button();
            tbSearch = new TextBox();
            dataGridView1 = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmPassword = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmSalary = new DataGridViewTextBoxColumn();
            clmRole = new DataGridViewTextBoxColumn();
            btnBack = new Button();
            pnlButton = new Panel();
            btnSave = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnAssign = new Button();
            pnlInputforn = new Panel();
            cbRole = new ComboBox();
            lblSalaryex = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tbSalary = new TextBox();
            tbPassword = new TextBox();
            tbName = new TextBox();
            tbUserId = new TextBox();
            lblSalary = new Label();
            lblRole = new Label();
            lblName = new Label();
            lblPassword = new Label();
            lblUserId = new Label();
            panel2 = new Panel();
            lblTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlButton.SuspendLayout();
            pnlInputforn.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(pnlButton);
            panel1.Controls.Add(pnlInputforn);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 600);
            panel1.TabIndex = 0;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(415, 216);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(124, 38);
            btnShow.TabIndex = 22;
            btnShow.Text = "Show";
            btnShow.TextAlign = ContentAlignment.TopCenter;
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(261, 216);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 38);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.TopCenter;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(5, 216);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(250, 27);
            tbSearch.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmId, clmPassword, clmName, clmSalary, clmRole });
            dataGridView1.Location = new Point(6, 256);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(976, 305);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick_1;
            // 
            // clmId
            // 
            clmId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmId.HeaderText = "Id";
            clmId.MinimumWidth = 6;
            clmId.Name = "clmId";
            clmId.ReadOnly = true;
            // 
            // clmPassword
            // 
            clmPassword.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmPassword.HeaderText = "Password";
            clmPassword.MinimumWidth = 6;
            clmPassword.Name = "clmPassword";
            clmPassword.ReadOnly = true;
            // 
            // clmName
            // 
            clmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 9;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            // 
            // clmSalary
            // 
            clmSalary.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmSalary.HeaderText = "Salary";
            clmSalary.MinimumWidth = 6;
            clmSalary.Name = "clmSalary";
            clmSalary.ReadOnly = true;
            // 
            // clmRole
            // 
            clmRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmRole.HeaderText = "Role";
            clmRole.MinimumWidth = 6;
            clmRole.Name = "clmRole";
            clmRole.ReadOnly = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(5, 565);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(113, 32);
            btnBack.TabIndex = 18;
            btnBack.Text = "<<Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pnlButton
            // 
            pnlButton.BackColor = SystemColors.GradientActiveCaption;
            pnlButton.Controls.Add(btnSave);
            pnlButton.Controls.Add(btnUpdate);
            pnlButton.Controls.Add(btnRemove);
            pnlButton.Controls.Add(btnAssign);
            pnlButton.Location = new Point(735, 35);
            pnlButton.Name = "pnlButton";
            pnlButton.Size = new Size(242, 177);
            pnlButton.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(137, 91);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 73);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(25, 92);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 73);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(137, 10);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(86, 73);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAssign.Location = new Point(25, 10);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(86, 73);
            btnAssign.TabIndex = 2;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // pnlInputforn
            // 
            pnlInputforn.BackColor = SystemColors.GradientInactiveCaption;
            pnlInputforn.Controls.Add(cbRole);
            pnlInputforn.Controls.Add(lblSalaryex);
            pnlInputforn.Controls.Add(label9);
            pnlInputforn.Controls.Add(label8);
            pnlInputforn.Controls.Add(label7);
            pnlInputforn.Controls.Add(label6);
            pnlInputforn.Controls.Add(tbSalary);
            pnlInputforn.Controls.Add(tbPassword);
            pnlInputforn.Controls.Add(tbName);
            pnlInputforn.Controls.Add(tbUserId);
            pnlInputforn.Controls.Add(lblSalary);
            pnlInputforn.Controls.Add(lblRole);
            pnlInputforn.Controls.Add(lblName);
            pnlInputforn.Controls.Add(lblPassword);
            pnlInputforn.Controls.Add(lblUserId);
            pnlInputforn.Location = new Point(9, 33);
            pnlInputforn.Name = "pnlInputforn";
            pnlInputforn.Size = new Size(974, 181);
            pnlInputforn.TabIndex = 1;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Employee" });
            cbRole.Location = new Point(107, 44);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(193, 28);
            cbRole.TabIndex = 15;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // lblSalaryex
            // 
            lblSalaryex.AutoSize = true;
            lblSalaryex.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSalaryex.ForeColor = Color.Maroon;
            lblSalaryex.Location = new Point(323, 147);
            lblSalaryex.Name = "lblSalaryex";
            lblSalaryex.Size = new Size(0, 20);
            lblSalaryex.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(323, 114);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 13;
            label9.Text = "[Please Select One]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(323, 81);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 12;
            label8.Text = "[e.g 1111]";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(323, 51);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 11;
            label7.Text = "[e.g Md. Ahanaf Apon]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(323, 19);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 10;
            label6.Text = "[e.g a-001, e-001]";
            // 
            // tbSalary
            // 
            tbSalary.Location = new Point(107, 144);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(193, 27);
            tbSalary.TabIndex = 9;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(107, 112);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(193, 27);
            tbPassword.TabIndex = 7;
            // 
            // tbName
            // 
            tbName.Location = new Point(107, 12);
            tbName.Name = "tbName";
            tbName.Size = new Size(193, 27);
            tbName.TabIndex = 6;
            // 
            // tbUserId
            // 
            tbUserId.Location = new Point(107, 79);
            tbUserId.Name = "tbUserId";
            tbUserId.Size = new Size(193, 27);
            tbUserId.TabIndex = 5;
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(20, 149);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(49, 20);
            lblSalary.TabIndex = 4;
            lblSalary.Text = "Salary";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(20, 50);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(39, 20);
            lblRole.TabIndex = 3;
            lblRole.Text = "Role";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 114);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUserId
            // 
            lblUserId.AutoSize = true;
            lblUserId.Location = new Point(20, 81);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(55, 20);
            lblUserId.TabIndex = 0;
            lblUserId.Text = "User Id";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(lblTitle);
            panel2.Location = new Point(337, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 35);
            panel2.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(10, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Admin/Employee";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 617);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEmployee";
            FormClosed += AddEmployee_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlButton.ResumeLayout(false);
            pnlInputforn.ResumeLayout(false);
            pnlInputforn.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel pnlInputforn;
        private Label lblRole;
        private Label lblName;
        private Label lblPassword;
        private Label lblUserId;
        private Label lblSalary;
        private TextBox tbSalary;
        private TextBox tbPassword;
        private TextBox tbName;
        private TextBox tbUserId;
        private Label lblSalaryex;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnRemove;
        private Button btnAssign;
        private Button btnSave;
        private Button btnUpdate;
        private Panel pnlButton;
        private DataGridView dataGridView1;
        private Button btnBack;
        private ComboBox cbRole;
        private Button btnSearch;
        private TextBox tbSearch;
        private Button btnShow;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmPassword;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmSalary;
        private DataGridViewTextBoxColumn clmRole;
        private Panel panel2;
    }
}