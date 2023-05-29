using PytCalcModel;
using PyTCalculoDedEspInc.Ayuda;
using PyTCalculoDedEspInc.Configuracion;
using PyTCalculoDedEspInc.MenuImportar;
using PyTCalculoDedEspInc.MenuVer;
using PyTCalculoDedEspInc.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyTCalculoDedEspInc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            switch (cmbVista.SelectedIndex)
            {
                case 0:
                    Model.SeeEmployees(dt);
                    this.dgvTablas.DataSource = dt;
                    //this.dgvTablas.Columns[0].Name = "Id;";
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "CUIL";
                    this.dgvTablas.Columns[3].HeaderText = "Nombre y Apellido";
                    this.dgvTablas.Columns[4].HeaderText = "Fecha de ingreso";
                    break;
                case 1:
                    Model.SeeRemunerations(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "Nombre y Apellido";
                    this.dgvTablas.Columns[3].HeaderText = "Año";
                    this.dgvTablas.Columns[4].HeaderText = "Mes";
                    this.dgvTablas.Columns[5].HeaderText = "Importe";
                    break;
                case 2:
                    Model.SeeDeductions(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "Nombre y Apellido";
                    this.dgvTablas.Columns[3].HeaderText = "Año";
                    this.dgvTablas.Columns[4].HeaderText = "Mes";
                    this.dgvTablas.Columns[5].HeaderText = "Importe";
                    break;
                case 3:
                    Model.SeeFamily(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "CUIL";
                    this.dgvTablas.Columns[3].HeaderText = "Año";
                    this.dgvTablas.Columns[4].HeaderText = "Tipo de doc.";
                    this.dgvTablas.Columns[5].HeaderText = "N° de doc.";
                    this.dgvTablas.Columns[6].HeaderText = "Apellido";
                    this.dgvTablas.Columns[7].HeaderText = "Nombre";
                    this.dgvTablas.Columns[8].HeaderText = "Fec. Nacimiento";
                    this.dgvTablas.Columns[9].HeaderText = "Mes desde";
                    this.dgvTablas.Columns[10].HeaderText = "Mes hasta";
                    this.dgvTablas.Columns[11].HeaderText = "Parentesco";
                    this.dgvTablas.Columns[12].HeaderText = "Porcentaje";
                    break;
                case 4:
                    Model.SeeJobs(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "Año";
                    this.dgvTablas.Columns[3].HeaderText = "CUIL";
                    this.dgvTablas.Columns[4].HeaderText = "CUIT";
                    this.dgvTablas.Columns[5].HeaderText = "Denominación";
                    this.dgvTablas.Columns[6].HeaderText = "Mes";
                    this.dgvTablas.Columns[7].HeaderText = "Obra Social";
                    this.dgvTablas.Columns[8].HeaderText = "Seguridad social";
                    this.dgvTablas.Columns[9].HeaderText = "Sindicato";
                    this.dgvTablas.Columns[10].HeaderText = "Ganancia bruta";
                    this.dgvTablas.Columns[11].HeaderText = "Ret. No Habituales";
                    this.dgvTablas.Columns[12].HeaderText = "Ajuste";
                    this.dgvTablas.Columns[13].HeaderText = "Remuneración exenta";
                    this.dgvTablas.Columns[14].HeaderText = "SAC";
                    this.dgvTablas.Columns[15].HeaderText = "Hs. Extras Grav.";
                    this.dgvTablas.Columns[16].HeaderText = "Hs. Extras Ext.";
                    this.dgvTablas.Columns[17].HeaderText = "Material Didactico";
                    this.dgvTablas.Columns[18].HeaderText = "Movilidad y viaticos";
                    break;
                case 5:
                    Model.SeeAverages(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "Año";
                    this.dgvTablas.Columns[3].HeaderText = "Mes";
                    this.dgvTablas.Columns[4].HeaderText = "Promedio";
                    break;
                case 6:
                    Model.SeeFirstDeductions(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "Año";
                    this.dgvTablas.Columns[3].HeaderText = "Mes";
                    this.dgvTablas.Columns[4].HeaderText = "Remuneración mensual";
                    this.dgvTablas.Columns[5].HeaderText = "Remuneración mensual (O.E.)";
                    this.dgvTablas.Columns[6].HeaderText = "Deducción mensual";
                    this.dgvTablas.Columns[7].HeaderText = "Deducción mensual (O.E.)";
                    this.dgvTablas.Columns[8].HeaderText = "Carga de familia";
                    this.dgvTablas.Columns[9].HeaderText = "Deducción personal";
                    this.dgvTablas.Columns[10].HeaderText = "Ded. Esp. Inc. [P.P.]";
                    break;
                case 7:
                    Model.SeeSecondDeductions(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "Año";
                    this.dgvTablas.Columns[3].HeaderText = "Mes";
                    this.dgvTablas.Columns[4].HeaderText = "Ded. Esp. Inc. [S.P.]";
                    break;
                case 8:
                    Model.SeeDivision(dt);
                    this.dgvTablas.DataSource = dt;
                    this.dgvTablas.Columns[0].Visible = false;
                    this.dgvTablas.Columns[1].HeaderText = "Legajo";
                    this.dgvTablas.Columns[2].HeaderText = "Año";
                    this.dgvTablas.Columns[3].HeaderText = "Mes";
                    this.dgvTablas.Columns[4].HeaderText = "Divisor";
                    break;
            }
        }
        private void mnuCargasFamilia_Click(object sender, EventArgs e)
        {
            ImportarSiradigExcel importarCargaFamilia = new ImportarSiradigExcel(FormType.FamilyForm);
            importarCargaFamilia.ShowDialog();
        }

        private void mnuOtrosEmpleadores_Click(object sender, EventArgs e)
        {
            ImportarSiradigExcel importarOtrosEmpleadores = new ImportarSiradigExcel(FormType.JobsForm);
            importarOtrosEmpleadores.ShowDialog();
        }

        private void mnuEmpleados_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.EmployeeForm);
            importarExcel.ShowDialog();
        }

        private void mnuDeduccion_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.DeductionsForm);
            importarExcel.ShowDialog();
        }

        private void mnuRemuneacion_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.RemunerationForm);
            importarExcel.ShowDialog();
        }

        private void mnuDivisor_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.DivisionForm);
            importarExcel.ShowDialog();
        }

        private void mnuVerEmpleados_Click(object sender, EventArgs e)
        {
            VerEmpleado verEmpleado = new VerEmpleado();
            verEmpleado.ShowDialog();
        }

        private void mnuVerRemuneraciones_Click(object sender, EventArgs e)
        {
            VerTablas verRemuneracion = new VerTablas(FormType.RemunerationForm);
            verRemuneracion.ShowDialog();
        }

        private void mnuVerDeducciones_Click(object sender, EventArgs e)
        {
            VerTablas verDeducciones = new VerTablas(FormType.DeductionsForm);
            verDeducciones.ShowDialog();
        }

        private void mnuVerCargaFamilia_Click(object sender, EventArgs e)
        {
            VerTablas verCargas = new VerTablas(FormType.FamilyForm);
            verCargas.ShowDialog();
        }

        private void mnuVerOtrosEmpleadores_Click(object sender, EventArgs e)
        {
            VerTablas verOtrosEmpleos = new VerTablas(FormType.JobsForm);
            verOtrosEmpleos.ShowDialog();
        }

        private void mnuVerDivisor_Click(object sender, EventArgs e)
        {
            VerTablas verDivisor = new VerTablas(FormType.DivisionForm);
            verDivisor.ShowDialog();
        }

        private void tsbImportarEmpleados_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.EmployeeForm);
            importarExcel.ShowDialog();
        }

        private void tsbImpRemuneraciones_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.RemunerationForm);
            importarExcel.ShowDialog();
        }

        private void tsbImportarDeducciones_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.DeductionsForm);
            importarExcel.ShowDialog();
        }

        private void tsbImportarFamilia_Click(object sender, EventArgs e)
        {
            ImportarSiradigExcel importarCargaFamilia = new ImportarSiradigExcel(FormType.FamilyForm);
            importarCargaFamilia.ShowDialog();
        }

        private void tsbImportarOtrosEmpleadores_Click(object sender, EventArgs e)
        {
            ImportarSiradigExcel importarCargaFamilia = new ImportarSiradigExcel(FormType.JobsForm);
            importarCargaFamilia.ShowDialog();
        }

        private void tsbImportarDivisor_Click(object sender, EventArgs e)
        {
            ImportarExcel importarExcel = new ImportarExcel(FormType.DivisionForm);
            importarExcel.ShowDialog();
        }

        private void itemsOtrosEmpleadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigOtrosEmp formConfig = new ConfigOtrosEmp();
            formConfig.ShowDialog();
        }

        private void deduccionesPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeduccionesPersonales deduccionesPersonales = new DeduccionesPersonales();
            deduccionesPersonales.ShowDialog();
        }

        private void mnuResolucion_Click(object sender, EventArgs e)
        {
            ConfigResoluciones formulario = new ConfigResoluciones();
            formulario.ShowDialog();
        }

        private void mnuCalculo_Click(object sender, EventArgs e)
        {
            DedEspInc formulario = new DedEspInc();
            formulario.ShowDialog();
        }

        private void mnuExportarResultados_Click(object sender, EventArgs e)
        {
            ExportarResultados formulario = new ExportarResultados();
            formulario.ShowDialog();
        }

        private void MainForm_OnExit(object sender, EventArgs e)
        {
            var question = MessageBox.Show("¿Esta seguro de querer cerrar el programa", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (question == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuAcercaDe_Click(object sender, EventArgs e)
        {
            MenuAyuda formulario = new MenuAyuda();
            formulario.ShowDialog();
        }

        private void directoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorioSalida directorioSalida = new DirectorioSalida();
            directorioSalida.ShowDialog();
        }

        private void mnuBorradoBD_Click(object sender, EventArgs e)
        {
            BorradoBBDD formulario = new BorradoBBDD();
            formulario.ShowDialog();
        }

        private void mnuVerPromedioBruto_Click(object sender, EventArgs e)
        {
            ResultadosLiquidacion formulario = new ResultadosLiquidacion(FormType.AverageForm);
            formulario.ShowDialog();
        }

        private void mnuVerDedEspInc_Click(object sender, EventArgs e)
        {
            ResultadosLiquidacion formulario = new ResultadosLiquidacion(FormType.FirstDeductionForm);
            formulario.ShowDialog();
        }
        private void mnuSegundaDeduccion_Click(object sender, EventArgs e)
        {
            ResultadosLiquidacion formulario = new ResultadosLiquidacion(FormType.SecondDeductionForm);
            formulario.ShowDialog();
        }

        private void mnuDocumentacion_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start($"{Environment.CurrentDirectory}/Documentation/Index.html");
        }
    }
}
