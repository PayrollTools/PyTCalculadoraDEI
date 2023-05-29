using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PytCalcModel;

namespace PyTCalculoDedEspInc.MenuVer.MenuesIndividuales
{
    public partial class EmpleadoIndividual : Form
    {
        public int id { get; set; }
        
        public EmpleadoIndividual(int id, EmployeeData employeeData)
        {
            InitializeComponent();
            // Id con el que se van a buscar los datos en la base de datos.
            this.id = id;
            // Datos del empleado.
            this.txtLegajo.Text = employeeData.Legajo.ToString();
            this.txtCuil.Text = employeeData.Cuil.ToString();
            this.txtApyNom.Text = employeeData.NombreApellido.ToString();
            this.txtFecIng.Text = employeeData.FecIng.ToString("dd/MM/yyyy");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string messege = null;
            try
            {                
                int legajo = int.Parse(this.txtLegajo.Text);
                long cuil = long.Parse(this.txtCuil.Text);
                string nombreApellido = this.txtApyNom.Text;
                string fechaIng = this.txtFecIng.Text;
                DateTime fecIng;
                DateTime.TryParseExact(fechaIng, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecIng);
                messege = Model.UpdateEmployee(this.id, legajo, cuil, nombreApellido, fecIng);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show(messege,
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(txtLegajo.Text);
            string question = "¿Esta seguro de borrar el siguiente registro?";


            if (MessageBox.Show(question, "Pregunta", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string message = Model.DeleteEmployee(legajo);

                MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
