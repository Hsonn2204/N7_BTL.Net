using System;
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
    public partial class ThaydoiMk : Form
    {
        private string mod;
        public ThaydoiMk(string mod)
        {
            this.mod = mod;
            InitializeComponent();
        }
        public bool KTThongTin()
        {
            
            if (txtmkcu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmkcu.Focus();
                return false;
            }
            if (txtmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmk.Focus();
                return false;
            }
            if (txtXn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu xác nhận ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtXn.Focus();
                return false;
            }
            return true;
        }

        private void ThaydoiMk_Load(object sender, EventArgs e)
        {
            
            txtTK.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            QuanTri qt = new QuanTri("0");
            qt.Show();
            this.Hide();
        }
        private void chb1_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.PasswordChar = '\0';
            if (chb1.Checked)
                txtmk.UseSystemPasswordChar = false;
            else
                txtmk.UseSystemPasswordChar = true;
        }

        private void QuenMK_Load(object sender, EventArgs e)
        {
            txtmk.PasswordChar = '*';
            txtXn.PasswordChar = '*';
            txtmkcu.PasswordChar = '*';
        }

        private void chb2_CheckedChanged(object sender, EventArgs e)
        {
            txtXn.PasswordChar = '\0';
            if (chb2.Checked)
                txtXn.UseSystemPasswordChar = false;
            else
                txtXn.UseSystemPasswordChar = true;
        }

        private void chb3_CheckedChanged(object sender, EventArgs e)
        {
            txtmkcu.PasswordChar = '\0';
            if (chb2.Checked)
                txtmkcu.UseSystemPasswordChar = false;
            else
                txtmkcu.UseSystemPasswordChar = true;
        }
    }
}
