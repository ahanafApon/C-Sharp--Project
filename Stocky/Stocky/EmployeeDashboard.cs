using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Stocky
{
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        public EmployeeDashboard(string name)
        {
            InitializeComponent();
            lblUsername.Text = name;
        }

        private void EmployeeDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            string employeeName=lblUsername.Text;
            UploadStock stock = new UploadStock(employeeName,"Employee");
            stock.Show();
            this.Hide();
        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {
            string employeeName = lblUsername.Text;
            Sales salesform = new Sales(employeeName, "Employee");
            salesform.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void btnLoggedOut_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }
    }
}