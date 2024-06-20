namespace Ing.Disenio
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panelRegistro = new Panel();
            boxDireccion = new TextBox();
            txtDir = new Label();
            boxTelefono = new TextBox();
            txtTelefono = new Label();
            boxEmail = new TextBox();
            txtEmail = new Label();
            registroCliente = new Button();
            boxName = new TextBox();
            txtNameCliente = new Label();
            tablaClientes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(262, 0);
            button1.Name = "button1";
            button1.Size = new Size(270, 43);
            button1.TabIndex = 0;
            button1.Text = "Consulta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Nirmala UI", 9F);
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(263, 43);
            button2.TabIndex = 1;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSteelBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(530, 0);
            button3.Name = "button3";
            button3.Size = new Size(267, 43);
            button3.TabIndex = 2;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Font = new Font("Nirmala UI", 9F);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 43);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panelRegistro);
            panel2.Controls.Add(tablaClientes);
            panel2.Font = new Font("Nirmala UI", 9F);
            panel2.Location = new Point(4, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 405);
            panel2.TabIndex = 4;
            // 
            // panelRegistro
            // 
            panelRegistro.BackColor = Color.Lavender;
            panelRegistro.BackgroundImage = (Image)resources.GetObject("panelRegistro.BackgroundImage");
            panelRegistro.BackgroundImageLayout = ImageLayout.Stretch;
            panelRegistro.Controls.Add(boxDireccion);
            panelRegistro.Controls.Add(txtDir);
            panelRegistro.Controls.Add(boxTelefono);
            panelRegistro.Controls.Add(txtTelefono);
            panelRegistro.Controls.Add(boxEmail);
            panelRegistro.Controls.Add(txtEmail);
            panelRegistro.Controls.Add(registroCliente);
            panelRegistro.Controls.Add(boxName);
            panelRegistro.Controls.Add(txtNameCliente);
            panelRegistro.Location = new Point(0, 0);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(794, 405);
            panelRegistro.TabIndex = 1;
            // 
            // boxDireccion
            // 
            boxDireccion.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            boxDireccion.ForeColor = SystemColors.ActiveCaptionText;
            boxDireccion.Location = new Point(470, 203);
            boxDireccion.Name = "boxDireccion";
            boxDireccion.Size = new Size(225, 25);
            boxDireccion.TabIndex = 8;
            // 
            // txtDir
            // 
            txtDir.AutoSize = true;
            txtDir.BackColor = Color.Transparent;
            txtDir.Font = new Font("Nirmala UI", 9F);
            txtDir.ForeColor = SystemColors.ActiveCaptionText;
            txtDir.Location = new Point(470, 165);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(148, 20);
            txtDir.TabIndex = 7;
            txtDir.Text = "Direccion del cliente:";
            // 
            // boxTelefono
            // 
            boxTelefono.BackColor = SystemColors.InactiveBorder;
            boxTelefono.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            boxTelefono.ForeColor = SystemColors.ActiveCaptionText;
            boxTelefono.Location = new Point(99, 203);
            boxTelefono.Name = "boxTelefono";
            boxTelefono.Size = new Size(225, 25);
            boxTelefono.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.Font = new Font("Nirmala UI", 9F);
            txtTelefono.ForeColor = SystemColors.ActiveCaptionText;
            txtTelefono.Location = new Point(99, 165);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(148, 20);
            txtTelefono.TabIndex = 5;
            txtTelefono.Text = "Telefono del cliente:*";
            // 
            // boxEmail
            // 
            boxEmail.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            boxEmail.ForeColor = SystemColors.ActiveCaptionText;
            boxEmail.Location = new Point(470, 93);
            boxEmail.Name = "boxEmail";
            boxEmail.Size = new Size(225, 25);
            boxEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Nirmala UI", 9F);
            txtEmail.ForeColor = SystemColors.ActiveCaptionText;
            txtEmail.Location = new Point(470, 55);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(122, 20);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Email del cliente:";
            // 
            // registroCliente
            // 
            registroCliente.BackColor = Color.Transparent;
            registroCliente.FlatStyle = FlatStyle.Flat;
            registroCliente.Font = new Font("Nirmala UI", 9F);
            registroCliente.ForeColor = SystemColors.ActiveCaptionText;
            registroCliente.Location = new Point(99, 290);
            registroCliente.Name = "registroCliente";
            registroCliente.Size = new Size(596, 33);
            registroCliente.TabIndex = 2;
            registroCliente.Text = "Registrar";
            registroCliente.UseVisualStyleBackColor = false;
            registroCliente.Click += registroCliente_Click;
            // 
            // boxName
            // 
            boxName.Font = new Font("Franklin Gothic Book", 9F, FontStyle.Bold);
            boxName.ForeColor = SystemColors.ActiveCaptionText;
            boxName.Location = new Point(99, 93);
            boxName.Name = "boxName";
            boxName.Size = new Size(225, 25);
            boxName.TabIndex = 1;
            // 
            // txtNameCliente
            // 
            txtNameCliente.AutoSize = true;
            txtNameCliente.BackColor = Color.Transparent;
            txtNameCliente.Font = new Font("Nirmala UI", 9F);
            txtNameCliente.ForeColor = SystemColors.ActiveCaptionText;
            txtNameCliente.Location = new Point(99, 55);
            txtNameCliente.Name = "txtNameCliente";
            txtNameCliente.Size = new Size(150, 20);
            txtNameCliente.TabIndex = 0;
            txtNameCliente.Text = "Nombre del cliente: *";
            // 
            // tablaClientes
            // 
            tablaClientes.BackgroundColor = SystemColors.GradientActiveCaption;
            tablaClientes.BorderStyle = BorderStyle.Fixed3D;
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaClientes.Location = new Point(8, 4);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.RowHeadersWidth = 51;
            tablaClientes.Size = new Size(786, 398);
            tablaClientes.TabIndex = 0;
            tablaClientes.CellDoubleClick += tablaClientes_CellDoubleClick;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Clientes";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private DataGridView tablaClientes;
        private Panel panelRegistro;
        private Label txtNameCliente;
        private TextBox boxDireccion;
        private Label txtDir;
        private TextBox boxTelefono;
        private Label txtTelefono;
        private TextBox boxEmail;
        private Label txtEmail;
        private Button registroCliente;
        private TextBox boxName;
    }
}