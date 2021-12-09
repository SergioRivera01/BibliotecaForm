namespace Biblioteca
{
    partial class Form2
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtMostrarApellidos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(159, 261);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(94, 29);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(169, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(260, 153);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(125, 27);
            this.txtMostrar.TabIndex = 2;
            this.txtMostrar.TextChanged += new System.EventHandler(this.txtMostrar_TextChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(177, 201);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(72, 20);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos";
            // 
            // txtMostrarApellidos
            // 
            this.txtMostrarApellidos.Location = new System.Drawing.Point(264, 198);
            this.txtMostrarApellidos.Name = "txtMostrarApellidos";
            this.txtMostrarApellidos.Size = new System.Drawing.Size(125, 27);
            this.txtMostrarApellidos.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMostrarApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAtras);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAtras;
        private Label lblNombre;
        public TextBox txtMostrar;
        private Label lblApellidos;
        public TextBox txtMostrarApellidos;
    }
}