using PytCalcModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyTCalculoDedEspInc.Configuracion
{
    public partial class DirectorioSalida : Form
    {
        public DirectorioSalida()
        {
            string directory = $@"{Environment.CurrentDirectory}\config.ini";

            InitializeComponent();

            try
            {
                this.txtDirectory.Text = Model.ReadIniFile("DIR_CONFIG", "path", directory);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                   "Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtDirectory.Text = folderBrowserDialog.SelectedPath;
                }
            }            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string directory = $@"{Environment.CurrentDirectory}\config.ini";
            if (Directory.Exists(this.txtDirectory.Text))
            {
                Model.WriteIniFile("DIR_CONFIG", "path", this.txtDirectory.Text, directory);
                MessageBox.Show("Cambios guardados",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Directorio ingresado no es valido",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
