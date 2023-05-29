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

namespace PyTCalculoDedEspInc.Procesos
{
    public partial class ExportarResultados : Form
    {
        public ExportarResultados()
        {
            InitializeComponent();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string message = null;

            switch(this.cmbSeleccion.SelectedIndex)
            {
                case 0:
                    message = Model.ExportInfo(0);
                    break;
                case 1:
                    message = Model.ExportInfo(1);
                    break;
                case 2:
                    message = Model.ExportInfo(2);
                    break;
                case 3:
                    message = Model.ExportInfo(3);
                    break;
                case 4:
                    message = Model.ExportInfo(4);
                    break;
                case 5:
                    message = Model.ExportInfo(5);
                    break;
                case 6:
                    message = Model.ExportInfo(6);
                    break;
                case 7:
                    message = Model.ExportInfo(7);
                    break;
            }
            // Mensaje a usuario.
            if (message == "Exportación de datos finalizada.")
            {
                MessageBox.Show("Exportación de datos finalizada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se produjo un error en el proceso de exportación de datos. Proceso abortado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
