using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_NTH
{
    public partial class Baocao : Form
    {
        
        public Baocao()
        {
            
            InitializeComponent();
        }
       
        private void Baocao_Load(object sender, EventArgs e)
        {
            
          
        }

        private void btnBaocaoTK_Click(object sender, EventArgs e)
        {
            string sql = "select * from Account";
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLNTH;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            rpvbaocao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvbaocao.LocalReport.ReportPath = "D:\\baithiltnet\\QL-NTH\\QL-NTH\\QL-NTH\\Report2.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1"; //tên DataSet đã đặt lúc tạo
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng
                rpvbaocao.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvbaocao.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvbaocao.RefreshReport();
            }
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            string sql = "select * from Listdaduyet";
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLNTH;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            rpvbaocao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvbaocao.LocalReport.ReportPath = "D:\\baithiltnet\\QL-NTH\\QL-NTH\\QL-NTH\\Report1.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1"; //tên DataSet đã đặt lúc tạo
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng
                rpvbaocao.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvbaocao.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvbaocao.RefreshReport();
            }
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            string sql = "select * from Listchoduyet";
            string path = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLNTH;Integrated Security=True";
            SqlConnection con = new SqlConnection(path);
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            rpvbaocao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            rpvbaocao.LocalReport.ReportPath = "D:\\baithiltnet\\QL-NTH\\QL-NTH\\QL-NTH\\Report3.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet1"; //tên DataSet đã đặt lúc tạo
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng
                rpvbaocao.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                rpvbaocao.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                rpvbaocao.RefreshReport();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
        
                QuanTri qt = new QuanTri("1");
                qt.Show();
                this.Hide();
                         
        }
    }
}
