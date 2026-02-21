using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 
namespace MinimartMIS
{
    public partial class frmminimart : Form
    {
        public frmminimart()
        {
            InitializeComponent();
        }
        int EmployeeID;
        string EmployeeName = string.Empty;
        string position = string.Empty;

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            // เปิดหน้าจัดการสินค้า
            frmProducts frm = new frmProducts();
            frm.ShowDialog();
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            frmProduct_by_Category frm = new frmProduct_by_Category();
            frm.ShowDialog();
        }

        private void mnuPOS_Click(object sender, EventArgs e)
        {
            // เปิดหน้าขายสินค้า (POS)
            frmPOS frm = new frmPOS();
            frm.ShowDialog();
        }

        private void frmminimart_Load(object sender, EventArgs e)
        {
            showMenuStart();
        }


        private void SetMenuVisible(params ToolStripMenuItem[] menuItems)
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                menuItem.Visible = false;
            }

            foreach (var m in menuItems)
            {
                m.Visible = true;
            }
        }

        private void showMenuStart()
        {
            SetMenuVisible(mnuLogin);
            this.Text = " - ระบบร้านสะดวกซื้อขนาดเล็ก";

        }
        private void showMenuSale()
        {
            SetMenuVisible(mnuReport, mnuPOS, mnuProduct_by_Category, mnuLogout);
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmLogin"] == null)
            {
                frmLogin frm = new frmLogin();
                var result = frm.ShowDialog();

                EmployeeID = 1;
                EmployeeName = "John";
                position = "Sale Manager";
                if (position == "Sale Manager")
                {
                    showMenuManager();
                    this.Text = $"- ผู้ปฏิบัติการ: {EmployeeName} (ตำแหน่ง: {position})";
                }
                else if (position == "Sale Representative")
                {
                    showMenuSale();
                    this.Text = $"- ผู้ปฏิบัติการ: {EmployeeName} (ตำแหน่ง: {position})";
                }
                else
                {
                    MessageBox.Show("ตำแหน่งไม่ถูกต้อง");
                }
            }
        }

        private void showMenuManager()
        {
            SetMenuVisible(mnuCRUD, mnuReport, mnuProduct_by_Category, mnuEmployees_Sales, mnuLogout);
        }

        private void mnuProducts_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frmProducts"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmProducts frm = new frmProducts();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuEmployees_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEmployees"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmEditEmployees frm = new frmEditEmployees();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuCategory_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCategory"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmEditCategory frm = new frmEditCategory();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuProducts_By_Category_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmProduct_by_Category"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmProduct_by_Category frm = new frmProduct_by_Category();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuEmployee_sale_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmSaleByEmployees"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmEmployees_Sales frm = new frmEmployees_Sales();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuPos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPOS"] == null)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    childForm.Close();
                }
                frmPOS frm = new frmPOS();
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            EmployeeID = 0;
            EmployeeName = string.Empty;
            position = string.Empty;
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
            showMenuStart(); 
        }
    }
}


