using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace MinimartMIS
{
    public partial class frmProduct_by_Category : Form
    {
        public frmProduct_by_Category()
        {
            InitializeComponent();
        }


        SqlConnection? conn;
        int CategoryID = 0;


        private void frmProduct_by_Category_Load(object sender, EventArgs e)
        {
            conn = connectDB.ConnectMinimart();
            showCategory();
            showProducts(0);
        }

        private void showProducts(int cateID)
        {
            SqlCommand cmd;

            if (cateID == 0)
            {
                string sql =
                    "Select productID, productName, UnitPrice, UnitsInStock " +
                    "from Products";

                cmd = new SqlCommand(sql, conn);
            }
            else
            {
                string sql =
                    "Select productID, productName, UnitPrice, UnitsInStock " +
                    "from Products where CategoryID = @CategoryID";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CategoryID", cateID);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvProducts.DataSource = ds.Tables[0];
        }

        private void showCategory()
        {
            string sql = "Select CategoryID, CategoryName from Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCategory.DataSource = ds.Tables[0];
        }



        private void dgvCategory_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CategoryID = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells[0].Value);
                showProducts(CategoryID);
            }
        }

        private void txshowall_Click(object sender, EventArgs e)
        {
            showProducts(0);

        
            dgvCategory.ClearSelection();
        }
    }
}


