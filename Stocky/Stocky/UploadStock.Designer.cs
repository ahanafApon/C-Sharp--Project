namespace Stocky
{
    partial class UploadStock
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
            btnBack = new Button();
            btnStock = new Button();
            btnSearch = new Button();
            tbSearch = new TextBox();
            btnClear = new Button();
            btnRemove = new Button();
            panel2 = new Panel();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            dtpPurchaseDate = new DateTimePicker();
            tbPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dgvStocks = new DataGridView();
            clmName = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmProductId = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmPurchase = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tbProductId = new TextBox();
            tbQuantity = new TextBox();
            tbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblName = new Label();
            panel3 = new Panel();
            label6 = new Label();
            lblNote = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStocks).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnBack.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(6, 715);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(132, 49);
            btnBack.TabIndex = 5;
            btnBack.Text = "<<Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            btnStock.BackColor = SystemColors.Control;
            btnStock.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnStock.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Location = new Point(410, 6);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(116, 54);
            btnStock.TabIndex = 5;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnSearch.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(218, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 54);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(3, 17);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Multiline = true;
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Product ";
            tbSearch.Size = new Size(209, 27);
            tbSearch.TabIndex = 3;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnClear.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(809, 150);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 54);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = SystemColors.Control;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnRemove.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(610, 6);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(114, 54);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(btnStock);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(tbSearch);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(btnSave);
            panel2.Location = new Point(7, 225);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 63);
            panel2.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnSave.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(807, 6);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 54);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Electronics", "Furniture" });
            cmbCategory.Location = new Point(127, 63);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(249, 28);
            cmbCategory.TabIndex = 11;
            // 
            // dtpPurchaseDate
            // 
            dtpPurchaseDate.Location = new Point(675, 115);
            dtpPurchaseDate.Margin = new Padding(3, 4, 3, 4);
            dtpPurchaseDate.Name = "dtpPurchaseDate";
            dtpPurchaseDate.Size = new Size(250, 27);
            dtpPurchaseDate.TabIndex = 10;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(673, 64);
            tbPrice.Margin = new Padding(3, 4, 3, 4);
            tbPrice.Multiline = true;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(250, 34);
            tbPrice.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(536, 113);
            label4.Name = "label4";
            label4.Size = new Size(133, 23);
            label4.TabIndex = 8;
            label4.Text = "Purchase Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(543, 64);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // dgvStocks
            // 
            dgvStocks.AllowUserToAddRows = false;
            dgvStocks.AllowUserToDeleteRows = false;
            dgvStocks.BackgroundColor = SystemColors.ControlLight;
            dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStocks.Columns.AddRange(new DataGridViewColumn[] { clmName, clmCategory, clmProductId, clmQuantity, clmPrice, clmPurchase });
            dgvStocks.Location = new Point(3, 308);
            dgvStocks.Margin = new Padding(3, 4, 3, 4);
            dgvStocks.Name = "dgvStocks";
            dgvStocks.ReadOnly = true;
            dgvStocks.RowHeadersWidth = 51;
            dgvStocks.RowTemplate.Height = 24;
            dgvStocks.Size = new Size(992, 399);
            dgvStocks.TabIndex = 3;
            dgvStocks.CellDoubleClick += dgvStocks_CellDoubleClick;
            // 
            // clmName
            // 
            clmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            // 
            // clmCategory
            // 
            clmCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmCategory.HeaderText = "Category";
            clmCategory.MinimumWidth = 6;
            clmCategory.Name = "clmCategory";
            clmCategory.ReadOnly = true;
            // 
            // clmProductId
            // 
            clmProductId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmProductId.HeaderText = "Product Id";
            clmProductId.MinimumWidth = 6;
            clmProductId.Name = "clmProductId";
            clmProductId.ReadOnly = true;
            // 
            // clmQuantity
            // 
            clmQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmQuantity.HeaderText = "Quantity";
            clmQuantity.MinimumWidth = 6;
            clmQuantity.Name = "clmQuantity";
            clmQuantity.ReadOnly = true;
            // 
            // clmPrice
            // 
            clmPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmPrice.HeaderText = "Unit Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            // 
            // clmPurchase
            // 
            clmPurchase.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmPurchase.HeaderText = "Purchase Date";
            clmPurchase.MinimumWidth = 6;
            clmPurchase.Name = "clmPurchase";
            clmPurchase.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold);
            label1.Location = new Point(543, 16);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 6;
            label1.Text = "Quantity";
            // 
            // tbProductId
            // 
            tbProductId.Location = new Point(127, 111);
            tbProductId.Margin = new Padding(3, 4, 3, 4);
            tbProductId.Multiline = true;
            tbProductId.Name = "tbProductId";
            tbProductId.Size = new Size(250, 34);
            tbProductId.TabIndex = 5;
            // 
            // tbQuantity
            // 
            tbQuantity.Location = new Point(673, 16);
            tbQuantity.Margin = new Padding(3, 4, 3, 4);
            tbQuantity.Multiline = true;
            tbQuantity.Name = "tbQuantity";
            tbQuantity.Size = new Size(250, 34);
            tbQuantity.TabIndex = 4;
            // 
            // tbName
            // 
            tbName.Location = new Point(129, 14);
            tbName.Margin = new Padding(3, 4, 3, 4);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(250, 34);
            tbName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Product Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(36, 16);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(lblNote);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(dtpPurchaseDate);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(tbPrice);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(tbProductId);
            panel3.Controls.Add(tbQuantity);
            panel3.Controls.Add(tbName);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblName);
            panel3.Location = new Point(7, 5);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 208);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(577, 171);
            label6.Name = "label6";
            label6.Size = new Size(226, 23);
            label6.TabIndex = 13;
            label6.Text = "*To Clear Data From Boxes";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNote.ForeColor = Color.DarkRed;
            lblNote.Location = new Point(57, 171);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(241, 23);
            lblNote.TabIndex = 12;
            lblNote.Text = "*Double Click For Select Row";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 7);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 305);
            panel1.TabIndex = 4;
            // 
            // UploadStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 771);
            Controls.Add(btnBack);
            Controls.Add(dgvStocks);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "UploadStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UploadStock";
            FormClosed += UploadStock_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStocks).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox5;
        private Button btnBack;
        private Button btnStock;
        private Button btnSearch;
        private TextBox tbSearch;
        private Button btnClear;
        private Button btnRemove;
        private Panel panel2;
        private Button btnSave;
        private ComboBox cmbCategory;
        private DateTimePicker dtpPurchaseDate;
        private TextBox tbPrice;
        private Label label4;
        private Label label5;
        private DataGridView dgvStocks;
        private Label label1;
        private TextBox tbProductId;
        private TextBox tbQuantity;
        private TextBox tbName;
        private Label label3;
        private Label label2;
        private Label lblName;
        private Panel panel3;
        private Panel panel1;
        private Label label6;
        private Label lblNote;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmProductId;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmPurchase;
    }
}