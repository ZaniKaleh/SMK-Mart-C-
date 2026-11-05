namespace LatihanProjek01
{
    partial class TambahUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahUser));
            Usernametambah = new TextBox();
            PemilihanRoleTambah = new ComboBox();
            PWtambah = new TextBox();
            panel1 = new Panel();
            Tekswelcome = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TeksPilihRole = new Label();
            SignIn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Usernametambah
            // 
            Usernametambah.BackColor = Color.WhiteSmoke;
            Usernametambah.BorderStyle = BorderStyle.FixedSingle;
            Usernametambah.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernametambah.Location = new Point(267, 292);
            Usernametambah.Name = "Usernametambah";
            Usernametambah.PlaceholderText = "Username";
            Usernametambah.Size = new Size(288, 31);
            Usernametambah.TabIndex = 0;
            // 
            // PemilihanRoleTambah
            // 
            PemilihanRoleTambah.BackColor = Color.Ivory;
            PemilihanRoleTambah.DropDownStyle = ComboBoxStyle.DropDownList;
            PemilihanRoleTambah.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PemilihanRoleTambah.FormattingEnabled = true;
            PemilihanRoleTambah.Items.AddRange(new object[] { "Pengelola Gudang", "Kasir", "Admin" });
            PemilihanRoleTambah.Location = new Point(267, 223);
            PemilihanRoleTambah.Name = "PemilihanRoleTambah";
            PemilihanRoleTambah.Size = new Size(288, 31);
            PemilihanRoleTambah.TabIndex = 9;
            // 
            // PWtambah
            // 
            PWtambah.BackColor = Color.WhiteSmoke;
            PWtambah.BorderStyle = BorderStyle.FixedSingle;
            PWtambah.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PWtambah.Location = new Point(267, 349);
            PWtambah.Name = "PWtambah";
            PWtambah.PlaceholderText = "Password";
            PWtambah.Size = new Size(288, 31);
            PWtambah.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(Tekswelcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-9, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 631);
            panel1.TabIndex = 11;
            // 
            // Tekswelcome
            // 
            Tekswelcome.BackColor = Color.Transparent;
            Tekswelcome.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tekswelcome.ForeColor = Color.MidnightBlue;
            Tekswelcome.ImageAlign = ContentAlignment.MiddleLeft;
            Tekswelcome.Location = new Point(3, 49);
            Tekswelcome.Name = "Tekswelcome";
            Tekswelcome.Size = new Size(239, 113);
            Tekswelcome.TabIndex = 3;
            Tekswelcome.Text = "TAMBAH AKUN BARU";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 628);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 139);
            label1.Name = "label1";
            label1.Size = new Size(352, 19);
            label1.TabIndex = 12;
            label1.Text = "Masukkan informasi akun yang akan ditambahkan.";
            // 
            // TeksPilihRole
            // 
            TeksPilihRole.AutoSize = true;
            TeksPilihRole.BackColor = Color.Ivory;
            TeksPilihRole.Location = new Point(267, 205);
            TeksPilihRole.Name = "TeksPilihRole";
            TeksPilihRole.Size = new Size(90, 15);
            TeksPilihRole.TabIndex = 13;
            TeksPilihRole.Text = "Pilih Role Anda!";
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.GreenYellow;
            SignIn.BackgroundImageLayout = ImageLayout.None;
            SignIn.FlatStyle = FlatStyle.Popup;
            SignIn.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn.Location = new Point(363, 431);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(96, 30);
            SignIn.TabIndex = 14;
            SignIn.Text = "Tambahkan";
            SignIn.UseVisualStyleBackColor = false;
            SignIn.Click += SignIn_Click;
            // 
            // TambahUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1045, 624);
            Controls.Add(SignIn);
            Controls.Add(TeksPilihRole);
            Controls.Add(label1);
            Controls.Add(PWtambah);
            Controls.Add(PemilihanRoleTambah);
            Controls.Add(Usernametambah);
            Controls.Add(panel1);
            Name = "TambahUser";
            Text = "TambahUser";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usernametambah;
        private ComboBox PemilihanRoleTambah;
        private TextBox PWtambah;
        private Panel panel1;
        private Label label1;
        private Label TeksPilihRole;
        private Label Tekswelcome;
        private PictureBox pictureBox1;
        private Button SignIn;
    }
}