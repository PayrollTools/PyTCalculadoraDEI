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
    internal partial class SalarioIndividual : Form
    {
        public int Legajo { get; set; }
        public short Anio { get; set; }
        public FormType TipoFormulario { get; set; }
        public SalarioIndividual(int legajo, short anio, string sp, FormType tipoFormulario)
        {
            InitializeComponent();
            // Tipo de formulario.
            this.TipoFormulario = tipoFormulario;

            if(tipoFormulario == FormType.RemunerationForm)
            {
                this.Text = "Remuneraciones mensuales";
            }
            else
            {
                this.Text = "Deducciones mensuales";
            }
            // Id para actualización de querys.
            this.Legajo = legajo;
            this.Anio = anio;
            // Datos de los textbox.
            this.txtLegajo.Text = legajo.ToString();
            this.txtAnio.Text = anio.ToString();
            this.txtEnero.Text = Model.GetEmployeeSalary(sp, legajo, anio, 1).ToString();
            this.txtFebrero.Text = Model.GetEmployeeSalary(sp, legajo, anio, 2).ToString();
            this.txtMarzo.Text = Model.GetEmployeeSalary(sp, legajo, anio, 3).ToString();
            this.txtAbril.Text = Model.GetEmployeeSalary(sp, legajo, anio, 4).ToString();
            this.txtMayo.Text = Model.GetEmployeeSalary(sp, legajo, anio, 5).ToString();
            this.txtJunio.Text = Model.GetEmployeeSalary(sp, legajo, anio, 6).ToString();
            this.txtJulio.Text = Model.GetEmployeeSalary(sp, legajo, anio, 7).ToString();
            this.txtAgosto.Text = Model.GetEmployeeSalary(sp, legajo, anio, 8).ToString();
            this.txtSeptiembre.Text = Model.GetEmployeeSalary(sp, legajo, anio, 9).ToString();
            this.txtOctubre.Text = Model.GetEmployeeSalary(sp, legajo, anio, 10).ToString();
            this.txtNoviembre.Text = Model.GetEmployeeSalary(sp, legajo, anio, 11).ToString();
            this.txtDiciembre.Text = Model.GetEmployeeSalary(sp, legajo, anio, 12).ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string messege = null;

            try
            {
                if (this.TipoFormulario == FormType.RemunerationForm)
                {
                    // Proceso de actualización de datos.
                    decimal enero = decimal.Parse(this.txtEnero.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 1, "SP_UpdateRemuneracion",enero);                   
                    decimal febrero = decimal.Parse(this.txtFebrero.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 2, "SP_UpdateRemuneracion", febrero);
                    decimal marzo = decimal.Parse(this.txtMarzo.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 3, "SP_UpdateRemuneracion", marzo);
                    decimal abril = decimal.Parse(this.txtAbril.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 4, "SP_UpdateRemuneracion", abril);
                    decimal mayo = decimal.Parse(this.txtMayo.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 5, "SP_UpdateRemuneracion", mayo);
                    decimal junio = decimal.Parse(this.txtJunio.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 6, "SP_UpdateRemuneracion", junio);
                    decimal julio = decimal.Parse(this.txtJulio.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 7, "SP_UpdateRemuneracion", julio);
                    decimal agosto = decimal.Parse(this.txtAgosto.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 8, "SP_UpdateRemuneracion", agosto);
                    decimal septiembre = decimal.Parse(this.txtSeptiembre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 9, "SP_UpdateRemuneracion", septiembre);
                    decimal octubre = decimal.Parse(this.txtOctubre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 10, "SP_UpdateRemuneracion", octubre);
                    decimal noviembre = decimal.Parse(this.txtNoviembre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 11, "SP_UpdateRemuneracion", noviembre);
                    decimal diciembre = decimal.Parse(this.txtDiciembre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 12, "SP_UpdateRemuneracion", diciembre);                         
                }
                else
                {
                
                    // Proceso de actualización de datos.
                    decimal enero = decimal.Parse(this.txtEnero.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 1, "SP_UpdateDeduccion", enero);
                    decimal febrero = decimal.Parse(this.txtFebrero.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 2, "SP_UpdateDeduccion", febrero);
                    decimal marzo = decimal.Parse(this.txtMarzo.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 3, "SP_UpdateDeduccion", marzo);
                    decimal abril = decimal.Parse(this.txtAbril.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 4, "SP_UpdateDeduccion", abril);
                    decimal mayo = decimal.Parse(this.txtMayo.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 5, "SP_UpdateDeduccion", mayo);
                    decimal junio = decimal.Parse(this.txtJunio.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 6, "SP_UpdateDeduccion", junio);
                    decimal julio = decimal.Parse(this.txtJulio.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 7, "SP_UpdateDeduccion", julio);
                    decimal agosto = decimal.Parse(this.txtAgosto.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 8, "SP_UpdateDeduccion", agosto);
                    decimal septiembre = decimal.Parse(this.txtSeptiembre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 9, "SP_UpdateDeduccion", septiembre);
                    decimal octubre = decimal.Parse(this.txtOctubre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 10, "SP_UpdateDeduccion", octubre);
                    decimal noviembre = decimal.Parse(this.txtNoviembre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 11, "SP_UpdateDeduccion", noviembre);
                    decimal diciembre = decimal.Parse(this.txtDiciembre.Text);
                    messege = Model.UpdateSalary(this.Legajo, this.Anio, 12, "SP_UpdateDeduccion", diciembre);
                }
            }
            catch (Exception ex)
            {
                messege = ex.Message.ToString();
            }
            finally
            {
                MessageBox.Show(messege, "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
