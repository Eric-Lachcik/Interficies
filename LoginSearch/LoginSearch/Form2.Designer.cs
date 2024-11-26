namespace LoginSearch
{
    partial class Search
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
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            textBuscar = new TextBox();
            Buscar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.cideOF_removebg_preview;
            pictureBox1.Location = new Point(242, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(193, 207);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBuscar
            // 
            textBuscar.Location = new Point(193, 159);
            textBuscar.Name = "textBuscar";
            textBuscar.PlaceholderText = "Buscador d'alumnes per Llinatge";
            textBuscar.Size = new Size(284, 23);
            textBuscar.TabIndex = 2;
            textBuscar.TextChanged += textBuscar_TextChanged;
            // 
            // Buscar
            // 
            Buscar.BackColor = Color.ForestGreen;
            Buscar.ForeColor = SystemColors.ButtonHighlight;
            Buscar.Location = new Point(544, 153);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(92, 41);
            Buscar.TabIndex = 3;
            Buscar.Text = "Cerca";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += button1_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Plum;
            buttonClear.Location = new Point(498, 159);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(27, 28);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "X";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(Buscar);
            Controls.Add(textBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Search";
            StartPosition = FormStartPosition.CenterParent;
            Text = "www.cide.es";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox textBuscar;
        private Button Buscar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonClear;
    }
}