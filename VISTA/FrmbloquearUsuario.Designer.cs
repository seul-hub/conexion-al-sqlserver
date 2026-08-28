namespace VISTA
{
    partial class FrmbloquearUsuario
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
            label1 = new Label();
            cmbUsuario = new ComboBox();
            btnBloquear = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(65, 42);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(121, 23);
            cmbUsuario.TabIndex = 1;
            // 
            // btnBloquear
            // 
            btnBloquear.Location = new Point(12, 99);
            btnBloquear.Name = "btnBloquear";
            btnBloquear.Size = new Size(75, 23);
            btnBloquear.TabIndex = 2;
            btnBloquear.Text = "bloquear";
            btnBloquear.UseVisualStyleBackColor = true;
            btnBloquear.Click += btnBloquear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(93, 99);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmbloquearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 175);
            Controls.Add(btnCancelar);
            Controls.Add(btnBloquear);
            Controls.Add(cmbUsuario);
            Controls.Add(label1);
            Name = "FrmbloquearUsuario";
            Text = "FrmbloquearUsuario";
            Load += FrmbloquearUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbUsuario;
        private Button btnBloquear;
        private Button btnCancelar;
    }
}