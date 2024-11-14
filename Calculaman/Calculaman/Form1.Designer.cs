namespace Calculaman
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
            label1 = new Label();
            labelintro = new Label();
            labelEx = new Label();
            labelex1 = new Label();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 18);
            label1.Name = "label1";
            label1.Size = new Size(193, 50);
            label1.TabIndex = 0;
            label1.Text = "Math Quiz";
            // 
            // labelintro
            // 
            labelintro.AutoSize = true;
            labelintro.Location = new Point(117, 83);
            labelintro.Name = "labelintro";
            labelintro.Size = new Size(222, 15);
            labelintro.TabIndex = 2;
            labelintro.Text = "Press \"Start\" to begin with the Math Quiz";
            labelintro.Click += label2_Click;
            // 
            // labelEx
            // 
            labelEx.AutoSize = true;
            labelEx.Location = new Point(173, 118);
            labelEx.Name = "labelEx";
            labelEx.Size = new Size(138, 15);
            labelEx.TabIndex = 3;
            labelEx.Text = "- 4 Exercises to complete";
            // 
            // labelex1
            // 
            labelex1.AutoSize = true;
            labelex1.Location = new Point(173, 148);
            labelex1.Name = "labelex1";
            labelex1.Size = new Size(86, 15);
            labelex1.TabIndex = 4;
            labelex1.Text = "- In 30 seconds";
            labelex1.Click += labelex1_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(182, 191);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(100, 52);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(462, 323);
            Controls.Add(buttonStart);
            Controls.Add(labelex1);
            Controls.Add(labelEx);
            Controls.Add(labelintro);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculaMan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelintro;
        private Label labelEx;
        private Label labelex1;
        private Button buttonStart;
    }
}
