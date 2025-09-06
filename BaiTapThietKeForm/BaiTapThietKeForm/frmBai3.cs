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
	 public partial class frmBai3 : Form
	 {
		  List<string> list = new List<string>();
		  public frmBai3()
		  {
				InitializeComponent();
		  }

		  private void frmBai3_Load(object sender, EventArgs e)
		  {

		  }

		  private void btnThemMoi_Click(object sender, EventArgs e)
		  {
				var tu = txtTuMoi.Text.Trim();
				var nghia = txtNghiaTu.Text.Trim();

				if (string.IsNullOrEmpty(tu) || string.IsNullOrEmpty(nghia))
				{
					 MessageBox.Show("Vui lòng nhập Từ mới và Nghĩa trước khi thêm!",
										  "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					 return;
				}
				lbDanhSachTuMoi.Items.Add(tu);
				list.Add(nghia);
				MessageBox.Show("Đã thêm từ mới: " + tu.ToUpper() +
					 "\nNghĩa từ là: " + nghia.ToUpper(),
					 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

				txtTuMoi.Focus();
				txtTuMoi.Text = "";
				txtNghiaTu.Text = "";
				lbDanhSachTuMoi.SelectedIndex = lbDanhSachTuMoi.Items.Count - 1;
				//txtNghiaTu.Text = nghia;
		  }
		  private void lbDanhSachTuMoi_SelectedIndexChanged(object sender, EventArgs e)
		  {
		

				var stt = lbDanhSachTuMoi.SelectedIndex;
				
				listbox2.Text = list[stt];
				

		  }
		  private void lbNghiaTuMoi_SelectedIndexChanged(object sender, EventArgs e)
		  {
		  }

		 
	 }
}
