namespace Stocky
{
    partial class Sales
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
            dgvSales = new DataGridView();
            clmName = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmProductId = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmSell = new DataGridViewTextBoxColumn();
            clmSellId = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            lblSell = new Label();
            lblSelect = new Label();
            lblClear = new Label();
            lblAddtoCart = new Label();
            btnClear = new Button();
            cmbCategory = new ComboBox();
            dtpSellDate = new DateTimePicker();
            tbPrice = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            tbProductId = new TextBox();
            tbQuantity = new TextBox();
            tbName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            lblName = new Label();
            panel2 = new Panel();
            btnShowCart = new Button();
            btnCart = new Button();
            btnStock = new Button();
            btnSearch = new Button();
            tbSearch = new TextBox();
            btnShow = new Button();
            btnSell = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.BackgroundColor = SystemColors.ControlLight;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { clmName, clmCategory, clmProductId, clmQuantity, clmPrice, clmSell, clmSellId });
            dgvSales.Location = new Point(3, 347);
            dgvSales.Margin = new Padding(3, 4, 3, 4);
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersWidth = 51;
            dgvSales.RowTemplate.Height = 24;
            dgvSales.Size = new Size(992, 375);
            dgvSales.TabIndex = 0;
            dgvSales.CellDoubleClick += dgvSales_CellDoubleClick;
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
            // clmSell
            // 
            clmSell.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmSell.HeaderText = "Sell Date";
            clmSell.MinimumWidth = 6;
            clmSell.Name = "clmSell";
            clmSell.ReadOnly = true;
            // 
            // clmSellId
            // 
            clmSellId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmSellId.HeaderText = "Sell Id";
            clmSellId.MinimumWidth = 6;
            clmSellId.Name = "clmSellId";
            clmSellId.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(4, 15);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 326);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientActiveCaption;
            panel3.Controls.Add(lblSell);
            panel3.Controls.Add(lblSelect);
            panel3.Controls.Add(lblClear);
            panel3.Controls.Add(lblAddtoCart);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(dtpSellDate);
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
            panel3.Location = new Point(5, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(982, 253);
            panel3.TabIndex = 1;
            // 
            // lblSell
            // 
            lblSell.AutoSize = true;
            lblSell.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSell.ForeColor = Color.DarkRed;
            lblSell.Location = new Point(446, 205);
            lblSell.Name = "lblSell";
            lblSell.Size = new Size(336, 23);
            lblSell.TabIndex = 17;
            lblSell.Text = "*To Sell Product Click Sell After Selection";
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSelect.ForeColor = Color.DarkRed;
            lblSelect.Location = new Point(22, 182);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(323, 23);
            lblSelect.TabIndex = 16;
            lblSelect.Text = "*Double Click to add or update product\r\n";
            // 
            // lblClear
            // 
            lblClear.AutoSize = true;
            lblClear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblClear.ForeColor = Color.DarkRed;
            lblClear.Location = new Point(447, 182);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(317, 23);
            lblClear.TabIndex = 15;
            lblClear.Text = "*To Clear Data From Boxes Click Clear";
            // 
            // lblAddtoCart
            // 
            lblAddtoCart.AutoSize = true;
            lblAddtoCart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddtoCart.ForeColor = Color.DarkRed;
            lblAddtoCart.Location = new Point(22, 205);
            lblAddtoCart.Name = "lblAddtoCart";
            lblAddtoCart.Size = new Size(283, 23);
            lblAddtoCart.TabIndex = 14;
            lblAddtoCart.Text = "*To Add Product Click Add to Cart";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.Control;
            btnClear.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnClear.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(809, 182);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 54);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Electronics", "Furniture" });
            cmbCategory.Location = new Point(134, 72);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(249, 28);
            cmbCategory.TabIndex = 11;
            // 
            // dtpSellDate
            // 
            dtpSellDate.Location = new Point(673, 120);
            dtpSellDate.Margin = new Padding(3, 4, 3, 4);
            dtpSellDate.Name = "dtpSellDate";
            dtpSellDate.Size = new Size(250, 27);
            dtpSellDate.TabIndex = 10;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(673, 66);
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
            label4.Location = new Point(566, 120);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 8;
            label4.Text = "Sell Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(566, 68);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold);
            label1.Location = new Point(566, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 6;
            label1.Text = "Quantity";
            // 
            // tbProductId
            // 
            tbProductId.Location = new Point(133, 117);
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
            tbName.Location = new Point(133, 21);
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
            label3.Location = new Point(19, 124);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "Product Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 77);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(19, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(60, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(btnShowCart);
            panel2.Controls.Add(btnCart);
            panel2.Controls.Add(btnStock);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(tbSearch);
            panel2.Controls.Add(btnShow);
            panel2.Controls.Add(btnSell);
            panel2.Location = new Point(3, 261);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 63);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // btnShowCart
            // 
            btnShowCart.BackColor = SystemColors.Control;
            btnShowCart.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnShowCart.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnShowCart.FlatStyle = FlatStyle.Flat;
            btnShowCart.Location = new Point(731, 3);
            btnShowCart.Margin = new Padding(3, 4, 3, 4);
            btnShowCart.Name = "btnShowCart";
            btnShowCart.Size = new Size(114, 54);
            btnShowCart.TabIndex = 7;
            btnShowCart.Text = "Show Cart";
            btnShowCart.UseVisualStyleBackColor = false;
            btnShowCart.Click += btnShowCart_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = SystemColors.Control;
            btnCart.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnCart.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Location = new Point(606, 4);
            btnCart.Margin = new Padding(3, 4, 3, 4);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(114, 54);
            btnCart.TabIndex = 6;
            btnCart.Text = "Add to Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = SystemColors.Control;
            btnStock.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnStock.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Location = new Point(356, 4);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(114, 54);
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
            btnSearch.Location = new Point(231, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 54);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(11, 17);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Multiline = true;
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Product Name";
            tbSearch.Size = new Size(209, 27);
            tbSearch.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.Control;
            btnShow.Cursor = Cursors.Hand;
            btnShow.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnShow.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Location = new Point(481, 4);
            btnShow.Margin = new Padding(3, 4, 3, 4);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(114, 54);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show Sales";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // btnSell
            // 
            btnSell.BackColor = SystemColors.Control;
            btnSell.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnSell.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.Location = new Point(856, 3);
            btnSell.Margin = new Padding(3, 4, 3, 4);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(114, 54);
            btnSell.TabIndex = 0;
            btnSell.Text = "Sell";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLightLight;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            btnBack.Location = new Point(12, 723);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(123, 49);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1000, 771);
            Controls.Add(btnBack);
            Controls.Add(panel1);
            Controls.Add(dgvSales);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Sales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SalesDashboard";
            FormClosed += Sales_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpSellDate;
        private Button btnSearch;
        private Button btnStock;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmProductId;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmSell;
        private DataGridViewTextBoxColumn clmSellId;
        private Button btnCart;
        private Label lblSelect;
        private Label lblClear;
        private Label lblAddtoCart;
        private Label lblSell;
        private Button btnShowCart;
    }
}