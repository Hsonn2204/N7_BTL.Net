using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NTH
{
    public partial class QuanTri : Form
    {
     
        
        
        
        private string mod;
        public QuanTri(string mod)
        {
            this.mod = mod;
            InitializeComponent();
        }

      

        private void QuanTri_Load(object sender, EventArgs e)
        {
            if(mod=="1")
            {
                lblmod.Text = "Quyền : Quản trị viên";
                thôngBáoToolStripMenuItem.Visible = false;
                mntThaydoimk.Visible = false;
            }    else
            {
                lblmod.Text = "Quyền : Người dùng";
            }  
            
            grdgvQT.Visible = false;
            
            if (mod == "0")
            {
                báoCáoToolStripMenuItem.Visible = false;
                mntQTTK.Visible = false;
                mntQTNH.Visible = false;
            }
            Media.URL = "D:\\HK_1_4\\TT .Net\\BTL\\QL-NTH\\QL-NTH\\Image\\Media.mp4";
          
           
        }

        private void mntQTTK_Click(object sender, EventArgs e)
        {
            //grdgvQT.Visible = true;          
            //dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Account");
            //dgvQuantriTT.Columns[0].HeaderText = "ID";
            //dgvQuantriTT.Columns[1].HeaderText = "Tài khoản";
            //dgvQuantriTT.Columns[2].HeaderText = "Mật khẩu";
            //dgvQuantriTT.Columns[3].HeaderText = "Quyền";
            //dgvQuantriTT.Columns[0].Width = 100;
            //dgvQuantriTT.Columns[1].Width = 300;
            //dgvQuantriTT.Columns[2].Width = 300;
            //dgvQuantriTT.Columns[3].Width = 100;
            QTTK qttk = new QTTK();
            qttk.Show();
            this.Hide();

        }


        private void mntDuyetcanban_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
            
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listchoduyet where khoa=N'CNTT' and monhoc=N'Lập trình căn bản'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian ";

        }

        private void mntDuyetweb_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
            
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listchoduyet where khoa=N'CNTT' and monhoc=N'Lập trình web'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian";
        }

        private void mntDuyetketoan_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
            
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listchoduyet where khoa=N'KINH TẾ' and monhoc=N'Kế toán'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian";
        }

        private void mntDuyetquantri_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
            
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listchoduyet where khoa=N'KINH TẾ' and monhoc=N'Quản trị'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian";
        }

        private void mntDanhsachcanban_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
           
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listdaduyet where khoa=N'CNTT' and monhoc=N'Lập trình căn bản'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian";
           
        }

        private void mntDanhsachwweb_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
            
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listdaduyet where khoa=N'CNTT' and monhoc=N'Lập trình web'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian";
        }

        private void mntDanhsachketoan_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
            
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listdaduyet where khoa=N'KINH TẾ' and monhoc=N'Kế toán'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian";
        }

        private void mntDanhsachquantri_Click(object sender, EventArgs e)
        {
            grdgvQT.Visible = true;
            
            dgvQuantriTT.DataSource = DBConfig.LayBang("select * from Listdaduyet where khoa=N'KINH TẾ' and monhoc=N'Quản trị'");
            dgvQuantriTT.Columns[0].HeaderText = "ID";
            dgvQuantriTT.Columns[1].HeaderText = "Họ tên";
            dgvQuantriTT.Columns[2].HeaderText = "Lớp";
            dgvQuantriTT.Columns[3].HeaderText = "Mã SV";
            dgvQuantriTT.Columns[4].HeaderText = "Số DT";
            dgvQuantriTT.Columns[5].HeaderText = "Khoa  ";
            dgvQuantriTT.Columns[6].HeaderText = "Môn học";
            dgvQuantriTT.Columns[7].HeaderText = "Thời gian";
        }

        private void thôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangkiNhom dk = new DangkiNhom("0");
            dk.Show();
            this.Hide();
        }

        private void btnThemQT_Click(object sender, EventArgs e)
        {
            if (mntDanhsachcanban.CheckOnClick)
            {

            }
        }

        private void mntDangxuat_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }

        private void nhómChờDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTCD cd = new QTCD();
            cd.Show();
            this.Hide();
        }

        private void nhómĐãDuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QTDD dd = new QTDD();
            dd.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (mod == "1")
            {
                lblmod.Text = "Quyền : Quản trị viên";
            }
            else
            {
                lblmod.Text = "Quyền : Người dùng";
            }

            grdgvQT.Visible = false;

            if (mod == "0")
            {
                báoCáoToolStripMenuItem.Visible = false;
                mntQTTK.Visible = false;
                mntQTNH.Visible = false;
            }
        }

        private void mntThongbao_Click(object sender, EventArgs e)
        {
            if (mod == "1")
            {
                ThongBao tb = new ThongBao("1");
                tb.Show();
                this.Hide();
            }else
            {
                ThongBao tb = new ThongBao("0");
                tb.Show();
                this.Hide();
            }    
        }

        private void mntThaydoimk_Click(object sender, EventArgs e)
        {
            ThaydoiMk t = new ThaydoiMk("0");
            t.Show();
            this.Hide();
                
        }

        private void khoaCNTTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
                Media.URL = openFileDialog1.FileName;
        }

        private void trìnhSoạnThảoTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(mod=="1")
            {
                Note n = new Note("1");
                n.Show();
                this.Hide();
            }else
            {
                Note n = new Note("0");
                n.Show();
                this.Hide();
            }    
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baocao bc = new Baocao();
            bc.Show();
            this.Hide();
        }

        private void QuanTri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void khoaCNTTToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (mod == "1")
            {
                TailieuWeb qt = new TailieuWeb("1");
                qt.Show();
                this.Hide();
            }else
            {
                TailieuWeb qt = new TailieuWeb("0");
                qt.Show();
                this.Hide();
            }    
        }

        private void khoaKếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mod == "1")
            {
                TailieuQT qt = new TailieuQT("1");
                qt.Show();
                this.Hide();
            }
            else
            {
                TailieuQT qt = new TailieuQT("0");
                qt.Show();
                this.Hide();
            }
        }

		private void btnPhanhoi_Click(object sender, EventArgs e)
		{
			if (mod == "1") // Kiểm tra nếu người dùng là quản trị viên
			{
				Process.Start(new ProcessStartInfo("https://github.com/Hsonn2204/N7_BTL.Net") { UseShellExecute = true });
			}
			else // Người dùng là người dùng thông thường
			{
				Lienhe lienhe = new Lienhe();
				lienhe.Show();
			}

		}

		private void thôngTinNhómHọcToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void ctmenustripTSX_Opening(object sender, CancelEventArgs e)
		{

		}

		private void ctmenustripThem_Click(object sender, EventArgs e)
		{

		}

		private void btnHuongdan_Click(object sender, EventArgs e)
		{
			Process.Start(new ProcessStartInfo("https://trello.com/b/KbvXujsJ/nhom-7-btlnet") { UseShellExecute = true });
		}
	}
}
