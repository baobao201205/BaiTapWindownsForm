using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
	 public partial class frmBai2 : Form
	 {


		  Dictionary<string, int> giaSanPham = new Dictionary<string, int>()
		  {
				{ "Chuột", 100000 },
				{ "Bàn phím", 150000 },
				{ "Máy in", 2000000 },
				{ "USB Kingmax", 200000 }
		  };

		  public frmBai2()
		  {
				InitializeComponent();
		  }

		  private void frmBai2_Load(object sender, EventArgs e)
		  {
				// Load danh sách hàng hóa vào ListBox1
				foreach (var sp in giaSanPham.Keys)
				{
					 lbSanPham.Items.Add(sp);
				}
		  }

		  // Nút chọn hàng >
		  private void btnChonHang_Click(object sender, EventArgs e)
		  {
				if (lbSanPham.SelectedItem != null)
				{
					 lbGioHang.Items.Add(lbSanPham.SelectedItem.ToString());
				}
				else
				{
					 MessageBox.Show("Vui lòng chọn sản phẩm trước!", "Thông báo");
				}
		  }

		  // Nút < Bỏ hàng
		  private void btnBoHang_Click(object sender, EventArgs e)
		  {
				if (lbGioHang.SelectedItem != null)
				{
					 lbGioHang.Items.Remove(lbGioHang.SelectedItem);
				}
				else
				{
					 MessageBox.Show("Vui lòng chọn sản phẩm trong giỏ hàng!", "Thông báo");
				}
		  }

		  // Nút tính tiền
		  private void btnTinhTien_Click(object sender, EventArgs e)
		  {
				int tongTien = 0;
				foreach (var item in lbGioHang.Items)
				{
					 string sp = item.ToString();
					 if (giaSanPham.ContainsKey(sp))
					 {
						  tongTien += giaSanPham[sp];
					 }
					
				}
				if (lbGioHang.Items.Count > 0)
				{
					 lbSoTien.Text =  tongTien.ToString("N0") + " VNĐ";
				}
				else
				{
					 lbSoTien.Text = "Vui lòng chọn hàng trước khi thanh toán!";
				}
		  }
	 }
}
