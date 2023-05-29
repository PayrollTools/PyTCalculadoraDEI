namespace PyTCalculoDedEspInc.Configuracion.MenuResoluciones
{
    partial class VerRangos
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
            this.dvgRangosResolution = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRangosResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgRangosResolution
            // 
            this.dvgRangosResolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRangosResolution.Location = new System.Drawing.Point(12, 12);
            this.dvgRangosResolution.Name = "dvgRangosResolution";
            this.dvgRangosResolution.Size = new System.Drawing.Size(407, 208);
            this.dvgRangosResolution.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(344, 232);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // VerRangos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 267);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dvgRangosResolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "VerRangos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Rangos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgRangosResolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgRangosResolution;
        private System.Windows.Forms.Button btnCerrar;
    }
}