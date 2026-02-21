using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinimartMIS
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
        SqlConnection? conn = null;
        int employeeID = 0;
        string title = string.Empty;
        string firstName = string.Empty;
        string lastName = string.Empty;
        string position = string.Empty;
        string username = string.Empty;
        string password = string.Empty;
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
            string sql = "select * from Employees";
            showdata(sql, dgvEmployees);
        }
        private void showdata(string sql, DataGridView dgv)
        {
            SqlCommand cmd = new SqlCommand(sql, conn); //สร้างคำสั่ง SQL
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgv.DataSource = ds.Tables[0]; //แสดงข้อมูลใน DataGridView
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchEmp(txtSearch.Text);
        }

        private void searchEmp(string text)
        {
            string sql = "Select * from Employees"
                + " where FirstName  like '%'+@str+'%'  "
                + " or LastName like '%'+@str+'%'";
            SqlCommand cmd = new SqlCommand(sql, conn); //สร้างคำสั่ง SQL
            cmd.Parameters.AddWithValue("@str", text);
            SqlDataAdapter da = new SqlDataAdapter(cmd); //สร้างตัวดึงข้อมูล
            DataSet ds = new DataSet(); //สร้างตัวเก็บข้อมูล
            da.Fill(ds); //ดึงข้อมูลใส่ตัวเก็บข้อมูล
            dgvEmployees.DataSource = ds.Tables[0]; //แสดงข้อมูลใน DataGridView
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditEmployees f = new frmEditEmployees();
            f.Status = "insert";
            f.ShowDialog();

            //โหลดข้อมูลใหม่หลังจากเพิ่มข้อมูลส มิฉะนั้นข้อมูลตัวใหม่จะไม่แสดง
            string sql = "select * from Employees";
            showdata(sql, dgvEmployees);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // แสดงข้อความยืนยันการลบข้อมูล
            DialogResult result = MessageBox.Show("คุณต้องการลบข้อมูลพนักงานนี้หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return; // ถ้าผู้ใช้เลือก "No" ให้หยุดการทำงานของฟังก์ชันนี้
            }
            string sql = "Delete from Employees where EmployeeID = @empID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@empID", employeeID);
            cmd.ExecuteNonQuery();

            //โหลดข้อมูลใหม่หลังจากลบข้อมูลส มิฉะนั้นข้อมูลตัวใหม่จะไม่แสดง
            sql = "select * from Employees";
            showdata(sql, dgvEmployees);
        }

        private void dgvEmployees_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeID = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            title = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            firstName = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
            lastName = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            position = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
            username = dgvEmployees.CurrentRow.Cells[5].Value.ToString();
            password = dgvEmployees.CurrentRow.Cells[6].Value.ToString();
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeID = Convert.ToInt32(dgvEmployees.CurrentRow.Cells[0].Value);
            title = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            firstName = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
            lastName = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            position = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
            username = dgvEmployees.CurrentRow.Cells[5].Value.ToString();
            password = dgvEmployees.CurrentRow.Cells[6].Value.ToString();

            frmEditEmployees f = new frmEditEmployees();
            f.EmployeeID = employeeID;
            f.Title = title;
            f.FirstName = firstName;
            f.LastName = lastName;
            f.Position = position;
            f.Username = username;
            f.Password = password;
            f.Status = "update";
            f.ShowDialog();

            string sql = "select * from Employees";
            showdata(sql, dgvEmployees);
        }
    }
}