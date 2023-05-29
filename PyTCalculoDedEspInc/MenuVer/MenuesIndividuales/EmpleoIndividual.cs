using PytCalcModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyTCalculoDedEspInc.MenuVer.MenuesIndividuales
{
    public partial class EmpleoIndividual : Form
    {
        public int Id { get; set; }
        public EmployeeJobs Empleo { get; set; }
        public EmpleoIndividual(int id, EmployeeJobs employeeJobs)
        {
            InitializeComponent();
            // Datos
            this.Id = id;
            this.Empleo = employeeJobs;
            // Visualización de la informacion
            this.txtLegajo.Text = employeeJobs.Legajo.ToString();
            this.txtAnio.Text = employeeJobs.Anio.ToString();
            this.txtCuil.Text = employeeJobs.Cuil.ToString();
            this.txtCuit.Text = employeeJobs.Cuit.ToString();
            this.txtDenominacion.Text = employeeJobs.Denominacion.ToString();
            this.txtMes.Text = employeeJobs.Mes.ToString();
            this.txtObraSocial.Text = employeeJobs.ObraSocial.ToString();
            this.txtSegSocial.Text = employeeJobs.SeguridadSocial.ToString();
            this.txtSindicato.Text = employeeJobs.Sindicato.ToString();
            this.txtGananBruta.Text = employeeJobs.GananciaBruta.ToString();
            this.txtRetNoHab.Text = employeeJobs.RetNoHabituales.ToString();
            this.txtAjuste.Text = employeeJobs.Ajuste.ToString();
            this.txtRemExenta.Text = employeeJobs.RemuneracionExenta.ToString();
            this.txtSac.Text = employeeJobs.Sac.ToString();
            this.txtHsExtGrav.Text = employeeJobs.HsExtrasGravadas.ToString();
            this.txtHsExtExentas.Text = employeeJobs.HsExtrasExentas.ToString();
            this.txtMatDidact.Text = employeeJobs.MaterialDidactico.ToString();
            this.txtMovViaticos.Text = employeeJobs.MovilidadViaticos.ToString();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Empleo.ObraSocial = decimal.Parse(this.txtObraSocial.Text);
                this.Empleo.SeguridadSocial = decimal.Parse(this.txtSegSocial.Text);
                this.Empleo.Sindicato = decimal.Parse(this.txtSindicato.Text);
                this.Empleo.GananciaBruta = decimal.Parse(this.txtGananBruta.Text);
                this.Empleo.RetNoHabituales = decimal.Parse(this.txtRetNoHab.Text);
                this.Empleo.Ajuste = decimal.Parse(this.txtAjuste.Text);
                this.Empleo.RemuneracionExenta = decimal.Parse(this.txtRemExenta.Text);
                this.Empleo.Sac = decimal.Parse(this.txtSac.Text);
                this.Empleo.HsExtrasGravadas = decimal.Parse(this.txtHsExtGrav.Text);
                this.Empleo.HsExtrasExentas = decimal.Parse(this.txtHsExtExentas.Text);
                this.Empleo.MaterialDidactico = decimal.Parse(this.txtMatDidact.Text);
                this.Empleo.MovilidadViaticos = decimal.Parse(this.txtMovViaticos.Text);

                string message = Model.UpdateJob(this.Id, this.Empleo);
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {          
            string question = "¿Esta seguro de borrar el siguiente registro?";

            if (MessageBox.Show(question, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string message = Model.DeleteEmployee(this.Id);

                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
