using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QL_NTH
{
    public partial class Note : Form
    {
        private string mod;
        public Note(string mod)
        {
            this.mod = mod;
            InitializeComponent();
        }
        OpenFileDialog open;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = open.FileName;
                StreamReader read = new StreamReader(open.FileName);
               richShow.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dl = new SaveFileDialog();
            dl.Filter = "|*.txt";
            DialogResult rs = dl.ShowDialog();
            if (rs == DialogResult.OK)
            {
                StreamWriter wr = new StreamWriter(dl.FileName);
                wr.Write(richShow.Text);
                wr.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
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
