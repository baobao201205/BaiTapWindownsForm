namespace BaiTapWindowsForm
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
				this.label2 = new System.Windows.Forms.Label();
				this.label3 = new System.Windows.Forms.Label();
				this.label1 = new System.Windows.Forms.Label();
				this.txtSoA = new System.Windows.Forms.TextBox();
				this.txtSoB = new System.Windows.Forms.TextBox();
				this.txtSoN = new System.Windows.Forms.TextBox();
				this.groupBox1 = new System.Windows.Forms.GroupBox();
				this.rdTinhTongab = new System.Windows.Forms.RadioButton();
				this.rdTong1n = new System.Windows.Forms.RadioButton();
				this.btnXemKetQua = new System.Windows.Forms.Button();
				this.label4 = new System.Windows.Forms.Label();
				this.lblKetQua = new System.Windows.Forms.Label();
				this.groupBox1.SuspendLayout();
				this.SuspendLayout();
				// 
				// label2
				// 
				this.label2.AutoSize = true;
				this.label2.Location = new System.Drawing.Point(88, 84);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(48, 16);
				this.label2.TabIndex = 1;
				this.label2.Text = "Số a = ";
				// 
				// label3
				// 
				this.label3.AutoSize = true;
				this.label3.Location = new System.Drawing.Point(88, 134);
				this.label3.Name = "label3";
				this.label3.Size = new System.Drawing.Size(48, 16);
				this.label3.TabIndex = 2;
				this.label3.Text = "Số b = ";
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Location = new System.Drawing.Point(88, 180);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(47, 16);
				this.label1.TabIndex = 3;
				this.label1.Text = "Số n = ";
				// 
				// txtSoA
				// 
				this.txtSoA.Location = new System.Drawing.Point(157, 78);
				this.txtSoA.Name = "txtSoA";
				this.txtSoA.Size = new System.Drawing.Size(116, 22);
				this.txtSoA.TabIndex = 4;
				this.txtSoA.Text = "0";
				// 
				// txtSoB
				// 
				this.txtSoB.Location = new System.Drawing.Point(157, 128);
				this.txtSoB.Name = "txtSoB";
				this.txtSoB.Size = new System.Drawing.Size(116, 22);
				this.txtSoB.TabIndex = 5;
				this.txtSoB.Text = "0";
				// 
				// txtSoN
				// 
				this.txtSoN.Location = new System.Drawing.Point(157, 177);
				this.txtSoN.Name = "txtSoN";
				this.txtSoN.Size = new System.Drawing.Size(116, 22);
				this.txtSoN.TabIndex = 6;
				this.txtSoN.Text = "0";
				// 
				// groupBox1
				// 
				this.groupBox1.Controls.Add(this.rdTong1n);
				this.groupBox1.Controls.Add(this.rdTinhTongab);
				this.groupBox1.Location = new System.Drawing.Point(91, 217);
				this.groupBox1.Name = "groupBox1";
				this.groupBox1.Size = new System.Drawing.Size(200, 100);
				this.groupBox1.TabIndex = 7;
				this.groupBox1.TabStop = false;
				this.groupBox1.Text = "Chọn phép toán";
				// 
				// rdTinhTongab
				// 
				this.rdTinhTongab.AutoSize = true;
				this.rdTinhTongab.Checked = true;
				this.rdTinhTongab.Location = new System.Drawing.Point(22, 27);
				this.rdTinhTongab.Name = "rdTinhTongab";
				this.rdTinhTongab.Size = new System.Drawing.Size(136, 20);
				this.rdTinhTongab.TabIndex = 0;
				this.rdTinhTongab.TabStop = true;
				this.rdTinhTongab.Text = "Tính Tổng của a, b";
				this.rdTinhTongab.UseVisualStyleBackColor = true;
				// 
				// rdTong1n
				// 
				this.rdTong1n.AutoSize = true;
				this.rdTong1n.Location = new System.Drawing.Point(22, 64);
				this.rdTong1n.Name = "rdTong1n";
				this.rdTong1n.Size = new System.Drawing.Size(139, 20);
				this.rdTong1n.TabIndex = 1;
				this.rdTong1n.Text = "Tính tổng từ 1 đến n";
				this.rdTong1n.UseVisualStyleBackColor = true;
				// 
				// btnXemKetQua
				// 
				this.btnXemKetQua.BackColor = System.Drawing.SystemColors.ControlLight;
				this.btnXemKetQua.Location = new System.Drawing.Point(145, 332);
				this.btnXemKetQua.Name = "btnXemKetQua";
				this.btnXemKetQua.Size = new System.Drawing.Size(101, 34);
				this.btnXemKetQua.TabIndex = 2;
				this.btnXemKetQua.Text = " Xem kết quả";
				this.btnXemKetQua.UseVisualStyleBackColor = false;
				this.btnXemKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
				// 
				// label4
				// 
				this.label4.AutoSize = true;
				this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.label4.Location = new System.Drawing.Point(52, 369);
				this.label4.Name = "label4";
				this.label4.Size = new System.Drawing.Size(84, 16);
				this.label4.TabIndex = 8;
				this.label4.Text = "Kết quả là: ";
				// 
				// lblKetQua
				// 
				this.lblKetQua.AutoSize = true;
				this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.lblKetQua.Location = new System.Drawing.Point(142, 369);
				this.lblKetQua.Name = "lblKetQua";
				this.lblKetQua.Size = new System.Drawing.Size(19, 16);
				this.lblKetQua.TabIndex = 9;
				this.lblKetQua.Text = "...";
				// 
				// frmBai3
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(385, 431);
				this.Controls.Add(this.lblKetQua);
				this.Controls.Add(this.label4);
				this.Controls.Add(this.btnXemKetQua);
				this.Controls.Add(this.groupBox1);
				this.Controls.Add(this.txtSoN);
				this.Controls.Add(this.txtSoB);
				this.Controls.Add(this.txtSoA);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.label3);
				this.Controls.Add(this.label2);
				this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
				this.Name = "frmBai3";
				this.Text = "Bài 3";
				this.groupBox1.ResumeLayout(false);
				this.groupBox1.PerformLayout();
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.TextBox txtSoA;
		  private System.Windows.Forms.TextBox txtSoB;
		  private System.Windows.Forms.TextBox txtSoN;
		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.RadioButton rdTong1n;
		  private System.Windows.Forms.RadioButton rdTinhTongab;
		  private System.Windows.Forms.Button btnXemKetQua;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.Label lblKetQua;
	 }
}