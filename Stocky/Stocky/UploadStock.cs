using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stocky
{
    public partial class UploadStock : Form
    {
        private string userName;
        private string userRole;
        private bool isNavigating = false;
        private bool isEditing = false;
        private DataAccess Da { get; set; }

        public UploadStock()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
        }

        public UploadStock(string name, string role = "Admin")
        {
            InitializeComponent();
            this.Da = new DataAccess();
            userName = name;
            userRole = role;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
        }

        private void UploadStock_Load(object sender, EventArgs e)
        {
            PopulateStockGridView();
        }

        private void PopulateStockGridView(string sql = "select * from Stock")
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(sql);

                dgvStocks.AutoGenerateColumns = false;

                dgvStocks.Columns["clmName"].DataPropertyName = "ProductName";
                dgvStocks.Columns["clmCategory"].DataPropertyName = "Category";
                dgvStocks.Columns["clmProductId"].DataPropertyName = "ProductId";
                dgvStocks.Columns["clmQuantity"].DataPropertyName = "Quantity";
                dgvStocks.Columns["clmPrice"].DataPropertyName = "Price";
                dgvStocks.Columns["clmPurchase"].DataPropertyName = "PurchaseDate";

                dgvStocks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Stock: " + ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEditing) return; 

            string selectedCategory = cmbCategory.Text.Trim();
            string prefix = "";

            if (selectedCategory.Equals("Electronics", StringComparison.OrdinalIgnoreCase))
            {
                prefix = "e-";
            }
            else if (selectedCategory.Equals("Furniture", StringComparison.OrdinalIgnoreCase))
            {
                prefix = "f-";
            }

            if (!string.IsNullOrEmpty(prefix))
            {
                try
                {
                    string query = $"SELECT TOP 1 ProductId FROM Stock WHERE ProductId LIKE '{prefix}%' ORDER BY ProductId DESC";
                    DataTable dt = Da.ExecuteQueryTable(query);

                    int nextNumber = 1;
                    if (dt.Rows.Count > 0)
                    {
                        string lastId = dt.Rows[0]["ProductId"].ToString();
                        if (lastId.Length > 2 && int.TryParse(lastId.Substring(2), out int currentNumber))
                        {
                            nextNumber = currentNumber + 1;
                        }
                    }

                    tbProductId.Text = $"{prefix}{nextNumber:D3}";
                }
                catch
                {
                    tbProductId.Text = $"{prefix}001";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductId.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbQuantity.Text) ||
                string.IsNullOrWhiteSpace(tbPrice.Text))
            {
                MessageBox.Show("Please fill out all required fields properly");
                return;
            }

            try
            {
                string productId = tbProductId.Text.Replace("'", "''");
                string name = tbName.Text.Replace("'", "''");
                string category = cmbCategory.Text.Replace("'", "''");
                int quantity = Convert.ToInt32(tbQuantity.Text);

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity cannot be negative or zero. Please enter a valid quantity.");
                    return;
                }

                decimal price = Convert.ToDecimal(tbPrice.Text);
                string purchaseDate = dtpPurchaseDate.Value.ToString("yyyy-MM-dd");

                DataAccess da = new DataAccess();
                string query = "";
                int rowsAffected = 0;

                if (isEditing)
                {
                    query = $"UPDATE Stock SET ProductName = '{name}', Category = '{category}', Quantity = {quantity}, Price = {price}, PurchaseDate = '{purchaseDate}' WHERE ProductId = '{productId}';";
                    rowsAffected = da.ExecuteDMLQuery(query);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stock Updated Successfully!");
                        PopulateStockGridView();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
                else
                {
                    string checkQuery = $"SELECT * FROM Stock WHERE ProductId = '{productId}'";
                    DataTable dt = da.ExecuteQueryTable(checkQuery);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Product ID already exists! You cannot use a previously assigned Product ID for a new stock.");
                        return;
                    }

                    query = $"INSERT INTO Stock (ProductId, ProductName, Category, Quantity, Price, PurchaseDate) VALUES ('{productId}', '{name}', '{category}', {quantity}, {price}, '{purchaseDate}');";
                    rowsAffected = da.ExecuteDMLQuery(query);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Stock Added Successfully!");
                        PopulateStockGridView();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Assignment failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProductId.Text))
            {
                MessageBox.Show("Please specify or double-click a product to remove quantity from.");
                return;
            }

            try
            {
                int removeQuantity = 1;
                if (!int.TryParse(tbQuantity.Text, out removeQuantity) || removeQuantity <= 0)
                {
                    removeQuantity = 1;
                }

                string productId = tbProductId.Text.Replace("'", "''");
                DataAccess da = new DataAccess();

                string checkStock = $"SELECT Quantity FROM Stock WHERE ProductId = '{productId}'";
                DataTable dtStock = da.ExecuteQueryTable(checkStock);

                if (dtStock.Rows.Count > 0)
                {
                    int currentQuantity = Convert.ToInt32(dtStock.Rows[0]["Quantity"]);

                    if (currentQuantity > removeQuantity)
                    {
                        string query = $"UPDATE Stock SET Quantity = Quantity - {removeQuantity} WHERE ProductId = '{productId}';";
                        int rowsAffected = da.ExecuteDMLQuery(query);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{removeQuantity} Product Removed Successfully!");
                            PopulateStockGridView();
                            ClearFields();
                        }
                    }
                    else
                    {
                        string query = $"DELETE FROM Stock WHERE ProductId = '{productId}';";
                        int rowsAffected = da.ExecuteDMLQuery(query);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"{removeQuantity} product removed. Product completely removed from stock!");
                            PopulateStockGridView();
                            ClearFields();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Product ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            PopulateStockGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Replace("'", "''");
            string sql = $"SELECT * FROM Stock WHERE ProductName LIKE '%{search}%' OR ProductId LIKE '%{search}%' OR Category LIKE '%{search}%'";
            PopulateStockGridView(sql);
        }

        private void dgvStocks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStocks.Rows[e.RowIndex];

                tbName.Text = Convert.ToString(row.Cells["clmName"].Value);
                cmbCategory.Text = Convert.ToString(row.Cells["clmCategory"].Value);
                tbProductId.Text = Convert.ToString(row.Cells["clmProductId"].Value);
                tbQuantity.Text = Convert.ToString(row.Cells["clmQuantity"].Value);
                tbPrice.Text = Convert.ToString(row.Cells["clmPrice"].Value);

                string date = Convert.ToString(row.Cells["clmPurchase"].Value);
                if (!string.IsNullOrWhiteSpace(date))
                {
                    dtpPurchaseDate.Text = date;
                }
                else
                {
                    dtpPurchaseDate.Value = DateTime.Now;
                }

                isEditing = true;
                tbProductId.Enabled = false;
                tbQuantity.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            PopulateStockGridView();
        }

        private void ClearFields()
        {
            tbName.Clear();
            cmbCategory.SelectedIndex = -1;
            tbProductId.Clear();
            tbQuantity.Clear();
            tbPrice.Clear();
            tbSearch.Clear();
            dtpPurchaseDate.Value = DateTime.Now;
            isEditing = false;
            tbProductId.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            isNavigating = true;
            if (userRole == "Employee")
            {
                EmployeeDashboard empDashboard = new EmployeeDashboard(userName);
                empDashboard.Show();
            }
            else
            {
                Admin admin = new Admin(userName);
                admin.Show();
            }
            this.Close();
        }

        private void UploadStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNavigating)
            {
                Application.Exit();
            }
        }
    }
}