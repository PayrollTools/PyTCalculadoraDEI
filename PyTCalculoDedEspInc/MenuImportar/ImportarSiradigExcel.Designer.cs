namespace PyTCalculoDedEspInc.MenuImportar
{
    partial class ImportarSiradigExcel
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Directorio:";
            // 
            // txtFuente
            // 
            this.txtFuente.Location = new System.Drawing.Point(93, 48);
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(205, 20);
            this.txtFuente.TabIndex = 3;
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.BackgroundImage = global::PyTCalculoDedEspInc.Resources.XML_Icon;
            this.btnFileDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFileDialog.Location = new System.Drawing.Point(309, 41);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(32, 32);
            this.btnFileDialog.TabIndex = 4;
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(174, 88);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(262, 88);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            this.OpenFileDialog.Title = "Seleccionar archivo excel";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Desde archivo xml [SIRADIG]",
            "Desde archivo excel [.xlsx]"});
            this.cmbOrigen.Location = new System.Drawing.Point(93, 6);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(248, 21);
            this.cmbOrigen.TabIndex = 7;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged_1);
            // 
            // ImportarSiradigExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(353, 123);
            this.Controls.Add(this.cmbOrigen);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnFileDialog);
            this.Controls.Add(this.txtFuente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportarSiradigExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ImportarSiradigExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.FolderBrowserDialog OpenBrowserDialog;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}