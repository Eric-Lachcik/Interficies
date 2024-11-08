namespace Examen
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
            buttonReservar = new Button();
            labelSalon = new Label();
            labelReserva = new Label();
            buttonSalir = new Button();
            SuspendLayout();
            // 
            // buttonReservar
            // 
            buttonReservar.Location = new Point(227, 211);
            buttonReservar.Name = "buttonReservar";
            buttonReservar.Size = new Size(105, 46);
            buttonReservar.TabIndex = 21;
            buttonReservar.Text = "Reservar";
            buttonReservar.UseVisualStyleBackColor = true;
            buttonReservar.Click += buttonReservar_Click;
            // 
            // labelSalon
            // 
            labelSalon.AutoSize = true;
            labelSalon.Location = new Point(241, 193);
            labelSalon.Name = "labelSalon";
            labelSalon.Size = new Size(80, 15);
            labelSalon.TabIndex = 20;
            labelSalon.Text = "Salón Habana";
            // 
            // labelReserva
            // 
            labelReserva.AutoSize = true;
            labelReserva.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelReserva.Location = new Point(199, 62);
            labelReserva.MinimumSize = new Size(175, 75);
            labelReserva.Name = "labelReserva";
            labelReserva.Size = new Size(175, 75);
            labelReserva.TabIndex = 19;
            labelReserva.Text = "Reservas";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(438, 393);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(102, 54);
            buttonSalir.TabIndex = 22;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(562, 466);
            ControlBox = false;
            Controls.Add(buttonSalir);
            Controls.Add(buttonReservar);
            Controls.Add(labelSalon);
            Controls.Add(labelReserva);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Reservas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonReservar;
        private Label labelSalon;
        private Label labelReserva;
        private Button buttonSalir;
    }
}
