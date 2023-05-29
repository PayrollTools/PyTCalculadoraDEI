using PytCalcModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyTCalculoDedEspInc.Configuracion
{
    public partial class ConfigOtrosEmp : Form
    {
        public ConfigOtrosEmp()
        {
            // Obtiene el directorio actual.
            string directory = $@"{Environment.CurrentDirectory}\config.ini";

            InitializeComponent();

            // Remuneraciones
            // CheckBox Ganancia bruta
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "ganancia_bruta", directory) == "true")
            {
                this.cbxGananciaBruta.Checked = true;
            }
            else
            {
                this.cbxGananciaBruta.Checked = false;
            }
            // CheckBox Retenciones no Habituales.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "retnohab", directory) == "true")
            {
                this.cbxRetNoHab.Checked = true;
            }
            else
            {
                this.cbxRetNoHab.Checked = false;
            }
            // CheckBox Ajuste.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "ajuste", directory) == "true")
            {
                this.cbxAjuste.Checked = true;
            }
            else
            {
                this.cbxAjuste.Checked = false;
            }
            // CheckBox Remuneración exenta.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "remuneracion_exenta", directory) == "true")
            {
                this.cbxRemExenta.Checked = true;
            }
            else
            {
                this.cbxRemExenta.Checked = false;
            }
            // CheckBox SAC.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "sac", directory) == "true")
            {
                this.cbxSac.Checked = true;
            }
            else
            {
                this.cbxSac.Checked = false;
            }
            // CheckBox Horas Extras Gravadas.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "hs_extras_gravadas", directory) == "true")
            {
                this.cbxHsExtGravadas.Checked = true;
            }
            else
            {
                this.cbxHsExtGravadas.Checked = false;
            }
            // CheckBox Horas Extras Exentas.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "hs_extras_exentas", directory) == "true")
            {
                this.cbxHsExtExentas.Checked = true;
            }
            else
            {
                this.cbxHsExtExentas.Checked = false;
            }
            // CheckBox Horas Material Didactico.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "material_didactico", directory) == "true")
            {
                this.cbxMaterialDidactico.Checked = true;
            }
            else
            {
                this.cbxMaterialDidactico.Checked = false;
            }
            // CheckBox Horas Movilidad y Viaticos.
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "movilidad_viaticos", directory) == "true")
            {
                this.cbxMovilidadViaticos.Checked = true;
            }
            else
            {
                this.cbxMovilidadViaticos.Checked = false;
            }
            //Deducciones
            // CheckBox Obra Social
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "obra_social", directory) == "true")
            {
                this.cbxObraSocial.Checked = true;
            }
            else
            {
                this.cbxObraSocial.Checked = false;
            }
            // CheckBox Seguridad Social
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "seguridad_social", directory) == "true")
            {
                this.cbxSegSocial.Checked = true;
            }
            else
            {
                this.cbxSegSocial.Checked = false;
            }
            // CheckBox Sindicato
            if (Model.ReadIniFile("OTROS_EMPLEADORES", "sindicato", directory) == "true")
            {
                this.cbxSindicato.Checked = true;
            }
            else
            {
                this.cbxSindicato.Checked = false;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtiene el directorio actual.
            string directory = $@"{Environment.CurrentDirectory}\config.ini";
            // Remuneraciones
            // CheckBox Ganancia Bruta.
            if(this.cbxGananciaBruta.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "ganancia_bruta", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "ganancia_bruta", "false", directory);
            }
            // CheckBox Retenciones no habituales.
            if (this.cbxRetNoHab.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "retnohab", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "retnohab", "false", directory);
            }
            // CheckBox Ajuste.
            if (this.cbxAjuste.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "ajuste", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "ajuste", "false", directory);
            }
            // CheckBox Remuneracion exenta.
            if (this.cbxRemExenta.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "remuneracion_exenta", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "remuneracion_exenta", "false", directory);
            }
            // CheckBox SAC.
            if (this.cbxSac.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "sac", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "sac", "false", directory);
            }
            // CheckBox Horas Extras Gravadas.
            if (this.cbxHsExtGravadas.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "hs_extras_gravadas", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "hs_extras_gravadas", "false", directory);
            }
            // CheckBox Horas Extras Exentas.
            if (this.cbxHsExtExentas.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "hs_extras_exentas", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "hs_extras_exentas", "false", directory);
            }
            // CheckBox Material Didactico.
            if (this.cbxMaterialDidactico.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "material_didactico", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "material_didactico", "false", directory);
            }
            // CheckBox Movilidad y Viaticos.
            if (this.cbxMovilidadViaticos.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "movilidad_viaticos", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "movilidad_viaticos", "false", directory);
            }
            // Deducciones
            // CheckBox Obra Social.
            if (this.cbxObraSocial.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "obra_social", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "obra_social", "false", directory);
            }
            // CheckBox Seguridad Social.
            if (this.cbxSegSocial.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "seguridad_social", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "seguridad_social", "false", directory);
            }
            // CheckBox Sindicato.
            if (this.cbxSindicato.Checked == true)
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "sindicato", "true", directory);
            }
            else
            {
                Model.WriteIniFile("OTROS_EMPLEADORES", "sindicato", "false", directory);
            }
            MessageBox.Show("Modificaciones guardadas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
