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
    public partial class AddEmployee : Form
    {
        private string adminName;

        public AddEmployee()
        {
            InitializeComponent();
        }

        public AddEmployee(string name)
        {
            InitializeComponent();
            adminName = name;
            tbUserId.ReadOnly = true; 
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            PopulateEmployeeGridView();
        }

        private string GenerateUserId(string role)
        {
            try
            {
                string prefix = "";
                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    prefix = "a-";
                }
                else if (role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                {
                    prefix = "e-";
                }
                else
                {
                    return "";
                }

                DataAccess da = new DataAccess();
                string sql = $"SELECT TOP 1 ID FROM StockyLogin WHERE ID LIKE '{prefix}%' ORDER BY ID DESC";
                DataTable dt = da.ExecuteQueryTable(sql);

                if (dt.Rows.Count > 0)
                {
                    string lastId = dt.Rows[0]["ID"].ToString();
                    string[] parts = lastId.Split('-');
                    if (parts.Length > 1 && int.TryParse(parts[1], out int number))
                    {
                        return prefix + (number + 1).ToString("D3");
                    }
                }

                return prefix + "001";
            }
            catch (Exception)
            {
                return "";
            }
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedItem != null)
            {
                string selectedRole = cbRole.SelectedItem.ToString();
                tbUserId.Text = GenerateUserId(selectedRole);
            }
        }

        private void PopulateEmployeeGridView(string sql = "SELECT * FROM StockyLogin")
        {
            try
            {
                DataAccess da = new DataAccess();
                DataTable dt = da.ExecuteQueryTable(sql);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns["clmId"].DataPropertyName = "ID";
                dataGridView1.Columns["clmPassword"].DataPropertyName = "Password";
                dataGridView1.Columns["clmName"].DataPropertyName = "Name";
                dataGridView1.Columns["clmSalary"].DataPropertyName = "Salary";
                dataGridView1.Columns["clmRole"].DataPropertyName = "Role";

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Employees: " + ex.Message);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserId.Text) ||
                string.IsNullOrWhiteSpace(tbName.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Please fill out all required fields properly");
                return;
            }

            try
            {
                string userId = tbUserId.Text.Replace("'", "''");
                string name = tbName.Text.Replace("'", "''");
                string password = tbPassword.Text.Replace("'", "''");
                string role = cbRole.Text.Replace("'", "''");
                decimal salary = string.IsNullOrWhiteSpace(tbSalary.Text) ? 0 : Convert.ToDecimal(tbSalary.Text);

                DataAccess da = new DataAccess();

                string query = $"INSERT INTO StockyLogin (ID, Name, Password, Role, Salary) VALUES ('{userId}', '{name}', '{password}', '{role}', {salary});";
                int rowsAffected = da.ExecuteDMLQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee Assigned Successfully!");
                    PopulateEmployeeGridView();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserId.Text))
            {
                MessageBox.Show("Please specify the User Id to update.");
                return;
            }

            try
            {
                string userId = tbUserId.Text.Replace("'", "''");
                string name = tbName.Text.Replace("'", "''");
                string password = tbPassword.Text.Replace("'", "''");
                string role = cbRole.Text.Replace("'", "''");
                decimal salary = string.IsNullOrWhiteSpace(tbSalary.Text) ? 0 : Convert.ToDecimal(tbSalary.Text);

                DataAccess da = new DataAccess();
                string query = $"UPDATE StockyLogin SET Name = '{name}', Password = '{password}', Role = '{role}', Salary = {salary} WHERE ID = '{userId}';";
                int rowsAffected = da.ExecuteDMLQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee Details Updated Successfully!");
                    PopulateEmployeeGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Employee ID not found for update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUserId.Text))
            {
                MessageBox.Show("Please specify the User Id to remove.");
                return;
            }

            try
            {
                string userId = tbUserId.Text.Replace("'", "''");
                DataAccess da = new DataAccess();
                string query = $"DELETE FROM StockyLogin WHERE ID = '{userId}';";
                int rowsAffected = da.ExecuteDMLQuery(query);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee Removed Successfully!");
                    PopulateEmployeeGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Employee ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            PopulateEmployeeGridView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text.Replace("'", "''");
            string sql = $"SELECT * FROM StockyLogin WHERE Name LIKE '%{search}%' OR ID LIKE '%{search}%'";
            PopulateEmployeeGridView(sql);
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                tbUserId.Text = Convert.ToString(row.Cells["clmId"].Value);
                tbPassword.Text = Convert.ToString(row.Cells["clmPassword"].Value);
                tbName.Text = Convert.ToString(row.Cells["clmName"].Value);
                tbSalary.Text = Convert.ToString(row.Cells["clmSalary"].Value);
                cbRole.Text = Convert.ToString(row.Cells["clmRole"].Value);

                tbName.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(adminName);
            admin.Show();
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ClearFields();
            PopulateEmployeeGridView();
        }

        private void ClearFields()
        {
            tbUserId.Clear();
            tbName.Clear();
            tbPassword.Clear();
            cbRole.SelectedIndex = -1;
            tbSalary.Clear();
            tbSearch.Clear();
        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrEmpty(adminName))
            {
                Admin adminform = new Admin(adminName);
                adminform.Show();
            }
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }
    }
}