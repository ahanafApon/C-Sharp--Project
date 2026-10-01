using System;
using System.Data;
using System.Data.Common;

namespace Stocky
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = tbUserId.Text;
            string password = tbPassword.Text;
            try
            {
                DataAccess da = new DataAccess();
                string sql = $"select * from StockyLogin where ID='{userId}' and password='{password}';";

                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count == 1)
                {
                    string userRole = dt.Rows[0]["Role"].ToString();
                    string userName = dt.Rows[0]["Name"].ToString();

                    if (userRole == "Admin")
                    {
                        MessageBox.Show("Login Successful! Welcome to the Admin Dashboard.");
                        Admin admin = new Admin(userName);
                        admin.Show();
                        this.Hide();
                    }
                    else if (userRole == "Employee")
                    {
                        MessageBox.Show("Login Successful! Welcome to the Employee Dashboard.");
                        EmployeeDashboard employee = new EmployeeDashboard(userName);
                        employee.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error!! Unrecognized user");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid user credentials!! Please try again.");
                    tbPassword.Clear();
                    tbPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUserId.Clear();
            tbPassword.Clear();
            tbUserId.Focus();
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

       