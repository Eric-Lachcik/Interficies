﻿namespace Calculaman
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
            components = new System.ComponentModel.Container();
            labelExer = new Label();
            Time = new Label();
            labelTimer = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBarTimer = new ProgressBar();
            plusLeft = new Label();
            plusRight = new Label();
            label1 = new Label();
            label2 = new Label();
            numericSum = new NumericUpDown();
            minusleft = new Label();
            minright = new Label();
            porleft = new Label();
            porright = new Label();
            divleft = new Label();
            divright = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            numericDiv = new NumericUpDown();
            numericPor = new NumericUpDown();
            numericMin = new NumericUpDown();
            Results = new Button();
            buttonClose = new Button();
            sumRes = new Label();
            minRes = new Label();
            porRes = new Label();
            divRes = new Label();
            ((System.ComponentModel.ISupportInitialize)numericSum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericMin).BeginInit();
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
            Time.Location = new Point(528, 19);
            Time.Name = "Time";
            Time.Size = new Size(132, 37);
            Time.TabIndex = 1;
            Time.Text = "Time Left:";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Location = new Point(693, 53);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(0, 15);
            labelTimer.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // progressBarTimer
            // 
            progressBarTimer.Location = new Point(657, 28);
            progressBarTimer.Name = "progressBarTimer";
            progressBarTimer.Size = new Size(141, 22);
            progressBarTimer.TabIndex = 3;
            progressBarTimer.Click += progressBar1_Click;
            // 
            // plusLeft
            // 
            plusLeft.AutoSize = true;
            plusLeft.BorderStyle = BorderStyle.Fixed3D;
            plusLeft.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            plusLeft.Location = new Point(205, 140);
            plusLeft.Name = "plusLeft";
            plusLeft.Size = new Size(25, 22);
            plusLeft.TabIndex = 4;
            plusLeft.Text = "¿?";
            plusLeft.Click += plusLeft_Click;
            // 
            // plusRight
            // 
            plusRight.AutoSize = true;
            plusRight.BorderStyle = BorderStyle.Fixed3D;
            plusRight.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            plusRight.Location = new Point(345, 140);
            plusRight.Name = "plusRight";
            plusRight.Size = new Size(25, 22);
            plusRight.TabIndex = 5;
            plusRight.Text = "¿?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(274, 142);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 6;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(407, 140);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 7;
            label2.Text = "=";
            // 
            // numericSum
            // 
            numericSum.Font = new Font("Segoe UI", 11.25F);
            numericSum.Location = new Point(473, 138);
            numericSum.Name = "numericSum";
            numericSum.Size = new Size(58, 27);
            numericSum.TabIndex = 8;
            // 
            // minusleft
            // 
            minusleft.AutoSize = true;
            minusleft.BorderStyle = BorderStyle.Fixed3D;
            minusleft.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            minusleft.Location = new Point(205, 184);
            minusleft.Name = "minusleft";
            minusleft.Size = new Size(25, 22);
            minusleft.TabIndex = 9;
            minusleft.Text = "¿?";
            // 
            // minright
            // 
            minright.AutoSize = true;
            minright.BorderStyle = BorderStyle.Fixed3D;
            minright.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            minright.Location = new Point(345, 184);
            minright.Name = "minright";
            minright.Size = new Size(25, 22);
            minright.TabIndex = 10;
            minright.Text = "¿?";
            minright.Click += label4_Click;
            // 
            // porleft
            // 
            porleft.AutoSize = true;
            porleft.BorderStyle = BorderStyle.Fixed3D;
            porleft.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            porleft.Location = new Point(205, 235);
            porleft.Name = "porleft";
            porleft.Size = new Size(25, 22);
            porleft.TabIndex = 11;
            porleft.Text = "¿?";
            // 
            // porright
            // 
            porright.AutoSize = true;
            porright.BorderStyle = BorderStyle.Fixed3D;
            porright.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            porright.Location = new Point(345, 235);
            porright.Name = "porright";
            porright.Size = new Size(25, 22);
            porright.TabIndex = 12;
            porright.Text = "¿?";
            // 
            // divleft
            // 
            divleft.AutoSize = true;
            divleft.BorderStyle = BorderStyle.Fixed3D;
            divleft.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            divleft.Location = new Point(205, 282);
            divleft.Name = "divleft";
            divleft.Size = new Size(25, 22);
            divleft.TabIndex = 13;
            divleft.Text = "¿?";
            // 
            // divright
            // 
            divright.AutoSize = true;
            divright.BorderStyle = BorderStyle.Fixed3D;
            divright.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            divright.Location = new Point(345, 282);
            divright.Name = "divright";
            divright.Size = new Size(25, 22);
            divright.TabIndex = 14;
            divright.Text = "¿?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label9.Location = new Point(277, 186);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 15;
            label9.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label10.Location = new Point(277, 235);
            label10.Name = "label10";
            label10.Size = new Size(18, 20);
            label10.TabIndex = 16;
            label10.Text = "x";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label11.Location = new Point(274, 284);
            label11.Name = "label11";
            label11.Size = new Size(20, 20);
            label11.TabIndex = 17;
            label11.Text = "÷";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label12.Location = new Point(407, 233);
            label12.Name = "label12";
            label12.Size = new Size(20, 20);
            label12.TabIndex = 18;
            label12.Text = "=";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(407, 282);
            label13.Name = "label13";
            label13.Size = new Size(20, 20);
            label13.TabIndex = 19;
            label13.Text = "=";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label14.Location = new Point(407, 184);
            label14.Name = "label14";
            label14.Size = new Size(20, 20);
            label14.TabIndex = 20;
            label14.Text = "=";
            // 
            // numericDiv
            // 
            numericDiv.Font = new Font("Segoe UI", 11.25F);
            numericDiv.Location = new Point(473, 282);
            numericDiv.Name = "numericDiv";
            numericDiv.Size = new Size(58, 27);
            numericDiv.TabIndex = 21;
            // 
            // numericPor
            // 
            numericPor.Font = new Font("Segoe UI", 11.25F);
            numericPor.Location = new Point(473, 235);
            numericPor.Name = "numericPor";
            numericPor.Size = new Size(58, 27);
            numericPor.TabIndex = 22;
            // 
            // numericMin
            // 
            numericMin.Font = new Font("Segoe UI", 11.25F);
            numericMin.Location = new Point(473, 184);
            numericMin.Name = "numericMin";
            numericMin.Size = new Size(58, 27);
            numericMin.TabIndex = 23;
            // 
            // Results
            // 
            Results.BackColor = Color.Gold;
            Results.FlatAppearance.BorderColor = Color.Yellow;
            Results.FlatAppearance.BorderSize = 5;
            Results.Location = new Point(675, 386);
            Results.Name = "Results";
            Results.Size = new Size(113, 52);
            Results.TabIndex = 24;
            Results.Text = "Check";
            Results.UseVisualStyleBackColor = false;
            Results.Click += Results_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Orange;
            buttonClose.Enabled = false;
            buttonClose.Location = new Point(12, 386);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(113, 52);
            buttonClose.TabIndex = 25;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Visible = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // sumRes
            // 
            sumRes.AutoSize = true;
            sumRes.BorderStyle = BorderStyle.Fixed3D;
            sumRes.Font = new Font("Segoe UI", 11.25F);
            sumRes.Location = new Point(568, 140);
            sumRes.Name = "sumRes";
            sumRes.Size = new Size(72, 22);
            sumRes.TabIndex = 26;
            sumRes.Text = "(✿◡‿◡)";
            sumRes.Visible = false;
            sumRes.Click += sumRes_Click;
            // 
            // minRes
            // 
            minRes.AutoSize = true;
            minRes.BorderStyle = BorderStyle.Fixed3D;
            minRes.Font = new Font("Segoe UI", 11.25F);
            minRes.Location = new Point(568, 186);
            minRes.Name = "minRes";
            minRes.Size = new Size(72, 22);
            minRes.TabIndex = 27;
            minRes.Text = "(✿◡‿◡)";
            minRes.Visible = false;
            minRes.Click += label4_Click_1;
            // 
            // porRes
            // 
            porRes.AutoSize = true;
            porRes.BorderStyle = BorderStyle.Fixed3D;
            porRes.Font = new Font("Segoe UI", 11.25F);
            porRes.Location = new Point(568, 237);
            porRes.Name = "porRes";
            porRes.Size = new Size(72, 22);
            porRes.TabIndex = 28;
            porRes.Text = "(✿◡‿◡)";
            porRes.Visible = false;
            // 
            // divRes
            // 
            divRes.AutoSize = true;
            divRes.BorderStyle = BorderStyle.Fixed3D;
            divRes.Font = new Font("Segoe UI", 11.25F);
            divRes.Location = new Point(568, 287);
            divRes.Name = "divRes";
            divRes.Size = new Size(72, 22);
            divRes.TabIndex = 29;
            divRes.Text = "(✿◡‿◡)";
            divRes.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(divRes);
            Controls.Add(porRes);
            Controls.Add(minRes);
            Controls.Add(sumRes);
            Controls.Add(buttonClose);
            Controls.Add(Results);
            Controls.Add(numericMin);
            Controls.Add(numericPor);
            Controls.Add(numericDiv);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(divright);
            Controls.Add(divleft);
            Controls.Add(porright);
            Controls.Add(porleft);
            Controls.Add(minright);
            Controls.Add(minusleft);
            Controls.Add(numericSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(plusRight);
            Controls.Add(plusLeft);
            Controls.Add(progressBarTimer);
            Controls.Add(labelTimer);
            Controls.Add(Time);
            Controls.Add(labelExer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Exercises";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericSum).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiv).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPor).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericMin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelExer;
        private Label Time;
        private Label labelTimer;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBarTimer;
        private Label plusLeft;
        private Label plusRight;
        private Label label1;
        private Label label2;
        private NumericUpDown numericSum;
        private Label minusleft;
        private Label minright;
        private Label porleft;
        private Label porright;
        private Label divleft;
        private Label divright;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private NumericUpDown numericDiv;
        private NumericUpDown numericPor;
        private NumericUpDown numericMin;
        private Button Results;
        private Button buttonClose;
        private Label sumRes;
        private Label minRes;
        private Label porRes;
        private Label divRes;
    }
}