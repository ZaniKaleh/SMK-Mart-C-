namespace LatihanProjek01
{
    partial class Sainin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sainin));
            Username = new TextBox();
            panel1 = new Panel();
            Tekswelcome = new Label();
            TitleSignIn = new Label();
            Password = new TextBox();
            SignIn = new Button();
            LihatPass = new CheckBox();
            GkValid = new Label();
            PemilihanRole = new ComboBox();
            TeksPilihRole = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.FixedSingle;
            Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.Location = new Point(427, 231);
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(288, 35);
            Username.TabIndex = 0;
            Username.TextChanged += Username_TextChanged;
            Username.KeyDown += Username_KeyDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(Tekswelcome);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 628);
            panel1.TabIndex = 1;
            // 
            // Tekswelcome
            // 
            Tekswelcome.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tekswelcome.ForeColor = Color.Wheat;
            Tekswelcome.ImageAlign = ContentAlignment.MiddleLeft;
            Tekswelcome.Location = new Point(3, 116);
            Tekswelcome.Name = "Tekswelcome";
            Tekswelcome.Size = new Size(292, 76);
            Tekswelcome.TabIndex = 2;
            Tekswelcome.Text = "SELAMAT DATANG DI SMK MART";
            Tekswelcome.Click += label1_Click;
            // 
            // TitleSignIn
            // 
            TitleSignIn.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleSignIn.ForeColor = Color.DarkSlateGray;
            TitleSignIn.ImageAlign = ContentAlignment.MiddleLeft;
            TitleSignIn.Location = new Point(345, 69);
            TitleSignIn.Name = "TitleSignIn";
            TitleSignIn.Size = new Size(145, 50);
            TitleSignIn.TabIndex = 3;
            TitleSignIn.Text = "Sign In";
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.FixedSingle;
            Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(427, 286);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(288, 35);
            Password.TabIndex = 4;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += Password_TextChanged;
            Password.KeyDown += Password_KeyDown;
            // 
            // SignIn
            // 
            SignIn.BackColor = Color.GreenYellow;
            SignIn.BackgroundImageLayout = ImageLayout.None;
            SignIn.FlatStyle = FlatStyle.Popup;
            SignIn.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignIn.Location = new Point(530, 400);
            SignIn.Name = "SignIn";
            SignIn.Size = new Size(75, 30);
            SignIn.TabIndex = 5;
            SignIn.Text = "SIGN IN";
            SignIn.UseVisualStyleBackColor = false;
            SignIn.Click += button1_Click;
            // 
            // LihatPass
            // 
            LihatPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LihatPass.Location = new Point(721, 286);
            LihatPass.Name = "LihatPass";
            LihatPass.Size = new Size(123, 35);
            LihatPass.TabIndex = 6;
            LihatPass.Text = "Lihat Password";
            LihatPass.UseVisualStyleBackColor = true;
            LihatPass.CheckedChanged += LihatPass_CheckedChanged;
            // 
            // GkValid
            // 
            GkValid.AutoSize = true;
            GkValid.ForeColor = Color.Red;
            GkValid.Location = new Point(427, 324);
            GkValid.Name = "GkValid";
            GkValid.Size = new Size(260, 15);
            GkValid.TabIndex = 7;
            GkValid.Text = "Username, Password, atau Role anda tidak valid!";
            GkValid.Visible = false;
            // 
            // PemilihanRole
            // 
            PemilihanRole.DropDownStyle = ComboBoxStyle.DropDownList;
            PemilihanRole.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PemilihanRole.FormattingEnabled = true;
            PemilihanRole.Items.AddRange(new object[] { "Pengelola Gudang", "Kasir", "Admin" });
            PemilihanRole.Location = new Point(427, 166);
            PemilihanRole.Name = "PemilihanRole";
            PemilihanRole.Size = new Size(288, 31);
            PemilihanRole.TabIndex = 8;
            // 
            // TeksPilihRole
            // 
            TeksPilihRole.AutoSize = true;
            TeksPilihRole.Location = new Point(427, 148);
            TeksPilihRole.Name = "TeksPilihRole";
            TeksPilihRole.Size = new Size(90, 15);
            TeksPilihRole.TabIndex = 9;
            TeksPilihRole.Text = "Pilih Role Anda!";
            // 
            // Sainin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1045, 624);
            Controls.Add(TeksPilihRole);
            Controls.Add(PemilihanRole);
            Controls.Add(GkValid);
            Controls.Add(LihatPass);
            Controls.Add(SignIn);
            Controls.Add(Password);
            Controls.Add(TitleSignIn);
            Controls.Add(panel1);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Sainin";
            Text = "Sign In";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username;
        private Panel panel1;
        private Label Tekswelcome;
        private Label TitleSignIn;
        private TextBox Password;
        private Button SignIn;
        private CheckBox LihatPass;
        private Label GkValid;
        private ComboBox PemilihanRole;
        private Label TeksPilihRole;
    }
}
