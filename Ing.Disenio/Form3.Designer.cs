namespace Ing.Disenio
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            btnAgenda = new Button();
            btnClientes = new Button();
            Servicios = new Button();
            txtBienv = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            grupoAgenda = new GroupBox();
            txtBtnAgenda = new Label();
            grupoClientes = new GroupBox();
            txtBtnClientes = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            grupoAgenda.SuspendLayout();
            grupoClientes.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgenda
            // 
            btnAgenda.BackgroundImage = (Image)resources.GetObject("btnAgenda.BackgroundImage");
            btnAgenda.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.ForeColor = Color.Gray;
            btnAgenda.ImageAlign = ContentAlignment.BottomCenter;
            btnAgenda.Location = new Point(5, 36);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(108, 101);
            btnAgenda.TabIndex = 0;
            btnAgenda.TextAlign = ContentAlignment.TopCenter;
            btnAgenda.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackgroundImage = (Image)resources.GetObject("btnClientes.BackgroundImage");
            btnClientes.BackgroundImageLayout = ImageLayout.Stretch;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = SystemColors.ActiveCaption;
            btnClientes.Location = new Point(5, 37);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(114, 111);
            btnClientes.TabIndex = 1;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // Servicios
            // 
            Servicios.BackgroundImage = (Image)resources.GetObject("Servicios.BackgroundImage");
            Servicios.BackgroundImageLayout = ImageLayout.Stretch;
            Servicios.FlatStyle = FlatStyle.Flat;
            Servicios.ForeColor = Color.Gray;
            Servicios.Location = new Point(5, 44);
            Servicios.Name = "Servicios";
            Servicios.Size = new Size(114, 111);
            Servicios.TabIndex = 2;
            Servicios.UseVisualStyleBackColor = true;
            Servicios.Click += Servicios_Click;
            // 
            // txtBienv
            // 
            txtBienv.AutoSize = true;
            txtBienv.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBienv.Location = new Point(5, 5);
            txtBienv.Name = "txtBienv";
            txtBienv.Size = new Size(182, 47);
            txtBienv.TabIndex = 4;
            txtBienv.Text = "Binvenido: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(grupoAgenda);
            panel1.Controls.Add(grupoClientes);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 497);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Location = new Point(167, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 406);
            panel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Servicios);
            groupBox1.Location = new Point(19, 318);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(125, 161);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 3;
            label1.Text = "Servicios";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // grupoAgenda
            // 
            grupoAgenda.Controls.Add(txtBtnAgenda);
            grupoAgenda.Controls.Add(btnAgenda);
            grupoAgenda.Location = new Point(19, 10);
            grupoAgenda.Name = "grupoAgenda";
            grupoAgenda.Size = new Size(119, 137);
            grupoAgenda.TabIndex = 6;
            grupoAgenda.TabStop = false;
            // 
            // txtBtnAgenda
            // 
            txtBtnAgenda.BackColor = SystemColors.Highlight;
            txtBtnAgenda.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBtnAgenda.ForeColor = SystemColors.Control;
            txtBtnAgenda.Location = new Point(6, 8);
            txtBtnAgenda.Name = "txtBtnAgenda";
            txtBtnAgenda.Size = new Size(114, 25);
            txtBtnAgenda.TabIndex = 1;
            txtBtnAgenda.Text = "Agenda";
            txtBtnAgenda.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grupoClientes
            // 
            grupoClientes.Controls.Add(txtBtnClientes);
            grupoClientes.Controls.Add(btnClientes);
            grupoClientes.ForeColor = Color.LightSkyBlue;
            grupoClientes.Location = new Point(19, 153);
            grupoClientes.Name = "grupoClientes";
            grupoClientes.Size = new Size(125, 154);
            grupoClientes.TabIndex = 6;
            grupoClientes.TabStop = false;
            // 
            // txtBtnClientes
            // 
            txtBtnClientes.BackColor = SystemColors.Highlight;
            txtBtnClientes.BorderStyle = BorderStyle.FixedSingle;
            txtBtnClientes.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBtnClientes.ForeColor = SystemColors.Control;
            txtBtnClientes.Location = new Point(6, 14);
            txtBtnClientes.Name = "txtBtnClientes";
            txtBtnClientes.Size = new Size(114, 20);
            txtBtnClientes.TabIndex = 3;
            txtBtnClientes.Text = "Clientes";
            txtBtnClientes.TextAlign = ContentAlignment.TopCenter;
            txtBtnClientes.Click += txtBtnClientes_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 391);
            label2.Name = "label2";
            label2.Size = new Size(396, 93);
            label2.TabIndex = 6;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSkyBlue;
            label3.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 4);
            label3.Name = "label3";
            label3.Size = new Size(368, 303);
            label3.TabIndex = 7;
            label3.Text = "AutoMecanica Proservicio";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(186, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 308);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(397, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 198);
            panel4.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Controls.Add(txtBienv);
            panel5.ForeColor = SystemColors.ButtonHighlight;
            panel5.Location = new Point(186, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(602, 62);
            panel5.TabIndex = 9;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 493);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form3";
            Text = "Inicio";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            grupoAgenda.ResumeLayout(false);
            grupoClientes.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgenda;
        private Button btnClientes;
        private Button Servicios;
        private Label txtBienv;
        private Panel panel1;
        private Label txtBtnClientes;
        private GroupBox grupoClientes;
        private GroupBox grupoAgenda;
        private Label txtBtnAgenda;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private System.Windows.Forms.Timer timer1;
    }
}