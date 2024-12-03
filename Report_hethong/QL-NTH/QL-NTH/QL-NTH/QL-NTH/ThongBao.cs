using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_NTH
{
    public partial class ThongBao : Form
    {
        private string mod;
        public ThongBao(string mod)
        {
            this.mod = mod;
            InitializeComponent();
        }
       

        private void ThongBao_Load(object sender, EventArgs e)
        {
            if(mod=="0")
            {
                groupBox4.Visible = false;
                btnThem.Visible = false;
                btnXoa.Visible = false;
            }    
            dgvThongBao.DataSource = DBConfig.LayBang("select sotb,noidung,ngay  from tbThongbao ");
            dgvThongBao.Columns[0].HeaderText = "Số";
            dgvThongBao.Columns[1].HeaderText = "Nội Dung";
            dgvThongBao.Columns[2].HeaderText = "Ngày";
            dgvThongBao.Columns[0].Width = 50;
            dgvThongBao.Columns[1].Width = 400;
            dgvThongBao.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvThongBao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           dgvThongBao.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
            //dgvThongBao.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
           txtNgay.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            lblSobanghi.Text = "Số bản ghi: " + (dgvThongBao.Rows.Count - 1).ToString();
            for (int i = 0; i < dgvThongBao.Rows.Count; i++)
            {
                dgvThongBao.Rows[i].HeaderCell.Value = i.ToString();

            }
        }
        public bool KTThongTin()
        {
            if (txtNoidung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtNoidung.Focus();
                return false;
            }
            if (txtNgay.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgay.Focus();
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
                    string sql = "insert into tbThongbao(sotb,noidung,ngay) values( N'"+txtma.Text+"',N'" +
                           txtNoidung.Text + "' , N'" +
                           txtNgay.Text + "')";
                    DBConfig.ThemSuaXoa(sql);
                    dgvThongBao.DataSource = DBConfig.LayBang("select sotb,noidung,ngay  from tbThongbao");
                    dgvThongBao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvThongBao.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                    MessageBox.Show("Đã thêm!");
                    lblSobanghi.Text = "Số bản ghi: " + (dgvThongBao.Rows.Count - 1).ToString();
                    for (int i = 0; i < dgvThongBao.Rows.Count; i++)
                    {
                        dgvThongBao.Rows[i].HeaderCell.Value = i.ToString();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn xóa không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                string sql = "delete from tbThongbao where sotb='"+txtma.Text+"'";
                DBConfig.ThemSuaXoa(sql);
                dgvThongBao.DataSource = DBConfig.LayBang("select sotb,noidung,ngay  from tbThongbao");
                dgvThongBao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvThongBao.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                MessageBox.Show("Đã xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    lblSobanghi.Text = "Số bản ghi: " + (dgvThongBao.Rows.Count - 1).ToString();
                    for (int i = 0; i < dgvThongBao.Rows.Count; i++)
                    {
                        dgvThongBao.Rows[i].HeaderCell.Value = i.ToString();

                    }
                }    
                
            }
        }

        private void dgvThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvThongBao.Rows[e.RowIndex];
            txtNoidung.Text = Convert.ToString(row.Cells[1].Value);
            txtNgay.Text = Convert.ToString(row.Cells[2].Value);
            txtma.Text = Convert.ToString(row.Cells[0].Value);
        }

        private void btnTrolai_Click(object sender, EventArgs e)
        {
           if(mod=="1")
            {
                QuanTri Qt = new QuanTri("1");
                Qt.Show();
                this.Hide();
            }
            else
            {
                QuanTri Qt = new QuanTri("0");
                Qt.Show();
                this.Hide();
            }
        }

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (KTThongTin())
			{
				DialogResult dlr = MessageBox.Show("Bạn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dlr == DialogResult.Yes)
				{
					// Giả sử bạn đã có trường txtNoidung và txtNgay để nhập thông tin cần sửa
					string sotb = txtma.Text; // Lấy giá trị từ trường txtma
					string noidung = txtNoidung.Text; // Lấy nội dung mới từ trường txtNoidung
					string ngay = txtNgay.Text; // Lấy ngày mới từ trường txtNgay

					// Câu lệnh SQL để cập nhật dữ liệu
					string sql = "UPDATE tbThongbao SET noidung = '" + noidung + "', ngay = '" + ngay + "' WHERE sotb = '" + sotb + "'";
					DBConfig.ThemSuaXoa(sql);

					// Cập nhật lại DataGridView
					dgvThongBao.DataSource = DBConfig.LayBang("SELECT sotb, noidung, ngay FROM tbThongbao");
					dgvThongBao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
					dgvThongBao.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

					MessageBox.Show("Đã sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					lblSobanghi.Text = "Số bản ghi: " + (dgvThongBao.Rows.Count - 1).ToString();
					for (int i = 0; i < dgvThongBao.Rows.Count; i++)
					{
						dgvThongBao.Rows[i].HeaderCell.Value = i.ToString();
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (KTThongTin())
			{
				DialogResult dlr = MessageBox.Show("Bạn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (dlr == DialogResult.Yes)
				{
					// Giả sử bạn đã có trường txtNoidung và txtNgay để nhập thông tin cần sửa
					string sotb = txtma.Text; // Lấy giá trị từ trường txtma
					string noidung = txtNoidung.Text; // Lấy nội dung mới từ trường txtNoidung
					string ngay = txtNgay.Text; // Lấy ngày mới từ trường txtNgay

					// Câu lệnh SQL để cập nhật dữ liệu
					string sql = "UPDATE tbThongbao SET noidung = '" + noidung + "', ngay = '" + ngay + "' WHERE sotb = '" + sotb + "'";
					DBConfig.ThemSuaXoa(sql);

					// Cập nhật lại DataGridView
					dgvThongBao.DataSource = DBConfig.LayBang("SELECT sotb, noidung, ngay FROM tbThongbao");
					dgvThongBao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
					dgvThongBao.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

					MessageBox.Show("Đã sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					lblSobanghi.Text = "Số bản ghi: " + (dgvThongBao.Rows.Count - 1).ToString();
					for (int i = 0; i < dgvThongBao.Rows.Count; i++)
					{
						dgvThongBao.Rows[i].HeaderCell.Value = i.ToString();
					}
				}
			}
		}
	}
}
