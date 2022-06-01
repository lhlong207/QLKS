namespace QL_KS.GUI
{
    partial class Huongdan
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Giao Diện Chính");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Giao Diện Nhân viên");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Giao Diện Dịch vụ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Giao Diện Khách hàng");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Giao Diện Phòng");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Giao Diện thuê phòng");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Giao Diện thiết bị");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Giao Diện sử dụng thiết bị");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Giao Diện thanh toán");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Hướng Dẫn", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1, 1);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Menu";
            treeNode1.Text = "Giao Diện Chính";
            treeNode2.Name = "NhanVien";
            treeNode2.Text = "Giao Diện Nhân viên";
            treeNode3.Name = "DichVu";
            treeNode3.Text = "Giao Diện Dịch vụ";
            treeNode4.Name = "KhachHang";
            treeNode4.Text = "Giao Diện Khách hàng";
            treeNode5.Name = "Phong";
            treeNode5.Text = "Giao Diện Phòng";
            treeNode6.Name = "ThuePhong";
            treeNode6.Text = "Giao Diện thuê phòng";
            treeNode7.Name = "ThietBi";
            treeNode7.Text = "Giao Diện thiết bị";
            treeNode8.Name = "SDDThietBi";
            treeNode8.Text = "Giao Diện sử dụng thiết bị";
            treeNode9.Name = "ThanhToan";
            treeNode9.Text = "Giao Diện thanh toán";
            treeNode10.Name = "Hướng Dẫn";
            treeNode10.Text = "Hướng Dẫn";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(519, 228);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1, 235);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(519, 137);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 369);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Huongdan";
            this.Text = "Hướng dẫn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Huongdan_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}