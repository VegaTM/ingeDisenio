namespace Ing.Disenio
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            btnConsultar = new Button();
            btnAgregar = new Button();
            btnVolver = new Button();
            registroCita = new Panel();
            boxDay = new DateTimePicker();
            btnEnviarRegistro = new Button();
            label5 = new Label();
            boxID = new ComboBox();
            label1 = new Label();
            panelCitas = new DataGridView();
            panel1 = new Panel();
            registroCita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCitas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(12, 22);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(206, 50);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar Agenda";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 78);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(206, 50);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar cita";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(12, 134);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(206, 50);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // registroCita
            // 
            registroCita.BackColor = Color.Lavender;
            registroCita.BackgroundImage = (Image)resources.GetObject("registroCita.BackgroundImage");
            registroCita.BackgroundImageLayout = ImageLayout.Center;
            registroCita.Controls.Add(boxDay);
            registroCita.Controls.Add(btnEnviarRegistro);
            registroCita.Controls.Add(label5);
            registroCita.Controls.Add(boxID);
            registroCita.Controls.Add(label1);
            registroCita.Location = new Point(42, 20);
            registroCita.Name = "registroCita";
            registroCita.Size = new Size(391, 249);
            registroCita.TabIndex = 4;
            // 
            // boxDay
            // 
            boxDay.Location = new Point(28, 48);
            boxDay.Name = "boxDay";
            boxDay.Size = new Size(327, 27);
            boxDay.TabIndex = 11;
            // 
            // btnEnviarRegistro
            // 
            btnEnviarRegistro.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            btnEnviarRegistro.Location = new Point(28, 182);
            btnEnviarRegistro.Name = "btnEnviarRegistro";
            btnEnviarRegistro.Size = new Size(94, 29);
            btnEnviarRegistro.TabIndex = 10;
            btnEnviarRegistro.Text = "Registrar";
            btnEnviarRegistro.UseVisualStyleBackColor = true;
            btnEnviarRegistro.Click += btnEnviarRegistro_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            label5.Location = new Point(28, 104);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 5;
            label5.Text = "Nombre del Cliente";
            // 
            // boxID
            // 
            boxID.FormattingEnabled = true;
            boxID.Location = new Point(28, 127);
            boxID.Name = "boxID";
            boxID.Size = new Size(327, 28);
            boxID.TabIndex = 2;
            boxID.SelectedIndexChanged += boxID_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // panelCitas
            // 
            panelCitas.BackgroundColor = Color.AliceBlue;
            panelCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panelCitas.Location = new Point(3, 0);
            panelCitas.Name = "panelCitas";
            panelCitas.RowHeadersWidth = 51;
            panelCitas.Size = new Size(567, 449);
            panelCitas.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(registroCita);
            panel1.Controls.Add(panelCitas);
            panel1.Location = new Point(231, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 449);
            panel1.TabIndex = 6;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregar);
            Controls.Add(btnConsultar);
            Name = "Agenda";
            Text = "Agenda";
            Load += Agenda_Load;
            registroCita.ResumeLayout(false);
            registroCita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCitas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnConsultar;
        private Button btnAgregar;
        private Button btnVolver;
        private Panel registroCita;
        private ComboBox boxID;
        private Label label1;
        private DateTimePicker boxDay;
        private Button btnEnviarRegistro;
        private Label label5;
        private DataGridView panelCitas;
        private Panel panel1;
    }
}