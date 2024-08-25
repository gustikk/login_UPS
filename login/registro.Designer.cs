namespace login
{
    partial class registro
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
            txtcontraseña = new TextBox();
            txtusuario = new TextBox();
            btnguardar = new Button();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(523, 45);
            panel1.TabIndex = 0;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(153, 248);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '$';
            txtcontraseña.Size = new Size(205, 31);
            txtcontraseña.TabIndex = 2;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(153, 134);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(205, 31);
            txtusuario.TabIndex = 3;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Red;
            btnguardar.Location = new Point(196, 315);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(112, 34);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 191);
            label3.Name = "label3";
            label3.Size = new Size(204, 30);
            label3.TabIndex = 6;
            label3.Text = "Ingrese Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 88);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 7;
            label2.Text = "Ingrese Usuario";
            // 
            // registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(523, 388);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnguardar);
            Controls.Add(txtcontraseña);
            Controls.Add(txtusuario);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "registro";
            Text = "registro";
            Load += registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtcontraseña;
        private TextBox txtusuario;
        private Button btnguardar;
        private Label label3;
        private Label label2;
    }
}