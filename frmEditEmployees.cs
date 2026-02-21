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
    public partial class frmEditEmployees : Form
    {
        public frmEditEmployees()
        {
            InitializeComponent();
        }
        SqlConnection? conn = null;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EmployeeID { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FirstName { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LastName { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Position { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Username { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Password { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Status { get; set; }
        private void frmEditEmployees_Load(object sender, EventArgs e)
        {
            setCboTitle();
            setCboPosition();
            conn = connectDB.ConnectMinimart(); //เรียกใช้ฟังก์ชันเชื่อมต่อฐานข้อมูล
            txtEmployeeID.Text = EmployeeID.ToString();
            cboTitle.Text = Title;
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            cboPosition.Text = Position;
            txtUsername.Text = Username;
            txtPassword.Text = Password;
        }
        private void setCboTitle()
        {
            cboTitle.Items.Add("นาย");
            cboTitle.Items.Add("นาง");
            cboTitle.Items.Add("นางสาว");
        }
        private void setCboPosition()
        {
            cboPosition.Items.Add("Sale Manager");
            cboPosition.Items.Add("Sale Representative");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Clear();
            cboTitle.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            cboPosition.SelectedIndex = -1;
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Status == "insert")
            {
                insertData();
            }
            else if (Status == "update")
            {
                updateData();
            }
            this.Close(); 
        }
        private void updateData()
        {
            conn = connectDB.ConnectMinimart();
            if (!checkInputData())
            {
                return; 
            }
            string sql = "Update Employees set Title=@Title,FirstName=@FirstName,LastName=@LastName,"
                + "Position=@Position,Username=@Username,Password=@Password where EmployeeID=@EmployeeID";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@Title", cboTitle.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Position", cboPosition.Text);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close();
        }
        private void insertData()
        {
            conn = connectDB.ConnectMinimart();
            if (!checkInputData())
            {
                return; //หมายความว่า ถ ้า checkInputData() มีค่าเป็น False จะจบโค้ดตรงนี้
            }
            string sql = "Insert into Employees(Title,FirstName,LastName,Position,Username,Password) values"
                + "(@Title,@FirstName,@LastName,@Position,@Username,@Password)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Title", cboTitle.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Position", cboPosition.Text);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "เกิดข้อผิดพลาด");
            }
            conn.Close();
        }
        private bool checkInputData()
        {
            //ตรวจสอบข้อมูลที่กรอกเข้ามา ว่ามีความถูกต้องหรือไม่ เช่น ชื่อและนามสกุลต้องไม่เป็นค่าว่าง รหัสผ่านต้องตรงกับการยืนยันรหัสผ่าน เป็นต้น
            if (string.IsNullOrWhiteSpace(cboTitle.Text))
            {
                MessageBox.Show("กรุณาเลือกคำนำหน้าชื่อ", "ข้อมูลไม่ครบถ้วน");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อ", "ข้อมูลไม่ครบถ้วน");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("กรุณากรอกนามสกุล", "ข้อมูลไม่ครบถ้วน");
                return false;
            }
            if (string.IsNullOrWhiteSpace(cboPosition.Text))
            {
                MessageBox.Show("กรุณาเลือกตำแหน่ง", "ข้อมูลไม่ครบถ้วน");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้", "ข้อมูลไม่ครบถ้วน");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("กรุณากรอกรหัสผ่าน", "ข้อมูลไม่ครบถ้วน");
                return false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน", "ข้อมูลไม่ครบถ้วน");
                return false;
            }
            return true; //ถ ้าข้อมูลครบถ้วนและถูกต้องจะคืนค่าเป็น true
        }
    }
}