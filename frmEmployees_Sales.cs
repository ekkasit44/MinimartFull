using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace MinimartMIS
{
    public partial class frmEmployees_Sales : Form
    {
        public frmEmployees_Sales()
        {
            InitializeComponent();
        }


        SqlConnection? conn;
        int employeeID;


        private void frmEmployees_Sales_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showEmployees();

            showReceipt(0);
        }
        private void showEmployees()
        {
            string sql = "select e.EmployeeID, Salename=title+FirstName+space(2)+LastName, SaleRevenue=sum(TotalCash) from Receipts r right outer join Employees e on r.EmployeeID = e.EmployeeID\r\ngroup by e.EmployeeID, title+FirstName+space(2)+LastName";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvEmployees.DataSource = ds.Tables[0];
        }

        private void showReceipt(int empID)
        {
            SqlCommand cmd;
            if (empID == 0)
            {
                string sql = "select ReceiptID, ReceiptDate, TotalCash AS TotalCash"
                    + " from Receipts r join Employees e on r.EmployeeID = e.EmployeeID"
                    + " order by r.ReceiptID";
                cmd = new SqlCommand(sql, conn);
            }
            else
            {
                string sql = "select ReceiptID, ReceiptDate, TotalCash from Receipts r join Employees e on r.EmployeeID = e.EmployeeID where e.EmployeeID = @empID order by r.ReceiptID";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@empID", empID);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvReceiptID.DataSource = ds.Tables[0];
        }



        private void dgvCategory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                employeeID = Convert.ToInt32(dgvEmployees.Rows[e.RowIndex].Cells[0].Value);
                showReceipt(employeeID);
            }
        }

        private void btnShowall_Click(object sender, EventArgs e)
        {
            showReceipt(0);
        }
    }
}

//showReceipt
