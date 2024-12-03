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
    public partial class TailieuWeb : Form
    {
        private string mod;
        public TailieuWeb(string mod)
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

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();          
        }

        private void btn1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn1, "Website https://fullstack.edu.vn/ \nClick để truy cập Website");
        }

        private void btn2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn2, "Website https://stackoverflow.com/ \nClick để truy cập Website");
        }

        private void btn3_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn3, "Website https://learnlayout.com/ \nClick để truy cập Website");
        }

        private void btn4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn4, "Website https://howkteam.vn/ \nClick để truy cập Website");
        }

        private void btn5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn5, "Website https://www.codecademy.com/ \nClick để truy cập Website");
        } 

        private void btn6_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn6, "Website https://www.edx.org/ \nClick để truy cập Website");
        }

        private void btn7_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn7, "Website https://ocw.mit.edu/ \nClick để truy cập Website");
        }

        private void btn8_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn8, "Website https://www.khanacademy.org/ \nClick để truy cập Website");
        }

        private void btn9_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btn9, "Website https://thecodeplayer.com/ \nClick để truy cập Website");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://fullstack.edu.vn/");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://stackoverflow.com/");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://learnlayout.com/");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://howkteam.vn/");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://www.codecademy.com/");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://www.edx.org/");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://ocw.mit.edu/");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://www.khanacademy.org/");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn truy cập Website", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OpenURL("https://thecodeplayer.com/");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
           if(mod=="1")
            {
                QuanTri qt = new QuanTri("1");
                qt.Show();
                this.Hide();
            }    else
            {
                QuanTri qt = new QuanTri("0");
                qt.Show();
                this.Hide();
            }    
        }
    }
}
