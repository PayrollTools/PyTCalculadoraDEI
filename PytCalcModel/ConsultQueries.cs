using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;

namespace PytCalcModel
{
    internal class ConsultQueries
    {
        /// <summary>
        /// Metodo para verificar si existe un empleado en la base de datos a partir del cuil.
        /// Devuelve un bool.
        /// </summary>
        /// <param name="cuil">Cuil a buscar.</param>
        /// <returns></returns>
        internal static bool CheckEmployeeData(long cuil)
        {
            Int32 result;
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";

            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CheckEmployee", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@cuil", cuil);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);
                }
            }
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        internal static bool CheckEmployeeFile(int legajo)
        {
            Int32 result;
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";

            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CheckEmployeeFile", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);
                }
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Verifica si ya existe en la base de datos un registro asociado.
        /// Devuelve un bool.
        /// </summary>
        /// <param name="legajo">Legajo a buscar</param>
        /// <param name="anio">Especifica el año en que se quiere buscar el registro</param>
        /// <param name="mes">Especifica el mes en que se quiere buscar el registro</param>
        /// <param name="sp">Procedimiento almacenado. 
        /// 'SP_CheckRemuneracion' si se busca una remuneración
        /// 'SP_CheckDeduccion' si se busca una deducción.</param>
        /// <returns></returns>
        internal static bool CheckEmployeeSalary(int legajo, short anio, byte mes, string sp)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            Int32 result;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand(sp, connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);
                }
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nrodoc"></param>
        /// <param name="anio"></param>
        /// <returns></returns>
        internal static bool CheckEmployeeFamily(int legajo, long nrodoc, short anio)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            Int32 result;
            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();
                using (SqlCommand storedProcedure = new SqlCommand("SP_CheckCargaFamilia", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@nrodoc", nrodoc);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);
                }
                connectSql.Close();
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="cuil"></param>
        /// <param name="cuit"></param>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <returns></returns>
        internal static bool CheckEmployeeJobs(int legajo, long cuil, long cuit, short anio, byte mes)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            Int32 result;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CheckEmployeeJobs", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@cuil", cuil);
                    storedProcedure.Parameters.AddWithValue("@cuit", cuit);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);
                }
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <returns></returns>
        internal static bool CheckEmployeeDivision(int legajo, short anio, byte mes)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            Int32 result;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CheckDivisor", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);
                }
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <returns></returns>
        internal static bool CheckResolution(short anio, byte mes)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            Byte result;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CheckResolucion", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToByte(returnValue.Value);
                }
                connectSql.Close();
            }

            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Devuelve la cantidad de familiares activos para un periodo determinado, para un legajo, 
        /// según su parentesco.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <param name="Parentesco"></param>
        /// <returns></returns>
        internal static int CountFamily(int legajo, short anio, byte mes, byte Parentesco)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            int result;
            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CountFamily", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);                    
                    storedProcedure.Parameters.AddWithValue("@parentesco", Parentesco);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);

                }
                connectSql.Close();
            }
            return result;
        }
        internal static byte CountWife(int legajo, short anio, byte mes, byte Parentesco)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            byte result;
            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CountWife", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.AddWithValue("@parentesco", Parentesco);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToByte(returnValue.Value);

                }
                connectSql.Close();
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns></returns>
        internal static int GetEmployeeFile(long cuil)
        {
            int result;

            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetEmployeeFile", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@cuil", cuil);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToInt32(returnValue.Value);
                }

                connectSql.Close();
            }
            return result;
        }
        /// <summary>
        /// Obtiene la lista completa de legajos, que contiene la tabla empleados (dentro del esquema EmployeeDataBase).
        /// Sin discriminar por fecha de ingreso.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        internal static List<int> GetEmployees(List<int> list)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using(SqlCommand storedProcedure = new SqlCommand("SP_GetEmployees", sqlConnection))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        list.Add(reader.GetInt32(0));
                    }
                }
            }
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        internal static DateTime? GetDateOfAdmission(int legajo)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            DateTime? result = null;
            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetEmployeeDateOfAdmission", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.Add("@result", SqlDbType.DateTime, 20).Direction = ParameterDirection.Output;

                    storedProcedure.ExecuteNonQuery();

                    DateTime dateOfAdmission;
                    CultureInfo dateFormat = new CultureInfo("es-ES");

                    bool x = DateTime.TryParse(storedProcedure.Parameters["@result"].Value.ToString(), dateFormat, DateTimeStyles.None, out dateOfAdmission);

                    if (x == true)
                    {
                        result = dateOfAdmission;
                    }
                    else
                    {
                        return null;
                    }
                }
                connectSql.Close();
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <returns></returns>
        internal static List<int> GetActiveEmployees(short anio, byte mes, int legajoDesde, int legajoHasta)
        {
            var result = new List<int>();

            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetActiveEmployeesY", connectSql))
                {

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.AddWithValue("@legajoDesde", legajoDesde);
                    storedProcedure.Parameters.AddWithValue("@legajoHasta", legajoHasta);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(reader.GetInt32(0));
                    }
                    reader.Close();
                }

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetActiveEmployeesYM", connectSql))
                {

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.AddWithValue("@legajoDesde", legajoDesde);
                    storedProcedure.Parameters.AddWithValue("@legajoHasta", legajoHasta);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(reader.GetInt32(0));
                    }
                    reader.Close();
                }

                connectSql.Close();
            }
            return result;
        }
        /// <summary>
        /// Genera una instancia de la clase EmployeeData a partir de los datos 
        /// que guarda la base de datos.
        /// </summary>
        /// <param name="id">Es el campo id, de la tabla empleados, por la cual busca y genera los datos.</param>
        /// <returns></returns>
        internal static EmployeeData GetEmployeeData(int id)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            
            EmployeeData employeeData = new EmployeeData();

            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using(SqlCommand storedProcedure = new SqlCommand("SP_GetEmployeeData", sqlConnection))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {                        
                        employeeData.Legajo = reader.GetInt32(0);
                        employeeData.Cuil = reader.GetInt64(1);
                        employeeData.NombreApellido = reader.GetString(2);
                        employeeData.FecIng = reader.GetDateTime(3);                    
                    }
                }
                sqlConnection.Close();
            }
            return employeeData;
        }
        internal static decimal GetEmployeeSalary(string sp, int legajo, short anio, byte mes)
        {
            // Datos para la conexión Sql
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            // Resultado
            decimal result = 0;
            
            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using(SqlCommand storedProcedure = new SqlCommand(sp, sqlConnection))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.Add(returnValue);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader.GetDecimal(0);
                    }                   
                }
            }
            return result;
        }
        internal static EmployeeFamily GetEmployeeFamily(int id)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            EmployeeFamily employeeFamily = new EmployeeFamily();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetEmployeeFamily", sqlConnection))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        employeeFamily.Legajo = reader.GetInt32(0);
                        employeeFamily.Cuil = reader.GetInt64(1);
                        employeeFamily.Anio = reader.GetInt16(2);
                        employeeFamily.TipoDoc = reader.GetByte(3);
                        employeeFamily.NroDoc = reader.GetInt64(4);
                        employeeFamily.Apellido = reader.GetString(5);
                        employeeFamily.Nombre = reader.GetString(6);
                        employeeFamily.FecNac = reader.GetDateTime(7);
                        employeeFamily.MesDesde = reader.GetByte(8);
                        employeeFamily.MesHasta = reader.GetByte(9);
                        employeeFamily.Parentesco = reader.GetByte(10);
                        employeeFamily.Porcentaje = reader.GetByte(11);
                    }
                }
                sqlConnection.Close();
            }
            return employeeFamily;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static EmployeeJobs GetEmployeeJobs(int id)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            EmployeeJobs employeeJobs = new EmployeeJobs();

            using(SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using(SqlCommand storedProcedure = new SqlCommand("SP_GetEmployeeJob", sqlConnection))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        employeeJobs.Legajo = reader.GetInt32(0);
                        employeeJobs.Anio = reader.GetInt16(1);
                        employeeJobs.Cuil = reader.GetInt64(2);
                        employeeJobs.Cuit = reader.GetInt64(3);
                        employeeJobs.Denominacion = reader.GetString(4);
                        employeeJobs.Mes = reader.GetByte(5);
                        employeeJobs.ObraSocial = reader.GetDecimal(6);
                        employeeJobs.SeguridadSocial = reader.GetDecimal(7);
                        employeeJobs.Sindicato = reader.GetDecimal(8);
                        employeeJobs.GananciaBruta = reader.GetDecimal(9);
                        employeeJobs.RetNoHabituales= reader.GetDecimal(10);
                        employeeJobs.Ajuste = reader.GetDecimal(11);
                        employeeJobs.RemuneracionExenta = reader.GetDecimal(12);
                        employeeJobs.Sac = reader.GetDecimal(13);
                        employeeJobs.HsExtrasGravadas = reader.GetDecimal(14);
                        employeeJobs.HsExtrasExentas = reader.GetDecimal(15);
                        employeeJobs.MaterialDidactico = reader.GetDecimal(16);
                        employeeJobs.MovilidadViaticos = reader.GetDecimal(17);
                    }
                }
                sqlConnection.Close();
            }
            return employeeJobs;
        }
        internal static EmployeeDivider GetEmployeeDivider(int id)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            EmployeeDivider employeeDivider = new EmployeeDivider();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetEmployeeDivisor", sqlConnection))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        employeeDivider.Legajo = reader.GetInt32(0);
                        employeeDivider.Anio = reader.GetInt16(1);
                        employeeDivider.Mes = reader.GetByte(2);
                        employeeDivider.Divisor = reader.GetByte(3);
                    }
                }
                sqlConnection.Close();
            }
            return employeeDivider;
        }
        /// <summary>
        /// Trae la sumatoria de la información requerida. La cual puede ser, remuneraciones, deducciones e items, del mes,
        /// correspondientes a otros empleos.
        /// </summary>
        /// <param name="legajo">Legajo del empleado a buscar</param>
        /// <param name="anio">Año a buscar.</param>
        /// <param name="mes">Mes a buscar.</param>
        /// <param name="sp">Procedimiento almacenado a ejecutar.</param>
        /// <returns></returns>
        internal static decimal GetMonthImport(int legajo, short anio, byte mes, string sp)
        {
            decimal result = 0;

            try
            {
                string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
                var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

                using (SqlConnection connectSql = new SqlConnection(connectionString))
                {
                    connectSql.Open();

                    using (SqlCommand storedProcedure = new SqlCommand(sp, connectSql))
                    {
                        storedProcedure.CommandType = CommandType.StoredProcedure;
                        storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                        storedProcedure.Parameters.AddWithValue("@anio", anio);
                        storedProcedure.Parameters.AddWithValue("@mes", mes);


                        var reader = storedProcedure.ExecuteReader();

                        while (reader.Read())
                        {
                            result = reader.GetDecimal(0);
                        }
                    }
                    connectSql.Close();
                }
            }
            catch
            {
                return 0;
            }
            return result;
        }
        /// <summary>
        /// Ejecuta un procedimiento almacenado que suma el importe, segun la variable sp.
        /// </summary>
        /// <param name="legajo">Legajo de busqueda</param>
        /// <param name="anio">Año de busqueda</param>
        /// <param name="mesDesde">Mes desde</param>
        /// <param name="mesHasta">Mes Hasta</param>
        /// <param name="sp">Stored procedure</param>
        /// <returns></returns>
        internal static decimal GetSumMonthImport(int legajo, short anio, byte mesDesde, byte mesHasta, string sp)
        {
            decimal result = 0  ;
            try
            {
                string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
                var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

                using (SqlConnection connectSql = new SqlConnection(connectionString))
                {
                    connectSql.Open();

                    using (SqlCommand storedProcedure = new SqlCommand(sp, connectSql))
                    {
                        storedProcedure.CommandType = CommandType.StoredProcedure;
                        storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                        storedProcedure.Parameters.AddWithValue("@anio", anio);
                        storedProcedure.Parameters.AddWithValue("@mesDesde", mesDesde);
                        storedProcedure.Parameters.AddWithValue("@mesHasta", mesHasta);

                        var reader = storedProcedure.ExecuteReader();

                        while (reader.Read())
                        {
                            result = reader.GetDecimal(0);
                        }
                    }
                    connectSql.Close();
                }
            }
            catch
            {
                return 0;
            }

            return result;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <returns></returns>
        internal static byte GetEmployeeDivision(int legajo, short anio, byte mes)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            byte result;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_CheckDivisor", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.Add(returnValue);

                    storedProcedure.ExecuteNonQuery();

                    result = Convert.ToByte(returnValue.Value);
                }
            }

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="sp"></param>
        /// <returns></returns>        
        internal static DataTable SeeAllRecords(DataTable ds, string sp)
        {
            // Cadena de conexión
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
           
            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand(sp, connectSql))
                {                    
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dt = new SqlDataAdapter(storedProcedure);
                    dt.Fill(ds);                    
                }
            }

            return ds;
        }

        /*
         * Queries para el esquema sistema.         
         */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resolution"></param>
        /// <param name="anio"></param>
        /// <param name="mes"></param>
        /// <returns></returns>

        internal static bool CheckActiveResolution(short anio, byte mesDesde, byte mesHasta)
        {
            byte result = 0;
            
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";

            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            for(int i = mesDesde;  i <= mesHasta; i++)
            {
                using (SqlConnection connectSql = new SqlConnection(connectionString))
                {
                    connectSql.Open();

                    using (SqlCommand storedProcedure = new SqlCommand("SP_CheckActiveResolution", connectSql))
                    {
                        SqlParameter returnValue = new SqlParameter();
                        returnValue.Direction = ParameterDirection.ReturnValue;

                        storedProcedure.CommandType = CommandType.StoredProcedure;
                        storedProcedure.Parameters.AddWithValue("@mes", i);
                        storedProcedure.Parameters.AddWithValue("@anio", anio);
                        storedProcedure.Parameters.Add(returnValue);

                        storedProcedure.ExecuteNonQuery();
                        
                        result = byte.Parse(returnValue.Value.ToString());                        
                    }

                    connectSql.Close();

                    if (result == 1)
                    {
                        break;
                    }
                }
            }
            
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static Resolucion GetMonthResolution(Resolucion resolution, short anio, byte mes)
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetActiveResolution", connectSql))
                {
                    SqlParameter returnValue = new SqlParameter();
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.Add(returnValue);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        resolution.Anio = reader.GetInt16(0);
                        resolution.MesDesde = reader.GetByte(1);
                        resolution.MesHasta = reader.GetByte(2);
                        resolution.LimiteInferior = reader.GetDecimal(3);
                        resolution.LimiteSuperior = reader.GetDecimal(4);
                        resolution.ResolucionName = reader.GetString(5);
                    }

                    reader.Close();
                }
                connectSql.Close();
            }
            return resolution;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="resolucion"></param>
        /// <returns></returns>
        internal static List<RangosSegundaDeduccion> GetRangeDedEspInc(string resolucion)
        {
            var result = new List<RangosSegundaDeduccion>();

            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetRangeDedIncEsp", connectSql))
                {

                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@resolucion", resolucion);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        result.Add(
                                new RangosSegundaDeduccion(
                                    resolucion,
                                    reader.GetDecimal(1),
                                    reader.GetDecimal(2), 
                                    reader.GetDecimal(3))
                            );
                    }

                    reader.Close();

                }
            }
            return result;
        }      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="deduccion"></param>
        /// <returns></returns>
        internal static decimal GetPersonalDeduction(short anio, string deduccion)
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;
            
            decimal result = 0;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetDeduccionPersonal", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@deduccion", deduccion);

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        result = reader.GetDecimal(0);
                    }                                
                }
            }

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valores"></param>
        /// <returns></returns>
        internal static List<short> GetDedEspYears(List<short> valores) 
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;          

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetDedPerYears", connectSql))
                {
                   
                    storedProcedure.CommandType = CommandType.StoredProcedure;

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        valores.Add(reader.GetInt16(0));
                    }
                }
            }
            return valores;
        }
        internal static List<string> GetResolutionName(List<string> resoluciones)
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetResolutionsName", sqlConnection))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;

                    var reader = storedProcedure.ExecuteReader();

                    while (reader.Read())
                    {
                        resoluciones.Add(reader.GetString(0));
                    }
                }
            }
                return resoluciones;
        }
       
        internal static DataTable SeeAllResolutions(DataTable ds)
        {
            // Cadena de conexión
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_SeeRangeDedIncEsp", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dt = new SqlDataAdapter(storedProcedure);
                    dt.Fill(ds);
                }
            }
            return ds;
        }

        public static Resolucion GetResolutionInfo(Resolucion resolucion, string resolutionName)
        {
            // Cadena de conexión
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_GetResolutionInfo", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@resolucion", resolutionName);

                    var reader = storedProcedure.ExecuteReader();

                    while(reader.Read())
                    {
                        resolucion.Anio = reader.GetInt16(0);
                        resolucion.MesDesde = reader.GetByte(1);
                        resolucion.MesHasta = reader.GetByte(2);
                        resolucion.LimiteInferior = reader.GetDecimal(3);
                        resolucion.LimiteSuperior = reader.GetDecimal(4);
                        resolucion.ResolucionName = resolutionName;
                    }                    
                }
            }
            return resolucion;
        }
    }
}
