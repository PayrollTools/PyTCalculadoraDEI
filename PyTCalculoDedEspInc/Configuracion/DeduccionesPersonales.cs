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

namespace PyTCalculoDedEspInc.Configuracion
{
    public partial class DeduccionesPersonales : Form
    {
        public DeduccionesPersonales()
        {
            InitializeComponent();
        }

        private void DeduccionesPersonales_Load(object sender, EventArgs e)
        {
            List<short> years = new List<short>();

            Model.GetDedEspYears(years);

            for(int i = 0; i < years.Count; i++)
            {
                this.cmbAnio.Items.Add(years[i].ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            short anioSelect = short.Parse(this.cmbAnio.Text);
            bool anioNuevo = true;
            
            List<short> years = new List<short>();
            try
            {
                Model.GetDedEspYears(years);

                for(int i = 0; i < years.Count; i++)
                {
                    if (years[i] == anioSelect)
                    {
                        anioNuevo = false;
                    }
                }

                if(anioNuevo == true)
                {
                    decimal[] valores =
                    {
                        decimal.Parse(this.txtGananNoImp.Text),
                        decimal.Parse(this.txtConyuge.Text),
                        decimal.Parse(this.txtHijo.Text),
                        decimal.Parse(this.txtHijoInc.Text),
                        decimal.Parse(this.txtDedEspcial.Text)
                    };

                    string message = Model.InsertDeduccionPersonal(anioSelect, valores);

                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    decimal[] valores =
                    {
                        decimal.Parse(this.txtGananNoImp.Text),
                        decimal.Parse(this.txtConyuge.Text),
                        decimal.Parse(this.txtHijo.Text),
                        decimal.Parse(this.txtHijoInc.Text),
                        decimal.Parse(this.txtDedEspcial.Text)
                    };

                    string message = Model.UpdateDeduccionPersonal(anioSelect, valores);

                    MessageBox.Show(message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            short anio = short.Parse(this.cmbAnio.SelectedItem.ToString());

            this.txtGananNoImp.Text = Model.GetGananciasNoImponibles(anio).ToString();
            this.txtConyuge.Text = Model.GetConyuge(anio).ToString();
            this.txtHijo.Text = Model.GetHijo(anio).ToString();
            this.txtHijoInc.Text = Model.GetHijoIncapacitado(anio).ToString();
            this.txtDedEspcial.Text = Model.GetDeduccionEspecial(anio).ToString();

        }
    }
}
