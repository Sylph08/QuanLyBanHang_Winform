namespace QuanLyBanHang_MaiKet
{
    partial class SearchProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChitietDepartment = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.rdbID = new System.Windows.Forms.RadioButton();
            this.txtSearchByID = new System.Windows.Forms.TextBox();
            this.rdbPrice = new System.Windows.Forms.RadioButton();
            this.txtSearchByPrice = new System.Windows.Forms.TextBox();
            this.rdbLoacation = new System.Windows.Forms.RadioButton();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnShowAllPro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbChitietDepartment);
            this.panel1.Controls.Add(this.cbDepartment);
            this.panel1.Controls.Add(this.rdbID);
            this.panel1.Controls.Add(this.txtSearchByID);
            this.panel1.Controls.Add(this.rdbPrice);
            this.panel1.Controls.Add(this.txtSearchByPrice);
            this.panel1.Controls.Add(this.rdbLoacation);
            this.panel1.Controls.Add(this.rdbName);
            this.panel1.Controls.Add(this.txtSearchByName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 150);
            this.panel1.TabIndex = 1;
            // 
            // cbChitietDepartment
            // 
            this.cbChitietDepartment.Enabled = false;
            this.cbChitietDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChitietDepartment.FormattingEnabled = true;
            this.cbChitietDepartment.Location = new System.Drawing.Point(332, 75);
            this.cbChitietDepartment.Name = "cbChitietDepartment";
            this.cbChitietDepartment.Size = new System.Drawing.Size(161, 30);
            this.cbChitietDepartment.TabIndex = 11;
            // 
            // cbDepartment
            // 
            this.cbDepartment.Enabled = false;
            this.cbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(171, 75);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(155, 30);
            this.cbDepartment.TabIndex = 10;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // rdbID
            // 
            this.rdbID.AutoSize = true;
            this.rdbID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbID.Location = new System.Drawing.Point(4, 11);
            this.rdbID.Name = "rdbID";
            this.rdbID.Size = new System.Drawing.Size(129, 26);
            this.rdbID.TabIndex = 9;
            this.rdbID.TabStop = true;
            this.rdbID.Text = "Tìm theo mã";
            this.rdbID.UseVisualStyleBackColor = true;
            this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
            // 
            // txtSearchByID
            // 
            this.txtSearchByID.Enabled = false;
            this.txtSearchByID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByID.Location = new System.Drawing.Point(171, 3);
            this.txtSearchByID.Name = "txtSearchByID";
            this.txtSearchByID.Size = new System.Drawing.Size(322, 30);
            this.txtSearchByID.TabIndex = 8;
            // 
            // rdbPrice
            // 
            this.rdbPrice.AutoSize = true;
            this.rdbPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrice.Location = new System.Drawing.Point(4, 119);
            this.rdbPrice.Name = "rdbPrice";
            this.rdbPrice.Size = new System.Drawing.Size(130, 26);
            this.rdbPrice.TabIndex = 6;
            this.rdbPrice.TabStop = true;
            this.rdbPrice.Text = "Tìm theo giá";
            this.rdbPrice.UseVisualStyleBackColor = true;
            this.rdbPrice.CheckedChanged += new System.EventHandler(this.rdbPrice_CheckedChanged);
            // 
            // txtSearchByPrice
            // 
            this.txtSearchByPrice.Enabled = false;
            this.txtSearchByPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPrice.Location = new System.Drawing.Point(171, 111);
            this.txtSearchByPrice.Name = "txtSearchByPrice";
            this.txtSearchByPrice.Size = new System.Drawing.Size(322, 30);
            this.txtSearchByPrice.TabIndex = 5;
            this.txtSearchByPrice.TextChanged += new System.EventHandler(this.txtSearchByPrice_TextChanged);
            // 
            // rdbLoacation
            // 
            this.rdbLoacation.AutoSize = true;
            this.rdbLoacation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLoacation.Location = new System.Drawing.Point(4, 83);
            this.rdbLoacation.Name = "rdbLoacation";
            this.rdbLoacation.Size = new System.Drawing.Size(145, 26);
            this.rdbLoacation.TabIndex = 4;
            this.rdbLoacation.TabStop = true;
            this.rdbLoacation.Text = "Tìm theo vị trí";
            this.rdbLoacation.UseVisualStyleBackColor = true;
            this.rdbLoacation.CheckedChanged += new System.EventHandler(this.rdbLoacation_CheckedChanged);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbName.Location = new System.Drawing.Point(4, 47);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(129, 26);
            this.rdbName.TabIndex = 2;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Tìm theo tên";
            this.rdbName.UseVisualStyleBackColor = true;
            this.rdbName.CheckedChanged += new System.EventHandler(this.rdbName_CheckedChanged);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Enabled = false;
            this.txtSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByName.Location = new System.Drawing.Point(171, 39);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(322, 30);
            this.txtSearchByName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(515, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 37);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(515, 126);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 37);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnShowAllPro
            // 
            this.btnShowAllPro.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllPro.Location = new System.Drawing.Point(515, 56);
            this.btnShowAllPro.Name = "btnShowAllPro";
            this.btnShowAllPro.Size = new System.Drawing.Size(130, 64);
            this.btnShowAllPro.TabIndex = 8;
            this.btnShowAllPro.Text = "Hiển thị tất cả sản phẩm";
            this.btnShowAllPro.UseVisualStyleBackColor = true;
            this.btnShowAllPro.Click += new System.EventHandler(this.btnShowAllPro_Click);
            // 
            // SearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 170);
            this.Controls.Add(this.btnShowAllPro);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sản phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.RadioButton rdbPrice;
        private System.Windows.Forms.TextBox txtSearchByPrice;
        private System.Windows.Forms.RadioButton rdbLoacation;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton rdbID;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.ComboBox cbChitietDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnShowAllPro;
    }
}