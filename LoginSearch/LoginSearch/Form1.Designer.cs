namespace LoginSearch
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            username = new Label();
            usernameText = new TextBox();
            password = new Label();
            passwordText = new TextBox();
            buttonLogin = new Button();
            subHeader = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(142, 230);
            username.Name = "username";
            username.Size = new Size(43, 15);
            username.TabIndex = 0;
            username.Text = "Usuari:";
            username.Click += username_Click;
            // 
            // usernameText
            // 
            usernameText.Location = new Point(191, 227);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(100, 23);
            usernameText.TabIndex = 1;
            usernameText.TextChanged += usernameText_TextChanged;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(109, 285);
            password.Name = "password";
            password.Size = new Size(76, 15);
            password.TabIndex = 2;
            password.Text = "Contrasenya:";
            // 
            // passwordText
            // 
            passwordText.Location = new Point(191, 282);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(100, 23);
            passwordText.TabIndex = 3;
            passwordText.TextChanged += passwordText_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(349, 386);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(76, 34);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Accedir";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // subHeader
            // 
            subHeader.AutoSize = true;
            subHeader.Location = new Point(137, 135);
            subHeader.Name = "subHeader";
            subHeader.Size = new Size(154, 15);
            subHeader.TabIndex = 6;
            subHeader.Text = "Students Management Web";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 120);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 164);
            label1.Name = "label1";
            label1.Size = new Size(202, 47);
            label1.TabIndex = 8;
            label1.Text = "Iniciar Sesió";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 432);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(subHeader);
            Controls.Add(buttonLogin);
            Controls.Add(passwordText);
            Controls.Add(password);
            Controls.Add(usernameText);
            Controls.Add(username);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "www.cide/login.es";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private TextBox usernameText;
        private Label password;
        private TextBox passwordText;
        private Button buttonLogin;
        private Label subHeader;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
