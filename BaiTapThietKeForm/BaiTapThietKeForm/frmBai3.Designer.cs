namespace BaiTapThietKeForm
{
	 partial class frmBai3
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
				this.label1 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.label4 = new System.Windows.Forms.Label();
				this.btnThem = new System.Windows.Forms.Button();
				this.txtTuMoi = new System.Windows.Forms.TextBox();
				this.txtNghiaTu = new System.Windows.Forms.TextBox();
				this.lbDanhSachTuMoi = new System.Windows.Forms.ListBox();
				this.listbox2 = new System.Windows.Forms.TextBox();
				this.SuspendLayout();
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(136, 48);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(60, 19);
				this.label1.TabIndex = 0;
				this.label1.Text = "Từ mới: ";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(102, 93);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(94, 19);
				this.label2.TabIndex = 0;
				this.label2.Text = "Nghĩa của từ: ";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(102, 171);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(160, 19);
				this.label3.TabIndex = 0;
				this.label3.Text = "DANH SÁCH TỪ MỚI";
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Location = new System.Drawing.Point(439, 171);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(119, 19);
				this.label4.TabIndex = 0;
				this.label4.Text = "NGHĨA CỦA TỪ";
				// 
				// btnThem
				// 
				this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
				this.btnThem.Location = new System.Drawing.Point(245, 118);
				this.btnThem.Name = "btnThem";
				this.btnThem.Size = new System.Drawing.Size(116, 25);
				this.btnThem.TabIndex = 3;
				this.btnThem.Text = "Thêm từ mới";
				this.btnThem.UseVisualStyleBackColor = false;
				this.btnThem.Click += new System.EventHandler(this.btnThemMoi_Click);
				// 
				// txtTuMoi
				// 
				this.txtTuMoi.Location = new System.Drawing.Point(202, 41);
				this.txtTuMoi.Name = "txtTuMoi";
				this.txtTuMoi.Size = new System.Drawing.Size(177, 26);
				this.txtTuMoi.TabIndex = 1;
				// 
				// txtNghiaTu
				// 
				this.txtNghiaTu.Location = new System.Drawing.Point(202, 86);
				this.txtNghiaTu.Name = "txtNghiaTu";
				this.txtNghiaTu.Size = new System.Drawing.Size(255, 26);
				this.txtNghiaTu.TabIndex = 2;
				// 
				// lbDanhSachTuMoi
				// 
				this.lbDanhSachTuMoi.FormattingEnabled = true;
				this.lbDanhSachTuMoi.ItemHeight = 19;
				this.lbDanhSachTuMoi.Location = new System.Drawing.Point(21, 212);
				this.lbDanhSachTuMoi.Name = "lbDanhSachTuMoi";
				this.lbDanhSachTuMoi.Size = new System.Drawing.Size(293, 194);
				this.lbDanhSachTuMoi.TabIndex = 4;
				this.lbDanhSachTuMoi.SelectedIndexChanged += new System.EventHandler(this.lbDanhSachTuMoi_SelectedIndexChanged);
				// 
				// listbox2
				// 
				this.listbox2.Location = new System.Drawing.Point(350, 212);
				this.listbox2.Multiline = true;
				this.listbox2.Name = "listbox2";
				this.listbox2.Size = new System.Drawing.Size(282, 194);
				this.listbox2.TabIndex = 5;
				// 
				// frmBai3
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.BackColor = System.Drawing.SystemColors.ControlLight;
				this.ClientSize = new System.Drawing.Size(666, 418);
				this.Controls.Add(this.listbox2);
				this.Controls.Add(this.lbDanhSachTuMoi);
				this.Controls.Add(this.txtNghiaTu);
				this.Controls.Add(this.txtTuMoi);
				this.Controls.Add(this.btnThem);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.Margin = new System.Windows.Forms.Padding(4);
				this.Name = "frmBai3";
				this.Text = "Từ điển Anh-Việt";
				this.Load += new System.EventHandler(this.frmBai3_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.Button btnThem;
		  private System.Windows.Forms.TextBox txtTuMoi;
		  private System.Windows.Forms.TextBox txtNghiaTu;
		  private System.Windows.Forms.ListBox lbDanhSachTuMoi;
		  private System.Windows.Forms.TextBox listbox2;
	 }
}