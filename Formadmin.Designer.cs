namespace LatihanProjek01
{
    partial class Formmenuadmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            textBox2 = new TextBox();
            btnmanajemenuser = new Button();
            btnbuatlaporanpenjualan = new Button();
            btnmasukmenugudang = new Button();
            btnmasukmenukasir = new Button();
            btnkeluarpaneladmin = new Button();
            panel2 = new Panel();
            label1 = new Label();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 624);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(52, 50);
            label2.Name = "label2";
            label2.Size = new Size(160, 37);
            label2.TabIndex = 8;
            label2.Text = "SMK MART";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 128);
            panel3.Location = new Point(312, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 62);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 255, 128);
            textBox2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(275, 115);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(260, 35);
            textBox2.TabIndex = 1;
            textBox2.Text = "Silahkan pilih tugas:";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btnmanajemenuser
            // 
            btnmanajemenuser.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmanajemenuser.Location = new Point(488, 191);
            btnmanajemenuser.Margin = new Padding(2);
            btnmanajemenuser.Name = "btnmanajemenuser";
            btnmanajemenuser.Size = new Size(210, 46);
            btnmanajemenuser.TabIndex = 2;
            btnmanajemenuser.Text = "Manajemen User";
            btnmanajemenuser.UseVisualStyleBackColor = true;
            btnmanajemenuser.Click += button1_Click;
            // 
            // btnbuatlaporanpenjualan
            // 
            btnbuatlaporanpenjualan.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnbuatlaporanpenjualan.Location = new Point(89, 191);
            btnbuatlaporanpenjualan.Margin = new Padding(2);
            btnbuatlaporanpenjualan.Name = "btnbuatlaporanpenjualan";
            btnbuatlaporanpenjualan.Size = new Size(210, 46);
            btnbuatlaporanpenjualan.TabIndex = 3;
            btnbuatlaporanpenjualan.Text = "Buat Laporan Penjualan";
            btnbuatlaporanpenjualan.UseVisualStyleBackColor = true;
            btnbuatlaporanpenjualan.Click += button2_Click;
            // 
            // btnmasukmenugudang
            // 
            btnmasukmenugudang.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmasukmenugudang.Location = new Point(89, 308);
            btnmasukmenugudang.Margin = new Padding(2);
            btnmasukmenugudang.Name = "btnmasukmenugudang";
            btnmasukmenugudang.Size = new Size(210, 46);
            btnmasukmenugudang.TabIndex = 4;
            btnmasukmenugudang.Text = "Masuk Menu Gudang";
            btnmasukmenugudang.UseVisualStyleBackColor = true;
            btnmasukmenugudang.Click += button3_Click;
            // 
            // btnmasukmenukasir
            // 
            btnmasukmenukasir.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmasukmenukasir.Location = new Point(488, 308);
            btnmasukmenukasir.Margin = new Padding(2);
            btnmasukmenukasir.Name = "btnmasukmenukasir";
            btnmasukmenukasir.Size = new Size(210, 46);
            btnmasukmenukasir.TabIndex = 5;
            btnmasukmenukasir.Text = "Masuk Menu Kasir";
            btnmasukmenukasir.UseVisualStyleBackColor = true;
            // 
            // btnkeluarpaneladmin
            // 
            btnkeluarpaneladmin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnkeluarpaneladmin.ForeColor = Color.Red;
            btnkeluarpaneladmin.Location = new Point(605, 488);
            btnkeluarpaneladmin.Margin = new Padding(2);
            btnkeluarpaneladmin.Name = "btnkeluarpaneladmin";
            btnkeluarpaneladmin.Size = new Size(160, 28);
            btnkeluarpaneladmin.TabIndex = 6;
            btnkeluarpaneladmin.Text = "Keluar";
            btnkeluarpaneladmin.UseVisualStyleBackColor = true;
            btnkeluarpaneladmin.Click += btnkeluarpaneladmin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(btnmanajemenuser);
            panel2.Controls.Add(btnmasukmenukasir);
            panel2.Controls.Add(btnmasukmenugudang);
            panel2.Controls.Add(btnbuatlaporanpenjualan);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(283, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 484);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(0, 192, 0);
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-117, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(944, 87);
            label1.TabIndex = 7;
            label1.Text = "Selamat Datang Petugas Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Formmenuadmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1045, 624);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnkeluarpaneladmin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Formmenuadmin";
            Text = "Form1";
            FormClosed += Formmenuadmin_FormClosed;
            Load += Formmenuadmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private Button btnmanajemenuser;
        private Button btnbuatlaporanpenjualan;
        private Button btnmasukmenugudang;
        private Button btnmasukmenukasir;
        private Button btnkeluarpaneladmin;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ImageList imageList1;
        private Label label2;
    }
}
