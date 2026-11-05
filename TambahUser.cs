using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LatihanProjek01
{
    public partial class TambahUser : Form
    {
        public TambahUser()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string hasil=KerjaDatabase.TambahUser(Usernametambah.Text, PWtambah.Text, PemilihanRoleTambah.Text, out string idbaru);
            if (hasil=="User berhasil ditambahkan!")
            {
                MessageBox.Show($"{hasil}\nID user: {idbaru}");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(hasil);
            }
        }
    }
}
