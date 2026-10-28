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
            string role = PemilihanRole.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Mohon isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool hasil = KerjaDatabase.Login(username, password, role);
            if (hasil)
            {
                if (role == "Admin")
                {
                    MessageBox.Show("Login berhasil!\n\nSelamat Datang, Admin!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuAdmin Menunya = new();
                    Menunya.Show();
                }
                else if (role == "Kasir")
                {
                    MessageBox.Show("Login berhasil!\n\nSelamat Datang, Kasir!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (role == "Pengelola Gudang")
                {
                    MessageBox.Show("Login berhasil!\n\nSelamat Datang, Pengelola Gudang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
            else
            {
                GkValid.Visible = true;
            }
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
    }
}