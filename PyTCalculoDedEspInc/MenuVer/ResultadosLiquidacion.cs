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

namespace PyTCalculoDedEspInc.MenuVer
{
    public partial class ResultadosLiquidacion : Form
    {       
        public ResultadosLiquidacion(FormType tipoFormulario)
        {
            InitializeComponent();

            DataTable dt = new DataTable();

            switch(tipoFormulario)
            {
                case FormType.AverageForm:
                    this.Text = "Promedios brutos";
                    Model.SeeAverages(dt);
                    this.dvgData.DataSource = dt;
                    this.dvgData.Columns[0].Visible = false;
                    this.dvgData.Columns[1].HeaderText = "Legajo";
                    this.dvgData.Columns[2].HeaderText = "Año";
                    this.dvgData.Columns[3].HeaderText = "Mes";
                    this.dvgData.Columns[4].HeaderText = "Promedio";
                    break;
                case FormType.FirstDeductionForm:
                    this.Text = "D.E.I. Primera parte del penúltimo párrafo";
                    Model.SeeFirstDeductions(dt);
                    this.dvgData.DataSource = dt;
                    this.dvgData.Columns[0].Visible = false;
                    this.dvgData.Columns[1].HeaderText = "Legajo";
                    this.dvgData.Columns[2].HeaderText = "Año";
                    this.dvgData.Columns[3].HeaderText = "Mes";
                    this.dvgData.Columns[4].HeaderText = "Remuneración mensual";
                    this.dvgData.Columns[5].HeaderText = "Remuneración mensual - OE";
                    this.dvgData.Columns[6].HeaderText = "Deducción Mensual - OE";
                    this.dvgData.Columns[1].HeaderText = "Deducción Mensual";
                    this.dvgData.Columns[1].HeaderText = "Cargas de familia";
                    this.dvgData.Columns[1].HeaderText = "Deducción personal";
                    this.dvgData.Columns[1].HeaderText = "Deducción";
                    break;
                case FormType.SecondDeductionForm:
                    this.Text = "D.E.I. Segunda parte del penúltimo párrafo del inciso";
                    Model.SeeSecondDeductions(dt);
                    this.dvgData.DataSource = dt;
                    this.dvgData.Columns[0].Visible = false;
                    this.dvgData.Columns[1].HeaderText = "Legajo";
                    this.dvgData.Columns[2].HeaderText = "Año";
                    this.dvgData.Columns[3].HeaderText = "Mes";
                    this.dvgData.Columns[4].HeaderText = "Deducción";
                    break;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultadosLiquidacion_Load(object sender, EventArgs e)
        {

        }
    }
}
