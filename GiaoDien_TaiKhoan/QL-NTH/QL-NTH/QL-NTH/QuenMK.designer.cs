
namespace QL_NTH
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtBaomat = new System.Windows.Forms.TextBox();
            this.btnThuchien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtXn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập trả lời hỏi bảo mật";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tạo mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác nhận mật khẩu mới";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(194, 20);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(152, 20);
            this.txtTK.TabIndex = 4;
            // 
            // txtBaomat
            // 
            this.txtBaomat.Location = new System.Drawing.Point(194, 52);
            this.txtBaomat.Name = "txtBaomat";
            this.txtBaomat.Size = new System.Drawing.Size(152, 20);
            this.txtBaomat.TabIndex = 5;
            // 
            // btnThuchien
            // 
            this.btnThuchien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThuchien.Location = new System.Drawing.Point(69, 165);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(118, 35);
            this.btnThuchien.TabIndex = 8;
            this.btnThuchien.Text = "Thực hiện";
            this.btnThuchien.UseVisualStyleBackColor = true;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(222, 165);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 35);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Image = ((System.Drawing.Image)(resources.GetObject("chb1.Image")));
            this.chb1.Location = new System.Drawing.Point(351, 92);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(31, 16);
            this.chb1.TabIndex = 10;
            this.chb1.UseVisualStyleBackColor = true;
            this.chb1.CheckedChanged += new System.EventHandler(this.chb1_CheckedChanged);
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Image = ((System.Drawing.Image)(resources.GetObject("chb2.Image")));
            this.chb2.Location = new System.Drawing.Point(351, 134);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(31, 16);
            this.chb2.TabIndex = 11;
            this.chb2.UseVisualStyleBackColor = true;
            this.chb2.CheckedChanged += new System.EventHandler(this.chb2_CheckedChanged);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(194, 88);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(152, 20);
            this.txtmk.TabIndex = 12;
            // 
            // txtXn
            // 
            this.txtXn.Location = new System.Drawing.Point(194, 132);
            this.txtXn.Name = "txtXn";
            this.txtXn.Size = new System.Drawing.Size(152, 20);
            this.txtXn.TabIndex = 13;
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(392, 210);
            this.Controls.Add(this.txtXn);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.chb2);
            this.Controls.Add(this.chb1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThuchien);
            this.Controls.Add(this.txtBaomat);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuenMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMK";
            this.Load += new System.EventHandler(this.QuenMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtBaomat;
        private System.Windows.Forms.Button btnThuchien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtXn;
    }
}