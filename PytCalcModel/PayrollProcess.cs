using DocumentFormat.OpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PytCalcModel
{
    internal class PayrollProcess
    {
        
        private static byte CalcEmployeeDivider(int legajo, short anio, byte mes)
        {
            byte result;

            Resolucion monthResolution = new Resolucion();

            ConsultQueries.GetMonthResolution(monthResolution, anio, mes);

            if (ConsultQueries.GetEmployeeDivision(legajo, anio, mes) > 0)
            {
                // Si existe un divisor devuelvo el mismo.                
                return ConsultQueries.GetEmployeeDivision(legajo, anio, mes); ;
            }
            else
            {
                // Caso contrario calcula el divisor.
                CultureInfo dateFormat = new CultureInfo("es-ES");

                DateTime? dateOfAdmission = ConsultQueries.GetDateOfAdmission(legajo);

                string yearOfAdmission = dateOfAdmission.HasValue ? dateOfAdmission.Value.ToString("yyyy", dateFormat) : "0";
                short year = short.Parse(yearOfAdmission);

                string monthOfAdmission = dateOfAdmission.HasValue ? dateOfAdmission.Value.ToString("MM", dateFormat) : "0";
                byte month = byte.Parse(monthOfAdmission);


                // Si el año de ingreso es igual al del calculo.
                if (year == monthResolution.Anio)
                {
                    // Si el mes de ingreso es mayor al inicio de la resolución.
                    if (month > monthResolution.MesDesde)
                    {
                        int x = mes - month + 1;
                        result = (byte)x;
                    }
                    else
                    {
                        int x = mes - monthResolution.MesDesde + 1;
                        result = (byte)x;
                    }
                }
                // Resto de los casos.
                else
                {
                    int x = mes - monthResolution.MesDesde + 1;
                    result = (byte)x;
                }
                return result;
            }
        }

        internal static EmployeeAverage PromedioBrutoMensual(int legajo, short anio, byte mes)
        {
            decimal result;

            // Obtengo el divisor para el calculo del promedio bruto mensual.
            int divisor = PayrollProcess.CalcEmployeeDivider(legajo, anio, mes);

            Resolucion monthResolution = new Resolucion();
            ConsultQueries.GetMonthResolution(monthResolution, anio, mes);

            // Obtengo la sumatoria de meses.
            decimal sumatoria = ConsultQueries.GetSumMonthImport( 
                legajo,
                anio,
                monthResolution.MesDesde,
                mes,
                "SP_GetSumEmployeeRemunerations");

            // Sumatoria de importes correspondientes a otros empleadores.
            string path = $@"{Environment.CurrentDirectory}\config.ini";
            IniFile iniFile = new IniFile(path);
            
            if(iniFile.ReadIniFile("OTROS_EMPLEADORES", "ganancia_bruta") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_GananBruta");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "retnohab") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_RetNoHab");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "ajuste") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_Ajuste");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "remuneracion_exenta") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_RemExenta");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "sac") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_SAC");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "hs_extras_gravadas") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_HsExtrasGrav");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "hs_extras_exentas") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_HsExtrasExentas");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "material_didactico") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_MaterialDidactico");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "movilidad_viaticos") == "true")
            {
                sumatoria += ConsultQueries.GetSumMonthImport(legajo, anio, monthResolution.MesDesde, mes, "SP_GetEmployeeSumOE_MovilidadViaticos");
            }

            result = sumatoria / divisor;

            EmployeeAverage employeeAverage = new EmployeeAverage();
            employeeAverage.Legajo = legajo;
            employeeAverage.Anio = anio;
            employeeAverage.Mes = mes;            
            employeeAverage.Promedio = result;

            return employeeAverage;
        }
        /// <summary>
        /// Calculo de la primera deducción especial incrementada.
        /// </summary>
        /// <param name="legajo">Legajo a calcular</param>
        /// <param name="anio">Año a calcular</param>
        /// <param name="mes">Mes a calcular</param>
        /// <returns></returns>
        internal static EmployeeFirstDeduction PrimerParrafo(int legajo, short anio, byte mes)
        {
            decimal result = 0;
            // Suma remuneraciones mensual
            decimal remuneracionMensual = ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeRemuneration");
            // Suma deduccion mensual
            decimal deduccionMensual = ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeDeduction");
            // Suma remuneración otros empleadores
            decimal remuOtrosEmpleadores = 0;

            string path = $@"{Environment.CurrentDirectory}\config.ini";
            IniFile iniFile = new IniFile(path);
            // Suma remuneraciones de otros empleos.
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "ganancia_bruta") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_GananBruta");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "retnohab") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_RetNoHab");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "ajuste") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_Ajuste");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "remuneracion_exenta") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_RemExenta");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "sac") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_SAC");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "hs_extras_gravadas") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_HsExtrasGrav");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "hs_extras_exentas") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_HsExtrasExentas");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "material_didactico") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_MaterialDidac");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "movilidad_viaticos") == "true")
            {
                remuOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_MovViaticos");
            }
            // Suma deduccion otros empleadores
            decimal deduccionOtrosEmpleadores = 0;
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "obra_social") == "true")
            {
                deduccionOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_ObraSocial");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "seguridad_social") == "true")
            {
                deduccionOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_SegSocial");
            }
            if (iniFile.ReadIniFile("OTROS_EMPLEADORES", "sindicato") == "true")
            {
                deduccionOtrosEmpleadores += ConsultQueries.GetMonthImport(legajo, anio, mes, "SP_GetEmployeeOE_Sindicato");
            }
            // Suma cargas de familia
            decimal cargaDeFamilia = 0;
            decimal valorHijo = ConsultQueries.GetPersonalDeduction(anio, "Hijo");
            decimal valorHijoIncapacitado = ConsultQueries.GetPersonalDeduction(anio, "Hijo incapacitado para el trabajo");
            decimal valorConyuge = ConsultQueries.GetPersonalDeduction(anio, "Cónyuge");
            byte cantConyuge = ConsultQueries.CountWife(legajo, anio, mes, 1);
            decimal cantHijo = ConsultQueries.CountFamily(legajo, anio, mes, 3);
            cantHijo += ConsultQueries.CountFamily(legajo, anio, mes, 30);
            cantHijo /= 100;
            decimal cantHijoIncapacitado = ConsultQueries.CountFamily(legajo, anio, mes, 31);
            cantHijoIncapacitado += ConsultQueries.CountFamily(legajo, anio, mes, 32);
            cantHijoIncapacitado /= 100;
            cargaDeFamilia = valorHijo * cantHijo;
            cargaDeFamilia += valorHijoIncapacitado * cantHijoIncapacitado;
            cargaDeFamilia += valorConyuge * cantConyuge;
            // Suma deducciones personales
            decimal deduccionPersonal = ConsultQueries.GetPersonalDeduction(anio, "Ganancias no imponibles");
            deduccionPersonal += ConsultQueries.GetPersonalDeduction(anio, "Deducción especial");
            result = remuneracionMensual + remuOtrosEmpleadores - deduccionMensual - deduccionOtrosEmpleadores - cargaDeFamilia - deduccionPersonal;
            // Verifica que el importe de la deducción no sea menor a cero.
            if(result < 0)
            {
                result = 0;
            }

            EmployeeFirstDeduction employee = new EmployeeFirstDeduction();
            employee.Legajo = legajo;
            employee.Anio = anio;
            employee.Mes = mes;
            employee.RemuneracionMensual = remuneracionMensual;
            employee.RemuneracionMensualOE = remuOtrosEmpleadores;
            employee.DeduccionMensual = deduccionMensual;
            employee.DeduccionMensualOE = deduccionOtrosEmpleadores;
            employee.CargasFamilia = cargaDeFamilia;
            employee.DeduccionesPersonales = deduccionPersonal;
            employee.Deduccion = result;


            return employee;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="promedioMensual"></param>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <returns></returns>
        internal static EmployeeSecondDeduction SegundaDeduccion(int legajo, decimal promedioMensual, short anio, byte mes)
        {
            //Obtiene los datos correspondientes a la resolución mensual
            Resolucion resolucion = new Resolucion();
            ConsultQueries.GetMonthResolution(resolucion, anio, mes);  
            // Obtiene los rangos.
            List<RangosSegundaDeduccion> rangos = ConsultQueries.GetRangeDedEspInc(resolucion.ResolucionName);
            // Genera una instancia.
            EmployeeSecondDeduction employee = new EmployeeSecondDeduction();

            foreach (RangosSegundaDeduccion rango in rangos)
            {
                if(promedioMensual >= rango.LimiteInferior && promedioMensual < rango.LimiteSuperior)
                {
                    employee.Legajo = legajo;
                    employee.Anio = anio;
                    employee.Mes = mes;
                    employee.Deduccion = rango.Deduccion;
                    break;
                }
            }
            return employee;
        }
    }
}
