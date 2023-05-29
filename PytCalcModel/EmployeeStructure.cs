using DocumentFormat.OpenXml.Drawing.Diagrams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PytCalcModel
{ 

    public sealed class EmployeeData
    {
        public int Legajo { set; get; }
        public long Cuil { set; get; }
        public string NombreApellido { set; get; }
        public DateTime FecIng { set; get; }

        public EmployeeData()
        {

        }
        public EmployeeData(int legajo, long cuil, string nombreApellido, DateTime fecIng)
        {
            this.Legajo = legajo;
            this.Cuil = cuil;
            this.NombreApellido = nombreApellido;
            this.FecIng = fecIng;
        }
        public EmployeeData(int id) 
        {
            EmployeeData employeeData = ConsultQueries.GetEmployeeData(id);

            this.Legajo = employeeData.Legajo;
            this.Cuil = employeeData.Cuil;
            this.NombreApellido = employeeData.NombreApellido;
            this.FecIng = employeeData.FecIng;
        }
    }

    public sealed class EmployeeSalary
    {
        public int Legajo { set; get; }
        public string NombreApellido { set; get; }
        public short Anio { set; get; }
        public byte Mes { set; get; }
        public decimal Importe { set; get; }

        public EmployeeSalary(int legajo, string nombreApellido, short anio, byte mes, decimal importe)
        {
                   
            this.Legajo = legajo;
            this.NombreApellido = nombreApellido;
            this.Anio = anio;
            this.Mes = mes;
            this.Importe = importe;
        }
    }

    public sealed class EmployeeFamily
    {
        public int Legajo { set; get; }
        public long Cuil { set; get; }
        public short Anio { set; get; }
        public byte TipoDoc { set; get; }
        public long NroDoc { set; get; }
        public string Apellido { set; get; }
        public string Nombre { set; get; }
        public DateTime FecNac { set; get; }
        public byte MesDesde { set; get; }
        public byte MesHasta { set; get; }
        public byte Parentesco { set; get; }
        public byte Porcentaje { set; get; }
        public EmployeeFamily()
        {

        }
        public EmployeeFamily(int id)
        {
            EmployeeFamily employeeFamily = ConsultQueries.GetEmployeeFamily(id);

            this.Legajo = employeeFamily.Legajo;
            this.Cuil = employeeFamily.Cuil;
            this.Anio = employeeFamily.Anio;
            this.TipoDoc = employeeFamily.TipoDoc;
            this.NroDoc = employeeFamily.NroDoc;
            this.Apellido = employeeFamily.Apellido;
            this.Nombre = employeeFamily.Nombre;
            this.FecNac = employeeFamily.FecNac;
            this.MesDesde = employeeFamily.MesDesde;
            this.MesHasta = employeeFamily.MesHasta;
            this.Parentesco = employeeFamily.Parentesco;
            this.Porcentaje = employeeFamily.Porcentaje;
        }

        public EmployeeFamily(int legajo, long cuil, short anio, byte tipoDoc, long nroDoc, string apellido, string nombre, DateTime fecNac, byte mesDesde, byte mesHasta, byte parentesco, byte porcentaje)
        {
            this.Legajo = legajo;
            this.Cuil = cuil;
            this.Anio = anio;
            this.TipoDoc = tipoDoc;
            this.NroDoc = nroDoc;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.FecNac = fecNac;
            this.MesDesde = mesDesde;
            this.MesHasta = mesHasta;
            this.Parentesco = parentesco;
            this.Porcentaje = porcentaje;
        }
    }

    public sealed class EmployeeJobs
    {
        public int Legajo { set; get; }
        public short Anio { set; get; }
        public long Cuil { set; get; }
        public long Cuit { set; get; }
        public string Denominacion { set; get; }
        public byte Mes { set; get; }
        public decimal ObraSocial { set; get; }
        public decimal SeguridadSocial { set; get; }
        public decimal Sindicato { set; get; }
        public decimal GananciaBruta { set; get; }
        public decimal RetNoHabituales { set; get; }
        public decimal Ajuste { set; get; }
        public decimal RemuneracionExenta { set; get; }
        public decimal Sac { set; get; }
        public decimal HsExtrasGravadas { set; get; }
        public decimal HsExtrasExentas { set; get; }
        public decimal MaterialDidactico { set; get; }
        public decimal MovilidadViaticos { set; get; }

        public EmployeeJobs()
        {

        }
        public EmployeeJobs(int id)
        {
            EmployeeJobs employeeJobs = ConsultQueries.GetEmployeeJobs(id);

            this.Legajo = employeeJobs.Legajo;
            this.Anio = employeeJobs.Anio;
            this.Cuil = employeeJobs.Cuil;
            this.Cuit = employeeJobs.Cuit;
            this.Denominacion = employeeJobs.Denominacion;
            this.Mes = employeeJobs.Mes;
            this.ObraSocial = employeeJobs.ObraSocial;
            this.SeguridadSocial = employeeJobs.SeguridadSocial;
            this.Sindicato = employeeJobs.Sindicato;
            this.GananciaBruta = employeeJobs.GananciaBruta;
            this.RetNoHabituales = employeeJobs.RetNoHabituales;
            this.Ajuste = employeeJobs.Ajuste;
            this.RemuneracionExenta = employeeJobs.RemuneracionExenta;
            this.Sac = employeeJobs.Sac;
            this.HsExtrasGravadas = employeeJobs.HsExtrasGravadas;
            this.HsExtrasExentas = employeeJobs.HsExtrasExentas;
            this.MaterialDidactico = employeeJobs.MaterialDidactico;
            this.MovilidadViaticos = employeeJobs.MovilidadViaticos;
        }
        public EmployeeJobs(int legajo, short anio, long cuil, long cuit, string denominacion, byte mes,
            decimal obraSocial, decimal seguridadSocial, decimal sindicato, decimal gananciaBruta,
            decimal retNoHabituales, decimal ajuste, decimal remuneracionExenta, decimal sac, decimal hsExtrasGravadas,
            decimal hsExtrasExentas, decimal materialDidactico, decimal movilidadViaticos)
        {
            this.Legajo = legajo;
            this.Anio = anio;
            this.Cuil = cuil;
            this.Cuit = cuit;
            this.Denominacion = denominacion;
            this.Mes = mes;
            this.ObraSocial = obraSocial;
            this.SeguridadSocial = seguridadSocial;
            this.Sindicato = sindicato;
            this.GananciaBruta = gananciaBruta;
            this.RetNoHabituales = retNoHabituales;
            this.Ajuste = ajuste;
            this.RemuneracionExenta = remuneracionExenta;
            this.Sac = sac;
            this.HsExtrasGravadas = hsExtrasGravadas;
            this.HsExtrasExentas = hsExtrasExentas;
            this.MaterialDidactico = materialDidactico;
            this.MovilidadViaticos = movilidadViaticos;
        }
    }
    public sealed class EmployeeDivider
    {
        public int Legajo { set; get; }
        public short Anio { set; get; }
        public byte Mes { set; get; }
        public byte Divisor { set; get; }

        public EmployeeDivider()
        {

        }
        public EmployeeDivider(int id)
        {
            EmployeeDivider employeeDivision = ConsultQueries.GetEmployeeDivider(id);
            this.Legajo = employeeDivision.Legajo;
            this.Anio = employeeDivision.Anio;
            this.Mes = employeeDivision.Mes;
            this.Divisor = employeeDivision.Divisor;
        }
        public EmployeeDivider(int legajo, short anio, byte mes, byte divisor)
        {
            this.Legajo = legajo;
            this.Anio = anio;
            this.Mes = mes;
            this.Divisor = divisor;
        }
    }
}
public sealed class EmployeeAverage
{
    public int Legajo { set; get; }
    public short Anio { set; get; }
    public byte Mes { set; get; }
    public decimal Promedio { set; get; }

    public EmployeeAverage() { }

}

public sealed class EmployeeFirstDeduction
{
    public int Legajo { set; get; }
    public short Anio { set; get; }
    public byte Mes { set; get; }
    public decimal RemuneracionMensual { set; get; }
    public decimal RemuneracionMensualOE { set; get; }
    public decimal DeduccionMensual { set; get; }
    public decimal DeduccionMensualOE { set; get; }
    public decimal CargasFamilia { set; get; }
    public decimal DeduccionesPersonales { set; get; }
    public decimal Deduccion { set; get; }

    public EmployeeFirstDeduction() { }
}

public sealed class EmployeeSecondDeduction
{
    public int Legajo { set; get; }
    public short Anio { set; get; }
    public byte Mes { set; get; }
    public decimal Deduccion { set; get; }
    public EmployeeSecondDeduction() { }
}
public sealed class Resolucion
{
    public string ResolucionName {get; set;}
    public short Anio { get; set; }
    public byte MesDesde { get; set; }
    public byte MesHasta { get; set; }
    public decimal LimiteInferior { get; set; }
    public decimal LimiteSuperior { get; set; }    
    public Resolucion()
    {

    }
    public Resolucion(string resolucionName,
        short anio,
        byte mesInicio,
        byte mesHasta,
        decimal limiteInferior,
        decimal limiteSuperior)
    {
        this.ResolucionName = resolucionName;
        this.Anio = anio;
        this.MesDesde = mesInicio;
        this.MesHasta = mesHasta;
        this.LimiteInferior = limiteInferior;
        this.LimiteSuperior = limiteSuperior;
    }
}

public sealed class RangosSegundaDeduccion
{
    internal string ResolutionName { get; set; }
    internal decimal LimiteInferior { get; }
    internal decimal LimiteSuperior { get; }
    internal decimal Deduccion { get; }
    public RangosSegundaDeduccion() { }

    public RangosSegundaDeduccion(string resolutionName, decimal limiteInferior, decimal limiteSuperior, decimal deduccion)
    {
        this.ResolutionName = resolutionName;
        this.LimiteInferior = limiteInferior;
        this.LimiteSuperior = limiteSuperior;
        this.Deduccion = deduccion;
    } 
}
