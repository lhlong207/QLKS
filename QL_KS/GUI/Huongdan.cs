using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_KS.GUI
{
    public partial class Huongdan : Form
    {
        public Huongdan()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Menu")
            {
                richTextBox1.Text = "Click vào thanh menu, chọn các button để sử dụng các chức năng";
            }
            else if (e.Node.Name == "NhanVien")
            {
                richTextBox1.Text = "Thêm, sửa, xóa thông tin 1 Nhân viên nào đó. Chức năng cần phải đăng nhập để được cấp quyền sử dụng";
            }
            else if (e.Node.Name == "DichVu")
            {
                richTextBox1.Text = "Thêm, sửa, xóa thông tin Dịch Vụ Khách sạn cung cấp";
            }
            else if (e.Node.Name == "KhachHang")
            {
                richTextBox1.Text = "Thêm, Sửa, xóa thông tin khách hàng, Xem danh sách khách hàng";
            }
            else if (e.Node.Name == "Phong")
            {
                richTextBox1.Text = "Thêm, Sửa, tìm kiếm thông tin Phòng, trạng thái Phòng";
            }
            else if (e.Node.Name == "ThuePhong")
            {
                richTextBox1.Text = "Tạo hóa đơn, thông tin thuê phòng của khách hàng";
            }
            else if (e.Node.Name == "ThietBi")
            {
                richTextBox1.Text = "Thêm, Sửa, xóa thiết bị trong phòng nào đó cảu khách sạn";
            }
            else if (e.Node.Name == "SDDichVu")
            {
                richTextBox1.Text = "Thêm, Xóa dịch vụ trong hóa đơn của khách hàng";
            }
            else if (e.Node.Name == "ThanhToan")
            {
                richTextBox1.Text = "Tạo thông tin thanh toán của Mã hóa đơn nào đó";
            }

        }
        private void Huongdan_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
