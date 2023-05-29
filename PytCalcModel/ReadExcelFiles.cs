using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace PytCalcModel
{
    internal class ReadExcelFiles
    {
        internal static List<EmployeeData> ImportEmployeesData(string file)
        {
            List<EmployeeData> employees = new List<EmployeeData>();

            SLDocument excelFile = new SLDocument(file);

            int column = 1;
            int row = 2;

            while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
            {
                // Declaración de variables.
                int legajo;
                long cuil;
                string apynom;
                DateTime fecing;
                
                // Lectura de archivo excel.
                string data = excelFile.GetCellValueAsString(row, 1);
                legajo = int.Parse(data);

                data = excelFile.GetCellValueAsString(row, 2);
                cuil = long.Parse(data);

                apynom = excelFile.GetCellValueAsString(row, 3);

                data = excelFile.GetCellValueAsDateTime(row, 4).ToString("dd/MM/yyyy");
                DateTime.TryParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecing);
                
                employees.Add(new EmployeeData(legajo, cuil, apynom, fecing));

                // Verificación de existencia de datos en el archivo.
                if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    break;
                }
                
            }
            return employees;
        }

        internal static List<EmployeeSalary> ImportEmployeeSalary(string file)
        {
            List<EmployeeSalary> employeesalary = new List<EmployeeSalary>();

            SLDocument excelFile = new SLDocument(file);            

            int column = 1;
            int row = 2;

            while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
            {
                // Declaración de variables.
                int legajo;
                string apynom;
                short anio;
                byte mes;
                decimal importe;

                // Lectura de archivo excel.
                string data = excelFile.GetCellValueAsString(row, 1);
                legajo = int.Parse(data);

                apynom = excelFile.GetCellValueAsString(row, 2);

                data = excelFile.GetCellValueAsString(row, 3);
                anio = short.Parse(data);

                data = excelFile.GetCellValueAsString(row, 4);
                mes = byte.Parse(data);

                importe = excelFile.GetCellValueAsDecimal(row, 5);               
                
                employeesalary.Add(new EmployeeSalary(legajo, apynom, anio, mes, importe));

                // Verificación de existencia de datos en el archivo.
                if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return employeesalary;
        }

        internal static List<EmployeeFamily> ImportEmployeeFamily(string file)
        {
            List<EmployeeFamily> employeeFamily = new List<EmployeeFamily>();

            SLDocument excelFile = new SLDocument(file);

            int column = 1;
            int row = 2;

            while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
            {
                // Declaración de variables.
                int legajo;
                long cuil;
                short anio;
                byte tipdoc;
                long nrodoc;
                string apellido;
                string nombre;
                DateTime fecnac;
                byte mesdesde;
                byte meshasta;
                byte parentesco;
                byte porcentaje;

                // Lectura de archivo excel.
                string data = excelFile.GetCellValueAsString(row, 1);
                legajo = int.Parse(data);

                data = excelFile.GetCellValueAsString(row, 2);
                cuil = long.Parse(data);

                data = excelFile.GetCellValueAsString(row, 3);
                anio = short.Parse(data);

                data = excelFile.GetCellValueAsString(row, 4);
                tipdoc = byte.Parse(data);

                data = excelFile.GetCellValueAsString(row, 5);
                nrodoc = long.Parse(data);

                apellido = excelFile.GetCellValueAsString(row, 6);
                nombre = excelFile.GetCellValueAsString(row, 7);

                fecnac = excelFile.GetCellValueAsDateTime(row, 8);

                data = excelFile.GetCellValueAsString(row, 9);
                mesdesde = byte.Parse(data);

                data = excelFile.GetCellValueAsString(row, 10);
                meshasta = byte.Parse(data);

                data = excelFile.GetCellValueAsString(row, 11);
                parentesco = byte.Parse(data);

                data = excelFile.GetCellValueAsString(row, 12);
                porcentaje = byte.Parse(data);

                employeeFamily.Add(new EmployeeFamily(legajo, cuil, anio, tipdoc, nrodoc,
                    apellido, nombre, fecnac, mesdesde, meshasta, parentesco, porcentaje));
                // Verificación de existencia de datos en el archivo.
                if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return employeeFamily;
        }

        internal static List<EmployeeJobs> ImporteEmployeeJobs(string file)
        {
            List<EmployeeJobs> employeeJobs = new List<EmployeeJobs>();
            SLDocument excelFile = new SLDocument(file);

            int column = 1;
            int row = 2;

            while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
            {
                // Declaración de variables.
                int legajo;
                short anio;
                long cuil;
                long cuit;
                string denominacion;
                byte mes;
                decimal obraSocial;
                decimal seguridadSocial;
                decimal sindicato;
                decimal gananciaBruta;
                decimal retNoHabituales;
                decimal ajuste;
                decimal remuneracionExenta;
                decimal sac;
                decimal hsExtrasGravadas;
                decimal hsExtrasExentas;
                decimal materialDidactico;
                decimal movilidadViaticos;

                // Lectura de archivo excel.
                string data = excelFile.GetCellValueAsString(row, 1);
                legajo = int.Parse(data);

                data = excelFile.GetCellValueAsString(row, 2);
                anio = short.Parse(data);

                data = excelFile.GetCellValueAsString(row, 3);
                cuil = long.Parse(data);

                data = excelFile.GetCellValueAsString(row, 4);
                cuit = long.Parse(data);

                denominacion = excelFile.GetCellValueAsString(row, 5);

                data = excelFile.GetCellValueAsString(row, 6);
                mes = byte.Parse(data);

                obraSocial = excelFile.GetCellValueAsDecimal(row, 7);

                seguridadSocial = excelFile.GetCellValueAsDecimal(row, 8);

                sindicato = excelFile.GetCellValueAsDecimal(row, 9);

                gananciaBruta = excelFile.GetCellValueAsDecimal(row, 10);

                retNoHabituales = excelFile.GetCellValueAsDecimal(row, 11);

                ajuste = excelFile.GetCellValueAsDecimal(row, 12);

                remuneracionExenta = excelFile.GetCellValueAsDecimal(row, 13);

                sac = excelFile.GetCellValueAsDecimal(row, 14);

                hsExtrasGravadas = excelFile.GetCellValueAsDecimal(row, 15);

                hsExtrasExentas = excelFile.GetCellValueAsDecimal(row, 16);

                materialDidactico = excelFile.GetCellValueAsDecimal(row, 17);

                movilidadViaticos = excelFile.GetCellValueAsDecimal(row, 18);

                employeeJobs.Add(new EmployeeJobs(
                    legajo,
                    anio,
                    cuil,
                    cuit,
                    denominacion,
                    mes,
                    obraSocial,
                    seguridadSocial,
                    sindicato,
                    gananciaBruta,
                    retNoHabituales,
                    ajuste,
                    remuneracionExenta,
                    sac,
                    hsExtrasGravadas,
                    hsExtrasExentas,
                    materialDidactico,
                    movilidadViaticos));

                // Verificación de existencia de datos en el archivo.
                if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return employeeJobs;
        }

        internal static List<EmployeeDivider> ImportEmployeeDivisions(string file)
        {
            List<EmployeeDivider> employeeDivisions = new List<EmployeeDivider>();
            SLDocument excelFile = new SLDocument(file);

            int column = 1;
            int row = 2;

            while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
            {
                // Declaración de variables.
                int legajo;
                short anio;
                byte mes;
                byte divisor;

                // Lectura de archivo excel.
                string data = excelFile.GetCellValueAsString(row, 1);
                legajo = int.Parse(data);

                data = excelFile.GetCellValueAsString(row, 2);
                anio = short.Parse(data);

                data = excelFile.GetCellValueAsString(row, 3);
                mes = byte.Parse(data);

                data = excelFile.GetCellValueAsString(row, 4);
                divisor = byte.Parse(data);

                employeeDivisions.Add(new EmployeeDivider(legajo, anio, mes, divisor));

                // Verificación de existencia de datos en el archivo.
                if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return employeeDivisions;
        }
        /*
         * Queries esquema system
         */
        internal static List<RangosSegundaDeduccion> ImportarRangosSegundaDeduc (string file, string resolutionName)
        {
            List<RangosSegundaDeduccion> rangosSegundaDeduccion = new List<RangosSegundaDeduccion>();
            SLDocument excelFile = new SLDocument(file);

            int column = 1;
            int row = 2;

            while (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row, column)) == false)
            {
                // Declaración de variables.
                decimal limiteInferior;
                decimal limiteSuperior;
                decimal deduccion;
                
                string data = excelFile.GetCellValueAsString(row, 1);
                limiteInferior = decimal.Parse(data);

                data = excelFile.GetCellValueAsString(row, 2);
                limiteSuperior = decimal.Parse(data);

                data = excelFile.GetCellValueAsString(row, 3);
                deduccion = decimal.Parse(data);

                rangosSegundaDeduccion.Add(new RangosSegundaDeduccion(resolutionName, limiteInferior, limiteSuperior, deduccion));

                // Verificación de existencia de datos en el archivo.
                if (string.IsNullOrEmpty(excelFile.GetCellValueAsString(row + 1, column)) == false)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    break;
                }
            }
            return rangosSegundaDeduccion;
        }
    }
}
