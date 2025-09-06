namespace BaiTapThietKeForm
{
	 partial class frmBai2
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
				this.panel1 = new System.Windows.Forms.Panel();
				this.btnChonHang = new System.Windows.Forms.Button();
				this.label1 = new System.Windows.Forms.Label();
				this.lbSanPham = new System.Windows.Forms.ListBox();
				this.panel2 = new System.Windows.Forms.Panel();
				this.btnBoHang = new System.Windows.Forms.Button();
				this.label2 = new System.Windows.Forms.Label();
				this.lbGioHang = new System.Windows.Forms.ListBox();
				this.btnTinhTien = new System.Windows.Forms.Button();
				this.label3 = new System.Windows.Forms.Label();
				this.lblTongTien = new System.Windows.Forms.Label();
				this.lbSoTien = new System.Windows.Forms.Label();
				this.panel1.SuspendLayout();
				this.panel2.SuspendLayout();
				this.SuspendLayout();
				// 
				// panel1
				// 
				this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				this.panel1.Controls.Add(this.btnChonHang);
				this.panel1.Controls.Add(this.label1);
				this.panel1.Controls.Add(this.lbSanPham);
				this.panel1.Location = new System.Drawing.Point(34, 48);
				this.panel1.Name = "panel1";
				this.panel1.Size = new System.Drawing.Size(327, 371);
				this.panel1.TabIndex = 0;
				// 
				// btnChonHang
				// 
				this.btnChonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnChonHang.Location = new System.Drawing.Point(229, 169);
				this.btnChonHang.Name = "btnChonHang";
				this.btnChonHang.Size = new System.Drawing.Size(83, 23);
				this.btnChonHang.TabIndex = 3;
				this.btnChonHang.Text = "Chọn hàng >";
				this.btnChonHang.UseVisualStyleBackColor = true;
				this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(66, 11);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(107, 13);
				this.label1.TabIndex = 1;
				this.label1.Text = "Danh sách hàng hoá";
				// 
				// lbSanPham
				// 
				this.lbSanPham.FormattingEnabled = true;
				this.lbSanPham.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
				this.lbSanPham.Location = new System.Drawing.Point(32, 38);
				this.lbSanPham.Name = "lbSanPham";
				this.lbSanPham.Size = new System.Drawing.Size(177, 303);
				this.lbSanPham.TabIndex = 0;
				// 
				// panel2
				// 
				this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
				this.panel2.Controls.Add(this.btnBoHang);
				this.panel2.Controls.Add(this.label2);
				this.panel2.Controls.Add(this.lbGioHang);
				this.panel2.Location = new System.Drawing.Point(422, 48);
				this.panel2.Name = "panel2";
				this.panel2.Size = new System.Drawing.Size(327, 371);
				this.panel2.TabIndex = 4;
				// 
				// btnBoHang
				// 
				this.btnBoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnBoHang.Location = new System.Drawing.Point(17, 169);
				this.btnBoHang.Name = "btnBoHang";
				this.btnBoHang.Size = new System.Drawing.Size(81, 23);
				this.btnBoHang.TabIndex = 3;
				this.btnBoHang.Text = "< Bỏ hàng";
				this.btnBoHang.UseVisualStyleBackColor = true;
				this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(114, 11);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(179, 13);
				this.label2.TabIndex = 1;
				this.label2.Text = "Danh sách sản phầm trong giỏ hàng";
				// 
				// lbGioHang
				// 
				this.lbGioHang.FormattingEnabled = true;
				this.lbGioHang.Location = new System.Drawing.Point(116, 38);
				this.lbGioHang.Name = "lbGioHang";
				this.lbGioHang.Size = new System.Drawing.Size(177, 303);
				this.lbGioHang.TabIndex = 0;
				// 
				// btnTinhTien
				// 
				this.btnTinhTien.BackColor = System.Drawing.Color.WhiteSmoke;
				this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnTinhTien.Location = new System.Drawing.Point(350, 425);
				this.btnTinhTien.Name = "btnTinhTien";
				this.btnTinhTien.Size = new System.Drawing.Size(81, 23);
				this.btnTinhTien.TabIndex = 4;
				this.btnTinhTien.Text = "Tính Tiền";
				this.btnTinhTien.UseVisualStyleBackColor = false;
				this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label3.Location = new System.Drawing.Point(160, 451);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(151, 19);
				this.label3.TabIndex = 4;
				this.label3.Text = "Tổng tiền thanh toán:";
				// 
				// lblTongTien
				// 
				this.lblTongTien.AutoSize = true;
				this.lblTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.lblTongTien.Location = new System.Drawing.Point(317, 451);
				this.lblTongTien.Name = "lblTongTien";
				this.lblTongTien.Size = new System.Drawing.Size(0, 19);
				this.lblTongTien.TabIndex = 5;
				// 
				// lbSoTien
				// 
				this.lbSoTien.AutoSize = true;
				this.lbSoTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.lbSoTien.ForeColor = System.Drawing.Color.Red;
				this.lbSoTien.Location = new System.Drawing.Point(323, 451);
				this.lbSoTien.Name = "lbSoTien";
				this.lbSoTien.Size = new System.Drawing.Size(25, 19);
				this.lbSoTien.TabIndex = 6;
				this.lbSoTien.Text = " ...";
				// 
				// frmBai2
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
				this.ClientSize = new System.Drawing.Size(779, 488);
				this.Controls.Add(this.lbSoTien);
				this.Controls.Add(this.lblTongTien);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.btnTinhTien);
				this.Controls.Add(this.panel2);
				this.Controls.Add(this.panel1);
				this.Name = "frmBai2";
				this.Text = "Bán Hàng";
				this.panel1.ResumeLayout(false);
				this.panel1.PerformLayout();
				this.panel2.ResumeLayout(false);
				this.panel2.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Panel panel1;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.ListBox lbSanPham;
		  private System.Windows.Forms.Button btnChonHang;
		  private System.Windows.Forms.Panel panel2;
		  private System.Windows.Forms.Button btnBoHang;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.ListBox lbGioHang;
		  private System.Windows.Forms.Button btnTinhTien;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label lblTongTien;
		  private System.Windows.Forms.Label lbSoTien;
	 }
}