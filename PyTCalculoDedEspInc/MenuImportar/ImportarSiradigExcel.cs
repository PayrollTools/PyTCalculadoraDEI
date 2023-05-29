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

namespace PyTCalculoDedEspInc.MenuImportar
{
    internal partial class ImportarSiradigExcel : Form
    {
        private string filePath;
        private string directory;
        internal FormType TipoFormulario { get; set; }

        internal ImportarSiradigExcel(FormType formType)
        {
            InitializeComponent();

            this.TipoFormulario = formType;

            if (FormType.FamilyForm== formType)
            {
                this.Text = "Importar cargas de familia";
            }
            else
            {
                this.Text = "Importar otros empleadores";
            }
        } 

        /// <summary>
        /// Obtiene el archivo excel a procesar.
        /// </summary>
        /// <returns>String</returns>
        private string ObtainExcelFile()
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "excel file (*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
            }

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                return OpenFileDialog.FileName;
            }
            else
            {
                return null;
            }
        }

        private string ObtainDirectory()
        {
            using(FolderBrowserDialog OpenBrowserDialog = new FolderBrowserDialog())
            {
                OpenFileDialog.InitialDirectory = Environment.CurrentDirectory;
            }

            if (OpenBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return OpenBrowserDialog.SelectedPath;
            }
            else
            {
                return null;
            }
        }


        private void cmbOrigen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex == 0)
            {
                //Datos desde archivo xml.
                btnFileDialog.BackgroundImage = PyTCalculoDedEspInc.Resources.XML_Icon;
                label2.Text = "Directorio:";
            }
            else
            {
                //Datos desde archivo excel.
                btnFileDialog.BackgroundImage = PyTCalculoDedEspInc.Resources.Excel_Icon;
                label2.Text = "Archivo:";
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string message = null;
            
            if(cmbOrigen.SelectedIndex == 0)
            {
                if (Directory.Exists(this.txtFuente.Text))
                {
                    switch (this.TipoFormulario)
                    {
                        case FormType.FamilyForm:
                            message = Model.CreateEmployeeFamilyXml(this.txtFuente.Text);
                            break;
                        case FormType.JobsForm:
                            message = Model.CreateEmployeeJobsXml(this.txtFuente.Text);
                            break;
                    }

                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Directorio invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (File.Exists(this.txtFuente.Text))
                {
                    switch (this.TipoFormulario)
                    {
                        case FormType.FamilyForm:
                            message = Model.CreateEmployeeFamilyExcel(this.txtFuente.Text);
                            break;
                        case FormType.JobsForm:
                            message = Model.CreateEmployeeJobsExcel(this.txtFuente.Text);
                            break;
                    }

                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Archivo invalido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {            
            if (cmbOrigen.SelectedIndex == 0)
            {
                directory = ObtainDirectory();
                txtFuente.Text = this.directory;
            }
            else if (cmbOrigen.SelectedIndex == 1)
            {
                filePath = ObtainExcelFile();
                txtFuente.Text = this.filePath;
            }
            else
            {
                MessageBox.Show("Debe seleccionar el origen de la importación primero.",
                    "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void ImportarSiradigExcel_Load(object sender, EventArgs e)
        {
            this.cmbOrigen.SelectedIndex = 0;
        }
    }
}