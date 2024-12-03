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
    public partial class Dangnhap : Form
    {   
        public Dangnhap()
        {
           
            InitializeComponent();
        }
        public bool KTThongTin()
        {           
            if (txtTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();
                return false;
            }
            if (txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMK.Focus();
                return false;
            }
            
            return true;
        }
        private void chbha_CheckedChanged(object sender, EventArgs e)
        {
            if(chbha.Checked)
            {
                txtMK.UseSystemPasswordChar = true;
            }else
            {
                txtMK.UseSystemPasswordChar = false;
            }    
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(KTThongTin())
            {
        string kq = DBConfig.LayMotGiaTri("select mod from Account where tk=N'"
                + txtTK.Text + "'and mk=N'" +
                txtMK.Text + "'");
            if (kq == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
               txtTK.Focus();
               txtTK.SelectAll();
            }
            else
            {
                this.Hide();
                QuanTri qt = new QuanTri(kq);
                qt.Show();
            }
            }    
            
        }

       

        private void btnreturn_Click(object sender, EventArgs e)
        {
            Giaodien gd = new Giaodien();
            gd.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK qmk = new QuenMK();
            qmk.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtTK.Text = "";
            txtMK.Focus();
        }
    }
}
