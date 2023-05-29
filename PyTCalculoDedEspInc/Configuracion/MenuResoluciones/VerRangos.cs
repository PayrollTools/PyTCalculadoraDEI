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

namespace PyTCalculoDedEspInc.Configuracion.MenuResoluciones
{
    public partial class VerRangos : Form
    {
        public VerRangos(string resolutionName)
        {
            InitializeComponent();
            
            // Datos del data grid view.
            DataTable dataTable = new DataTable();
            
            dataTable = Model.SeeAllResolutions(dataTable);
            dataTable.DefaultView.RowFilter = $"resolucion like '{resolutionName}%'";
            this.dvgRangosResolution.DataSource  = dataTable;

            this.dvgRangosResolution.Columns[0].Visible = false;
            this.dvgRangosResolution.Columns[1].HeaderText = "Nombre Resol.";
            this.dvgRangosResolution.Columns[2].HeaderText = "Limite Inferior";
            this.dvgRangosResolution.Columns[3].HeaderText = "Limite Superior";
            this.dvgRangosResolution.Columns[4].HeaderText = "Deducción";
            
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
