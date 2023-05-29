namespace PyTCalculoDedEspInc.MenuVer
{
    partial class VerTablas
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
            this.dgvSalario = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalario
            // 
            this.dgvSalario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalario.Location = new System.Drawing.Point(15, 12);
            this.dgvSalario.Name = "dgvSalario";
            this.dgvSalario.ReadOnly = true;
            this.dgvSalario.Size = new System.Drawing.Size(518, 308);
            this.dgvSalario.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(457, 329);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(376, 329);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 8;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // VerTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 364);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvSalario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VerSalario";
            this.Load += new System.EventHandler(this.VerSalario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSalario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
    }
}