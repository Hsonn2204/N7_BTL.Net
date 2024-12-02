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
    public partial class QTTK : Form
    {
       
        public QTTK()
        {
            

            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            QuanTri qt = new QuanTri("1");
            qt.Show();
            this.Hide();
        }

        private void QTTK_Load(object sender, EventArgs e)
        {
            dgvQTTK.DataSource = DBConfig.LayBang("select * from Account");
            dgvQTTK.Columns[0].HeaderText = "ID";
            dgvQTTK.Columns[1].HeaderText = "Tài khoản";
            dgvQTTK.Columns[2].HeaderText = "Mật khẩu";
            dgvQTTK.Columns[3].HeaderText = "Quyền";
            dgvQTTK.Columns[4].HeaderText = "Bảo mật";
            dgvQTTK.Columns[0].Width = 50;
            dgvQTTK.Columns[1].Width = 200;
            dgvQTTK.Columns[2].Width = 200;
            dgvQTTK.Columns[3].Width=50;
            dgvQTTK.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvQTTK.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTTK.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTTK.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTTK.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTTK.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTTK.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtid.Enabled = false;
            lblSobanghi.Text = "Số bản ghi: " + (dgvQTTK.Rows.Count - 1).ToString();
            for (int i = 0; i < dgvQTTK.Rows.Count; i++)
            {
                dgvQTTK.Rows[i].HeaderCell.Value = i.ToString();

            }
        }

       

        private void dgvQTTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvQTTK.Rows[e.RowIndex];
            txtid.Text = Convert.ToString(row.Cells[0].Value);
            txttk.Text = Convert.ToString(row.Cells[1].Value);
            txtmk.Text = Convert.ToString(row.Cells[2].Value);
            txtmod.Text = Convert.ToString(row.Cells[3].Value);
            txtBaomat.Text = Convert.ToString(row.Cells[4].Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txttk.Clear();
            txtmk.Clear();
            txtmod.Clear();
            txttk.Focus();
            txtBaomat.Clear();
        }
        public bool KTThongTin()
        {
            if (txttk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttk.Focus();
                return false;
            }
            if (txtmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmk.Focus();
                return false;
            }
            if (txtmod.Text == "")
            {
                MessageBox.Show("Vui lòng nhập quyền truy cập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmod.Focus();
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KTThongTin())
            {
                string sql = "insert into Account(tk,mk,mod,baomat) values( N'" +
                       txttk.Text + "' , N'" +
                       txtmk.Text + "','" + txtmod.Text +"',N'"+txtBaomat.Text+"')";
                    DBConfig.ThemSuaXoa(sql);
                    dgvQTTK.DataSource = DBConfig.LayBang("select * from Account");
                    MessageBox.Show("Đã thêm!");
                    lblSobanghi.Text = "Số bản ghi: " + (dgvQTTK.Rows.Count - 1).ToString();
                    for (int i = 0; i < dgvQTTK.Rows.Count; i++)
                    {
                        dgvQTTK.Rows[i].HeaderCell.Value = i.ToString();

                    }
                }
            
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                string sql = "update Account set tk = N'" +
               txttk.Text + "',mk =" +
               txtmk.Text + ", mod = " +
               txtmod.Text + " , baomat=N'"+txtBaomat.Text+"' where id = N'" +
               txtid.Text + "'";
                DBConfig.ThemSuaXoa(sql);
                dgvQTTK.DataSource = DBConfig.LayBang("select * from Account");
                MessageBox.Show("Đã sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                string sql = "delete from Account where id=N'" +
             txtid.Text + "'";
                DBConfig.ThemSuaXoa(sql);
                dgvQTTK.DataSource = DBConfig.LayBang("select * from Account");
                MessageBox.Show("Đã xóa!");
                lblSobanghi.Text = "Số bản ghi: " + (dgvQTTK.Rows.Count - 1).ToString();
                for (int i = 0; i < dgvQTTK.Rows.Count; i++)
                {
                    dgvQTTK.Rows[i].HeaderCell.Value = i.ToString();

                }
            }
        }

        

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

            if (txtsearch.Text.Trim() == " ")
                dgvQTTK.DataSource = DBConfig.LayBang("select * from Account");
            else
            {
                string sql = "select * from Account where tk like N'%" +
                    txtsearch.Text + "%'";
                dgvQTTK.DataSource = DBConfig.LayBang(sql);
            }
        }
    }
}
