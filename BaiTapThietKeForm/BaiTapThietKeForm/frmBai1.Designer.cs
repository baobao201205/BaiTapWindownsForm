namespace BaiTapThietKeForm
{
	 partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.rdXanh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTinhTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTrang);
            this.groupBox1.Controls.Add(this.rdDo);
            this.groupBox1.Controls.Add(this.rdXanh);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rdTrang
            // 
            resources.ApplyResources(this.rdTrang, "rdTrang");
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
            // 
            // rdDo
            // 
            resources.ApplyResources(this.rdDo, "rdDo");
            this.rdDo.Name = "rdDo";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
            // 
            // rdXanh
            // 
            resources.ApplyResources(this.rdXanh, "rdXanh");
            this.rdXanh.Checked = true;
            this.rdXanh.Name = "rdXanh";
            this.rdXanh.TabStop = true;
            this.rdXanh.UseVisualStyleBackColor = true;
            this.rdXanh.CheckedChanged += new System.EventHandler(this.rdXanh_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtDonGia
            // 
            resources.ApplyResources(this.txtDonGia, "txtDonGia");
            this.txtDonGia.Name = "txtDonGia";
            // 
            // txtSoLuong
            // 
            resources.ApplyResources(this.txtSoLuong, "txtSoLuong");
            this.txtSoLuong.Name = "txtSoLuong";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.btnTinhTien, "btnTinhTien");
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtTinhTien
            // 
            resources.ApplyResources(this.txtTinhTien, "txtTinhTien");
            this.txtTinhTien.Name = "txtTinhTien";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::BaiTapThietKeForm.Properties.Resources.f156da1e2378e7a9e805a693c99c6a47;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmBai1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTinhTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		  }

		  #endregion
		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.RadioButton rdTrang;
		  private System.Windows.Forms.RadioButton rdDo;
		  private System.Windows.Forms.RadioButton rdXanh;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.Label label2;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.TextBox txtDonGia;
		  private System.Windows.Forms.TextBox txtSoLuong;
		  private System.Windows.Forms.Button btnTinhTien;
		  private System.Windows.Forms.Label label4;
		  private System.Windows.Forms.TextBox txtTinhTien;
		  private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}