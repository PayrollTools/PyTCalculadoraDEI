using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PytCalcModel
{
    internal static class UpdateQueries
    {
        internal static void UpdateEmployeeData(int id, long cuil, string nombreApellido, DateTime fecIng)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();                
                using (SqlCommand storedProcedure = new SqlCommand("SP_UpdateEmployee", connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);
                    storedProcedure.Parameters.AddWithValue("@cuil", cuil);
                    storedProcedure.Parameters.AddWithValue("@apynom", nombreApellido);
                    storedProcedure.Parameters.AddWithValue("@fecing", fecIng);
                    storedProcedure.ExecuteNonQuery();                    
                }               
                connectionSql.Close();
            }
        }
        internal static void UpdateEmployeeSalary(int legajo, short anio, byte mes, string procedure, decimal employeeSalary)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();
                using (SqlCommand storedProcedure = new SqlCommand(procedure, connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@mes", mes);
                    storedProcedure.Parameters.AddWithValue("@importe", employeeSalary);
                    storedProcedure.ExecuteNonQuery();
                }
                connectionSql.Close();
            }
        }
        internal static void UpdateEmployeeFamily(int id, EmployeeFamily employeeFamily)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();                
                using (SqlCommand storedProcedured = new SqlCommand("SP_UpdateCargaFamilia", connectionSql))
                {
                    storedProcedured.CommandType = CommandType.StoredProcedure;
                    storedProcedured.Parameters.AddWithValue("@id", id);
                    storedProcedured.Parameters.AddWithValue("@tipdoc", employeeFamily.TipoDoc);
                    storedProcedured.Parameters.AddWithValue("@nrodoc", employeeFamily.NroDoc);
                    storedProcedured.Parameters.AddWithValue("@apellido", employeeFamily.Apellido);
                    storedProcedured.Parameters.AddWithValue("@nombre", employeeFamily.Nombre);
                    storedProcedured.Parameters.AddWithValue("@fecnac", employeeFamily.FecNac);
                    storedProcedured.Parameters.AddWithValue("@mesdesde", employeeFamily.MesDesde);
                    storedProcedured.Parameters.AddWithValue("@meshasta", employeeFamily.MesHasta);
                    storedProcedured.Parameters.AddWithValue("@parentesco", employeeFamily.Parentesco);
                    storedProcedured.Parameters.AddWithValue("@porcentaje", employeeFamily.Porcentaje);
                    storedProcedured.ExecuteNonQuery();
                }
                connectionSql.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employeeJobs"></param>
        internal static void UpdateEmployeeJobs(int id, EmployeeJobs employeeJobs)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();
                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedure = new SqlCommand("SP_UpdateOtroEmpleo", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);
                    storedProcedure.Parameters.AddWithValue("@obrasocial", employeeJobs.ObraSocial);
                    storedProcedure.Parameters.AddWithValue("@seguridadsocial", employeeJobs.SeguridadSocial);
                    storedProcedure.Parameters.AddWithValue("@sindicato", employeeJobs.Sindicato);
                    storedProcedure.Parameters.AddWithValue("@gananciabruta", employeeJobs.GananciaBruta);                    
                    storedProcedure.Parameters.AddWithValue("@retnohab", employeeJobs.RetNoHabituales);
                    storedProcedure.Parameters.AddWithValue("@ajuste", employeeJobs.Ajuste);
                    storedProcedure.Parameters.AddWithValue("@remuneracionexenta", employeeJobs.RemuneracionExenta);
                    storedProcedure.Parameters.AddWithValue("@sac", employeeJobs.Sac);
                    storedProcedure.Parameters.AddWithValue("@hsextrasgravadas", employeeJobs.HsExtrasGravadas);
                    storedProcedure.Parameters.AddWithValue("@hsextrasexentas", employeeJobs.HsExtrasExentas);
                    storedProcedure.Parameters.AddWithValue("@materialdidactico", employeeJobs.MaterialDidactico);
                    storedProcedure.Parameters.AddWithValue("@movilidadviaticos", employeeJobs.MovilidadViaticos);
                    storedProcedure.ExecuteNonQuery();
                }
                transaction.Commit();
                connectionSql.Close();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employeeDivision"></param>
        internal static void UpdateEmployeeDivision(int id, byte divisor)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();
                
                using (SqlCommand storedProcedure = new SqlCommand("SP_UpdateDivisor", connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);
                    storedProcedure.Parameters.AddWithValue("@divisor", divisor);
                    storedProcedure.ExecuteNonQuery();
                }
                connectionSql.Close();
            }
        }

        /*
         * Queries esquema System.
         */

        internal static void UpdatePersonalDeduction(short anio, string deduccion, decimal importe)
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();
                using (SqlCommand storedProcedure = new SqlCommand("SP_UpdateDeducPersonales", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@deduccion", deduccion);
                    storedProcedure.Parameters.AddWithValue("@importe", importe);
                    storedProcedure.ExecuteNonQuery();
                }
                connectSql.Close();
            }
        }

        internal static void UpdateResolution(byte mesDesde, byte mesHasta, decimal importeDesde, decimal importeHasta, string resolucion)
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();
                using (SqlCommand storedProcedure = new SqlCommand("SP_UpdateResoluciones", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@mesDesde", mesDesde);
                    storedProcedure.Parameters.AddWithValue("@mesHasta", mesHasta);
                    storedProcedure.Parameters.AddWithValue("@importeDesde", importeDesde);
                    storedProcedure.Parameters.AddWithValue("@importeHasta", importeHasta);
                    storedProcedure.Parameters.AddWithValue("@resolucion", resolucion);
                    storedProcedure.ExecuteNonQuery();
                }
                connectSql.Close();
            }
        }
    }
}
