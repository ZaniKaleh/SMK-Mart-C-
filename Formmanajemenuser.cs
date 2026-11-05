using System;
using System.IO;
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
        private void TampilkanUser()
        {
            List<string[]> users = KerjaDatabase.SpilUser();
            dataGridView1.Rows.Clear();
            foreach (string[] user in users)
            {
                dataGridView1.Rows.Add(user[0], user[1], user[2], user[3], user.Length >= 5 ? user[4] : "1");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kembali = true;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Formmanajemenuser_Load(object sender, EventArgs e)
        {
            TampilkanUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TampilkanUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih user yang ingin dihapus!");
                return;
            }
            string? id = dataGridView1.SelectedRows[0].Cells["colIDuser"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("ID User tidak valid!");
                return;
            }
            DialogResult pilihan = MessageBox.Show($"Yakin ingin menghapus user {id}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (pilihan == DialogResult.Yes)
            {
                if (KerjaDatabase.HapusUser(id))
                {
                    MessageBox.Show("User Berhasil dihapus!");
                }
                else
                {
                    MessageBox.Show("User gagal ditemukan!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TambahUser siguma = new TambahUser();
            siguma.Show();
        }
    }
}
