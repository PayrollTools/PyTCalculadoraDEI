namespace PyTCalculoDedEspInc.Procesos
{
    partial class ExportarResultados
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
            this.btnExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar tabla:";
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
            "Promedios brutos mensuales",
            "Deducciones especiales incrementadas [P.P.]",
            "Deducciones especiales incrementadas [S.P.]"});
            this.cmbSeleccion.Location = new System.Drawing.Point(110, 12);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(232, 21);
            this.cmbSeleccion.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(267, 52);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(186, 52);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // ExportarResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 86);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbSeleccion);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportarResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exportar resultados de liquidación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSeleccion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnExportar;
    }
}