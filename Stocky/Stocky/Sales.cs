using Microsoft.VisualBasic;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Stocky
{
    public partial class Sales : Form
    {
        private string userName;
        private string userRole;
        private bool isViewingSales = false;
        private bool isViewingCart = false;
        private bool isNavigating = false;

        private DataTable cartTable = new DataTable();

        private DataAccess Da { get; set; }

        public Sales()
        {
            InitializeComponent();
            InitializeCartTable();
        }

        public Sales(string name, string role = "Admin")
        {
            InitializeComponent();
            tbProductId.ReadOnly = true;
            tbPrice.ReadOnly = true;

            this.Da = new DataAccess();
            userName = name;
            userRole = role;
            InitializeCartTable();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            PopulateStockGridView();
        }

        private void InitializeCartTable()
        {
            if (cartTable.Columns.Count == 0)
            {
                cartTable.Columns.Add("ProductId", typeof(string));
                cartTable.Columns.Add("ProductName", typeof(string));
                cartTable.Columns.Add("Category", typeof(string));
                cartTable.Columns.Add("Quantity", typeof(int));
                cartTable.Columns.Add("Price", typeof(decimal));
            }
        }

        private string GenerateSellId()
        {
            try
            {
                DataAccess da = new DataAccess();
                string sql = "SELECT TOP 1 SaleId FROM Sales ORDER BY SaleId DESC";
                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    string lastId = dt.Rows[0]["SaleId"].ToString();
                    int number = Convert.ToInt32(lastId.Split('-')[1]);
                    return "SL-" + (number + 1).ToString("D3");
                }

                return "SL-001";
            }
            catch (Exception)
            {
                return "SL-000";
            }
        }

        private void PopulateStockGridView(string sql = "select * from Stock")
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(sql);

                dgvSales.AutoGenerateColumns = false;
                dgvSales.Columns["clmSellId"].Visible = false;

                dgvSales.Columns["clmName"].DataPropertyName = "ProductName";
                dgvSales.Columns["clmCategory"].DataPropertyName = "Category";
                dgvSales.Columns["clmProductId"].DataPropertyName = "ProductId";
                dgvSales.Columns["clmQuantity"].DataPropertyName = "Quantity";
                dgvSales.Columns["clmPrice"].DataPropertyName = "Price";
                dgvSales.Columns["clmSell"].DataPropertyName = "PurchaseDate";

                dgvSales.DataSource = dt;
                isViewingSales = false;
                isViewingCart = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Stock: " + ex.Message);
            }
        }

        private void PopulateSalesGridView(string sql = "select * from Sales")
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(sql);

                dgvSales.AutoGenerateColumns = false;

                dgvSales.Columns["clmSellId"].Visible = true;
                dgvSales.Columns["clmSellId"].DataPropertyName = "SaleId";

                dgvSales.Columns["clmName"].DataPropertyName = "ProductName";
                dgvSales.Columns["clmCategory"].DataPropertyName = "Category";
                dgvSales.Columns["clmProductId"].DataPropertyName = "ProductId";
                dgvSales.Columns["clmQuantity"].DataPropertyName = "Quantity";
                dgvSales.Columns["clmPrice"].DataPropertyName = "Price";
                dgvSales.Columns["clmSell"].DataPropertyName = "PurchaseDate";

                dgvSales.DataSource = dt;
                isViewingSales = true;
                isViewingCart = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Sales: " + ex.Message);
            }
        }

        private void PopulateCartGridView()
        {
            dgvSales.AutoGenerateColumns = false;
            dgvSales.Columns["clmSellId"].Visible = false;

            dgvSales.Columns["clmName"].DataPropertyName = "ProductName";
            dgvSales.Columns["clmCategory"].DataPropertyName = "Category";
            dgvSales.Columns["clmProductId"].DataPropertyName = "ProductId";
            dgvSales.Columns["clmQuantity"].DataPropertyName = "Quantity";
            dgvSales.Columns["clmPrice"].DataPropertyName = "Price";
            dgvSales.Columns["clmSell"].DataPropertyName = "";

            dgvSales.DataSource = cartTable;
            isViewingSales = false;
            isViewingCart = true;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbQuantity.Text) ||
                string.IsNullOrWhiteSpace(tbPrice.Text) ||
                string.IsNullOrWhiteSpace(tbProductId.Text))
            {
                MessageBox.Show("Please fill out all required fields properly");
                return;
            }

            try
            {
                string productId = tbProductId.Text.Replace("'", "''");
                string name = tbName.Text.Replace("'", "''");
                string category = cmbCategory.Text.Replace("'", "''");
                int sellQuantity = Convert.ToInt32(tbQuantity.Text);
                decimal price = Convert.ToDecimal(tbPrice.Text);

                DataAccess da = new DataAccess();
                string checkStock = $"SELECT Quantity FROM Stock WHERE ProductId='{productId}'";
                DataTable dtStock = da.ExecuteQueryTable(checkStock);

                if (dtStock.Rows.Count > 0)    
                {
                    int currentStock = Convert.ToInt32(dtStock.Rows[0]["Quantity"]);

                    if (sellQuantity > currentStock)
                    {
                        MessageBox.Show($"Stock Unavailable! Only {currentStock} items left in Stock.");
                        return;
                    }

                    string updateStock = $"UPDATE Stock SET Quantity = Quantity - {sellQuantity} WHERE ProductId = '{productId}'";
                    int stockUpdateResult = da.ExecuteDMLQuery(updateStock);

                    if (stockUpdateResult <= 0)
                    {
                        MessageBox.Show("Failed to update stock temporarily.");
                        return;
                    }

                    DataRow existingRow = null;
                    foreach (DataRow cartRow in cartTable.Rows)
                    {
                        if (cartRow.RowState != DataRowState.Deleted && cartRow["ProductId"].ToString() == productId)
                        {
                            existingRow = cartRow;
                            break;
                        }
                    }

                    if (existingRow != null)
                    {
                        existingRow["Quantity"] = Convert.ToInt32(existingRow["Quantity"]) + sellQuantity;
                        MessageBox.Show("Cart quantity updated and stock temporarily deducted!");
                    }
                    else
                    {
                        cartTable.Rows.Add(productId, name, category, sellQuantity, price);
                        MessageBox.Show("Item added to cart and stock temporarily deducted!");
                    }
                }
                else
                {
                    MessageBox.Show("Product Id not found in Stock!!");
                    return;
                }

                PopulateCartGridView();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding to cart: " + ex.Message);
            }
        }

        private void btnShowCart_Click(object sender, EventArgs e)
        {
            PopulateCartGridView();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (cartTable == null || cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty! Please add products to the cart before completing the sale.");
                return;
            }

            try
            {
                DataAccess da = new DataAccess();
                string sellDate = dtpSellDate.Value.ToString("yyyy-MM-dd");
                int totalSuccessRows = 0;

                foreach (DataRow row in cartTable.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    string uniqueSellId = GenerateSellId();

                    string productId = row["ProductId"].ToString();
                    string productName = row["ProductName"].ToString().Replace("'", "''");
                    string category = row["Category"].ToString().Replace("'", "''");
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["Price"]);

                    string insertSales = $"INSERT INTO Sales (SaleId, ProductId, ProductName, Category, Quantity, Price, PurchaseDate) " +
                                         $"VALUES ('{uniqueSellId}', '{productId}', '{productName}', '{category}', {quantity}, {price}, '{sellDate}')";
                    int insertResult = da.ExecuteDMLQuery(insertSales);

                    if (insertResult > 0)
                    {
                        totalSuccessRows++;
                    }
                }

                if (totalSuccessRows > 0)
                {
                    MessageBox.Show("Checkout Successful!");
                    cartTable.Clear();
                    PopulateStockGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Checkout failed. No records were saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Checkout Error: " + ex.Message);
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            PopulateStockGridView();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PopulateSalesGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Replace("'", "''");

            if (isViewingSales)
            {
                string sql = $"SELECT * FROM Sales WHERE ProductName LIKE '%{search}%' OR ProductId LIKE '%{search}%' OR SaleId LIKE '%{search}%'";
                PopulateSalesGridView(sql);
            }
            else if (isViewingCart)
            {
                MessageBox.Show("Searching is only available in Stock or Sales view.");
            }
            else
            {
                string sql = $"SELECT * FROM Stock WHERE ProductName LIKE '%{search}%' OR ProductId LIKE '%{search}%'";
                PopulateStockGridView(sql);
            }
        }

        private void dgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (isViewingCart)
                {
                    DataGridViewRow row = dgvSales.Rows[e.RowIndex];
                    string productId = row.Cells["clmProductId"].Value.ToString();
                    int currentCartQty = Convert.ToInt32(row.Cells["clmQuantity"].Value);

                    DialogResult result = MessageBox.Show("Click Yes to Edit Quantity, or No to Remove Item from Cart.", "Cart Options", MessageBoxButtons.YesNoCancel);

                    DataAccess da = new DataAccess();

                    if (result == DialogResult.Yes)
                    {
                        string input = Interaction.InputBox("Enter new quantity:", "Edit Quantity", currentCartQty.ToString());

                        if (!string.IsNullOrEmpty(input))
                        {
                            if (int.TryParse(input, out int newQty))
                            {
                                if (newQty <= 0)
                                {
                                    string restoreStock = $"UPDATE Stock SET Quantity = Quantity + {currentCartQty} WHERE ProductId = '{productId}'";
                                     da.ExecuteDMLQuery(restoreStock);

                                    cartTable.Rows[e.RowIndex].Delete();
                                    MessageBox.Show("Item removed from cart and stock restored.");
                                }
                                else
                                {
                                    string checkStock = $"SELECT Quantity FROM Stock WHERE ProductId='{productId}'";
                                    DataTable dtStock = da.ExecuteQueryTable(checkStock);

                                    if (dtStock.Rows.Count > 0)
                                    {
                                        int currentStock = Convert.ToInt32(dtStock.Rows[0]["Quantity"]);
                                        int qtyDifference = newQty - currentCartQty;

                                        if (qtyDifference > 0 && qtyDifference > currentStock)
                                        {
                                            MessageBox.Show($"Stock Unavailable! Only {currentStock} more items left in Stock.");
                                            return;
                                        }

                                        string adjustStock = $"UPDATE Stock SET Quantity = Quantity - {qtyDifference} WHERE ProductId = '{productId}'";
                                        da.ExecuteDMLQuery(adjustStock);

                                        DataRowView drv = (DataRowView)row.DataBoundItem;
                                        drv["Quantity"] = newQty;
                                        MessageBox.Show("Quantity updated successfully!");
                                    }
                                }
                                PopulateCartGridView();
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid number.");
                            }
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        string restoreStock = $"UPDATE Stock SET Quantity = Quantity + {currentCartQty} WHERE ProductId = '{productId}'";
                        da.ExecuteDMLQuery(restoreStock);

                        cartTable.Rows[e.RowIndex].Delete();
                        MessageBox.Show("Item removed from cart and stock restored.");
                        PopulateCartGridView();
                    }

                    return;
                }

                if (!isViewingSales && !isViewingCart)
                {
                    DataGridViewRow row = dgvSales.Rows[e.RowIndex];

                    tbName.Text = Convert.ToString(row.Cells["clmName"].Value);
                    cmbCategory.Text = Convert.ToString(row.Cells["clmCategory"].Value);
                    tbProductId.Text = Convert.ToString(row.Cells["clmProductId"].Value);

                    tbQuantity.Clear();

                    string priceStr = Convert.ToString(row.Cells["clmPrice"].Value);
                    if (decimal.TryParse(priceStr, out decimal basePrice))
                    {
                        decimal finalPrice = basePrice;

                        if (basePrice < 10000)
                        {
                            finalPrice += 500;
                        }
                        else if (basePrice >= 10000 && basePrice < 30000)
                        {
                            finalPrice += 1000;
                        }
                        else if (basePrice >= 30000 && basePrice < 50000)
                        {
                            finalPrice += 1500;
                        }
                        else if (basePrice >= 50000 && basePrice < 70000)
                        {
                            finalPrice += 2000;
                        }
                        else if (basePrice >= 70000 && basePrice < 100000)
                        {
                            finalPrice += 3000;
                        }
                        else if (basePrice >= 100000 && basePrice < 200000)
                        {
                            finalPrice += 4000;
                        }
                        else
                        {
                            finalPrice += 5000;
                        }

                        tbPrice.Text = finalPrice.ToString("0.00");
                    }
                    else
                    {
                        tbPrice.Clear();
                    }

                    string date = Convert.ToString(row.Cells["clmSell"].Value);
                    if (!string.IsNullOrWhiteSpace(date))
                    {
                        dtpSellDate.Text = date;
                    }
                    else
                    {
                        dtpSellDate.Value = DateTime.Now;
                    }

                    tbQuantity.Focus();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            isNavigating = true;
            RestoreCartStockOnExit();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            if (isViewingSales) PopulateSalesGridView();
            else if (isViewingCart) PopulateCartGridView();
            else PopulateStockGridView();
        }

        private void ClearFields()
        {
            tbName.Clear();
            cmbCategory.SelectedIndex = -1;
            tbProductId.Clear();
            tbQuantity.Clear();
            tbPrice.Clear();
            tbSearch.Clear();
            dtpSellDate.Value = DateTime.Now;
        }

        private void RestoreCartStockOnExit()
        {
            if (cartTable != null && cartTable.Rows.Count > 0)
            {
                DataAccess da = new DataAccess();
                foreach (DataRow row in cartTable.Rows)
                {
                    if (row.RowState == DataRowState.Deleted) continue;

                    string productId = row["ProductId"].ToString();
                    int quantity = Convert.ToInt32(row["Quantity"]);

                    string restoreStock = $"UPDATE Stock SET Quantity = Quantity + {quantity} WHERE ProductId = '{productId}'";
                    da.ExecuteDMLQuery(restoreStock);
                }
                cartTable.Clear();
            }
        }

        private void Sales_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNavigating)
            {
                RestoreCartStockOnExit();
                Application.Exit();
            }
        }
    }
}