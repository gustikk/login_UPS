namespace login
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
            c = new Label();
            groupBox1 = new GroupBox();
            btnsalir = new Button();
            btnregistrarse = new Button();
            btningresar = new Button();
            txtcontraseña = new TextBox();
            txtusuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // c
            // 
            c.AutoSize = true;
            c.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            c.Location = new Point(194, 28);
            c.Name = "c";
            c.Size = new Size(404, 48);
            c.TabIndex = 0;
            c.Text = "BIENVENIDO A LA UPS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnsalir);
            groupBox1.Controls.Add(btnregistrarse);
            groupBox1.Controls.Add(btningresar);
            groupBox1.Controls.Add(txtcontraseña);
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(703, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese Sus Datos ";
            // 
            // btnsalir
            // 
            btnsalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(316, 272);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(124, 46);
            btnsalir.TabIndex = 2;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnregistrarse
            // 
            btnregistrarse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregistrarse.Location = new Point(544, 176);
            btnregistrarse.Name = "btnregistrarse";
            btnregistrarse.Size = new Size(124, 46);
            btnregistrarse.TabIndex = 2;
            btnregistrarse.Text = "Registrarse";
            btnregistrarse.UseVisualStyleBackColor = true;
            btnregistrarse.Click += btnregistrarse_Click;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.Location = new Point(544, 74);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(124, 46);
            btningresar.TabIndex = 2;
            btningresar.Text = "ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += btningresar_Click;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(246, 187);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '$';
            txtcontraseña.Size = new Size(194, 39);
            txtcontraseña.TabIndex = 1;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(246, 76);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(194, 39);
            txtusuario.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 192);
            label3.Name = "label3";
            label3.Size = new Size(204, 30);
            label3.TabIndex = 0;
            label3.Text = "Ingrese Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 81);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 0;
            label2.Text = "Ingrese Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(c);
            Name = "Form1";
            Text = "Ingreso a Sistema";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label c;
        private GroupBox groupBox1;
        private TextBox txtusuario;
        private Label label3;
        private Label label2;
        private Button btnsalir;
        private Button btnregistrarse;
        private Button btningresar;
        private TextBox txtcontraseña;
    }
}
