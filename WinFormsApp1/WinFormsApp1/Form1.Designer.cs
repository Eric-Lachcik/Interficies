namespace WinFormsApp1
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            Selector = new ComboBox();
            label1 = new Label();
            nombrecito = new TextBox();
            apellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AdminList = new ListBox();
            UserList = new ListBox();
            TotalAdmins = new MaskedTextBox();
            TotalUser = new MaskedTextBox();
            Adminers = new Label();
            Users = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(240, 0, 0);
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.Location = new Point(619, 449);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 0;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Location = new Point(465, 81);
            button2.Name = "button2";
            button2.Size = new Size(114, 50);
            button2.TabIndex = 1;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Selector
            // 
            Selector.FormattingEnabled = true;
            Selector.Items.AddRange(new object[] { "Administrator", "User" });
            Selector.Location = new Point(128, 55);
            Selector.Name = "Selector";
            Selector.Size = new Size(100, 23);
            Selector.TabIndex = 2;
            Selector.SelectedIndexChanged += Type_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 37);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Choose type:";
            label1.Click += label1_Click;
            // 
            // nombrecito
            // 
            nombrecito.Location = new Point(128, 108);
            nombrecito.Name = "nombrecito";
            nombrecito.Size = new Size(100, 23);
            nombrecito.TabIndex = 4;
            nombrecito.TextChanged += textBox1_TextChanged_1;
            // 
            // apellido
            // 
            apellido.Location = new Point(128, 152);
            apellido.Name = "apellido";
            apellido.Size = new Size(100, 23);
            apellido.TabIndex = 5;
            apellido.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 90);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 134);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 7;
            label3.Text = "Surname";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 196);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "Admin List";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 196);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 11;
            label5.Text = "User List";
            // 
            // AdminList
            // 
            AdminList.FormattingEnabled = true;
            AdminList.ItemHeight = 15;
            AdminList.Location = new Point(96, 214);
            AdminList.Name = "AdminList";
            AdminList.Size = new Size(223, 154);
            AdminList.TabIndex = 12;
            AdminList.SelectedIndexChanged += AdminList_SelectedIndexChanged;
            // 
            // UserList
            // 
            UserList.FormattingEnabled = true;
            UserList.ItemHeight = 15;
            UserList.Location = new Point(400, 214);
            UserList.Name = "UserList";
            UserList.Size = new Size(223, 154);
            UserList.TabIndex = 13;
            UserList.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // TotalAdmins
            // 
            TotalAdmins.BorderStyle = BorderStyle.None;
            TotalAdmins.Location = new Point(137, 373);
            TotalAdmins.Name = "TotalAdmins";
            TotalAdmins.Size = new Size(55, 16);
            TotalAdmins.TabIndex = 14;
            TotalAdmins.TextAlign = HorizontalAlignment.Center;
            TotalAdmins.MaskInputRejected += TotalAdmins_MaskInputRejected;
            // 
            // TotalUser
            // 
            TotalUser.BorderStyle = BorderStyle.None;
            TotalUser.Location = new Point(441, 374);
            TotalUser.Name = "TotalUser";
            TotalUser.Size = new Size(55, 16);
            TotalUser.TabIndex = 15;
            TotalUser.TextAlign = HorizontalAlignment.Center;
            TotalUser.MaskInputRejected += TotalUser_MaskInputRejected;
            // 
            // Adminers
            // 
            Adminers.AutoSize = true;
            Adminers.Location = new Point(96, 374);
            Adminers.Name = "Adminers";
            Adminers.Size = new Size(35, 15);
            Adminers.TabIndex = 16;
            Adminers.Text = "Total:";
            // 
            // Users
            // 
            Users.AutoSize = true;
            Users.Location = new Point(400, 375);
            Users.Name = "Users";
            Users.Size = new Size(35, 15);
            Users.TabIndex = 17;
            Users.Text = "Total:";
            Users.Click += label7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(548, 371);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Clear Users";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(233, 370);
            button4.Name = "button4";
            button4.Size = new Size(86, 23);
            button4.TabIndex = 19;
            button4.Text = "Clear Admin";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(706, 495);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Users);
            Controls.Add(Adminers);
            Controls.Add(TotalUser);
            Controls.Add(TotalAdmins);
            Controls.Add(UserList);
            Controls.Add(AdminList);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(apellido);
            Controls.Add(nombrecito);
            Controls.Add(label1);
            Controls.Add(Selector);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "List & Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox Selector;
        private Label label1;
        private TextBox nombrecito;
        private TextBox apellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox AdminList;
        private ListBox UserList;
        private MaskedTextBox TotalAdmins;
        private MaskedTextBox TotalUser;
        private Label Adminers;
        private Label Users;
        private Button button3;
        private Button button4;
    }
}
