namespace PyTCalculoDedEspInc.Configuracion
{
    partial class DirectorioSalida
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directorio de salida:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(118, 16);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(206, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.BackgroundImage = global::PyTCalculoDedEspInc.Resources.Directory_Icon;
            this.btnDirectorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirectorio.Location = new System.Drawing.Point(334, 9);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(32, 32);
            this.btnDirectorio.TabIndex = 2;
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(291, 61);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(210, 61);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DirectorioSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(378, 100);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnDirectorio);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectorioSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Directorio de salida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
    }
}