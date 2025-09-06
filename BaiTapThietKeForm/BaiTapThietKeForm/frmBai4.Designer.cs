namespace BaiTapThietKeForm
{
	 partial class frmBai4
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
				this.listBox1 = new System.Windows.Forms.ListBox();
				this.label1 = new System.Windows.Forms.Label();
				this.label2 = new System.Windows.Forms.Label();
				this.lblKetQua = new System.Windows.Forms.Label();
				this.txtNhapSo = new System.Windows.Forms.TextBox();
				this.btnTimSo = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// listBox1
				// 
				this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.listBox1.FormattingEnabled = true;
				this.listBox1.ItemHeight = 19;
				this.listBox1.Location = new System.Drawing.Point(56, 56);
				this.listBox1.Name = "listBox1";
				this.listBox1.Size = new System.Drawing.Size(213, 251);
				this.listBox1.TabIndex = 0;
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label1.Location = new System.Drawing.Point(285, 112);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(111, 19);
				this.label1.TabIndex = 1;
				this.label1.Text = "Nhấp số cần tìm:";
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label2.Location = new System.Drawing.Point(307, 202);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(89, 24);
				this.label2.TabIndex = 2;
				this.label2.Text = "Kết quả:";
				// 
				// lblKetQua
				// 
				this.lblKetQua.AutoSize = true;
				this.lblKetQua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.lblKetQua.ForeColor = System.Drawing.Color.Red;
				this.lblKetQua.Location = new System.Drawing.Point(418, 202);
				this.lblKetQua.Name = "lblKetQua";
				this.lblKetQua.Size = new System.Drawing.Size(25, 24);
				this.lblKetQua.TabIndex = 3;
				this.lblKetQua.Text = "...";
				// 
				// txtNhapSo
				// 
				this.txtNhapSo.Location = new System.Drawing.Point(422, 113);
				this.txtNhapSo.Name = "txtNhapSo";
				this.txtNhapSo.Size = new System.Drawing.Size(146, 20);
				this.txtNhapSo.TabIndex = 4;
				// 
				// btnTimSo
				// 
				this.btnTimSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.btnTimSo.Location = new System.Drawing.Point(422, 158);
				this.btnTimSo.Name = "btnTimSo";
				this.btnTimSo.Size = new System.Drawing.Size(75, 23);
				this.btnTimSo.TabIndex = 5;
				this.btnTimSo.Text = "Tìm số";
				this.btnTimSo.UseVisualStyleBackColor = true;
				this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
				// 
				// frmBai4
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(655, 372);
				this.Controls.Add(this.btnTimSo);
				this.Controls.Add(this.txtNhapSo);
				this.Controls.Add(this.lblKetQua);
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.listBox1);
				this.Name = "frmBai4";
				this.Text = "Tìm số trong danh sách";
				this.Load += new System.EventHandler(this.frmBai4_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.ListBox listBox1;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label lblKetQua;
		  private System.Windows.Forms.TextBox txtNhapSo;
		  private System.Windows.Forms.Button btnTimSo;
	 }
}