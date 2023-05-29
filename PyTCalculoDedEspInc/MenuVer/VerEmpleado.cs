using PytCalcModel;
using PyTCalculoDedEspInc.MenuVer.MenuesIndividuales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyTCalculoDedEspInc.MenuVer
{
    public partial class VerEmpleado : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public VerEmpleado()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cuando se genera una instancia del formulario, el evento de carga del mismo, setea 
        /// los titulos de las columnas del data gried view y esconde la columna id.
        /// </summary>
        private void VerEmpleado_Load(object sender, EventArgs e)
        {
            DataTable ds = new DataTable();
            this.dgvEmpleado.DataSource = Model.SeeEmployees(ds);
            this.dgvEmpleado.Columns[0].Visible = false;
            this.dgvEmpleado.Columns[1].HeaderText = "Legajo";
            this.dgvEmpleado.Columns[2].HeaderText = "CUIL";
            this.dgvEmpleado.Columns[3].HeaderText = "Nombre y Apellido";
            this.dgvEmpleado.Columns[4].HeaderText = "Fecha de ingreso";
        }
        /// <summary>
        /// Cierre de la instancia.
        /// </summary>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVer_Click(object sender, EventArgs e)
        {           
            try
            {
                string rowValue = null;
                
                rowValue = this.dgvEmpleado.CurrentCell.RowIndex.ToString();
            
                int x = int.Parse(rowValue);
                int id = int.Parse(this.dgvEmpleado.Rows[x].Cells[0].Value.ToString());
                
                EmployeeData employeeData= new EmployeeData(id);
                EmpleadoIndividual formulario = new EmpleadoIndividual(id, employeeData);
                
                if(formulario.ShowDialog(this) == DialogResult.OK)
                {
                    DataTable ds = new DataTable();
                    this.dgvEmpleado.DataSource = Model.SeeEmployees(ds);
                }                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar un registro primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }                                                               
}
