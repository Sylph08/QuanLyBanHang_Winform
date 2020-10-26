namespace QuanLyBanHang_MaiKet
{
    partial class FrmShowProductDetail
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
            this.txtIDPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPricePro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grvProduct = new System.Windows.Forms.DataGridView();
            this.ptbImagePro = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbChitietDepartment = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.txtLocationPro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoadPic = new System.Windows.Forms.Button();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagePro)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIDPro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 40);
            this.panel1.TabIndex = 1;
            // 
            // txtIDPro
            // 
            this.txtIDPro.Enabled = false;
            this.txtIDPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPro.Location = new System.Drawing.Point(170, 4);
            this.txtIDPro.Name = "txtIDPro";
            this.txtIDPro.ReadOnly = true;
            this.txtIDPro.Size = new System.Drawing.Size(258, 30);
            this.txtIDPro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNamePro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 40);
            this.panel2.TabIndex = 2;
            // 
            // txtNamePro
            // 
            this.txtNamePro.Enabled = false;
            this.txtNamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePro.Location = new System.Drawing.Point(170, 4);
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.Size = new System.Drawing.Size(368, 30);
            this.txtNamePro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPricePro);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 40);
            this.panel3.TabIndex = 2;
            // 
            // txtPricePro
            // 
            this.txtPricePro.Enabled = false;
            this.txtPricePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePro.Location = new System.Drawing.Point(170, 4);
            this.txtPricePro.Name = "txtPricePro";
            this.txtPricePro.Size = new System.Drawing.Size(258, 30);
            this.txtPricePro.TabIndex = 1;
            this.txtPricePro.TextChanged += new System.EventHandler(this.txtPricePro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá sản phẩm";
            // 
            // grvProduct
            // 
            this.grvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProduct.Location = new System.Drawing.Point(12, 194);
            this.grvProduct.Name = "grvProduct";
            this.grvProduct.ReadOnly = true;
            this.grvProduct.RowTemplate.Height = 24;
            this.grvProduct.Size = new System.Drawing.Size(643, 344);
            this.grvProduct.TabIndex = 3;
            this.grvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvProduct_CellClick);
            // 
            // ptbImagePro
            // 
            this.ptbImagePro.Location = new System.Drawing.Point(6, 29);
            this.ptbImagePro.Name = "ptbImagePro";
            this.ptbImagePro.Size = new System.Drawing.Size(480, 363);
            this.ptbImagePro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbImagePro.TabIndex = 4;
            this.ptbImagePro.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(667, 459);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 37);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(781, 501);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 37);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(667, 502);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 37);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbChitietDepartment);
            this.panel4.Controls.Add(this.cbDepartment);
            this.panel4.Controls.Add(this.txtLocationPro);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 38);
            this.panel4.TabIndex = 3;
            // 
            // cbChitietDepartment
            // 
            this.cbChitietDepartment.Enabled = false;
            this.cbChitietDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChitietDepartment.FormattingEnabled = true;
            this.cbChitietDepartment.Location = new System.Drawing.Point(409, 4);
            this.cbChitietDepartment.Name = "cbChitietDepartment";
            this.cbChitietDepartment.Size = new System.Drawing.Size(231, 30);
            this.cbChitietDepartment.TabIndex = 12;
            this.cbChitietDepartment.SelectedIndexChanged += new System.EventHandler(this.cbChitietDepartment_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.Enabled = false;
            this.cbDepartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(228, 4);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(175, 30);
            this.cbDepartment.TabIndex = 11;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.cbDepartment_SelectedIndexChanged);
            // 
            // txtLocationPro
            // 
            this.txtLocationPro.Enabled = false;
            this.txtLocationPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationPro.Location = new System.Drawing.Point(170, 4);
            this.txtLocationPro.Name = "txtLocationPro";
            this.txtLocationPro.ReadOnly = true;
            this.txtLocationPro.Size = new System.Drawing.Size(52, 30);
            this.txtLocationPro.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vị trí sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoadPic);
            this.groupBox1.Controls.Add(this.btnXoaAnh);
            this.groupBox1.Controls.Add(this.ptbImagePro);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(661, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 441);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ảnh sản phẩm";
            // 
            // btnLoadPic
            // 
            this.btnLoadPic.Enabled = false;
            this.btnLoadPic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPic.Location = new System.Drawing.Point(378, 398);
            this.btnLoadPic.Name = "btnLoadPic";
            this.btnLoadPic.Size = new System.Drawing.Size(108, 37);
            this.btnLoadPic.TabIndex = 12;
            this.btnLoadPic.Text = "Load ảnh";
            this.btnLoadPic.UseVisualStyleBackColor = true;
            this.btnLoadPic.Visible = false;
            this.btnLoadPic.Click += new System.EventHandler(this.btnLoadPic_Click);
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.Enabled = false;
            this.btnXoaAnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaAnh.Location = new System.Drawing.Point(264, 398);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(108, 37);
            this.btnXoaAnh.TabIndex = 14;
            this.btnXoaAnh.Text = "Xóa ảnh";
            this.btnXoaAnh.UseVisualStyleBackColor = true;
            this.btnXoaAnh.Visible = false;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(781, 459);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 37);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmShowProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 555);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grvProduct);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmShowProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiển thị sản phẩm";
            this.Load += new System.EventHandler(this.FrmShowProductDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagePro)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPricePro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grvProduct;
        private System.Windows.Forms.PictureBox ptbImagePro;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtLocationPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChitietDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnLoadPic;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnXoaAnh;
    }
}