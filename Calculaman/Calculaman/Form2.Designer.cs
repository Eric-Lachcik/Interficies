namespace Calculaman
{
    partial class Form2
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
            labelExer = new Label();
            Time = new Label();
            SuspendLayout();
            // 
            // labelExer
            // 
            labelExer.AutoSize = true;
            labelExer.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelExer.Location = new Point(268, 9);
            labelExer.Name = "labelExer";
            labelExer.Size = new Size(263, 50);
            labelExer.TabIndex = 0;
            labelExer.Text = "Math Exercises";
            labelExer.Click += labelExer_Click;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.ForeColor = SystemColors.ControlDark;
            Time.Location = new Point(537, 19);
            Time.Name = "Time";
            Time.Size = new Size(132, 37);
            Time.TabIndex = 1;
            Time.Text = "Time Left:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Time);
            Controls.Add(labelExer);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Exercises";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelExer;
        private Label Time;
    }
}