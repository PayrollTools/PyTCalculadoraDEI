using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data;
using System.Net;
using System.Net.Http.Headers;
using System.ComponentModel.Design;
using System.Configuration;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Windows.Forms;

namespace PytCalcModel
{
    public class Model
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static string CreateEmployeeData(string filepath)
        {
            string resultado = "El proceso finalizo correctamente.";
            StreamWriter txtFile = new StreamWriter(@"C:\xml\logs.txt");

            try
            {             
                List<EmployeeData> employeeData = ReadExcelFiles.ImportEmployeesData(filepath);

                foreach (EmployeeData employee in employeeData)            
                {               
                    // El resultado da true, por mas que no existan datos en la BBDD. 
                    // Por codigo, no se ve ningún error. Por lo que deberia de funcionar.
                    if (ConsultQueries.CheckEmployeeData(employee.Cuil))
                    {
                        string message = $"No se puede crear el registro. El número de cuil {employee.Cuil} ya esta asociado a un CUIL.";
                        txtFile.WriteLine(message);
                        resultado = "El proceso finalizo con errores. Ver log de importación.";
                    }
                    else
                    {
                        InsertQueries.InsertEmployeeData(employee);
                    }
                }                                   
            }
            catch (FormatException)
            {
                resultado = "El archivo a subir contiene errores de formato. Importación cancelada.";
            }
            catch (IOException ex)
            {
                resultado = ex.Message;
            }

            txtFile.Close();
            return resultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sp"></param>
        /// <returns></returns>
        public static string CreateEmployeeSalary(string path, string sp1, string sp2)
        {
            string messege = "El proceso se ejecuto correctamente";
            StreamWriter txtFile = new StreamWriter(@"C:\xml\logs.txt");
            try
            {

                List<EmployeeSalary> employeeSalaries = ReadExcelFiles.ImportEmployeeSalary(path);

                foreach (EmployeeSalary salary in employeeSalaries)
                {
                    if (ConsultQueries.CheckEmployeeSalary(salary.Legajo, salary.Anio, salary.Mes, sp1))
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. Ya existe un registro asociado al legajo {salary.Legajo}, para el año {salary.Anio}, mes {salary.Mes}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else if (ConsultQueries.CheckEmployeeFile(salary.Legajo) == false)
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. No existe un legajo asociado para el legajo: {salary.Legajo}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else
                    {

                        InsertQueries.InsertEmployeeSalary(salary, sp2);
                    }
                }
            }
            catch (FormatException)
            {
                messege = "El archivo a subir contiene errores de formato. Importación cancelada.";
            }
            catch (IOException ex)
            {
                messege = ex.Message;
            }
            finally
            {
                txtFile.Close();
            }
            
            return messege;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string CreateEmployeeFamilyExcel(string path)
        {
            string messege = "El proceso se ejecuto correctamente";
            StreamWriter txtFile = new StreamWriter(@"C:\xml\logs.txt");

            try
            {               
                List<EmployeeFamily> employeeFamily = ReadExcelFiles.ImportEmployeeFamily(path);

                foreach (EmployeeFamily family in employeeFamily)
                {
                    if (ConsultQueries.CheckEmployeeFamily(family.Legajo, family.NroDoc, family.Anio))
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. Ya existe un registro asociado al legajo {family.Legajo}, para el año {family.Anio}, documento {family.NroDoc}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else if (ConsultQueries.CheckEmployeeFile(family.Legajo) == false)
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. No existe un legajo asociado para el legajo: {family.Legajo}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else
                    {
                        InsertQueries.InsertEmployeeFamily(family);
                    }
                }
                
            }
            catch (FormatException)
            {
                messege = "El archivo a subir contiene errores de formato. Importación cancelada.";
            }
            catch (IOException ex)
            {
                messege = ex.Message;
            }
            finally
            {
              txtFile.Close();
            }
            return messege;
        }
        public static string CreateEmployeeFamilyXml(string path)
        {
            string messege = "El proceso finalizo correctamente";
            
            StreamWriter txtFile = new StreamWriter(@"C:\xml\logs.txt");

            string [] xmlFiles = SystemFiles.GetXmlFiles(path);

            for (int i = 0; i < xmlFiles.Length; i++)
            {
                List<EmployeeFamily> familyList = ReadXmlFiles.ReadXmlEmployeeFamily(xmlFiles[i]);

                foreach (EmployeeFamily family in familyList)
                {
                    if (ConsultQueries.CheckEmployeeFamily(family.Legajo, family.NroDoc, family.Anio))
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. Ya existe un registro asociado al legajo {family.Legajo}, para el año {family.Anio}, documento {family.NroDoc}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else if (ConsultQueries.CheckEmployeeFile(family.Legajo) == false)
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. No existe un legajo asociado para el legajo: {family.Legajo}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else
                    {
                        InsertQueries.InsertEmployeeFamily(family);
                    }
                    
                }
            }
            txtFile.Close();
            return messege;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string CreateEmployeeJobsExcel(string path)
        {
            string messege = "El proceso se ejecuto correctamente";

            try
            {
                StreamWriter txtFile = new StreamWriter(@"C:\xml\logs.txt");

                List<EmployeeJobs> employeeJobs = ReadExcelFiles.ImporteEmployeeJobs(path);

                foreach (EmployeeJobs job in employeeJobs)
                {
                    if (ConsultQueries.CheckEmployeeJobs(job.Legajo, job.Cuil, job.Cuit, job.Anio, job.Mes))
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. Ya existe un registro asociado al legajo {job.Legajo}, para el año {job.Anio}, mes {job.Mes}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else if (ConsultQueries.CheckEmployeeFile(job.Legajo) == false)
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. No existe un legajo asociado para el legajo: {job.Legajo}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else
                    {
                        InsertQueries.InsertEmployeeJobs(job);
                    }
                }
                txtFile.Close();
            }
            catch (FormatException)
            {
                messege = "El archivo a subir contiene errores de formato. Importación cancelada.";
            }
            catch (IOException ex)
            {
                messege = ex.Message;
            }
            return messege;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string CreateEmployeeJobsXml(string path)
        {
            string messege = "El proceso finalizo correctamente";

            StreamWriter txtFile = new StreamWriter(@"C:\xml\logs.txt");

            string[] xmlFiles = SystemFiles.GetXmlFiles(path);

            for (int i = 0; i < xmlFiles.Length; i++)
            {
                List<EmployeeJobs> jobList = ReadXmlFiles.ReadXmlEmployeeJobs(xmlFiles[i]);

                foreach (EmployeeJobs job in jobList)
                {

                    if (ConsultQueries.CheckEmployeeJobs(job.Legajo, job.Cuil, job.Cuit, job.Anio, job.Mes))
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. Ya existe un registro asociado al legajo {job.Legajo}, para el año {job.Anio}, mes {job.Mes}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else if (ConsultQueries.CheckEmployeeFile(job.Legajo) == false)
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. No existe un legajo asociado para el legajo: {job.Legajo}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else
                    {
                        InsertQueries.InsertEmployeeJobs(job);
                    }
                }
            }

            return messege;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string CreateEmployeeDivisor(string path)
        {
            string messege = "El proceso se ejecuto correctamente";
            try

            {
                StreamWriter txtFile = new StreamWriter(@"C:\xml\logs.txt");

                List<EmployeeDivider> employeeDivisions = ReadExcelFiles.ImportEmployeeDivisions(path);               

                foreach(EmployeeDivider division in employeeDivisions)
                {
                    messege = division.Legajo.ToString();
                    if (ConsultQueries.CheckEmployeeDivision(division.Legajo, division.Anio, division.Mes))
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. Ya existe un registro asociado al legajo {division.Legajo}, para el año {division.Anio}, mes {division.Mes}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else if (ConsultQueries.CheckEmployeeFile(division.Legajo) == false)
                    {
                        messege = "El proceso finalizo con errores. Ver log de importación.";
                        string errorMessege = $"No se puede crear el registro. No existe un legajo asociado para el legajo: {division.Legajo}.";
                        txtFile.WriteLine(errorMessege);
                    }
                    else
                    {
                        InsertQueries.InsertEmployeeDivision(division);
                    }
                }
                txtFile.Close();
            }
            catch (FormatException)
            {
                messege = "El archivo a subir contiene errores de formato. Importación cancelada.";
            }
            catch (IOException ex)
            {
                messege = ex.Message.ToString();
            }
            return messege;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="legajo"></param>
        /// <param name="cuil"></param>
        /// <param name="nombreApellido"></param>
        /// <param name="fecIng"></param>
        /// <returns></returns>
        public static string UpdateEmployee(int id, int legajo, long cuil, string nombreApellido, DateTime fecIng)
        {
            string messege = "Se actualizaron los registros correctamente";           
            try
            {
                if(ConsultQueries.GetEmployeeFile(cuil) != legajo)
                {
                    messege = "Error. Ya existe un legajo asociado al cuil especificado.";
                }
                else
                {
                    UpdateQueries.UpdateEmployeeData(id, cuil, nombreApellido, fecIng);                    
                }

            }catch(Exception ex)
            {
                messege = ex.Message.ToString();
            }
            return messege;
        }
        public static string UpdateSalary(int legajo, short anio, byte mes, string procedure, decimal employeeSalary)
        {
            string messege = "Se actualizaron los registros correctamente";
            try
            {
                UpdateQueries.UpdateEmployeeSalary(legajo, anio, mes, procedure, employeeSalary);
            }
            catch(Exception ex)
            {
                messege = ex.Message.ToString();
            }
            return messege;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employeeFamily"></param>
        /// <returns></returns>
        public static string UpdateFamily(int id, EmployeeFamily employeeFamily)
        {
            string result = "Se finalizo el proceso de actualización correctamente.";

            try
            {
                UpdateQueries.UpdateEmployeeFamily(id, employeeFamily);
            }
            catch(Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }
        public static string UpdateJob(int id, EmployeeJobs employeeJobs)
        {
            string result = "Se finalizo el proceso de actualización correctamente.";
            try
            {
                UpdateQueries.UpdateEmployeeJobs(id, employeeJobs);
            }
            catch(Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }
        public static string UpdateDivider(int id, byte divisor)
        {
            string result = "Se finalizo el proceso de actualización correctamente.";
            try
            {
                UpdateQueries.UpdateEmployeeDivision(id, divisor);
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }
        public static string DeleteEmployee(int legajo)
        {
            string menssage = "Se elimino el registro correctamente.";
            try
            {
                DeleteQueries.DeleteEmployee(legajo);
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        public static string DeleteFamily(int id)
        {
            string menssage = "Se elimino el registro correctamente.";
            try
            {
                DeleteQueries.DeleteRegister(id, "SP_DeleteCargaFamilia");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        public static string DeleteJob(int id)
        {
            string menssage = "Se elimino el registro correctamente.";
            try
            {
                DeleteQueries.DeleteRegister(id, "SP_DeleteOtroEmpleo");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        public static string DeleteDivider(int id)
        {
            string menssage = "Se elimino el registro correctamente.";
            try
            {
                DeleteQueries.DeleteRegister(id, "SP_DeleteDivisor");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la totalidad de las tablas correspondientes al esquema empleados.
        /// </summary>
        /// <returns></returns>
        public static string DeleteAll()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAll");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla de remuneraciones mensuales
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllRemunerations()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllRemunerations");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla de deducciones mensuales.
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllDeductions()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllDeductions");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla cargas de familia
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllFamilys()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllFamily");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla de otros empleadores
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllJobs()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllJobs");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla de divisores mensuales
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllDividers()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllDividers");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla de promedios mensuales bruto.
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllAverages()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllAverage");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla de la primer deduccion especial incrementada
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllFirstDeduction()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllFirstDeductions");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Borra la tabla de la segunda deduccion especial incrementada
        /// </summary>
        /// <returns></returns>
        public static string DeleteAllSecondDeductions()
        {
            string menssage = "Se ejecuto el proceso correctamente.";
            try
            {
                DeleteQueries.DeleteTable("SP_DeleteAllFirstDeductions");
            }
            catch (Exception ex)
            {
                menssage = ex.Message.ToString();
            }
            return menssage;
        }
        /// <summary>
        /// Obtiene la lista completa de legajos, que contiene la tabla empleados (dentro del esquema EmployeeDataBase).
        /// Sin discriminar por fecha de ingreso.
        /// </summary>
        /// <param name="listEmployees"></param>
        /// <returns></returns>
        public static List<int> GetEmployees(List<int> listEmployees)
        {
            return ConsultQueries.GetEmployees(listEmployees);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        public static DataTable SeeEmployees(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllEmployees");

            return ds;
        }
        public static DataTable SeeRemunerations(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllRemunerations");

            return ds;
        }

        public static DataTable SeeDeductions(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllDeductions");

            return ds;
        }
        public static DataTable SeeFamily(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllFamily");

            return ds;
        }
        public static DataTable SeeJobs(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllJobs");

            return ds;
        }

        public static DataTable SeeDivision(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllDivisions");

            return ds;
        }

        public static DataTable SeeAverages(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllAverages");

            return ds;
        }

        public static DataTable SeeFirstDeductions(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllFirstDeductions");

            return ds;
        }
        public static DataTable SeeSecondDeductions(DataTable ds)
        {
            ConsultQueries.SeeAllRecords(ds, "SP_SeeAllSecondDeductions");

            return ds;
        }

        public static decimal GetEmployeeSalary(string sp, int legajo, short anio, byte mes)
        {
            return ConsultQueries.GetEmployeeSalary(sp, legajo, anio, mes);
        }

        public static void WriteIniFile(string name, string key, string val, string path)
        {
            IniFile iniFile = new IniFile(path);
            iniFile.WriteIniFile(name, key, val);
        }

        public static string ReadIniFile(string section, string key, string path)
        {
            IniFile iniFile = new IniFile(path);
            return iniFile.ReadIniFile(section, key);
        }

        /*
         * Exportación de datos 
         */
        
        public static string ExportInfo(byte op)
        {
            // Mensaje resultado.
            string message = "Exportación de datos finalizada.";

            // Directorio en donde se exporta el archivo.
            string directory = ReadIniFile("DIR_CONFIG", "path", $@"{Environment.CurrentDirectory}\config.ini");
        
            // Datos a exportar
            DataTable data = new DataTable();
            switch (op)
            {
                case 0:
                    SeeEmployees(data);
                    if (ExportData.ExportEmployees(data, directory) == false)
                    {
                        message = null;
                    }
                    break;
                case 1:
                    SeeRemunerations(data);
                    if (ExportData.ExportRemunerations(data, directory) == false)
                    {
                        message = null; ;
                    }
                    break;
                case 2:
                    SeeDeductions(data);
                    if (ExportData.ExportDeductions(data, directory) == false)
                    {
                        message = null; ;
                    }
                    break;
                case 3:
                    SeeFamily(data);
                    if (ExportData.ExportFamily(data, directory) == false)
                    {
                        message = null;
                    }
                    break;
                case 4:
                    SeeJobs(data);
                    if (ExportData.ExportJobs(data, directory) == false)
                    {
                        message = null;
                    }
                    break;
                case 5:
                    SeeAverages(data);
                    if (ExportData.ExportAverage(data, directory) == false)
                    {
                        message = null;
                    }
                    break;
                case 6:
                    SeeFirstDeductions(data);
                    if (ExportData.ExportFirstDeductions(data, directory) == false)
                    {
                        message = null;
                    }
                    break;
                case 7:
                    SeeSecondDeductions(data);
                    if (ExportData.ExportSecondDeduction(data, directory) == false)
                    {
                        message = null;
                    }
                    break;
            }
            
            if (message != null)
            {
                return message;
            }
            else
            {
                return "Se produjo un error en el proceso de exportación de datos. Proceso abortado.";
            }
        }
        /*
         * Queries del esquema system 
         */

        public static List<short> GetDedEspYears(List<short> years)
        {
            years = ConsultQueries.GetDedEspYears(years);

            return years;
        }        

        public static decimal GetGananciasNoImponibles(short anio)
        {
             return ConsultQueries.GetPersonalDeduction(anio, "Ganancias no imponibles");
        }
        public static decimal GetConyuge(short anio)
        {
            return ConsultQueries.GetPersonalDeduction(anio, "Cónyuge");
        }
        public static decimal GetHijo(short anio)
        {
            return ConsultQueries.GetPersonalDeduction(anio, "Hijo");
        }
        public static decimal GetHijoIncapacitado(short anio)
        {
            return ConsultQueries.GetPersonalDeduction(anio, "Hijo incapacitado para el trabajo");
        }
        public static decimal GetDeduccionEspecial(short anio)
        {
            return ConsultQueries.GetPersonalDeduction(anio, "Deducción especial");
        }

        public static string InsertDeduccionPersonal(short anio, decimal[] importes)
        {
            string message = "Se agregaron los valores correctamente en el sistema.";
            try
            {
                InsertQueries.InsertPersonalDeduction(anio, "Ganancias no imponibles", importes[0]);
                InsertQueries.InsertPersonalDeduction(anio, "Cónyuge", importes[1]);
                InsertQueries.InsertPersonalDeduction(anio, "Hijo", importes[2]);
                InsertQueries.InsertPersonalDeduction(anio, "Hijo incapacitado para el trabajo", importes[3]);
                InsertQueries.InsertPersonalDeduction(anio, "Deducción especial", importes[4]);

            }
            catch(Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }

        public static string UpdateDeduccionPersonal(short anio, decimal[] importes)
        {
            string message = "Se agregaron los valores correctamente en el sistema.";
            try
            {
                UpdateQueries.UpdatePersonalDeduction(anio, "Ganancias no imponibles", importes[0]);
                UpdateQueries.UpdatePersonalDeduction(anio, "Cónyuge", importes[1]);
                UpdateQueries.UpdatePersonalDeduction(anio, "Hijo", importes[2]);
                UpdateQueries.UpdatePersonalDeduction(anio, "Hijo incapacitado para el trabajo", importes[3]);
                UpdateQueries.UpdatePersonalDeduction(anio, "Deducción especial", importes[4]);

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }

        public static string InsertResolution(Resolucion resolucion, string file)
        {
            string message = null;

            try
            {
                if (ConsultQueries.CheckActiveResolution(resolucion.Anio, resolucion.MesDesde, resolucion.MesHasta) == true)
                {
                    message = "Ya existe una resolución dentro del año y rango de meses indicado.";
                }
                else
                {
                    message = InsertQueries.InsertResolution(resolucion, file);
                }                            
            }
            catch( Exception ex)
            {
                message = ex.Message;
            }
            
            return message;
        }

        public static string UpdateResolution(byte mesDesde, byte mesHasta, decimal importeDesde, decimal importeHasta, string resolucion)
        {
            string message = "Se finalizo el proceso correctamente";

            try
            {
                UpdateQueries.UpdateResolution(mesDesde, mesHasta, importeDesde, importeHasta, resolucion);
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }
            
            return message;
        }

        public static string DeleteResolution(string resolucion)
        {
            string message = "Se finalizo el proceso correctamente";

            try
            {
                DeleteQueries.DeleteResolution(resolucion);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }

        public static DataTable SeeAllResolutions(DataTable dt)
        {
            return ConsultQueries.SeeAllResolutions(dt);
        }
        public static List<string> GetResolutionsName(List<string> resolutions)
        {
            return ConsultQueries.GetResolutionName(resolutions);
        }

        public static Resolucion GetResolutionInfo(Resolucion resolucion, string resolutionName)
        {                       
            return ConsultQueries.GetResolutionInfo(resolucion, resolutionName); ;                
        }

        /********************************************************************************
         ****************    LIQUIDADOR   ***********************************************
         ********************************************************************************
         ********************************************************************************/

        public static string Liquidador(short anio, byte mesDesde, byte mesHasta, int legajoDesde, int legajoHasta)
        {
            string message = "Proceso finalizado correctamente";            
            /*try
            {*/
                for (byte i = mesDesde; i <= mesHasta; i++)
                {
                    List<int> activeEmployees = ConsultQueries.GetActiveEmployees(anio, i, legajoDesde, legajoHasta);

                    for (int j = 0; j < activeEmployees.Count; j++)
                    {

                        EmployeeAverage employeeAverage = PayrollProcess.PromedioBrutoMensual(activeEmployees[j], anio, i);

                        Resolucion monthResolution = new Resolucion();
                        ConsultQueries.GetMonthResolution(monthResolution, anio, i);

                        DeleteQueries.DeleteEmployeeAverage(employeeAverage);
                        InsertQueries.InsertEmployeeAverage(employeeAverage);

                        if (employeeAverage.Promedio < monthResolution.LimiteInferior && employeeAverage.Promedio > 0)
                        {
                            EmployeeFirstDeduction employeeFirstDeduction = PayrollProcess.PrimerParrafo(activeEmployees[j], anio, i);
                            // Busco eliminar posibles registro de la tabla segundadeduccion
                            EmployeeSecondDeduction employeeSecondDeduction = new EmployeeSecondDeduction();
                            employeeSecondDeduction.Legajo = employeeFirstDeduction.Legajo;
                            employeeSecondDeduction.Anio = employeeFirstDeduction.Anio;
                            employeeSecondDeduction.Mes = employeeFirstDeduction.Mes;

                            DeleteQueries.DeleteEmployeeFirstDeduction(employeeFirstDeduction);
                            DeleteQueries.DeleteEmployeeSecondDeduction(employeeSecondDeduction);
                            InsertQueries.InsertEmployeeFirstDeduction(employeeFirstDeduction);

                        }
                        else if (employeeAverage.Promedio >= monthResolution.LimiteInferior &&
                        employeeAverage.Promedio <= monthResolution.LimiteSuperior)
                        {
                            EmployeeSecondDeduction employeeSecondDeduction = PayrollProcess.SegundaDeduccion(activeEmployees[j], employeeAverage.Promedio, anio, i);
                            // Busco eliminar posibles registro de la tabla primeradeduccion
                            EmployeeFirstDeduction employeeFirstDeduction = new EmployeeFirstDeduction();
                            employeeFirstDeduction.Legajo = employeeSecondDeduction.Legajo;
                            employeeFirstDeduction.Anio = employeeSecondDeduction.Anio;
                            employeeFirstDeduction.Mes = employeeSecondDeduction.Mes;

                            DeleteQueries.DeleteEmployeeFirstDeduction(employeeFirstDeduction);
                            DeleteQueries.DeleteEmployeeSecondDeduction(employeeSecondDeduction);
                            InsertQueries.InsertEmployeeSecondDeduction(employeeSecondDeduction);
                        }

                    }
                }
            /*}
            catch (Exception ex)
            {
                message = ex.Message;
            }*/
                   
            return message;
        }
    }
}
