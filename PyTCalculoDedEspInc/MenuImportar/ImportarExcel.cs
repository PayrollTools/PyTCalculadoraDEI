using PytCalcModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace PyTCalculoDedEspInc.MenuImportar
{
    internal partial class ImportarExcel : Form
    {
        internal FormType TipoFomulario { get; set; }

        internal ImportarExcel(FormType formType)
        {
            InitializeComponent();
            
            this.TipoFomulario = formType;

            if (FormType.EmployeeForm == TipoFomulario)
            {
                this.Text = "Importar empleado";
            } 
            else if(FormType.RemunerationForm == TipoFomulario)
            {
                this.Text = "Importar remuneraciones";
            }
            else if (FormType.DeductionsForm == TipoFomulario) 
            {
                this.Text = "Importar deducciones";
            }
            else
            {
                this.Text = "Importar divisor.";
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Variables
            string message = null;
            string path = txtOrigen.Text;
            // Inhabilita el formulario.
            this.Enabled = false;

            if (File.Exists(path))
            {
                switch (this.TipoFomulario)
                {
                    case FormType.EmployeeForm:
                        message = Model.CreateEmployeeData(this.txtOrigen.Text);
                        break;
                    case FormType.RemunerationForm:
                        message = Model.CreateEmployeeSalary(this.txtOrigen.Text, "SP_CheckRemuneracion", "SP_InsertRemuneracion");
                        break;
                    case FormType.DeductionsForm:
                        message = Model.CreateEmployeeSalary(this.txtOrigen.Text, "SP_CheckDeduction","SP_InsertDeducciones");
                        break;
                    case FormType.DivisionForm:
                        message = Model.CreateEmployeeDivisor(this.txtOrigen.Text);
                        break;
                }
                MessageBox.Show(message, "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("El directorio especificado es invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Enabled = true;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {                                
                openFileDialog.Multiselect = false;
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "excel file (*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 1;                
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtOrigen.Text = openFileDialog.FileName.ToString();
            }            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
