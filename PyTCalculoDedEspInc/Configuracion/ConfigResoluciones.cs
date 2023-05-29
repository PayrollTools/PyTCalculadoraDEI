using PytCalcModel;
using PyTCalculoDedEspInc.Configuracion.InsertResolution;
using PyTCalculoDedEspInc.Configuracion.MenuResoluciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyTCalculoDedEspInc.Configuracion
{
    public partial class ConfigResoluciones : Form
    {
        public ConfigResoluciones()
        {
            InitializeComponent();
        }
        private void ConfigResoluciones_Load(object sender, EventArgs e)
        {
            List<string> resolutions = new List<string>();
            Model.GetResolutionsName(resolutions);
            for(int i = 0; i < resolutions.Count; i++)
            {
                this.cmbResolucion.Items.Add(resolutions[i]);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbResolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resolutionName = this.cmbResolucion.Text;

            Resolucion resolucion = new Resolucion();
            Model.GetResolutionInfo(resolucion, resolutionName);

            this.txtAnio.Text = resolucion.Anio.ToString();
            this.txtMesDesde.Text = resolucion.MesDesde.ToString();
            this.txtMesHasta.Text = resolucion.MesHasta.ToString();
            this.txtImporteDesde.Text = resolucion.LimiteInferior.ToString();
            this.txtImporteHasta.Text = resolucion.LimiteSuperior.ToString();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerRangos_Click(object sender, EventArgs e)
        {
            bool checkResolutionName = false;

            List<string> resolutions = new List<string>();
            Model.GetResolutionsName(resolutions);

            for(int i = 0; i < resolutions.Count; i++)
            {
                if(this.cmbResolucion.Text == resolutions[i])
                {
                    checkResolutionName = true;
                    break;
                }
            }

            if (checkResolutionName == false)
            {
                MessageBox.Show("Debe seleccionar una resolución primero",
                    "Error",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else
            {
               
               VerRangos verRangos = new VerRangos(this.cmbResolucion.Text);
               verRangos.ShowDialog();
            }
        }

        private void btnAgregarResol_Click(object sender, EventArgs e)
        {
            AgregarResolucion formulario = new AgregarResolucion();
            
            if(formulario.ShowDialog() == DialogResult.OK)
            {
                this.cmbResolucion.Items.Clear();
                List<string> resolutions = new List<string>();
                Model.GetResolutionsName(resolutions);
                for (int i = 0; i < resolutions.Count; i++)
                {                    
                    this.cmbResolucion.Items.Add(resolutions[i]);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que exista
                if (this.cmbResolucion.Text == "")
                {
                    MessageBox.Show("Debe seleccionar una resolución primero",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                byte mesDesde = byte.Parse(this.txtMesDesde.Text);
                byte mesHasta = byte.Parse(this.txtMesHasta.Text);
                decimal importeDesde = decimal.Parse(this.txtImporteDesde.Text);
                decimal importeHasta = decimal.Parse(this.txtImporteHasta.Text);

                string message = Model.UpdateResolution(mesDesde, mesHasta, importeDesde, importeHasta, this.cmbResolucion.Text);

                if(message == "Se finalizo el proceso correctamente")
                {
                    MessageBox.Show(message,
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {           
            if (this.cmbResolucion.Text == "")
            {
                MessageBox.Show("Debe seleccionar una resolución primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string message = Model.DeleteResolution(this.cmbResolucion.Text);

                if (message == "Se finalizo el proceso correctamente")
                {
                    MessageBox.Show(message,
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    
                    this.cmbResolucion.Items.Clear();
                    
                    List<string> resolutions = new List<string>();
                    
                    Model.GetResolutionsName(resolutions);
                    
                    for (int i = 0; i < resolutions.Count; i++)
                    {
                        this.cmbResolucion.Items.Add(resolutions[i]);
                    }
                }
                else
                {
                    MessageBox.Show(message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
