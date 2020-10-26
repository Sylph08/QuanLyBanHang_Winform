namespace QuanLyBanHang_MaiKet
{
    partial class FrmListBill
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
            this.grvBill = new System.Windows.Forms.DataGridView();
            this.dtpByDate = new System.Windows.Forms.DateTimePicker();
            this.rdbByDate = new System.Windows.Forms.RadioButton();
            this.rdbByStatus = new System.Windows.Forms.RadioButton();
            this.cbByStatus = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // grvBill
            // 
            this.grvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBill.Location = new System.Drawing.Point(13, 77);
            this.grvBill.Name = "grvBill";
            this.grvBill.RowTemplate.Height = 24;
            this.grvBill.Size = new System.Drawing.Size(546, 438);
            this.grvBill.TabIndex = 0;
            // 
            // dtpByDate
            // 
            this.dtpByDate.CustomFormat = "dd/MM/yyyy";
            this.dtpByDate.Enabled = false;
            this.dtpByDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpByDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpByDate.Location = new System.Drawing.Point(241, 6);
            this.dtpByDate.Name = "dtpByDate";
            this.dtpByDate.Size = new System.Drawing.Size(318, 30);
            this.dtpByDate.TabIndex = 1;
            this.dtpByDate.ValueChanged += new System.EventHandler(this.dtpByDate_ValueChanged);
            // 
            // rdbByDate
            // 
            this.rdbByDate.AutoSize = true;
            this.rdbByDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByDate.Location = new System.Drawing.Point(12, 10);
            this.rdbByDate.Name = "rdbByDate";
            this.rdbByDate.Size = new System.Drawing.Size(173, 26);
            this.rdbByDate.TabIndex = 2;
            this.rdbByDate.TabStop = true;
            this.rdbByDate.Text = "Hiển thị theo ngày";
            this.rdbByDate.UseVisualStyleBackColor = true;
            this.rdbByDate.CheckedChanged += new System.EventHandler(this.rdbByDate_CheckedChanged);
            // 
            // rdbByStatus
            // 
            this.rdbByStatus.AutoSize = true;
            this.rdbByStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbByStatus.Location = new System.Drawing.Point(12, 42);
            this.rdbByStatus.Name = "rdbByStatus";
            this.rdbByStatus.Size = new System.Drawing.Size(210, 26);
            this.rdbByStatus.TabIndex = 3;
            this.rdbByStatus.TabStop = true;
            this.rdbByStatus.Text = "Hiển thị theo trạng thái";
            this.rdbByStatus.UseVisualStyleBackColor = true;
            this.rdbByStatus.CheckedChanged += new System.EventHandler(this.rdbByStatus_CheckedChanged);
            // 
            // cbByStatus
            // 
            this.cbByStatus.Enabled = false;
            this.cbByStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbByStatus.FormattingEnabled = true;
            this.cbByStatus.Location = new System.Drawing.Point(241, 41);
            this.cbByStatus.Name = "cbByStatus";
            this.cbByStatus.Size = new System.Drawing.Size(318, 30);
            this.cbByStatus.TabIndex = 4;
            this.cbByStatus.SelectedIndexChanged += new System.EventHandler(this.cbByStatus_SelectedIndexChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(12, 521);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(484, 521);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbByStatus);
            this.Controls.Add(this.rdbByStatus);
            this.Controls.Add(this.rdbByDate);
            this.Controls.Add(this.dtpByDate);
            this.Controls.Add(this.grvBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmListBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.FrmListBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvBill;
        private System.Windows.Forms.DateTimePicker dtpByDate;
        private System.Windows.Forms.RadioButton rdbByDate;
        private System.Windows.Forms.RadioButton rdbByStatus;
        private System.Windows.Forms.ComboBox cbByStatus;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}