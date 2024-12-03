using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
namespace QL_NTH
{
    public partial class Lienhe : Form

    {
        private QuanTri mainform;
        private string mod;
        public Lienhe()
        {
           
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.facebook.com/linhphan.03ok");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.facebook.com/linhphan.03ok");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.facebook.com/linhphan.03ok");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.facebook.com/linhphan.03ok");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenURL("https://www.facebook.com/linhphan.03ok");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Giaodien gd = new Giaodien();
            this.Hide();
            gd.Show();
        }

		private void Lienhe_Load(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
	}
}
