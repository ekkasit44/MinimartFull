using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;


namespace MinimartMIS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EmployeeID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmployeeName { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Position { get; set; }
        SqlConnection? conn = null;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            conn = connectDB.ConnectMinimart();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();

            }
            string sql = @"
SELECT EmployeeID,
       Title + FirstName + '  ' + LastName AS SaleName,
       Position,
       PasswordHash
FROM Employees
WHERE UserName = @usr";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@usr", username);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string hashFromDb = reader["PasswordHash"].ToString();

                if (BCrypt.Net.BCrypt.Verify(password, hashFromDb))
                {
                    EmployeeID = reader.GetInt32(0);
                    EmployeeName = reader.GetString(1);
                    Position = reader.GetString(2);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("รหัสผ่านไม่ถูกต้อง", "Login Failed");
                }
            }
            else
            {
                MessageBox.Show("ไม่พบผู้ใช้งาน", "Login Failed");
            }


        }
    }



}
