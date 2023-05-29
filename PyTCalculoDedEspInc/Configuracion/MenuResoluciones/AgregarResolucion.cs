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

namespace PyTCalculoDedEspInc.Configuracion.InsertResolution
{
    public partial class AgregarResolucion : Form
    {
        public AgregarResolucion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog.Filter = "excel file (*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtFile.Text = openFileDialog.FileName;
                }

            }           
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                string nameResolution = this.txtNameResolution.Text;
                short anio = short.Parse(this.txtAnioResolution.Text);
                byte mesDesde = byte.Parse(this.cmbMesDesde.Text);
                byte mesHasta = byte.Parse(this.cmbMesHasta.Text);
                decimal limiteInferior = decimal.Parse(this.txtLimiteInferior.Text);
                decimal limiteSuperior = decimal.Parse(this.txtLimiteSuperior.Text);

                Resolucion resolucion = new Resolucion(nameResolution, anio, mesDesde, mesHasta, limiteInferior, limiteSuperior);

                if (mesDesde > mesHasta)
                {
                    MessageBox.Show("Mes inicial no puede ser menor a mes final de resolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(limiteInferior >= limiteSuperior)
                {
                    MessageBox.Show("Limite inferior no puede ser menor a limite superior de la resolución", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(nameResolution == "")
                {
                    MessageBox.Show("Debe seleccionar un archivo con el rango de la segunda deducción primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string message = Model.InsertResolution(resolucion, this.txtFile.Text);

                    if (message == "Se finalizo el proceso correctamente.")
                    {
                        MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
