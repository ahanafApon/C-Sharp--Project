namespace Stocky
{
    partial class SalesReport
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
            pnlSalesReport = new Panel();
            dgvSalesReport = new DataGridView();
            clmSaleId = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmProductId = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmPurchaseDate = new DataGridViewTextBoxColumn();
            btnApplyFilter = new Button();
            btnBack = new Button();
            panel3 = new Panel();
            tbTotalRevenue = new TextBox();
            tbTotalItemsSold = new TextBox();
            tbTotalTransactions = new TextBox();
            label3 = new Label();
            lblTotalTransactions = new Label();
            lblTotalItems = new Label();
            lblTotalRevenue = new Label();
            panel2 = new Panel();
            dtpEndDate = new DateTimePicker();
            lblEndDate = new Label();
            panel1 = new Panel();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            lblSalesReport = new Label();
            pnlSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSalesReport
            // 
            pnlSalesReport.Controls.Add(dgvSalesReport);
            pnlSalesReport.Controls.Add(btnApplyFilter);
            pnlSalesReport.Controls.Add(btnBack);
            pnlSalesReport.Controls.Add(panel3);
            pnlSalesReport.Controls.Add(panel2);
            pnlSalesReport.Controls.Add(panel1);
            pnlSalesReport.Controls.Add(lblSalesReport);
            pnlSalesReport.Location = new Point(14, 3);
            pnlSalesReport.Margin = new Padding(3, 4, 3, 4);
            pnlSalesReport.Name = "pnlSalesReport";
            pnlSalesReport.Size = new Size(883, 583);
            pnlSalesReport.TabIndex = 0;
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.AllowUserToAddRows = false;
            dgvSalesReport.AllowUserToDeleteRows = false;
            dgvSalesReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSalesReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalesReport.BackgroundColor = SystemColors.ControlLight;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Columns.AddRange(new DataGridViewColumn[] { clmSaleId, clmName, clmCategory, clmProductId, clmQuantity, clmPrice, clmPurchaseDate });
            dgvSalesReport.Location = new Point(10, 279);
            dgvSalesReport.Margin = new Padding(3, 4, 3, 4);
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.ReadOnly = true;
            dgvSalesReport.RowHeadersWidth = 51;
            dgvSalesReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalesReport.Size = new Size(850, 249);
            dgvSalesReport.TabIndex = 7;
            // 
            // clmSaleId
            // 
            clmSaleId.HeaderText = "Sale Id";
            clmSaleId.MinimumWidth = 6;
            clmSaleId.Name = "clmSaleId";
            clmSaleId.ReadOnly = true;
            // 
            // clmName
            // 
            clmName.HeaderText = "Product Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            // 
            // clmCategory
            // 
            clmCategory.HeaderText = "Category";
            clmCategory.MinimumWidth = 6;
            clmCategory.Name = "clmCategory";
            clmCategory.ReadOnly = true;
            // 
            // clmProductId
            // 
            clmProductId.HeaderText = "Product Id";
            clmProductId.MinimumWidth = 6;
            clmProductId.Name = "clmProductId";
            clmProductId.ReadOnly = true;
            // 
            // clmQuantity
            // 
            clmQuantity.HeaderText = "Quantity";
            clmQuantity.MinimumWidth = 6;
            clmQuantity.Name = "clmQuantity";
            clmQuantity.ReadOnly = true;
            // 
            // clmPrice
            // 
            clmPrice.HeaderText = "Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            // 
            // clmPurchaseDate
            // 
            clmPurchaseDate.HeaderText = "Purchase Date";
            clmPurchaseDate.MinimumWidth = 6;
            clmPurchaseDate.Name = "clmPurchaseDate";
            clmPurchaseDate.ReadOnly = true;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = SystemColors.Control;
            btnApplyFilter.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnApplyFilter.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApplyFilter.Location = new Point(755, 76);
            btnApplyFilter.Margin = new Padding(3, 4, 3, 4);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(119, 59);
            btnApplyFilter.TabIndex = 6;
            btnApplyFilter.Text = "Apply Filter";
            btnApplyFilter.UseVisualStyleBackColor = false;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(10, 536);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(104, 43);
            btnBack.TabIndex = 5;
            btnBack.Text = "<< Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbTotalRevenue);
            panel3.Controls.Add(tbTotalItemsSold);
            panel3.Controls.Add(tbTotalTransactions);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblTotalTransactions);
            panel3.Controls.Add(lblTotalItems);
            panel3.Controls.Add(lblTotalRevenue);
            panel3.Location = new Point(10, 156);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 113);
            panel3.TabIndex = 3;
            // 
            // tbTotalRevenue
            // 
            tbTotalRevenue.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbTotalRevenue.Location = new Point(623, 61);
            tbTotalRevenue.Multiline = true;
            tbTotalRevenue.Name = "tbTotalRevenue";
            tbTotalRevenue.Size = new Size(214, 44);
            tbTotalRevenue.TabIndex = 9;
            // 
            // tbTotalItemsSold
            // 
            tbTotalItemsSold.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbTotalItemsSold.Location = new Point(333, 61);
            tbTotalItemsSold.Multiline = true;
            tbTotalItemsSold.Name = "tbTotalItemsSold";
            tbTotalItemsSold.Size = new Size(186, 44);
            tbTotalItemsSold.TabIndex = 8;
            // 
            // tbTotalTransactions
            // 
            tbTotalTransactions.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            tbTotalTransactions.Location = new Point(50, 61);
            tbTotalTransactions.Multiline = true;
            tbTotalTransactions.Name = "tbTotalTransactions";
            tbTotalTransactions.Size = new Size(148, 44);
            tbTotalTransactions.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(681, 61);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransactions.ForeColor = Color.DarkRed;
            lblTotalTransactions.Location = new Point(30, 17);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(220, 32);
            lblTotalTransactions.TabIndex = 2;
            lblTotalTransactions.Text = "Total Transactions";
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItems.ForeColor = Color.DarkRed;
            lblTotalItems.Location = new Point(333, 17);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(197, 32);
            lblTotalItems.TabIndex = 1;
            lblTotalItems.Text = "Total Items Sold";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.ForeColor = Color.DarkRed;
            lblTotalRevenue.Location = new Point(655, 17);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(159, 44);
            lblTotalRevenue.TabIndex = 3;
            lblTotalRevenue.Text = "Total Revenue";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(dtpEndDate);
            panel2.Controls.Add(lblEndDate);
            panel2.Location = new Point(389, 67);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 81);
            panel2.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(83, 23);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(228, 27);
            dtpEndDate.TabIndex = 1;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndDate.ForeColor = Color.DarkRed;
            lblEndDate.Location = new Point(3, 25);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(83, 23);
            lblEndDate.TabIndex = 0;
            lblEndDate.Text = "End Date";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dtpStartDate);
            panel1.Controls.Add(lblStartDate);
            panel1.Location = new Point(37, 67);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 81);
            panel1.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(90, 28);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(228, 27);
            dtpStartDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartDate.ForeColor = Color.DarkRed;
            lblStartDate.Location = new Point(3, 28);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(93, 23);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Start Date";
            // 
            // lblSalesReport
            // 
            lblSalesReport.AutoSize = true;
            lblSalesReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesReport.ForeColor = Color.OliveDrab;
            lblSalesReport.Location = new Point(331, 13);
            lblSalesReport.Name = "lblSalesReport";
            lblSalesReport.Size = new Size(235, 32);
            lblSalesReport.TabIndex = 0;
            lblSalesReport.Text = "Stocky-Sales report";
            // 
            // SalesReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(907, 601);
            Controls.Add(pnlSalesReport);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SalesReport";
            Text = "SalesReport";
            pnlSalesReport.ResumeLayout(false);
            pnlSalesReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSalesReport;
        private Label lblSalesReport;
        private Panel panel2;
        private DateTimePicker dtpEndDate;
        private Label lblEndDate;
        private Panel panel1;
        private DateTimePicker dtpStartDate;
        private Label lblStartDate;
        private Panel panel3;
        private Label lblTotalItems;
        private Label lblTotalRevenue;
        private Button btnBack;
        private Button btnApplyFilter;
        private Label lblTotalTransactions;
        private Label label3;
        private TextBox tbTotalRevenue;
        private TextBox tbTotalItemsSold;
        private TextBox tbTotalTransactions;
        private DataGridView dgvSalesReport;
        private DataGridViewTextBoxColumn clmSaleId;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmProductId;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmPurchaseDate;
    }
}