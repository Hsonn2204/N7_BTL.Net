using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NTH
{
    public partial class DangkiNhom : Form
    {
        private string mod;
        public DangkiNhom(string mod)
        {
            this.mod = mod;
            InitializeComponent();
        }
       
        

        private void DangkiNhom_Load(object sender, EventArgs e)
        {
            txtThoigian.Text= monthCalendar1.SelectionEnd.ToShortDateString();
            txtThoigian.Enabled = false;          
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedItem == "CNTT")
            {
                cbMonhoc.Items.Clear();
                cbMonhoc.Text = "";
                cbMonhoc.Items.Add("Lập trình web");
                cbMonhoc.Items.Add("Lập trình căn bản");
            }
            if (cbKhoa.SelectedItem == "KINH TẾ")
            {
                cbMonhoc.Items.Clear();
                cbMonhoc.Text = "";
                cbMonhoc.Items.Add("Kế toán");
                cbMonhoc.Items.Add("Quản trị");
            }
        }
        public bool KTThongTin()
        {
            if (txtHt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHt.Focus();
                return false;
            }
            if (txtLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            
            if (txtSdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSdt.Focus();
                return false;
            }
            if (cbKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập bộ môn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbKhoa.Focus();
                return false;
            }
            if (cbMonhoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khoa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMonhoc.Focus();
                return false;
            }
            
            return true;
        }
        private void btnDangki_Click(object sender, EventArgs e)
        {
            try
            {
                if (KTThongTin())
                {
                    string sql = "insert into Listchoduyet (hoten,lop,msv,sdt,khoa,monhoc,ngay) values(N'" + txtHt.Text + "',N'" + txtLop.Text + "','" + txtMsv.Text + "','" + txtSdt.Text + "',N'" + cbKhoa.Text + "',N'" + cbMonhoc.Text + "','" + txtThoigian.Text + "')";
                    DBConfig.ThemSuaXoa(sql);                  
                    MessageBox.Show("Đăng kí thành công!","Thông báo!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    QuanTri qt = new QuanTri("0");
                    qt.Show();
                    this.Hide();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
           
           
                QuanTri qt = new QuanTri("0");
                qt.Show();
            this.Hide();  
        }
    }
}
