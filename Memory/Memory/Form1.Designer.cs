namespace Memory
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
            labelTitulo = new Label();
            buttonStart = new Button();
            labelSubtitulo = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Sitka Text", 26.2499962F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(73, 57);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(163, 50);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Memory";
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(97, 194);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(106, 55);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelSubtitulo
            // 
            labelSubtitulo.AutoSize = true;
            labelSubtitulo.Font = new Font("Sitka Text", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelSubtitulo.Location = new Point(118, 107);
            labelSubtitulo.Name = "labelSubtitulo";
            labelSubtitulo.Size = new Size(66, 18);
            labelSubtitulo.TabIndex = 2;
            labelSubtitulo.Text = "Card Game";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(301, 333);
            Controls.Add(labelSubtitulo);
            Controls.Add(buttonStart);
            Controls.Add(labelTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Button buttonStart;
        private Label labelSubtitulo;
    }
}
