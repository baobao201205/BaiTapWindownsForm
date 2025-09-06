using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm.models
{
	 public class HangHoa
	 {
		  public string maHang { get; set; }
		  public string tenHang { get; set; }
		  public string DVT { get; set; }
		  public int soLuong { get; set; }
		  public int donGia { get; set; }

		  public HangHoa()
		  {

		  }
		  public string HienThi()
		  {
				return string.Format("{0}, {1}, {2}, {3}, {4}", maHang, tenHang, DVT, soLuong, donGia);
		  }
	 }
	 
}
