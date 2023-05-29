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

namespace PyTCalculoDedEspInc.MenuVer.MenuesIndividuales
{
    public partial class DivisorIndividual : Form
    {
        public int Id { get; set; }        
        public DivisorIndividual(int id)
        {
            InitializeComponent();    
            this.Id = id;

            EmployeeDivider divisor = new EmployeeDivider(id);

            this.txtLegajo.Text = divisor.Legajo.ToString();
            this.txtAnio.Text = divisor.Anio.ToString();
            this.txtMes.Text = divisor.Mes.ToString();
            this.txtDivisor.Text = divisor.Divisor.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                byte divisor = byte.Parse(this.txtDivisor.Text);
                string message = Model.UpdateDivider(this.Id, divisor);
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {        
            string question = "¿Esta seguro de borrar el siguiente registro?";

            if (MessageBox.Show(question, "Pregunta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string message = Model.DeleteDivider(this.Id);

                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
