namespace PyTCalculoDedEspInc.Procesos
{
    partial class BorradoBBDD
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
            this.cmbSeleccion = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar base:";
            // 
            // cmbSeleccion
            // 
            this.cmbSeleccion.FormattingEnabled = true;
            this.cmbSeleccion.Items.AddRange(new object[] {
            "Empleados",
            "Remuneraciones mensuales",
            "Deducciones mensuales",
            "Cargas de familia",
            "Datos de otros empleadores",
            "Divisores",
            "Promedios brutos mensuales",
            "Deducciones especiales incrementadas [P.P.]",
            "Deducciones especiales incrementadas [S.P.]"});
            this.cmbSeleccion.Location = new System.Drawing.Point(112, 13);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(271, 21);
            this.cmbSeleccion.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(308, 49);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(227, 49);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Ejecutar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // BorradoBBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 89);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbSeleccion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorradoBBDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BorradoBBDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeleccion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnProcesar;
    }
}