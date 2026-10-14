namespace VISTA
{
    partial class FrmPreguntasSeguridad
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
            lblpregunta1 = new Label();
            lblpregunta2 = new Label();
            lblpregunta3 = new Label();
            lblpregunta4 = new Label();
            lblpregunta5 = new Label();
            txtrespuesta1 = new TextBox();
            txtrespuesta2 = new TextBox();
            txtrespuesta3 = new TextBox();
            txtrespuesta4 = new TextBox();
            txtrespuesta5 = new TextBox();
            btnenviar = new Button();
            SuspendLayout();
            // 
            // lblpregunta1
            // 
            lblpregunta1.AutoSize = true;
            lblpregunta1.Location = new Point(21, 31);
            lblpregunta1.Name = "lblpregunta1";
            lblpregunta1.Size = new Size(38, 15);
            lblpregunta1.TabIndex = 0;
            lblpregunta1.Text = "label1";
            // 
            // lblpregunta2
            // 
            lblpregunta2.AutoSize = true;
            lblpregunta2.Location = new Point(21, 60);
            lblpregunta2.Name = "lblpregunta2";
            lblpregunta2.Size = new Size(38, 15);
            lblpregunta2.TabIndex = 1;
            lblpregunta2.Text = "label2";
            // 
            // lblpregunta3
            // 
            lblpregunta3.AutoSize = true;
            lblpregunta3.Location = new Point(21, 86);
            lblpregunta3.Name = "lblpregunta3";
            lblpregunta3.Size = new Size(38, 15);
            lblpregunta3.TabIndex = 2;
            lblpregunta3.Text = "label3";
            // 
            // lblpregunta4
            // 
            lblpregunta4.AutoSize = true;
            lblpregunta4.Location = new Point(21, 112);
            lblpregunta4.Name = "lblpregunta4";
            lblpregunta4.Size = new Size(38, 15);
            lblpregunta4.TabIndex = 3;
            lblpregunta4.Text = "label4";
            // 
            // lblpregunta5
            // 
            lblpregunta5.AutoSize = true;
            lblpregunta5.Location = new Point(21, 137);
            lblpregunta5.Name = "lblpregunta5";
            lblpregunta5.Size = new Size(38, 15);
            lblpregunta5.TabIndex = 4;
            lblpregunta5.Text = "label5";
            // 
            // txtrespuesta1
            // 
            txtrespuesta1.Location = new Point(129, 28);
            txtrespuesta1.Name = "txtrespuesta1";
            txtrespuesta1.Size = new Size(100, 23);
            txtrespuesta1.TabIndex = 5;
            // 
            // txtrespuesta2
            // 
            txtrespuesta2.Location = new Point(129, 52);
            txtrespuesta2.Name = "txtrespuesta2";
            txtrespuesta2.Size = new Size(100, 23);
            txtrespuesta2.TabIndex = 6;
            // 
            // txtrespuesta3
            // 
            txtrespuesta3.Location = new Point(129, 78);
            txtrespuesta3.Name = "txtrespuesta3";
            txtrespuesta3.Size = new Size(100, 23);
            txtrespuesta3.TabIndex = 7;
            // 
            // txtrespuesta4
            // 
            txtrespuesta4.Location = new Point(129, 104);
            txtrespuesta4.Name = "txtrespuesta4";
            txtrespuesta4.Size = new Size(100, 23);
            txtrespuesta4.TabIndex = 8;
            // 
            // txtrespuesta5
            // 
            txtrespuesta5.Location = new Point(129, 129);
            txtrespuesta5.Name = "txtrespuesta5";
            txtrespuesta5.Size = new Size(100, 23);
            txtrespuesta5.TabIndex = 9;
            // 
            // btnenviar
            // 
            btnenviar.Location = new Point(81, 179);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(75, 23);
            btnenviar.TabIndex = 10;
            btnenviar.Text = "ENVIAR";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // FrmPreguntasSeguridad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 246);
            Controls.Add(btnenviar);
            Controls.Add(txtrespuesta5);
            Controls.Add(txtrespuesta4);
            Controls.Add(txtrespuesta3);
            Controls.Add(txtrespuesta2);
            Controls.Add(txtrespuesta1);
            Controls.Add(lblpregunta5);
            Controls.Add(lblpregunta4);
            Controls.Add(lblpregunta3);
            Controls.Add(lblpregunta2);
            Controls.Add(lblpregunta1);
            Name = "FrmPreguntasSeguridad";
            Text = "FrmPreguntasSeguridad";
            Load += FrmPreguntasSeguridad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblpregunta1;
        private Label lblpregunta2;
        private Label lblpregunta3;
        private Label lblpregunta4;
        private Label lblpregunta5;
        private TextBox txtrespuesta1;
        private TextBox txtrespuesta2;
        private TextBox txtrespuesta3;
        private TextBox txtrespuesta4;
        private TextBox txtrespuesta5;
        private Button btnenviar;
    }
}