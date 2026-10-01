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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Stocky
{
    public partial class SalesReport : Form
    {
        private string userName;
        private bool isNavigating = false;
        private DataAccess Da { get; set; }

        public SalesReport()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesReport_FormClosed);

        }

        public SalesReport(string name)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            userName = name;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SalesReport_FormClosed);
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            PopulateReportGridView();
            LoadTotals();

        }

        private void PopulateReportGridView(string sql = "select * from Sales")
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(sql);

                dgvSalesReport.AutoGenerateColumns = false;

                dgvSalesReport.Columns["clmSaleId"].DataPropertyName = "SaleId";
                dgvSalesReport.Columns["clmName"].DataPropertyName = "ProductName";
                dgvSalesReport.Columns["clmCategory"].DataPropertyName = "Category";
                dgvSalesReport.Columns["clmProductId"].DataPropertyName = "ProductId";
                dgvSalesReport.Columns["clmQuantity"].DataPropertyName = "Quantity";
                dgvSalesReport.Columns["clmPrice"].DataPropertyName = "Price";
                dgvSalesReport.Columns["clmPurchaseDate"].DataPropertyName = "PurchaseDate";

                dgvSalesReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Sales Report: " + ex.Message);
            }
        }

        private void LoadTotals(string sql = "select * from Sales")
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(sql);

                int totalTransactions = dt.Rows.Count;
                int totalItemsSold = 0;
                decimal totalRevenue = 0;

                foreach (DataRow row in dt.Rows)
                {
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["Price"]);

                    totalItemsSold += quantity;
                    totalRevenue += quantity * price;
                }

                tbTotalTransactions.Text = totalTransactions.ToString();
                tbTotalItemsSold.Text = totalItemsSold.ToString();
                tbTotalRevenue.Text = totalRevenue.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Totals: " + ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            isNavigating = true;
            Admin admin = new Admin(userName);
            admin.Show();
            this.Close();
        }


        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");
                string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");

                if (dtpStartDate.Value.Date > dtpEndDate.Value.Date)
                {
                    MessageBox.Show("Start Date cannot be later than End Date");
                    return;
                }

                string sql = $"select * from Sales where PurchaseDate between '{startDate}' and '{endDate}'";

                PopulateReportGridView(sql);
                LoadTotals(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Applying Filter: " + ex.Message);
            }
        }
        private void SalesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNavigating)
            {
                Application.Exit();
            }
        }
    }
}