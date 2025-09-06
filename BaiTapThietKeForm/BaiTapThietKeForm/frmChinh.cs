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
	 public partial class frmChinh : Form
	 {
		  public frmChinh()
		  {
				InitializeComponent();
		  }

		  private void Form1_Load(object sender, EventArgs e)
		  {

		  }

		  private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		  {
			
		  }

		  private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		  {


		  }

		  private void tsmiBai1_Click(object sender, EventArgs e)
		  {
				frmBai1 f = new frmBai1();
				f.Show();

		  }

		  private void tsmiBai2_Click(object sender, EventArgs e)
		  {
				frmBai2 f = new frmBai2();
				f.Show();
		  }

		  private void tsmiBai3_Click(object sender, EventArgs e)
		  {
				frmBai3 f = new frmBai3();
				f.Show();
		  }

		  private void tsmiBai4_Click(object sender, EventArgs e)
		  {
				frmBai4 f = new frmBai4();
				f.Show();
		  }
	 }
}
