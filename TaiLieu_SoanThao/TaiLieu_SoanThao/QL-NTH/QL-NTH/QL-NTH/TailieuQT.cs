using Microsoft.Win32;
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
    public partial class TailieuQT : Form
    {
        private string mod;
        public TailieuQT(string mod)
        {
            this.mod = mod;
            InitializeComponent();
        }
        private void OpenURL(string url)
        {
            string key = @"htmlfile\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            // Get the default browser path on the system
            string Default_Browser_Path = ((string)registryKey.GetValue(null, null)).Split('"')[1];

            Process p = new Process();
            p.StartInfo.FileName = Default_Browser_Path;
            p.StartInfo.Arguments = url;
            p.Start();
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn1, "Website http://www.ketoanthue.vn/ \nClick để truy cập Website");
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn2, "Website https://vinatrain.edu.vn/tai-lieu-tu-hoc-ke-toan/ \nClick để truy cập Website");
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn3, "Website https://drive.google.com/file/d/1Lex3Lv0WOhtIVo2wsSwK95gU6vaOPlU7/view \nClick để truy cập Website");
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn4, "Website https://ketoanthienung.net/ \nClick để truy cập Website");
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn5, "Website https://doc.edu.vn/tai-lieu/quan-tri-kinh-doanh/ \nClick để truy cập Website");
        }

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn6, "Website https://vietbooks.info/ \nClick để truy cập Website");
        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn7, "Website http://elib.vnuf.edu.vn/ \nClick để truy cập Website");
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn8, "Website https://lms.uneti.edu.vn/enrol/index.php?id=15747 \nClick để truy cập Website");
        }

       
        private void btn9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn9, "Website https://lms.uneti.edu.vn/enrol/index.php?id=15571 \nClick để truy cập Website");
        } 
       

        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("http://www.ketoanthue.vn/");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://vinatrain.edu.vn/tai-lieu-tu-hoc-ke-toan/");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://drive.google.com/file/d/1Lex3Lv0WOhtIVo2wsSwK95gU6vaOPlU7/view");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://ketoanthienung.net/");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://doc.edu.vn/tai-lieu/quan-tri-kinh-doanh/");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://vietbooks.info/");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("http://elib.vnuf.edu.vn/");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://lms.uneti.edu.vn/enrol/index.php?id=15747");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://lms.uneti.edu.vn/enrol/index.php?id=15571");
            }
        }
        private void TailieuQT_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
        }

        private void label9_Click(object sender, EventArgs e)
        {
           if(mod=="1")
            {
                QuanTri qt = new QuanTri("1");
                qt.Show();
                this.Hide();
            }
            else
            {
                QuanTri qt = new QuanTri("0");
                qt.Show();
                this.Hide();
            }
        }
    }
}
