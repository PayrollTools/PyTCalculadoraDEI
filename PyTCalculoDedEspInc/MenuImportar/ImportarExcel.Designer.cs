namespace PyTCalculoDedEspInc.MenuImportar
{
    partial class ImportarExcel
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
            this.lblDirectorio = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblDirectorio
            // 
            this.lblDirectorio.AutoSize = true;
            this.lblDirectorio.Location = new System.Drawing.Point(13, 13);
            this.lblDirectorio.Name = "lblDirectorio";
            this.lblDirectorio.Size = new System.Drawing.Size(46, 13);
            this.lblDirectorio.TabIndex = 0;
            this.lblDirectorio.Text = "Archivo:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(74, 10);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(247, 20);
            this.txtOrigen.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.BackgroundImage = global::PyTCalculoDedEspInc.Resources.Excel_Icon;
            this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImportar.Location = new System.Drawing.Point(327, 3);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(32, 32);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(203, 50);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(284, 50);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "OpenFileDialog";
            // 
            // ImportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(374, 85);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.lblDirectorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportarExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Importar Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirectorio;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}