using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LatihanProjek01
{
    public partial class Formmanajemenuser : Form
    {
        bool kembali = false;
        public Formmanajemenuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kembali=true;
            this.Close();
        }

        private void Formmanajemenuser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (kembali)
            {
                Formmenuadmin menu = new();
                menu.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
