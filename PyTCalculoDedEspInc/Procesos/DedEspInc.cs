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
    public partial class DedEspInc : Form
    {
        public DedEspInc()
        {
            InitializeComponent();

            List<int> listOfEmployees = new List<int>();
            Model.GetEmployees(listOfEmployees);

            for(int i = 0; i < listOfEmployees.Count; i++)
            {
                this.cmbLegajoDesde.Items.Add(listOfEmployees[i]);
                this.cmbLegajoHasta.Items.Add(listOfEmployees[i]);
            }

            List<short> listOfYears = new List<short>();
            Model.GetDedEspYears(listOfYears);

            for(int i = 0;i < listOfYears.Count; i++)
            {
                this.cmbAnio.Items.Add(listOfYears[i]);
            }
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            short anio = 0;
            byte mesDesde = 0;
            byte mesHasta = 0;
            int legajoDesde = 0;
            int legajoHasta = 0;

            this.Enabled = false;
            
            // Obtengo variables para llamar al liquidador.
            if (this.cmbAnio.SelectedIndex != -1)
            {
                anio = short.Parse(this.cmbAnio.Text);
            }
            if (this.cmbMesDesde.SelectedIndex != -1)
            {
                mesDesde = byte.Parse(this.cmbMesDesde.Text);
            }
            if (this.cmbMesHasta.SelectedIndex != -1)
            {
                mesHasta = byte.Parse(this.cmbMesHasta.Text);
            }
            if (this.cmbLegajoDesde.SelectedIndex != -1)
            {
                legajoDesde = int.Parse(this.cmbLegajoDesde.Text);
            }
            if (this.cmbLegajoHasta.SelectedIndex != -1)
            {
                legajoHasta = int.Parse(this.cmbLegajoHasta.Text);
            }

            // Manejo de errores.
            if (this.cmbAnio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un periodo primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (this.cmbLegajoDesde.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un legajo inicial primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (this.cmbLegajoHasta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un legajo de finalización primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (this.cmbMesDesde.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un mes inicial primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (this.cmbMesHasta.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un legajo de finalización primero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if(mesDesde > mesHasta)
            {
                MessageBox.Show("Mes de inicio no puede ser mayor al de finalización",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (legajoDesde > legajoHasta)
            {
                MessageBox.Show("Legajo de inicio no puede ser mayor al de finalización",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // LLamo al liquidador si no veo errores.
            else
            {
                string message = Model.Liquidador(anio, mesDesde, mesHasta, legajoDesde, legajoHasta);

                if(message == "Proceso finalizado correctamente")
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

            this.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
