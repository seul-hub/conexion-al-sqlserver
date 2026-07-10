namespace VISTA
{
    partial class FrmLogin
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
            button1 = new Button();
            btnsalir = new Button();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            lbluser = new Label();
            lblcontraseña = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(177, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(177, 131);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(75, 23);
            btnsalir.TabIndex = 1;
            btnsalir.Text = "salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(166, 44);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(166, 73);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(103, 52);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(46, 15);
            lbluser.TabIndex = 4;
            lbluser.Text = "usuario";
            lbluser.Click += label1_Click;
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Location = new Point(95, 81);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(65, 15);
            lblcontraseña.TabIndex = 5;
            lblcontraseña.Text = "contraseña";
            lblcontraseña.Click += lblcontraseña_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblcontraseña);
            Controls.Add(lbluser);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnsalir);
            Controls.Add(button1);
            Name = "FrmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnsalir;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label lbluser;
        private Label lblcontraseña;
    }
}
