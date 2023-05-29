namespace PyTCalculoDedEspInc.Configuracion
{
    partial class DeduccionesPersonales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGananNoImp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConyuge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHijo = new System.Windows.Forms.TextBox();
            this.txtHijoInc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDedEspcial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.cmbAnio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 34);
            this.panel1.TabIndex = 0;
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(41, 6);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(121, 21);
            this.cmbAnio.TabIndex = 1;
            this.cmbAnio.SelectedIndexChanged += new System.EventHandler(this.cmbAnio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ganancias no Imponibles:";
            // 
            // txtGananNoImp
            // 
            this.txtGananNoImp.Location = new System.Drawing.Point(153, 59);
            this.txtGananNoImp.Name = "txtGananNoImp";
            this.txtGananNoImp.Size = new System.Drawing.Size(130, 20);
            this.txtGananNoImp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cónyuge:";
            // 
            // txtConyuge
            // 
            this.txtConyuge.Location = new System.Drawing.Point(153, 85);
            this.txtConyuge.Name = "txtConyuge";
            this.txtConyuge.Size = new System.Drawing.Size(130, 20);
            this.txtConyuge.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hijo:";
            // 
            // txtHijo
            // 
            this.txtHijo.Location = new System.Drawing.Point(153, 111);
            this.txtHijo.Name = "txtHijo";
            this.txtHijo.Size = new System.Drawing.Size(130, 20);
            this.txtHijo.TabIndex = 6;
            // 
            // txtHijoInc
            // 
            this.txtHijoInc.Location = new System.Drawing.Point(153, 137);
            this.txtHijoInc.Name = "txtHijoInc";
            this.txtHijoInc.Size = new System.Drawing.Size(130, 20);
            this.txtHijoInc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hijo Incapacitado:";
            // 
            // txtDedEspcial
            // 
            this.txtDedEspcial.Location = new System.Drawing.Point(153, 163);
            this.txtDedEspcial.Name = "txtDedEspcial";
            this.txtDedEspcial.Size = new System.Drawing.Size(130, 20);
            this.txtDedEspcial.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Deducción Especial:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(126, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(208, 199);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // DeduccionesPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 234);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDedEspcial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHijoInc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHijo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConyuge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGananNoImp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeduccionesPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deducciones Personales";
            this.Load += new System.EventHandler(this.DeduccionesPersonales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGananNoImp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConyuge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHijo;
        private System.Windows.Forms.TextBox txtHijoInc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDedEspcial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
    }
}