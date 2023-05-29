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
    public partial class VerTablas : Form
    {
        // Determina que tipo de formulario va a ser.
        internal FormType TipoFormulario { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="typeForm"></param>
        internal VerTablas(FormType typeForm)
        {
            InitializeComponent();
            this.TipoFormulario = typeForm;

            switch (this.TipoFormulario)
            {
                case FormType.RemunerationForm:
                    this.Text = "Ver Remuneraciones Mensuales";                 
                    break;
                case FormType.DeductionsForm:
                    this.Text = "Ver Deducciones Mensuales";
                    break;
                case FormType.FamilyForm:
                    this.Text = "Ver Cargas de Familia";
                    break;
                case FormType.JobsForm:
                    this.Text = "Ver Otros Empleadores";
                    break;
                case FormType.DivisionForm:
                    this.Text = "Ver divisores";
                    break;
            }
        }
        /// <summary>
        /// Cuando se genera una instancia del formulario, se cargan los datos 
        /// cuando se actualiza el mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerSalario_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            switch (this.TipoFormulario) 
            {
                case FormType.RemunerationForm:
                    Model.SeeRemunerations(dt);
                    this.dgvSalario.DataSource= dt;
                    this.dgvSalario.Columns[0].Visible = false;
                    this.dgvSalario.Columns[0].Visible = false;
                    this.dgvSalario.Columns[1].HeaderText = "Legajo";
                    this.dgvSalario.Columns[2].HeaderText = "Nombre y Apellido";
                    this.dgvSalario.Columns[3].HeaderText = "Año";
                    this.dgvSalario.Columns[4].HeaderText = "Mes";
                    this.dgvSalario.Columns[5].HeaderText = "Importe";
                    break;
                case FormType.DeductionsForm:
                    Model.SeeDeductions(dt);
                    this.dgvSalario.DataSource = dt;
                    this.dgvSalario.Columns[0].Visible = false;
                    this.dgvSalario.Columns[1].HeaderText = "Legajo";
                    this.dgvSalario.Columns[2].HeaderText = "Nombre y Apellido";
                    this.dgvSalario.Columns[3].HeaderText = "Año";
                    this.dgvSalario.Columns[4].HeaderText = "Mes";
                    this.dgvSalario.Columns[5].HeaderText = "Importe";
                    break;
                case FormType.FamilyForm:
                    Model.SeeFamily(dt);
                    this.dgvSalario.DataSource = dt;
                    this.dgvSalario.Columns[0].Visible = false;
                    this.dgvSalario.Columns[1].HeaderText = "Legajo";
                    this.dgvSalario.Columns[2].HeaderText = "CUIL";
                    this.dgvSalario.Columns[3].HeaderText = "Año";
                    this.dgvSalario.Columns[4].HeaderText = "Tipo de doc.";
                    this.dgvSalario.Columns[5].HeaderText = "N° de doc.";
                    this.dgvSalario.Columns[6].HeaderText = "Apellido";
                    this.dgvSalario.Columns[7].HeaderText = "Nombre";
                    this.dgvSalario.Columns[8].HeaderText = "Fec. Nacimiento";
                    this.dgvSalario.Columns[9].HeaderText = "Mes desde";
                    this.dgvSalario.Columns[10].HeaderText = "Mes hasta";
                    this.dgvSalario.Columns[11].HeaderText = "Parentesco";
                    this.dgvSalario.Columns[12].HeaderText = "Porcentaje";
                    break;
                case FormType.JobsForm:
                    Model.SeeJobs(dt);
                    this.dgvSalario.DataSource = dt;
                    this.dgvSalario.Columns[0].Visible = false;
                    this.dgvSalario.Columns[1].HeaderText = "Legajo";
                    this.dgvSalario.Columns[2].HeaderText = "Año";
                    this.dgvSalario.Columns[3].HeaderText = "CUIL";
                    this.dgvSalario.Columns[4].HeaderText = "CUIT";
                    this.dgvSalario.Columns[5].HeaderText = "Denominación";
                    this.dgvSalario.Columns[6].HeaderText = "Mes";
                    this.dgvSalario.Columns[7].HeaderText = "Obra Social";
                    this.dgvSalario.Columns[8].HeaderText = "Seguridad social";
                    this.dgvSalario.Columns[9].HeaderText = "Sindicato";
                    this.dgvSalario.Columns[10].HeaderText = "Ganancia bruta";
                    this.dgvSalario.Columns[11].HeaderText = "Ret. No Habituales";
                    this.dgvSalario.Columns[12].HeaderText = "Ajuste";
                    this.dgvSalario.Columns[13].HeaderText = "Remuneración exenta";
                    this.dgvSalario.Columns[14].HeaderText = "SAC";
                    this.dgvSalario.Columns[15].HeaderText = "Hs. Extras Grav.";
                    this.dgvSalario.Columns[16].HeaderText = "Hs. Extras Ext.";
                    this.dgvSalario.Columns[17].HeaderText = "Material Didactico";
                    this.dgvSalario.Columns[18].HeaderText = "Movilidad y viaticos";
                    break;
                case FormType.DivisionForm: 
                    Model.SeeDivision(dt);
                    this.dgvSalario.DataSource = dt;
                    this.dgvSalario.Columns[0].Visible = false;
                    this.dgvSalario.Columns[1].HeaderText = "Legajo";
                    this.dgvSalario.Columns[2].HeaderText = "Año";
                    this.dgvSalario.Columns[3].HeaderText = "Mes";
                    this.dgvSalario.Columns[4].HeaderText = "Divisor";
                    break;                  
            }
        }
        /// <summary>
        /// Cierre del formulario.
        /// </summary>
        private void btnSalir_Click(object sender, EventArgs e)
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
                
                rowValue = this.dgvSalario.CurrentCell.RowIndex.ToString();

                int x = int.Parse(rowValue);
                int id = int.Parse(this.dgvSalario.Rows[x].Cells[0].Value.ToString());

                switch (this.TipoFormulario)
                {
                    case FormType.RemunerationForm:
                        int legajo = int.Parse(this.dgvSalario.Rows[x].Cells[1].Value.ToString());
                        short anio = short.Parse(this.dgvSalario.Rows[x].Cells[3].Value.ToString());
                        SalarioIndividual remuneraciones = new SalarioIndividual(legajo, anio, "SP_GetEmployeeRemuneration", FormType.RemunerationForm);
                        if(remuneraciones.ShowDialog()== DialogResult.OK)
                        {
                            DataTable dt = new DataTable();
                            Model.SeeRemunerations(dt);
                            this.dgvSalario.DataSource = dt;
                        }
                        break;
                    case FormType.DeductionsForm:
                        legajo = int.Parse(this.dgvSalario.Rows[x].Cells[1].Value.ToString());
                        anio = short.Parse(this.dgvSalario.Rows[x].Cells[3].Value.ToString());
                        SalarioIndividual deducciones = new SalarioIndividual(legajo, anio, "SP_GetEmployeeDeduction", FormType.RemunerationForm);
                        if (deducciones.ShowDialog() == DialogResult.OK)
                        {
                            DataTable dt = new DataTable();
                            Model.SeeDeductions(dt);
                            this.dgvSalario.DataSource = dt;
                        }
                        break;
                    case FormType.FamilyForm:
                        EmployeeFamily employeeFamily = new EmployeeFamily(id);
                        FamiliarIndividual familiar = new FamiliarIndividual(id, employeeFamily);
                        if (familiar.ShowDialog() == DialogResult.OK)
                        {
                            DataTable dt = new DataTable();
                            Model.SeeFamily(dt);
                            this.dgvSalario.DataSource = dt;
                        }
                        break;
                    case FormType.JobsForm:
                        EmployeeJobs employeeJobs = new EmployeeJobs(id);
                        EmpleoIndividual empleo = new EmpleoIndividual(id, employeeJobs);
                        if(empleo.ShowDialog() == DialogResult.OK)
                        {
                            DataTable dt = new DataTable();
                            Model.SeeJobs(dt);
                            this.dgvSalario.DataSource = dt;
                        }
                        break;
                    case FormType.DivisionForm:
                        DivisorIndividual divisor = new DivisorIndividual(id);
                        if(divisor.ShowDialog() == DialogResult.OK)
                        {
                            DataTable dt = new DataTable();
                            Model.SeeDivision(dt);
                            this.dgvSalario.DataSource = dt;
                        }
                        break;
                }
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar un registro primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
