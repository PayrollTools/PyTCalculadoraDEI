using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PytCalcModel
{
    internal class ReadXmlFiles
    {
        internal static List<EmployeeFamily> ReadXmlEmployeeFamily(string file)
        {
            List<EmployeeFamily> employeeFamilies = new List<EmployeeFamily>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(file);

            int legajo = 0;
            long cuil;
            short anio = 0;
            byte tipoDoc = 0;
            long nroDoc = 0;
            string apellido = null;
            string nombre = null;
            DateTime fecNac = DateTime.Parse("01/01/1900");
            byte mesDesde = 0;
            byte mesHasta = 0;
            byte parentesco = 0;
            byte porcentaje = 0;

            // Obtengo el año de la presentación.
            XmlNodeList xmlPresentacion = xmlDocument.SelectNodes("//presentacion");

            foreach (XmlNode xmlNode in xmlPresentacion)
            {
                for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                {
                    if (xmlNode.ChildNodes[i].Name.ToString() == "periodo")
                    {
                        anio = short.Parse(xmlNode.ChildNodes[i].InnerText);
                    }
                }
            }

            // Obtengo el cuil del empleado.
            XmlNodeList xmlEmployeeData = xmlDocument.SelectNodes("//presentacion//empleado//cuit");

            cuil = long.Parse(xmlEmployeeData[0].InnerText);

            // Obtengo el legajo del empleado.            
            legajo = ConsultQueries.GetEmployeeFile(cuil);

            // Obtengo los datos cargados del familiar.
            XmlNodeList xmlFamiliaNode = xmlDocument.SelectNodes("//presentacion//cargasFamilia//cargaFamilia");

            foreach (XmlNode xmlNode in xmlFamiliaNode)
            {
                for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                {
                    string data = null;

                    switch (xmlNode.ChildNodes[i].Name.ToString())
                    {
                        case "tipoDoc":
                            data = xmlNode.ChildNodes[i].InnerText;
                            tipoDoc = byte.Parse(data);
                            break;
                        case "nroDoc":
                            data = xmlNode.ChildNodes[i].InnerText;
                            nroDoc = long.Parse(data);
                            break;
                        case "apellido":
                            apellido = xmlNode.ChildNodes[i].InnerText;
                            break;
                        case "nombre":
                            nombre = xmlNode.ChildNodes[i].InnerText;
                            break;
                        case "fechaNac":
                            data = xmlNode.ChildNodes[i].InnerText;
                            fecNac = DateTime.Parse(data);
                            break;
                        case "mesDesde":
                            data = xmlNode.ChildNodes[i].InnerText;
                            mesDesde = byte.Parse(data);
                            break;
                        case "mesHasta":
                            data = xmlNode.ChildNodes[i].InnerText;
                            mesHasta = byte.Parse(data);
                            break;
                        case "parentesco":
                            data = xmlNode.ChildNodes[i].InnerText;
                            parentesco = byte.Parse(data);
                            break;
                        case "porcentajeDeduccion":
                            data = xmlNode.ChildNodes[i].InnerText;
                            porcentaje = byte.Parse(data);
                            break;
                    }
                }

                EmployeeFamily employeeFamily = new EmployeeFamily(
                    legajo,
                    cuil,
                    anio,
                    tipoDoc,
                    nroDoc,
                    apellido,
                    nombre,
                    fecNac,
                    mesDesde,
                    mesHasta,
                    parentesco,
                    porcentaje);

                employeeFamilies.Add(employeeFamily);
            }
            return employeeFamilies;
        }

        internal static List<EmployeeJobs> ReadXmlEmployeeJobs(string path)
        {
            List<EmployeeJobs> employeeJobs = new List<EmployeeJobs>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            int legajo = 0;
            short anio = 0;
            long cuil;
            long cuit = 0;
            string denominacion = null;
            byte mes = 0;
            decimal obraSocial = 0;
            decimal seguridadSocial = 0;
            decimal sindicato = 0;
            decimal gananciaBruta = 0;
            decimal retNoHabituales = 0;
            decimal ajuste = 0;
            decimal remuneracionExenta = 0;
            decimal sac = 0;
            decimal hsExtrasGravadas = 0;
            decimal hsExtrasExentas = 0;
            decimal materialDidactico = 0;
            decimal movilidadViaticos = 0;

            // Obtengo el año de la presentación.
            XmlNodeList xmlPresentacion = xmlDocument.SelectNodes("//presentacion");

            foreach (XmlNode xmlNode in xmlPresentacion)
            {
                for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                {
                    if (xmlNode.ChildNodes[i].Name.ToString() == "periodo")
                    {
                        anio = short.Parse(xmlNode.ChildNodes[i].InnerText);
                    }
                }
            }

            // Obtengo el cuil del empleado.
            XmlNodeList xmlEmployeeData = xmlDocument.SelectNodes("//presentacion//empleado//cuit");
            cuil = long.Parse(xmlEmployeeData[0].InnerText);

            // Obtengo el legajo del empleado           
            legajo = ConsultQueries.GetEmployeeFile(cuil);

            //Obtengo los datos relacionados a otros empleadores.
            //CUIT del empleador
            XmlNodeList jobCuit = xmlDocument.SelectNodes("//presentacion//ganLiqOtrosEmpEnt//cuit");
            cuit = long.Parse(jobCuit[0].InnerText);
            //DENOMINACIÓN del empleador.
            XmlNodeList jobDenomination = xmlDocument.SelectNodes("//presentacion//ganLiqOtrosEmpEnt//denominacion");
            denominacion = jobDenomination[0].InnerText;
            //DATOS DEL MES.
            XmlNodeList jobData = xmlDocument.SelectNodes("//presentacion//ganLiqOtrosEmpEnt//ingresosAportes//ingAp");
            // Formato del separador decimal
            NumberFormatInfo format = new NumberFormatInfo();
            format.NumberDecimalSeparator = ",";

            foreach (XmlNode xmlNode in jobData)
            {
                mes = byte.Parse(xmlNode.Attributes["mes"].Value);
                string data;
               
                for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                {
                    switch (xmlNode.ChildNodes[i].Name.ToString())
                    {
                        case "obraSoc":
                            data = xmlNode.ChildNodes[i].InnerText.ToString().Replace(".", ",");
                            obraSocial = decimal.Parse(data);
                            break;
                        case "segSoc":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            seguridadSocial = decimal.Parse(data);
                            break;
                        case "sind":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            sindicato = decimal.Parse(data);
                            break;
                        case "ganBrut":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            gananciaBruta = decimal.Parse(data);
                            break;
                        case "retribNoHab":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            retNoHabituales = decimal.Parse(data);
                            break;
                        case "ajuste":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            ajuste = decimal.Parse(data);
                            break;
                        case "exeNoAlc":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            remuneracionExenta = decimal.Parse(data);
                            break;
                        case "sac":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            sac = decimal.Parse(data);
                            break;
                        case "horasExtGr":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            hsExtrasGravadas = decimal.Parse(data);
                            break;
                        case "horasExtEx":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            hsExtrasExentas = decimal.Parse(data);
                            break;
                        case "matDid":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            materialDidactico = decimal.Parse(data);
                            break;
                        case "gastosMovViat":
                            data = xmlNode.ChildNodes[i].InnerText.ToString(format).Replace(".", ",");
                            movilidadViaticos = decimal.Parse(data);
                            break;
                    }                    
                }

                EmployeeJobs jobs = new EmployeeJobs(
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
                    movilidadViaticos);

                employeeJobs.Add(jobs);
            }
            return employeeJobs;
        }
    }
}
