namespace QL_KS.GUI
{
    partial class frmNhanvien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.tltChuThich = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDanhSachNV = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SuaTT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAD = new System.Windows.Forms.CheckBox();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaTT = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(120, 208);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiaChi.Size = new System.Drawing.Size(231, 70);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(120, 173);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(231, 25);
            this.txtSoDT.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "CMND";
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(120, 139);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(231, 25);
            this.txtCMND.TabIndex = 5;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 69);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(231, 25);
            this.dtpNgaySinh.TabIndex = 3;
            this.dtpNgaySinh.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dtpNgaySinh_ValueChanged);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(120, 103);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(231, 25);
            this.cboGioiTinh.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ và tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(120, 34);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(231, 25);
            this.txtHoTen.TabIndex = 2;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoDT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.dtpNgaySinh);
            this.groupBox2.Controls.Add(this.cboGioiTinh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cá nhân";
            // 
            // lstDanhSachNV
            // 
            this.lstDanhSachNV.FormattingEnabled = true;
            this.lstDanhSachNV.ItemHeight = 14;
            this.lstDanhSachNV.Location = new System.Drawing.Point(531, 12);
            this.lstDanhSachNV.Margin = new System.Windows.Forms.Padding(4);
            this.lstDanhSachNV.Name = "lstDanhSachNV";
            this.lstDanhSachNV.Size = new System.Drawing.Size(156, 410);
            this.lstDanhSachNV.TabIndex = 2;
            this.lstDanhSachNV.SelectedIndexChanged += new System.EventHandler(this.lstDanhSachNV_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_SuaTT);
            this.panel1.Controls.Add(this.lstDanhSachNV);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnXoaTT);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoaTK);
            this.panel1.Controls.Add(this.btnThemTK);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 429);
            this.panel1.TabIndex = 3;
            // 
            // btn_SuaTT
            // 
            this.btn_SuaTT.AccessibleDescription = "";
            this.btn_SuaTT.BackColor = System.Drawing.SystemColors.Control;
            this.btn_SuaTT.FlatAppearance.BorderSize = 0;
            this.btn_SuaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuaTT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTT.ForeColor = System.Drawing.Color.Navy;
            this.btn_SuaTT.Image = global::QL_KS.Properties.Resources.pm2;
            this.btn_SuaTT.Location = new System.Drawing.Point(426, 92);
            this.btn_SuaTT.Name = "btn_SuaTT";
            this.btn_SuaTT.Size = new System.Drawing.Size(86, 56);
            this.btn_SuaTT.TabIndex = 12;
            this.btn_SuaTT.Text = "Sửa TT";
            this.btn_SuaTT.UseVisualStyleBackColor = false;
            this.btn_SuaTT.Click += new System.EventHandler(this.btn_SuaTT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAD);
            this.groupBox1.Controls.Add(this.btnDoiMK);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 118);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // chkAD
            // 
            this.chkAD.AutoSize = true;
            this.chkAD.Location = new System.Drawing.Point(295, 38);
            this.chkAD.Name = "chkAD";
            this.chkAD.Size = new System.Drawing.Size(81, 21);
            this.chkAD.TabIndex = 3;
            this.chkAD.Text = "ADMIN";
            this.chkAD.UseVisualStyleBackColor = true;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(295, 73);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(116, 28);
            this.btnDoiMK.TabIndex = 2;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(120, 73);
            this.txtPass.Name = "txtPass";
            this.txtPass.ReadOnly = true;
            this.txtPass.Size = new System.Drawing.Size(169, 25);
            this.txtPass.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(120, 36);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(169, 25);
            this.txtMaNV.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnXoaTT
            // 
            this.btnXoaTT.AccessibleDescription = "";
            this.btnXoaTT.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaTT.FlatAppearance.BorderSize = 0;
            this.btnXoaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTT.ForeColor = System.Drawing.Color.Navy;
            this.btnXoaTT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTT.Image")));
            this.btnXoaTT.Location = new System.Drawing.Point(426, 166);
            this.btnXoaTT.Name = "btnXoaTT";
            this.btnXoaTT.Size = new System.Drawing.Size(86, 56);
            this.btnXoaTT.TabIndex = 8;
            this.btnXoaTT.Text = "Xóa NV";
            this.btnXoaTT.UseVisualStyleBackColor = false;
            this.btnXoaTT.Click += new System.EventHandler(this.btnXoaTT_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleDescription = "";
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Navy;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(426, 238);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 56);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.AccessibleDescription = "";
            this.btnXoaTK.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaTK.Enabled = false;
            this.btnXoaTK.FlatAppearance.BorderSize = 0;
            this.btnXoaTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTK.ForeColor = System.Drawing.Color.Navy;
            this.btnXoaTK.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTK.Image")));
            this.btnXoaTK.Location = new System.Drawing.Point(426, 335);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(94, 56);
            this.btnXoaTK.TabIndex = 10;
            this.btnXoaTK.Text = "Xóa TK";
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.AccessibleDescription = "";
            this.btnThemTK.AccessibleName = "";
            this.btnThemTK.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemTK.Enabled = false;
            this.btnThemTK.FlatAppearance.BorderSize = 0;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTK.ForeColor = System.Drawing.Color.Navy;
            this.btnThemTK.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTK.Image")));
            this.btnThemTK.Location = new System.Drawing.Point(426, 12);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(86, 56);
            this.btnThemTK.TabIndex = 9;
            this.btnThemTK.Text = "Thêm NV";
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 438);
            this.Controls.Add(this.panel1);
            this.Name = "frmNhanvien";
            this.Text = "frmNhanvien";
            this.Load += new System.EventHandler(this.frmNhanvien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tltChuThich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnXoaTT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDanhSachNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SuaTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAD;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}