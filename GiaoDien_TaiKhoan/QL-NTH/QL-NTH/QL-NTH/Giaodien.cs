using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
namespace QL_NTH
{
    public partial class Giaodien : Form
    {      
        public Giaodien()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void OpenURL(string url)
        {
            string key = @"htmlfile\shell\open\command";
            RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(key, false);
            //Get the default browser path on the system
            string Default_Browser_Path = ((string)registryKey.GetValue(null, null)).Split('"')[1];

            Process p = new Process();
            p.StartInfo.FileName = Default_Browser_Path;
            p.StartInfo.Arguments = url;
            p.Start();
        }
            private void btnDN_Click(object sender, EventArgs e)
        {
           Dangnhap dn = new Dangnhap();
            dn.Show();
            this.Hide();
        }

        private void Giaodien_Load(object sender, EventArgs e)
        {
            
        }


        private void btnDK_Click(object sender, EventArgs e)
        {
            DangKi dk = new DangKi();
            dk.Show();
            this.Hide();
        }

        private void btnLh_Click(object sender, EventArgs e)
        {
          
            
             this.Hide();
            Lienhe lh = new Lienhe();
            lh.Show();
             
           
        }

        private void Giaodien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

