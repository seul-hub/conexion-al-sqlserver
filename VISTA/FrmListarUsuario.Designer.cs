namespace VISTA
{
    partial class FrmListarUsuario
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
            dguUsuarios = new DataGridView();
            btnModificar = new Button();
            btnCerrar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dguUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dguUsuarios
            // 
            dguUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dguUsuarios.Location = new Point(12, 12);
            dguUsuarios.Name = "dguUsuarios";
            dguUsuarios.Size = new Size(469, 150);
            dguUsuarios.TabIndex = 0;
            dguUsuarios.CellContentClick += dguUsuarios_CellContentClick;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(195, 168);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 38);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(321, 168);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(92, 38);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(67, 168);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(92, 38);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmListarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 250);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnModificar);
            Controls.Add(dguUsuarios);
            Name = "FrmListarUsuario";
            Text = "FrmListarUsuario";
            Load += FrmListarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dguUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dguUsuarios;
        private Button btnModificar;
        private Button btnCerrar;
        private Button btnActualizar;
    }
}