namespace VISTA
{
    partial class FrmCambiarContraseñaUsuario
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
            btnCambiar_contraseña = new Button();
            button2 = new Button();
            cmbUsuario = new ComboBox();
            txtRepetir_Contraseña = new TextBox();
            txtContraseña_Nueva = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCambiar_contraseña
            // 
            btnCambiar_contraseña.Location = new Point(62, 148);
            btnCambiar_contraseña.Name = "btnCambiar_contraseña";
            btnCambiar_contraseña.Size = new Size(75, 23);
            btnCambiar_contraseña.TabIndex = 0;
            btnCambiar_contraseña.Text = "cambiar";
            btnCambiar_contraseña.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(143, 148);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(118, 47);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(121, 23);
            cmbUsuario.TabIndex = 2;
            // 
            // txtRepetir_Contraseña
            // 
            txtRepetir_Contraseña.Location = new Point(118, 105);
            txtRepetir_Contraseña.Name = "txtRepetir_Contraseña";
            txtRepetir_Contraseña.Size = new Size(100, 23);
            txtRepetir_Contraseña.TabIndex = 3;
            // 
            // txtContraseña_Nueva
            // 
            txtContraseña_Nueva.Location = new Point(118, 76);
            txtContraseña_Nueva.Name = "txtContraseña_Nueva";
            txtContraseña_Nueva.Size = new Size(100, 23);
            txtContraseña_Nueva.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 5;
            label1.Text = "usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 6;
            label2.Text = "contraseña nueva";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 7;
            label3.Text = "repetir contraseña";
            // 
            // FrmCambiarContraseñaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 216);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña_Nueva);
            Controls.Add(txtRepetir_Contraseña);
            Controls.Add(cmbUsuario);
            Controls.Add(button2);
            Controls.Add(btnCambiar_contraseña);
            Name = "FrmCambiarContraseñaUsuario";
            Text = "FrmCambiarContraseñaUsuario";
            Load += FrmCambiarContraseñaUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiar_contraseña;
        private Button button2;
        private ComboBox cmbUsuario;
        private TextBox txtRepetir_Contraseña;
        private TextBox txtContraseña_Nueva;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}