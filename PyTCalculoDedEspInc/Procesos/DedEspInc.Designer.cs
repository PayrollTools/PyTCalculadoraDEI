namespace PyTCalculoDedEspInc.Procesos
{
    partial class DedEspInc
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLegajoDesde = new System.Windows.Forms.ComboBox();
            this.cmbLegajoHasta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMesHasta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMesDesde = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Legajo desde:";
            // 
            // cmbLegajoDesde
            // 
            this.cmbLegajoDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLegajoDesde.FormattingEnabled = true;
            this.cmbLegajoDesde.Location = new System.Drawing.Point(95, 52);
            this.cmbLegajoDesde.Name = "cmbLegajoDesde";
            this.cmbLegajoDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbLegajoDesde.TabIndex = 3;
            // 
            // cmbLegajoHasta
            // 
            this.cmbLegajoHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLegajoHasta.FormattingEnabled = true;
            this.cmbLegajoHasta.Location = new System.Drawing.Point(329, 52);
            this.cmbLegajoHasta.Name = "cmbLegajoHasta";
            this.cmbLegajoHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbLegajoHasta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Legajo hasta:";
            // 
            // cmbMesHasta
            // 
            this.cmbMesHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesHasta.FormattingEnabled = true;
            this.cmbMesHasta.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMesHasta.Location = new System.Drawing.Point(329, 90);
            this.cmbMesHasta.Name = "cmbMesHasta";
            this.cmbMesHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbMesHasta.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mes hasta:";
            // 
            // cmbMesDesde
            // 
            this.cmbMesDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesDesde.FormattingEnabled = true;
            this.cmbMesDesde.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbMesDesde.Location = new System.Drawing.Point(95, 90);
            this.cmbMesDesde.Name = "cmbMesDesde";
            this.cmbMesDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbMesDesde.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mes desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Periodo:";
            // 
            // cmbAnio
            // 
            this.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(95, 12);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbAnio.TabIndex = 11;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(375, 129);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(294, 129);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // DedEspInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 166);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMesHasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMesDesde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLegajoHasta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLegajoDesde);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DedEspInc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ejecutar proceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLegajoDesde;
        private System.Windows.Forms.ComboBox cmbLegajoHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMesHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMesDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnProcesar;
    }
}