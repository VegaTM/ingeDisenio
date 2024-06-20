namespace Ing.Disenio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegistro = new Button();
            txtNombre = new TextBox();
            txtUserr = new TextBox();
            txtAPM = new TextBox();
            txtAPP = new TextBox();
            label5 = new Label();
            txtContra = new TextBox();
            btnBack = new Button();
            label7 = new Label();
            txtContraConfirmar = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 10.2F);
            label1.Location = new Point(58, 66);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 10.2F);
            label2.Location = new Point(58, 120);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 10.2F);
            label3.Location = new Point(58, 184);
            label3.Name = "label3";
            label3.Size = new Size(142, 23);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 10.2F);
            label4.Location = new Point(58, 245);
            label4.Name = "label4";
            label4.Size = new Size(68, 23);
            label4.TabIndex = 3;
            label4.Text = "Usuario";
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.Transparent;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Nirmala UI", 9F);
            btnRegistro.ForeColor = Color.SteelBlue;
            btnRegistro.Location = new Point(657, 305);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(94, 29);
            btnRegistro.TabIndex = 4;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.HighlightText;
            txtNombre.Location = new Point(239, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(396, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtUserr
            // 
            txtUserr.Location = new Point(239, 244);
            txtUserr.Name = "txtUserr";
            txtUserr.Size = new Size(396, 27);
            txtUserr.TabIndex = 6;
            // 
            // txtAPM
            // 
            txtAPM.Location = new Point(239, 183);
            txtAPM.Name = "txtAPM";
            txtAPM.Size = new Size(396, 27);
            txtAPM.TabIndex = 7;
            // 
            // txtAPP
            // 
            txtAPP.Location = new Point(239, 119);
            txtAPP.Name = "txtAPP";
            txtAPP.Size = new Size(396, 27);
            txtAPP.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 10.2F);
            label5.Location = new Point(58, 306);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 9;
            label5.Text = "Contraseña";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(239, 305);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(396, 27);
            txtContra.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Nirmala UI", 9F);
            btnBack.ForeColor = Color.SteelBlue;
            btnBack.Location = new Point(657, 350);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 12;
            btnBack.Text = "Cancelar";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 10.2F);
            label7.Location = new Point(58, 360);
            label7.Name = "label7";
            label7.Size = new Size(175, 23);
            label7.TabIndex = 13;
            label7.Text = "Confirmar contraseña";
            label7.Click += label7_Click;
            // 
            // txtContraConfirmar
            // 
            txtContraConfirmar.Location = new Point(239, 359);
            txtContraConfirmar.Name = "txtContraConfirmar";
            txtContraConfirmar.Size = new Size(396, 27);
            txtContraConfirmar.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtContraConfirmar);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(txtContra);
            Controls.Add(label5);
            Controls.Add(txtAPP);
            Controls.Add(txtAPM);
            Controls.Add(txtUserr);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistro);
            Name = "Form2";
            Text = "Registrar nuevo usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegistro;
        private TextBox txtNombre;
        private TextBox txtUserr;
        private TextBox txtAPM;
        private TextBox txtAPP;
        private Label label5;
        private TextBox txtContra;
        private Button btnBack;
        private Label label7;
        private TextBox txtContraConfirmar;
    }
}