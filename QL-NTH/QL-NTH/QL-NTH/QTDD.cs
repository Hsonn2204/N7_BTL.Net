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
    public partial class QTDD : Form
    {
        private string mod;
        public QTDD()
        {
            
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtht.Clear();
            txtmsv.Clear();
            txtLop.Clear();
            txtsdt.Clear();
            txtKhoa.Text = "";
            txtBM.Text = "";
            txtht.Focus();
            txtngay.Text = monthCalendar1.SelectionEnd.ToShortDateString();
        }

        private void QTDD_Load(object sender, EventArgs e)
        {
                       
            dgvQTDD.DataSource = DBConfig.LayBang("select * from Listdaduyet ");
            dgvQTDD.Columns[0].HeaderText = "ID";
            dgvQTDD.Columns[1].HeaderText = "Họ tên";
            dgvQTDD.Columns[2].HeaderText = "Lớp";
            dgvQTDD.Columns[3].HeaderText = "Mã SV";
            dgvQTDD.Columns[4].HeaderText = "Số DT";
            dgvQTDD.Columns[5].HeaderText = "Khoa  ";
            dgvQTDD.Columns[6].HeaderText = "Môn học";
            dgvQTDD.Columns[7].HeaderText = "Thời gian ";
            dgvQTDD.Columns[0].Width = 50;
            dgvQTDD.Columns[1].Width = 150;
      
            dgvQTDD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQTDD.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtngay.Enabled = false;
            txtid.Enabled = false;
            txtngay.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            lblSobanghi.Text = "Số bản ghi: " + (dgvQTDD.Rows.Count - 1).ToString();
            for (int i = 0; i < dgvQTDD.Rows.Count; i++)
            {
                dgvQTDD.Rows[i].HeaderCell.Value = i.ToString();

            }
        }

        private void dgvQTDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvQTDD.Rows[e.RowIndex];
            txtid.Text = Convert.ToString(row.Cells[0].Value);
            txtht.Text = Convert.ToString(row.Cells[1].Value);
            txtLop.Text = Convert.ToString(row.Cells[2].Value);
            txtmsv.Text = Convert.ToString(row.Cells[3].Value);
            txtsdt.Text = Convert.ToString(row.Cells[4].Value);
            txtKhoa.Text = Convert.ToString(row.Cells[5].Value);
            txtBM.Text = Convert.ToString(row.Cells[6].Value);
            txtngay.Text = Convert.ToString(row.Cells[7].Value);
        }

        
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            if (txtsearch.Text.Trim() == " ")
                dgvQTDD.DataSource = DBConfig.LayBang("select * from Listdaduyet");
            else
            {
                string sql = "select * from Listdaduyet where hoten like N'%" +
                    txtsearch.Text + "%' and monhoc like N'%" +
                    cbsearch.Text + "%'";
                dgvQTDD.DataSource = DBConfig.LayBang(sql);
            }
        }
      
        public bool KTThongTin()
        {
            if (txtLop.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            if (txtht.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtht.Focus();
                return false;
            }
            if (txtmsv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmsv.Focus();
                return false;
            }
            if (txtBM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập bộ môn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBM.Focus();
                return false;
            }
            if (txtKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khoa ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoa.Focus();
                return false;
            }
            if (txtsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsdt.Focus();
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
                    string sql = "insert into Listdaduyet (hoten,lop,msv,sdt,khoa,monhoc,ngay) values(N'"+txtht.Text+ "',N'" + txtLop.Text + "','" + txtmsv.Text+ "','" + txtsdt.Text + "',N'" + txtKhoa.Text + "',N'" + txtBM.Text + "','" + txtngay.Text + "')";
                    DBConfig.ThemSuaXoa(sql);
                    dgvQTDD.DataSource = DBConfig.LayBang("select * from Listdaduyet");
                    MessageBox.Show("Đã thêm!");
                    lblSobanghi.Text = "Số bản ghi: " + (dgvQTDD.Rows.Count - 1).ToString();
                    for (int i = 0; i < dgvQTDD.Rows.Count; i++)
                    {
                        dgvQTDD.Rows[i].HeaderCell.Value = i.ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            QuanTri qt = new QuanTri("1");
            qt.Show();
            this.Hide();
        }

        private void txtKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtKhoa.SelectedItem == "CNTT")
            {
                txtBM.Items.Clear();
                txtBM.Text = "";
                txtBM.Items.Add("Lập trình web");
                txtBM.Items.Add("Lập trình căn bản");
            }
            if (txtKhoa.SelectedItem == "KINH TẾ")
            {
                txtBM.Items.Clear();
                txtBM.Text = "";
                txtBM.Items.Add("Kế toán");
                txtBM.Items.Add("Quản trị");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                string sql = "update Listdaduyet set hoten= N'" + txtht.Text + "',lop = N'" + txtLop.Text + "',msv='" + txtmsv.Text + "',sdt='" + txtsdt.Text + "',khoa=N'" + txtKhoa.Text + "',monhoc=N'" + txtBM.Text + "',ngay='" + txtngay.Text + "' where id= '"+txtid.Text+"'";
                DBConfig.ThemSuaXoa(sql);
                dgvQTDD.DataSource = DBConfig.LayBang("select * from Listdaduyet");
                MessageBox.Show("Đã sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                string sql = "delete from Listdaduyet where id=N'" +
             txtid.Text + "'";
                DBConfig.ThemSuaXoa(sql);
                dgvQTDD.DataSource = DBConfig.LayBang("select * from Listdaduyet");
                MessageBox.Show("Đã xóa!");
                lblSobanghi.Text = "Số bản ghi: " + (dgvQTDD.Rows.Count - 1).ToString();
                for (int i = 0; i < dgvQTDD.Rows.Count; i++)
                {
                    dgvQTDD.Rows[i].HeaderCell.Value = i.ToString();

                }
            }
        }

        private void cbsearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbsearch.Text.Trim() == "Ban đầu")
                dgvQTDD.DataSource = DBConfig.LayBang("select * from Listdaduyet");
            else
            {
                string sql = "select * from Listdaduyet where monhoc like N'%" +
                    cbsearch.Text + "%' and hoten like N'%" +
                    txtsearch.Text + "%'";
                dgvQTDD.DataSource = DBConfig.LayBang(sql);
            }
        }
    }
}
