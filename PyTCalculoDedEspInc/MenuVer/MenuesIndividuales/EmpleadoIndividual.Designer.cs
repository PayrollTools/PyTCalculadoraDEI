namespace PyTCalculoDedEspInc.MenuVer.MenuesIndividuales
{
    partial class EmpleadoIndividual
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
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApyNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecIng = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(120, 10);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.ReadOnly = true;
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 1;
            this.txtLegajo.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre y Apellido:";
            // 
            // txtApyNom
            // 
            this.txtApyNom.Location = new System.Drawing.Point(120, 44);
            this.txtApyNom.Name = "txtApyNom";
            this.txtApyNom.Size = new System.Drawing.Size(100, 20);
            this.txtApyNom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CUIL:";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(340, 10);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(100, 20);
            this.txtCuil.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de ingreso:";
            // 
            // txtFecIng
            // 
            this.txtFecIng.Location = new System.Drawing.Point(340, 45);
            this.txtFecIng.Name = "txtFecIng";
            this.txtFecIng.Size = new System.Drawing.Size(100, 20);
            this.txtFecIng.TabIndex = 7;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(365, 81);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(284, 81);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEliminar.Location = new System.Drawing.Point(203, 81);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // EmpleadoIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 119);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtFecIng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApyNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmpleadoIndividual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos del empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApyNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecIng;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
    }
}