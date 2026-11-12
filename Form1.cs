using System;
using System.IO;

namespace LatihanProjek01
{
    public partial class Sainin : Form
    {
        public Sainin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LihatPass_CheckedChanged(object sender, EventArgs e)
        {
            if (LihatPass.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Mohon isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hasil = KerjaDatabase.Login(username, password);
            if (hasil == "YaAdmin")
            {
                MenuAdmin ituAdmin = new();
                ituAdmin.Show();
            }
            else if (hasil == "Gagal")
            {
                MessageBox.Show("Login gagal! Username atau Password tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (hasil == "YaKasir")
            {

            }
            else if (hasil == "YaGudang")
            {

            }
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Password.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignIn.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sainin_Load(object sender, EventArgs e)
        {

        }

        private void Sainin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}