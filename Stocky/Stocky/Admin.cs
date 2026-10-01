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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string name)
        {
            InitializeComponent();
            lblUsername.Text = name;
        }
        private void timer4_Tick_1(object sender, EventArgs e)
        {
            lblDateTime.Text = "📅" + DateTime.Now.ToString("MMMM dd, yyyy | hh:mm tt");
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            string adminName = lblUsername.Text;
            UploadStock stock = new UploadStock(adminName, "Admin");
            stock.Show();
            this.Hide();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee stock = new AddEmployee();
            stock.Show();
            this.Hide();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            string adminName = lblUsername.Text;
            Sales salesform = new Sales(adminName);
            salesform.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            string adminName = lblUsername.Text;
            SalesReport reportForm = new SalesReport(adminName);
            reportForm.Show();
            this.Hide();
        }
    }
}