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
    public partial class FamiliarIndividual : Form
    {
        public EmployeeFamily Family { get; set; }
        public int Id { get; set; }
        public FamiliarIndividual(int id, EmployeeFamily employeeFamily)
        {
            InitializeComponent();
            // Datos para generar el update luego.
            this.Family = employeeFamily;
            this.Id= id;
            // Muestreo de datos.
            this.txtLegajo.Text = employeeFamily.Legajo.ToString();
            this.txtCuil.Text = employeeFamily.Cuil.ToString();
            this.txtAnio.Text = employeeFamily.Anio.ToString();
            this.txtTipDocumento.Text = employeeFamily.TipoDoc.ToString();
            this.txtNumDocumento.Text = employeeFamily.NroDoc.ToString();
            this.txtApellido.Text = employeeFamily.Apellido.ToString();
            this.txtNombre.Text = employeeFamily.Nombre.ToString();
            this.txtFechaNac.Text = employeeFamily.FecNac.ToString("dd/MM/yyyy");
            this.txtMesDesde.Text = employeeFamily.MesDesde.ToString();
            this.txtMesHasta.Text = employeeFamily.MesHasta.ToString();
            this.txtParentesco.Text = employeeFamily.Parentesco.ToString();
            if(employeeFamily.Porcentaje == 100)
            {
                this.cmbPorcentaje.SelectedIndex = 0;
            }
            else
            {
                this.cmbPorcentaje.SelectedIndex = 1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string message = null;

            try
            {
                byte tipoDocumento = byte.Parse(this.txtTipDocumento.Text);
                long nroDoc = long.Parse(this.txtNumDocumento.Text);
                string apellido = this.txtApellido.Text;
                string nombre = this.txtNombre.Text;
                DateTime fechaNac = DateTime.Parse(this.txtFechaNac.Text);
                byte mesDesde = byte.Parse(this.txtMesDesde.Text);
                byte mesHasta = byte.Parse(this.txtMesHasta.Text);
                byte parentesco = byte.Parse(this.txtParentesco.Text);
                byte porcentaje;
            
                if(this.cmbPorcentaje.SelectedIndex == 0)
                {
                    porcentaje = 100;
                }
                else
                {
                    porcentaje = 50;
                }
                this.Family.TipoDoc = tipoDocumento;
                this.Family.NroDoc = nroDoc;
                this.Family.Apellido= apellido;
                this.Family.Nombre = nombre;
                this.Family.FecNac = fechaNac;
                this.Family.MesDesde = mesDesde;
                this.Family.MesHasta = mesHasta;
                this.Family.Parentesco = parentesco;
                this.Family.Porcentaje = porcentaje;

                message = Model.UpdateFamily(this.Id, this.Family);
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                message = ex.Message;
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
