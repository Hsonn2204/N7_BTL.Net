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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        

        private void chb1_CheckedChanged(object sender, EventArgs e)
        {
            if (chb1.Checked)
            {
                txtnewmk.UseSystemPasswordChar = true;
            }
            else
            {
                txtnewmk.UseSystemPasswordChar = false;
            }
        }

        private void chb2_CheckedChanged(object sender, EventArgs e)
        {
            if (chb2.Checked)
            {
                txtconfirm.UseSystemPasswordChar = true;
            }
            else
            {
                txtconfirm.UseSystemPasswordChar = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Giaodien gd = new Giaodien();
            gd.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtnewtk.Text = " ";
            txtnewmk.Text ="";
            txtconfirm.Text ="";
            txtBaomat.Text = "";
            txtnewtk.Focus();
        }
        public bool KTThongTin()
        {
            if (txtnewtk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnewtk.Focus();
                return false;
            }
            if (txtnewmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnewmk.Focus();
                return false;
            }
            if (txtconfirm.Text == "")
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtconfirm.Focus();
                return false;
            }
            if (txtconfirm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập câu hỏi bảo mật ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtconfirm.Focus();
                return false;
            }
            return true;
        }
        private void btndk_Click(object sender, EventArgs e)
        {
			if (KTThongTin())
			{
				try
				{
					if (txtnewmk.Text.CompareTo(txtconfirm.Text) == 0)
					{
						string sql1 = "select tk from Account";
						if (txtnewtk.Text.CompareTo(DBConfig.LayMotGiaTri(sql1)) != 0)
						{
							// Xóa điều kiện kiểm tra tài khoản admin
							string sql = "insert into Account(tk,mk,mod,baomat) values( N'" +
						   txtnewtk.Text + "' , N'" +
						   txtnewmk.Text + "', 0, N'" + txtBaomat.Text + "')"; // Luôn gán mod = 0
							DBConfig.ThemSuaXoa(sql);
							MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Giaodien gd = new Giaodien();
							gd.Show();
							this.Hide();
						}
						else
						{
							MessageBox.Show("Đã tồn tại tên tài khoản! Hãy nhập tên khác", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							txtnewtk.SelectAll();
							txtnewtk.Focus();
						}
					}
					else
					{
						MessageBox.Show("Mật Khẩu xác nhận không trùng khớp", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txtnewmk.Text = "";
						txtconfirm.Text = "";
						txtnewmk.Focus();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        private void txtBaomat_MouseClick(object sender, MouseEventArgs e)
        {
            txtBaomat.SelectAll();
            txtBaomat.Focus();
          //  txtBaomat.Font = new Font(txtBaomat.Font, txtBaomat.Font.Style ^ FontStyle.Bold);
        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }
    }
}
