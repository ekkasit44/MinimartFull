namespace MinimartMIS
{
    partial class frmEmployees_Sales
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
            dgvEmployees = new DataGridView();
            dgvReceiptID = new DataGridView();
            btnShowall = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceiptID).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 58);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(347, 748);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellMouseUp += dgvCategory_CellMouseUp;
            // 
            // dgvReceiptID
            // 
            dgvReceiptID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiptID.Location = new Point(383, 58);
            dgvReceiptID.Name = "dgvReceiptID";
            dgvReceiptID.RowHeadersWidth = 51;
            dgvReceiptID.Size = new Size(733, 748);
            dgvReceiptID.TabIndex = 1;
            // 
            // btnShowall
            // 
            btnShowall.Location = new Point(956, 23);
            btnShowall.Name = "btnShowall";
            btnShowall.Size = new Size(94, 29);
            btnShowall.TabIndex = 2;
            btnShowall.Text = "ShowAll";
            btnShowall.UseVisualStyleBackColor = true;
            btnShowall.Click += btnShowall_Click;
            // 
            // frmEmployees_Sales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 818);
            Controls.Add(btnShowall);
            Controls.Add(dgvReceiptID);
            Controls.Add(dgvEmployees);
            Name = "frmEmployees_Sales";
            Text = "frmEmployees_Sales";
            Load += frmEmployees_Sales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReceiptID).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private DataGridView dgvReceiptID;
        private Button btnShowall;
    }
}