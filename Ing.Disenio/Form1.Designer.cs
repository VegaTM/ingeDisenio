namespace Ing.Disenio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUs = new Label();
            txtContra = new Label();
            boxUS = new TextBox();
            boxPss = new TextBox();
            btnIngresar = new Button();
            btnReg = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // txtUs
            // 
            txtUs.AutoSize = true;
            txtUs.BackColor = Color.Transparent;
            txtUs.Font = new Font("Bahnschrift Condensed", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 161);
            txtUs.ForeColor = SystemColors.ActiveCaptionText;
            txtUs.ImageAlign = ContentAlignment.MiddleLeft;
            txtUs.Location = new Point(210, 162);
            txtUs.Name = "txtUs";
            txtUs.Size = new Size(111, 45);
            txtUs.TabIndex = 0;
            txtUs.Text = "Usuario";
            txtUs.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContra
            // 
            txtContra.AutoSize = true;
            txtContra.BackColor = Color.Transparent;
            txtContra.Font = new Font("Bahnschrift Condensed", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContra.ForeColor = SystemColors.ActiveCaptionText;
            txtContra.Location = new Point(210, 240);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(158, 45);
            txtContra.TabIndex = 1;
            txtContra.Text = "Contraseña";
            // 
            // boxUS
            // 
            boxUS.BorderStyle = BorderStyle.FixedSingle;
            boxUS.Location = new Point(210, 210);
            boxUS.Name = "boxUS";
            boxUS.Size = new Size(385, 27);
            boxUS.TabIndex = 3;
            // 
            // boxPss
            // 
            boxPss.BorderStyle = BorderStyle.FixedSingle;
            boxPss.Location = new Point(210, 288);
            boxPss.Name = "boxPss";
            boxPss.PasswordChar = '*';
            boxPss.Size = new Size(385, 27);
            boxPss.TabIndex = 4;
            boxPss.TextChanged += boxPss_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(423, 340);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(172, 29);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnReg
            // 
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = SystemColors.ActiveCaptionText;
            btnReg.Location = new Point(423, 375);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(172, 29);
            btnReg.TabIndex = 6;
            btnReg.Text = "Registrarse...";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(163, 15);
            label1.Name = "label1";
            label1.Size = new Size(453, 144);
            label1.TabIndex = 7;
            label1.Text = "AutoMecánica\r\n ProServicio";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(137, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(81, 78);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(566, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(93, 91);
            panel2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(txtUs);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btnReg);
            Controls.Add(btnIngresar);
            Controls.Add(boxPss);
            Controls.Add(boxUS);
            Controls.Add(txtContra);
            MaximizeBox = false;
            Name = "Form1";
            Text = "LOG IN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtUs;
        private Label txtContra;
        private TextBox boxUS;
        private TextBox boxPss;
        private Button btnIngresar;
        private Button btnReg;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
