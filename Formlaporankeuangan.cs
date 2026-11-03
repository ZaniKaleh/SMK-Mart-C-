using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LatihanProjek01
{
    public partial class Formlaporankeuangan : Form
    {
        bool kembali = false;
        public Formlaporankeuangan()
        {
            InitializeComponent();
        }

        private void Formlaporankeuangan_FormClosed(object sender, FormClosedEventArgs e)
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

        private void Formlaporankeuangan_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            kembali = true;
            this.Close();
        }
    }
}