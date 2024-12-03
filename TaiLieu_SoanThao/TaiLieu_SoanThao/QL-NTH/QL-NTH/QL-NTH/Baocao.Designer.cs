
namespace QL_NTH
{
    partial class Baocao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocao));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ListdaduyetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCD = new System.Windows.Forms.Button();
            this.btnDD = new System.Windows.Forms.Button();
            this.btnBaocaoTK = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rpvbaocao = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ListdaduyetBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListdaduyetBindingSource
            // 
            this.ListdaduyetBindingSource.DataMember = "Listdaduyet";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1084, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnCD);
            this.groupBox2.Controls.Add(this.btnDD);
            this.groupBox2.Controls.Add(this.btnBaocaoTK);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 511);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(6, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Trở lại";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            //this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCD
            // 
            this.btnCD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCD.Image = ((System.Drawing.Image)(resources.GetObject("btnCD.Image")));
            this.btnCD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCD.Location = new System.Drawing.Point(6, 153);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(192, 36);
            this.btnCD.TabIndex = 3;
            this.btnCD.Text = "Danh sách chờ duyệt";
            this.btnCD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCD.UseVisualStyleBackColor = true;
          //  this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // btnDD
            // 
            this.btnDD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDD.Image = ((System.Drawing.Image)(resources.GetObject("btnDD.Image")));
            this.btnDD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDD.Location = new System.Drawing.Point(6, 94);
            this.btnDD.Name = "btnDD";
            this.btnDD.Size = new System.Drawing.Size(192, 36);
            this.btnDD.TabIndex = 2;
            this.btnDD.Text = "Danh sách đã duyệt";
            this.btnDD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDD.UseVisualStyleBackColor = true;
           // this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // btnBaocaoTK
            // 
            this.btnBaocaoTK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBaocaoTK.Image = ((System.Drawing.Image)(resources.GetObject("btnBaocaoTK.Image")));
            this.btnBaocaoTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocaoTK.Location = new System.Drawing.Point(4, 38);
            this.btnBaocaoTK.Name = "btnBaocaoTK";
            this.btnBaocaoTK.Size = new System.Drawing.Size(192, 36);
            this.btnBaocaoTK.TabIndex = 1;
            this.btnBaocaoTK.Text = "Danh sách Tài Khoản";
            this.btnBaocaoTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaocaoTK.UseVisualStyleBackColor = true;
            //this.btnBaocaoTK.Click += new System.EventHandler(this.btnBaocaoTK_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(3, 337);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rpvbaocao);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(232, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 511);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // rpvbaocao
            // 
            this.rpvbaocao.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.ListdaduyetBindingSource;
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = null;
            this.rpvbaocao.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvbaocao.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvbaocao.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvbaocao.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvbaocao.LocalReport.ReportEmbeddedResource = "QL_NTH.Report1.rdlc";
            this.rpvbaocao.Location = new System.Drawing.Point(3, 16);
            this.rpvbaocao.Name = "rpvbaocao";
            this.rpvbaocao.ServerReport.BearerToken = null;
            this.rpvbaocao.Size = new System.Drawing.Size(846, 492);
            this.rpvbaocao.TabIndex = 0;
            // 
            // Baocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Baocao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baocao";
          //  this.Load += new System.EventHandler(this.Baocao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListdaduyetBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.Reporting.WinForms.ReportViewer rpvbaocao;       
        private System.Windows.Forms.BindingSource ListdaduyetBindingSource;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnBaocaoTK;
        private System.Windows.Forms.Button btnDD;
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Button btnThoat;
    }
}