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
	 public partial class frmChinh : Form
	 {
		  public frmChinh()
		  {
				InitializeComponent();
		  }

		  private void tsbBai1_Click(object sender, EventArgs e)
		  {
				frmBai1 f = new frmBai1();
				f.Show();
		  }

		  private void tsbBai2_Click(object sender, EventArgs e)
		  {
				frmBai2 f = new frmBai2();
				f.Show();
		  }

		  private void tsbBai3_Click(object sender, EventArgs e)
		  {
				frmBai3 f = new frmBai3();
				f.Show();
		  }
	 }
}
