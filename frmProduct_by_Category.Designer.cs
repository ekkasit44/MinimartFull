namespace MinimartMIS
{
    partial class frmProduct_by_Category
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCategory = new DataGridView();
            dgvProducts = new DataGridView();
            txshowall = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Location = new Point(12, 58);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.Size = new Size(347, 748);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellMouseUp += dgvCategory_CellMouseUp;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(383, 58);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(733, 748);
            dgvProducts.TabIndex = 1;
            // 
            // txshowall
            // 
            txshowall.Location = new Point(1008, 12);
            txshowall.Name = "txshowall";
            txshowall.Size = new Size(94, 29);
            txshowall.TabIndex = 2;
            txshowall.Text = "Show All";
            txshowall.UseVisualStyleBackColor = true;
            txshowall.Click += txshowall_Click;
            // 
            // frmProduct_by_Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 818);
            Controls.Add(txshowall);
            Controls.Add(dgvProducts);
            Controls.Add(dgvCategory);
            Name = "frmProduct_by_Category";
            Text = "frmProduct_by_Category";
            Load += frmProduct_by_Category_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategory;
        private DataGridView dgvProducts;
        private Button txshowall;
    }
}