namespace LatihanProjek01
{
    public partial class Formmenuadmin : Form
    {
        bool keluar = false;
        public Formmenuadmin()
        {
            InitializeComponent();
        }

        private void Formmenuadmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlaporankeuangan formlaporankeuangan = new Formlaporankeuangan();
            formlaporankeuangan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formmanajemenuser formmanajemenuser = new Formmanajemenuser();
            formmanajemenuser.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkeluarpaneladmin_Click(object sender, EventArgs e)
        {
            keluar = true;
            this.Close();
        }

        private void Formmenuadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (keluar == true)
            {
                Sainin menu = new();
                menu.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
