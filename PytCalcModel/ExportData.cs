using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PytCalcModel
{
    internal static class ExportData
    {
        internal static bool ExportEmployees(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeEmployees(data);
                data.Columns[0].ColumnName = "Id";
                data.Columns[1].ColumnName = "Legajo";
                data.Columns[2].ColumnName = "CUIL";
                data.Columns[3].ColumnName = "Nombre y apellido";
                data.Columns[4].ColumnName = "Fecha de Nacimiento";

                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\empleados.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static bool ExportRemunerations(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeRemunerations(data);
                data.Columns[1].ColumnName = "Legajo";
                data.Columns[2].ColumnName = "Nombre y apellido";
                data.Columns[3].ColumnName = "Año";
                data.Columns[4].ColumnName = "Mes";
                data.Columns[5].ColumnName = "Importe";

                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\remuneraciones.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }
        internal static bool ExportDeductions(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeDeductions(data);
                data.Columns[1].ColumnName = "Legajo";
                data.Columns[2].ColumnName = "Nombre y apellido";
                data.Columns[3].ColumnName = "Año";
                data.Columns[4].ColumnName = "Mes";
                data.Columns[5].ColumnName = "Importe";

                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\deducciones.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static bool ExportFamily(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeFamily(data);
                data.Columns[1].ColumnName = "Legajo";
                data.Columns[2].ColumnName = "CUIL";
                data.Columns[3].ColumnName = "Año";
                data.Columns[4].ColumnName = "Tipo de Doc.";
                data.Columns[5].ColumnName = "N° Doc";
                data.Columns[6].ColumnName = "Apellido";
                data.Columns[7].ColumnName = "Nombre";
                data.Columns[8].ColumnName = "Fecha de Nac.";
                data.Columns[9].ColumnName = "Mes Desde";
                data.Columns[10].ColumnName = "Mes Hasta";
                data.Columns[11].ColumnName = "Parentesco";
                data.Columns[12].ColumnName = "Porcentaje";

                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\familiares.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static bool ExportJobs(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeJobs(data);
                data.Columns[1].ColumnName = "Legajo";
                data.Columns[2].ColumnName = "Año";
                data.Columns[3].ColumnName = "CUIL";
                data.Columns[4].ColumnName = "CUIT";
                data.Columns[5].ColumnName = "Denominación";
                data.Columns[6].ColumnName = "Mes";
                data.Columns[7].ColumnName = "Obra Social";
                data.Columns[8].ColumnName = "Seguridad Social";
                data.Columns[9].ColumnName = "Sindicato";
                data.Columns[10].ColumnName = "Ganancia bruta";
                data.Columns[11].ColumnName = "Ret. No Hab.";
                data.Columns[12].ColumnName = "Ajuste";
                data.Columns[13].ColumnName = "Remuneración exenta";
                data.Columns[14].ColumnName = "SAC";
                data.Columns[15].ColumnName = "Hs. Ext. Grav.";
                data.Columns[16].ColumnName = "Hs. Ext. Exentas";
                data.Columns[17].ColumnName = "Material Didactico";
                data.Columns[18].ColumnName = "Movilidad y viaticos";



                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\otros_empleadores.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static bool ExportAverage(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeAverages(data);
                data.Columns[1].ColumnName = "Legajo";               
                data.Columns[2].ColumnName = "Año";
                data.Columns[3].ColumnName = "Mes";
                data.Columns[4].ColumnName = "Importe";

                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\promedios_brutos.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }
        internal static bool ExportFirstDeductions(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeFirstDeductions(data);
                data.Columns[1].ColumnName = "Legajo";
                data.Columns[2].ColumnName = "Año";
                data.Columns[3].ColumnName = "Mes";
                data.Columns[4].ColumnName = "Remuneración Mes";
                data.Columns[5].ColumnName = "Remuneración Mes - OE";
                data.Columns[6].ColumnName = "Deducción Mes";
                data.Columns[7].ColumnName = "Deducción Mes - OE";
                data.Columns[8].ColumnName = "Cargas de familia";
                data.Columns[9].ColumnName = "Deducción personal";
                data.Columns[10].ColumnName = "Deducción";


                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\primer_deduccion.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }
        internal static bool ExportSecondDeduction(DataTable data, string directory)
        {
            try
            {
                SLDocument excelFile = new SLDocument();
                Model.SeeSecondDeductions(data);
                data.Columns[1].ColumnName = "Legajo";
                data.Columns[2].ColumnName = "Año";
                data.Columns[3].ColumnName = "Mes";
                data.Columns[4].ColumnName = "Importe";

                excelFile.ImportDataTable(1, 1, data, true);
                excelFile.SaveAs(directory + @"\segunda_deduccion.xlsx");

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
