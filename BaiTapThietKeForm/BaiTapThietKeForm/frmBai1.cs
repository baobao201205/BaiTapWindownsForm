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
	 public partial class frmBai1 : Form
	 {
		  public frmBai1()
		  {
				InitializeComponent();
		  }

		  private void frmBai1_Load(object sender, EventArgs e)
		  {
			
		  }

		  private void rdXanh_CheckedChanged(object sender, EventArgs e)
		  {
				if (rdXanh.Checked)
					 txtDonGia.Text = "22000";
				

		  }

		  private void rdDo_CheckedChanged(object sender, EventArgs e)
		  {
				if (rdDo.Checked)
					 txtDonGia.Text = "21000";
		  }

		  private void rdTrang_CheckedChanged(object sender, EventArgs e)
		  {
				if (rdTrang.Checked)
					 txtDonGia.Text = "20000";
		  }

		  private void btnTinhTien_Click(object sender, EventArgs e)
		  {
				int soLuong = 1;
				double donGia = 0;

				if (!string.IsNullOrEmpty(txtSoLuong.Text))
					 int.TryParse(txtSoLuong.Text, out soLuong);
				double.TryParse(txtDonGia.Text, out donGia);
				double tongTien = soLuong * donGia;
				if (rdXanh.Checked)
				{
	
				}
				txtTinhTien.Text = tongTien.ToString("N0");
		  }
	 }
}
