namespace Examen
{
    partial class Reservas
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
            numericUpDownComensales = new NumericUpDown();
            labelComensales = new Label();
            comboBoxBanquete = new ComboBox();
            labelBanquete = new Label();
            comboBoxAsistentes = new ComboBox();
            labelAsistentes = new Label();
            numericJornada = new NumericUpDown();
            labelJornada = new Label();
            comboBoxCocina = new ComboBox();
            labelTipoCocina = new Label();
            labelTipoEvento = new Label();
            comboBoxEventos = new ComboBox();
            labelFechaEvento = new Label();
            labelFecha = new Label();
            dateTimePickerFecha = new DateTimePicker();
            textBoxContacto = new TextBox();
            labelContacto = new Label();
            textBoxNombres = new TextBox();
            labelNombres = new Label();
            toolTipPrincipal = new ToolTip(components);
            buttonLimpiar = new Button();
            labelDatos = new Label();
            buttonAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComensales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericJornada).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownComensales
            // 
            numericUpDownComensales.Enabled = false;
            numericUpDownComensales.Location = new Point(207, 339);
            numericUpDownComensales.Margin = new Padding(4, 3, 4, 3);
            numericUpDownComensales.Name = "numericUpDownComensales";
            numericUpDownComensales.Size = new Size(117, 23);
            numericUpDownComensales.TabIndex = 37;
            numericUpDownComensales.TextAlign = HorizontalAlignment.Center;
            toolTipPrincipal.SetToolTip(numericUpDownComensales, "Comensales");
            numericUpDownComensales.ValueChanged += this.numericUpDownComensales_ValueChanged;
            // 
            // labelComensales
            // 
            labelComensales.AutoSize = true;
            labelComensales.BorderStyle = BorderStyle.Fixed3D;
            labelComensales.Enabled = false;
            labelComensales.Location = new Point(74, 342);
            labelComensales.Margin = new Padding(4, 0, 4, 0);
            labelComensales.Name = "labelComensales";
            labelComensales.Size = new Size(125, 17);
            labelComensales.TabIndex = 36;
            labelComensales.Text = "Comensales Por Mesa";
            // 
            // comboBoxBanquete
            // 
            comboBoxBanquete.Enabled = false;
            comboBoxBanquete.FormattingEnabled = true;
            comboBoxBanquete.Items.AddRange(new object[] { "Mesa Rectangular", "Mesa Redonda" });
            comboBoxBanquete.Location = new Point(203, 289);
            comboBoxBanquete.Margin = new Padding(4, 3, 4, 3);
            comboBoxBanquete.Name = "comboBoxBanquete";
            comboBoxBanquete.Size = new Size(137, 23);
            comboBoxBanquete.TabIndex = 35;
            toolTipPrincipal.SetToolTip(comboBoxBanquete, "Tipo de Mesa");
            comboBoxBanquete.SelectedIndexChanged += this.comboBoxBanquete_SelectedIndexChanged;
            // 
            // labelBanquete
            // 
            labelBanquete.AutoSize = true;
            labelBanquete.BorderStyle = BorderStyle.Fixed3D;
            labelBanquete.Enabled = false;
            labelBanquete.Location = new Point(120, 291);
            labelBanquete.Margin = new Padding(4, 0, 4, 0);
            labelBanquete.Name = "labelBanquete";
            labelBanquete.Size = new Size(79, 17);
            labelBanquete.TabIndex = 34;
            labelBanquete.Text = "Tipo de Mesa";
            // 
            // comboBoxAsistentes
            // 
            comboBoxAsistentes.Enabled = false;
            comboBoxAsistentes.FormattingEnabled = true;
            comboBoxAsistentes.Items.AddRange(new object[] { "Si", "No" });
            comboBoxAsistentes.Location = new Point(534, 339);
            comboBoxAsistentes.Margin = new Padding(4, 3, 4, 3);
            comboBoxAsistentes.Name = "comboBoxAsistentes";
            comboBoxAsistentes.Size = new Size(121, 23);
            comboBoxAsistentes.TabIndex = 33;
            toolTipPrincipal.SetToolTip(comboBoxAsistentes, "Habitaciones");
            comboBoxAsistentes.SelectedIndexChanged += comboBoxAsistentes_SelectedIndexChanged;
            // 
            // labelAsistentes
            // 
            labelAsistentes.AutoSize = true;
            labelAsistentes.BorderStyle = BorderStyle.Fixed3D;
            labelAsistentes.Enabled = false;
            labelAsistentes.Location = new Point(382, 342);
            labelAsistentes.Margin = new Padding(4, 0, 4, 0);
            labelAsistentes.Name = "labelAsistentes";
            labelAsistentes.Size = new Size(149, 17);
            labelAsistentes.TabIndex = 32;
            labelAsistentes.Text = "Se necesitan habitaciones?";
            // 
            // numericJornada
            // 
            numericJornada.Enabled = false;
            numericJornada.Location = new Point(534, 289);
            numericJornada.Margin = new Padding(4, 3, 4, 3);
            numericJornada.Name = "numericJornada";
            numericJornada.Size = new Size(103, 23);
            numericJornada.TabIndex = 31;
            numericJornada.TextAlign = HorizontalAlignment.Center;
            toolTipPrincipal.SetToolTip(numericJornada, "Número de Jornadas");
            numericJornada.ValueChanged += numericJornada_ValueChanged;
            // 
            // labelJornada
            // 
            labelJornada.AutoSize = true;
            labelJornada.BorderStyle = BorderStyle.Fixed3D;
            labelJornada.Enabled = false;
            labelJornada.Location = new Point(412, 291);
            labelJornada.Margin = new Padding(4, 0, 4, 0);
            labelJornada.Name = "labelJornada";
            labelJornada.Size = new Size(118, 17);
            labelJornada.TabIndex = 30;
            labelJornada.Text = "Número de Jornadas";
            // 
            // comboBoxCocina
            // 
            comboBoxCocina.FormattingEnabled = true;
            comboBoxCocina.Items.AddRange(new object[] { "Bufé", "Carta", "Pedir cita con el Chef", "No se precisa" });
            comboBoxCocina.Location = new Point(337, 199);
            comboBoxCocina.Margin = new Padding(4, 3, 4, 3);
            comboBoxCocina.Name = "comboBoxCocina";
            comboBoxCocina.Size = new Size(137, 23);
            comboBoxCocina.TabIndex = 29;
            toolTipPrincipal.SetToolTip(comboBoxCocina, "Tipo de Cocina");
            comboBoxCocina.SelectedIndexChanged += this.comboBoxCocina_SelectedIndexChanged;
            // 
            // labelTipoCocina
            // 
            labelTipoCocina.AutoSize = true;
            labelTipoCocina.BorderStyle = BorderStyle.Fixed3D;
            labelTipoCocina.Location = new Point(245, 202);
            labelTipoCocina.Margin = new Padding(4, 0, 4, 0);
            labelTipoCocina.Name = "labelTipoCocina";
            labelTipoCocina.Size = new Size(88, 17);
            labelTipoCocina.TabIndex = 28;
            labelTipoCocina.Text = "Tipo de Cocina";
            // 
            // labelTipoEvento
            // 
            labelTipoEvento.AutoSize = true;
            labelTipoEvento.BorderStyle = BorderStyle.Fixed3D;
            labelTipoEvento.Location = new Point(246, 242);
            labelTipoEvento.Margin = new Padding(4, 0, 4, 0);
            labelTipoEvento.Name = "labelTipoEvento";
            labelTipoEvento.Size = new Size(87, 17);
            labelTipoEvento.TabIndex = 27;
            labelTipoEvento.Text = "Tipo de Evento";
            // 
            // comboBoxEventos
            // 
            comboBoxEventos.FormattingEnabled = true;
            comboBoxEventos.Items.AddRange(new object[] { "Banquete", "Jornada", "Congreso" });
            comboBoxEventos.Location = new Point(337, 239);
            comboBoxEventos.Margin = new Padding(4, 3, 4, 3);
            comboBoxEventos.Name = "comboBoxEventos";
            comboBoxEventos.Size = new Size(137, 23);
            comboBoxEventos.TabIndex = 26;
            toolTipPrincipal.SetToolTip(comboBoxEventos, "Tipo de Evento");
            comboBoxEventos.SelectedIndexChanged += comboBoxEventos_SelectedIndexChanged;
            // 
            // labelFechaEvento
            // 
            labelFechaEvento.AutoSize = true;
            labelFechaEvento.BorderStyle = BorderStyle.Fixed3D;
            labelFechaEvento.Location = new Point(232, 160);
            labelFechaEvento.Margin = new Padding(4, 0, 4, 0);
            labelFechaEvento.Name = "labelFechaEvento";
            labelFechaEvento.Size = new Size(101, 17);
            labelFechaEvento.TabIndex = 25;
            labelFechaEvento.Text = "Fecha del Evento:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(234, 160);
            labelFecha.Margin = new Padding(4, 0, 4, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(0, 15);
            labelFecha.TabIndex = 24;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Format = DateTimePickerFormat.Short;
            dateTimePickerFecha.Location = new Point(337, 160);
            dateTimePickerFecha.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerFecha.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dateTimePickerFecha.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(137, 23);
            dateTimePickerFecha.TabIndex = 23;
            toolTipPrincipal.SetToolTip(dateTimePickerFecha, "Fecha del Evento");
            dateTimePickerFecha.ValueChanged += dateTimePickerFecha_ValueChanged;
            // 
            // textBoxContacto
            // 
            textBoxContacto.Location = new Point(337, 127);
            textBoxContacto.Margin = new Padding(4, 3, 4, 3);
            textBoxContacto.Name = "textBoxContacto";
            textBoxContacto.Size = new Size(137, 23);
            textBoxContacto.TabIndex = 22;
            toolTipPrincipal.SetToolTip(textBoxContacto, "Numero de Contacto");
            textBoxContacto.TextChanged += this.textBoxContacto_TextChanged;
            textBoxContacto.KeyPress += textBoxContacto_KeyPress_1;
            // 
            // labelContacto
            // 
            labelContacto.AutoSize = true;
            labelContacto.BorderStyle = BorderStyle.Fixed3D;
            labelContacto.Location = new Point(208, 127);
            labelContacto.Margin = new Padding(4, 0, 4, 0);
            labelContacto.Name = "labelContacto";
            labelContacto.Size = new Size(125, 17);
            labelContacto.TabIndex = 21;
            labelContacto.Text = "Telefono de Contacto:";
            // 
            // textBoxNombres
            // 
            textBoxNombres.Location = new Point(337, 90);
            textBoxNombres.Margin = new Padding(4, 3, 4, 3);
            textBoxNombres.Name = "textBoxNombres";
            textBoxNombres.Size = new Size(137, 23);
            textBoxNombres.TabIndex = 20;
            toolTipPrincipal.SetToolTip(textBoxNombres, "Nombres y Apellidos");
            textBoxNombres.TextChanged += textBoxNombres_TextChanged;
            // 
            // labelNombres
            // 
            labelNombres.AutoSize = true;
            labelNombres.BorderStyle = BorderStyle.Fixed3D;
            labelNombres.Location = new Point(216, 93);
            labelNombres.Margin = new Padding(4, 0, 4, 0);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(117, 17);
            labelNombres.TabIndex = 19;
            labelNombres.Text = "Nombre y Apellidos:";
            // 
            // toolTipPrincipal
            // 
            toolTipPrincipal.IsBalloon = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Font = new Font("Sitka Subheading", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonLimpiar.Location = new Point(479, 122);
            buttonLimpiar.Margin = new Padding(4, 3, 4, 3);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(62, 30);
            buttonLimpiar.TabIndex = 38;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += button1_Click;
            // 
            // labelDatos
            // 
            labelDatos.AutoSize = true;
            labelDatos.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDatos.Location = new Point(298, 19);
            labelDatos.Margin = new Padding(4, 0, 4, 0);
            labelDatos.Name = "labelDatos";
            labelDatos.Size = new Size(128, 50);
            labelDatos.TabIndex = 39;
            labelDatos.Text = "Datos ";
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(592, 416);
            buttonAceptar.Margin = new Padding(4, 3, 4, 3);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(136, 60);
            buttonAceptar.TabIndex = 40;
            buttonAceptar.Text = " Reservar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += button1_Click_1;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(738, 488);
            ControlBox = false;
            Controls.Add(buttonAceptar);
            Controls.Add(labelDatos);
            Controls.Add(buttonLimpiar);
            Controls.Add(numericUpDownComensales);
            Controls.Add(labelComensales);
            Controls.Add(comboBoxBanquete);
            Controls.Add(labelBanquete);
            Controls.Add(comboBoxAsistentes);
            Controls.Add(labelAsistentes);
            Controls.Add(numericJornada);
            Controls.Add(labelJornada);
            Controls.Add(comboBoxCocina);
            Controls.Add(labelTipoCocina);
            Controls.Add(labelTipoEvento);
            Controls.Add(comboBoxEventos);
            Controls.Add(labelFechaEvento);
            Controls.Add(labelFecha);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(textBoxContacto);
            Controls.Add(labelContacto);
            Controls.Add(textBoxNombres);
            Controls.Add(labelNombres);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Reservas";
            Text = "Reserva Salón Habana";
            Load += Reservas_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownComensales).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericJornada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numericUpDownComensales;
        private Label labelComensales;
        private ComboBox comboBoxBanquete;
        private Label labelBanquete;
        private ComboBox comboBoxAsistentes;
        private Label labelAsistentes;
        private NumericUpDown numericJornada;
        private Label labelJornada;
        private ComboBox comboBoxCocina;
        private Label labelTipoCocina;
        private Label labelTipoEvento;
        private ComboBox comboBoxEventos;
        private Label labelFechaEvento;
        private Label labelFecha;
        private DateTimePicker dateTimePickerFecha;
        private TextBox textBoxContacto;
        private Label labelContacto;
        private TextBox textBoxNombres;
        private Label labelNombres;
        private ToolTip toolTipPrincipal;
        private Button buttonLimpiar;
        private Label labelDatos;
        private Button buttonAceptar;
    }
}