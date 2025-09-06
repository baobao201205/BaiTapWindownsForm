using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
	 public partial class frmBai2 : Form
	 {
		  public frmBai2()
		  {
				InitializeComponent();
		  }

		  private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
		  {
				var stt = cbbTenHang.SelectedIndex;
				switch (stt)
				{
					 //0,1,2 la vi tri cac mat hang trong danh sach
					 case 0:
						  txtDonGia.Text = "100000";
						  break;
					 case 1:
						  txtDonGia.Text = "200000";
						  break;
					 case 2:
						  txtDonGia.Text = "150000";
						  break;

				}
		  }

		  private void btnTinhTien_Click(object sender, EventArgs e)
		  {
				try
				{
					 if (string.IsNullOrWhiteSpace(txtDonGia.Text) || string.IsNullOrWhiteSpace(txtSoLuong.Text))
					 {
						  MessageBox.Show("Vui lòng nhập đầy đủ đơn giá và số lượng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						  return;
					 }

					 int donGia = int.Parse(txtDonGia.Text);
					 int soLuong = int.Parse(txtSoLuong.Text);

					 if (soLuong <= 0)
					 {
						  MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						  return;
					 }

					 double thanhTien = donGia * soLuong;

					 if (rdChuyenKhoan.Checked)
					 {
						  thanhTien = donGia * soLuong * 0.95;
						  MessageBox.Show("Thanh toán chuyển khoản được giảm 5%!", "Khuyến mãi");
					 }

					 lblSoTienThanhToan.Text = thanhTien.ToString("N0") + " VND";
					 MessageBox.Show("Tính tiền thành công!\nSố tiền cần thanh toán: " + thanhTien.ToString("N0") + " VND", "Kết quả");
				}
				catch (FormatException)
				{
					 MessageBox.Show("Dữ liệu nhập không hợp lệ, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
		  }
	 }
}
