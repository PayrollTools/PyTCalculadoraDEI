using PytCalcModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyTCalculoDedEspInc.Procesos
{
    public partial class BorradoBBDD : Form
    {
        public BorradoBBDD()
        {
            InitializeComponent();
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string message = null;

            if(this.cmbSeleccion.SelectedIndex == 0)
            {
                if(MessageBox.Show("El siguiente procesos borrara la totalidad de datos del esquema empleados. ¿Desea continuar?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    message = Model.DeleteAll();
                }
                if (message == "Se ejecuto el proceso correctamente.")
                {
                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("El siguiente procesos borrara la totalidad de datos de la tabla seleccionada. ¿Desea continuar?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    switch (this.cmbSeleccion.SelectedIndex)
                    {
                        case 1:
                            message = Model.DeleteAllRemunerations();
                            break;
                        case 2:
                            message = Model.DeleteAllDeductions();
                            break;
                        case 3:
                            message = Model.DeleteAllFamilys();
                            break;
                        case 4:
                            message = Model.DeleteAllJobs();
                            break;
                        case 5:
                            message = Model.DeleteAllDividers();
                            break;
                        case 6:
                            message = Model.DeleteAllAverages();
                            break;
                        case 7:
                            message = Model.DeleteAllFirstDeduction();
                            break;
                        case 8:
                            message = Model.DeleteAllSecondDeductions();
                            break;
                    }
                    if (message == "Se ejecuto el proceso correctamente.")
                    {
                        MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
