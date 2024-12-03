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
    public partial class QuenMK : Form
    {
      
        public QuenMK()
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
            if (txtBaomat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập câu hỏi bảo mật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBaomat.Focus();
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
        private void btnThuchien_Click(object sender, EventArgs e)
        {
            if(KTThongTin())
            {
                try
                {
                   
                    string sql3 = "select tk from Account";
                    string sql1 = "select baomat from Account";

                    if (txtTK.Text.CompareTo(DBConfig.LayMotGiaTri(sql3).ToString())==0)
                    {
                       if(txtBaomat.Text.CompareTo(DBConfig.LayMotGiaTri(sql1)) == 0)
                        {
                            if (txtmk.Text.CompareTo(txtXn.Text)==0)
                            {
                                string sql2 = "update Account set mk=N'" + txtmk.Text + "' where tk=N'" + txtTK.Text + "'";
                                DBConfig.ThemSuaXoa(sql2);
                                MessageBox.Show("Lấy lại mật khẩu thành công\nBạn sẽ quay lại trang đăng nhập", "Thông báo",
                                MessageBoxButtons.OK);
                                Dangnhap dn = new Dangnhap();
                                dn.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu mới và xác nhận không trùng khớp", "Thông báo",
                                 MessageBoxButtons.RetryCancel);
                                txtmk.Clear();
                                txtXn.Clear();
                                txtmk.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sai câu hỏi bảo mật","Thông báo");
                            txtBaomat.Clear();
                            txtBaomat.Focus();
                        }
                    }else
                    {
                        MessageBox.Show("Không tồn tại tài khoản này","Thông báo");
                        txtTK.Clear();
                        txtTK.Focus();
                    }    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dangnhap dn = new Dangnhap();
            dn.Show();
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
        }

        private void chb2_CheckedChanged(object sender, EventArgs e)
        {
            txtXn.PasswordChar = '\0';
            if (chb2.Checked)
                txtXn.UseSystemPasswordChar = false;
            else
                txtXn.UseSystemPasswordChar = true;
        }
    }
}
