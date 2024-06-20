namespace Ing.Disenio
{
    partial class Form5
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
            panel1 = new Panel();
            menuBtn = new Button();
            consultaBtn = new Button();
            panel2 = new Panel();
            panelServicio = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelServicio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuBtn);
            panel1.Controls.Add(consultaBtn);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 55);
            panel1.TabIndex = 0;
            // 
            // menuBtn
            // 
            menuBtn.Location = new Point(384, 0);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(414, 54);
            menuBtn.TabIndex = 2;
            menuBtn.Text = "Volver";
            menuBtn.UseVisualStyleBackColor = true;
            menuBtn.Click += menuBtn_Click;
            // 
            // consultaBtn
            // 
            consultaBtn.Location = new Point(5, -2);
            consultaBtn.Name = "consultaBtn";
            consultaBtn.Size = new Size(373, 54);
            consultaBtn.TabIndex = 1;
            consultaBtn.Text = "Consultar";
            consultaBtn.UseVisualStyleBackColor = true;
            consultaBtn.Click += consultaBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelServicio);
            panel2.Location = new Point(6, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 396);
            panel2.TabIndex = 1;
            // 
            // panelServicio
            // 
            panelServicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panelServicio.Location = new Point(20, 8);
            panelServicio.Name = "panelServicio";
            panelServicio.RowHeadersWidth = 51;
            panelServicio.Size = new Size(738, 375);
            panelServicio.TabIndex = 0;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelServicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button menuBtn;
        private Button consultaBtn;
        private Panel panel2;
        private DataGridView panelServicio;
    }
}