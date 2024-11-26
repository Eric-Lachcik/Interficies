namespace LoginSearch
{
    partial class Form3
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            textBoxLinatge = new TextBox();
            labelLina = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 128);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cideOF_removebg_preview;
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 110);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 154);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 2;
            label1.Text = "DNI:";
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(12, 172);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(161, 23);
            textBoxDNI.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(11, 224);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(161, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(12, 334);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(161, 23);
            textBoxEdad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 206);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 6;
            label2.Text = "Nom:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 316);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Edat:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(346, 437);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 47);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guarda";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // textBoxLinatge
            // 
            textBoxLinatge.Location = new Point(11, 276);
            textBoxLinatge.Name = "textBoxLinatge";
            textBoxLinatge.Size = new Size(161, 23);
            textBoxLinatge.TabIndex = 9;
            // 
            // labelLina
            // 
            labelLina.AutoSize = true;
            labelLina.Location = new Point(10, 258);
            labelLina.Name = "labelLina";
            labelLina.Size = new Size(52, 15);
            labelLina.TabIndex = 10;
            labelLina.Text = "Llinatge:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(198, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 145);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 154);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 12;
            label4.Text = "Notes Académiques";
            label4.Click += label4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(450, 496);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(labelLina);
            Controls.Add(textBoxLinatge);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDNI);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private TextBox textBoxLinatge;
        private Label labelLina;
        private DataGridView dataGridView1;
        private Label label4;
    }
}