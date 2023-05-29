using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PytCalcModel
{
    internal class InsertQueries
    {
        public static void InsertEmployeeData(EmployeeData employeeData)
        {            
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                SqlTransaction transaction = connectionSql.BeginTransaction();


                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertEmployee", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeData.Legajo);
                    storedProcedure.Parameters.AddWithValue("@cuil", employeeData.Cuil);
                    storedProcedure.Parameters.AddWithValue("@apynom", employeeData.NombreApellido);
                    storedProcedure.Parameters.AddWithValue("@fecing", employeeData.FecIng);

                    storedProcedure.ExecuteNonQuery();
                };

                transaction.Commit();

                connectionSql.Close();
            }            
        }

        public static void InsertEmployeeSalary(EmployeeSalary employeeSalary, string sp)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            string procedimientoAlmacenado = sp;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();
                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedured = new SqlCommand(procedimientoAlmacenado, connectionSql, transaction))
                {
                    storedProcedured.CommandType = CommandType.StoredProcedure;
                    storedProcedured.Parameters.AddWithValue("@legajo", employeeSalary.Legajo);
                    storedProcedured.Parameters.AddWithValue("@apynom", employeeSalary.NombreApellido);
                    storedProcedured.Parameters.AddWithValue("@anio", employeeSalary.Anio);
                    storedProcedured.Parameters.AddWithValue("@mes", employeeSalary.Mes);
                    storedProcedured.Parameters.AddWithValue("@importe", employeeSalary.Importe);

                    storedProcedured.ExecuteNonQuery();
                }

                transaction.Commit();

                connectionSql.Close();
            }
        }

        public static void InsertEmployeeFamily(EmployeeFamily employeeFamily)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();
                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertCargasFamilia", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeFamily.Legajo);
                    storedProcedure.Parameters.AddWithValue("@cuil", employeeFamily.Cuil);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeFamily.Anio);
                    storedProcedure.Parameters.AddWithValue("@tipoDoc", employeeFamily.TipoDoc);
                    storedProcedure.Parameters.AddWithValue("@nroDoc", employeeFamily.NroDoc);
                    storedProcedure.Parameters.AddWithValue("@apellido", employeeFamily.Apellido);
                    storedProcedure.Parameters.AddWithValue("@nombre", employeeFamily.Nombre);
                    storedProcedure.Parameters.AddWithValue("@fecNac", employeeFamily.FecNac);
                    storedProcedure.Parameters.AddWithValue("@mesDesde", employeeFamily.MesDesde);
                    storedProcedure.Parameters.AddWithValue("@mesHasta", employeeFamily.MesHasta);
                    storedProcedure.Parameters.AddWithValue("@parentesco", employeeFamily.Parentesco);
                    storedProcedure.Parameters.AddWithValue("@porcentaje", employeeFamily.Porcentaje);

                    storedProcedure.ExecuteNonQuery();
                };

                transaction.Commit();

                connectionSql.Close();
            };
        }

        public static void InsertEmployeeJobs(EmployeeJobs employeeJobs)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();
                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertOtrosEmpleos", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeJobs.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeJobs.Anio);
                    storedProcedure.Parameters.AddWithValue("@cuil", employeeJobs.Cuil);
                    storedProcedure.Parameters.AddWithValue("@cuit", employeeJobs.Cuit);
                    storedProcedure.Parameters.AddWithValue("@denominacion", employeeJobs.Denominacion);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeJobs.Mes);
                    storedProcedure.Parameters.AddWithValue("@obraSocial", employeeJobs.ObraSocial);
                    storedProcedure.Parameters.AddWithValue("@seguridadSocial", employeeJobs.SeguridadSocial);
                    storedProcedure.Parameters.AddWithValue("@sindicato", employeeJobs.Sindicato);
                    storedProcedure.Parameters.AddWithValue("@gananciaBruta", employeeJobs.GananciaBruta);
                    storedProcedure.Parameters.AddWithValue("@retNoHab", employeeJobs.RetNoHabituales);
                    storedProcedure.Parameters.AddWithValue("@ajuste", employeeJobs.Ajuste);
                    storedProcedure.Parameters.AddWithValue("@remuneracionExenta", employeeJobs.RemuneracionExenta);
                    storedProcedure.Parameters.AddWithValue("@sac", employeeJobs.Sac);
                    storedProcedure.Parameters.AddWithValue("@hsExtrasGravadas", employeeJobs.HsExtrasGravadas);
                    storedProcedure.Parameters.AddWithValue("@hsExtrasExentas", employeeJobs.HsExtrasExentas);
                    storedProcedure.Parameters.AddWithValue("@materialDidactico", employeeJobs.MaterialDidactico);
                    storedProcedure.Parameters.AddWithValue("@movilidadViaticos", employeeJobs.MovilidadViaticos);

                    storedProcedure.ExecuteNonQuery();
                };

                transaction.Commit();

                connectionSql.Close();
            };
        }

        public static void InsertEmployeeDivision(EmployeeDivider employeeDivision)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertDivisor", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeDivision.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeDivision.Anio);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeDivision.Mes);
                    storedProcedure.Parameters.AddWithValue("@divisor", employeeDivision.Divisor);

                    storedProcedure.ExecuteNonQuery();
                }

                transaction.Commit();

                connectionSql.Close();
            }
        }
        /// <summary>
        /// Agrega un registro en la tabla "promediosbrutos", dentro del esquema "EmployeeDataBase".
        /// </summary>
        /// <param name="employeeAverage">EmployeeAverage</param>
        public static void InsertEmployeeAverage(EmployeeAverage employeeAverage)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertAverage", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeAverage.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeAverage.Anio);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeAverage.Mes);
                    storedProcedure.Parameters.AddWithValue("@importe", employeeAverage.Promedio);

                    storedProcedure.ExecuteNonQuery();
                }

                transaction.Commit();

                connectionSql.Close();
            }
        }
        /// <summary>
        /// Agrega un registro en la tabla "primerparrafo", dentro del esquema "EmployeeDataBase".
        /// </summary>
        /// <param name="employeeFirstDeduction">EmployeeFirstDeduction</param>
        public static void InsertEmployeeFirstDeduction(EmployeeFirstDeduction employeeFirstDeduction)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertFirstDeduction", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeFirstDeduction.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeFirstDeduction.Anio);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeFirstDeduction.Mes);
                    storedProcedure.Parameters.AddWithValue("@remmes", employeeFirstDeduction.RemuneracionMensual);
                    storedProcedure.Parameters.AddWithValue("@remmesoe", employeeFirstDeduction.RemuneracionMensualOE);
                    storedProcedure.Parameters.AddWithValue("@dedmes", employeeFirstDeduction.DeduccionMensual);
                    storedProcedure.Parameters.AddWithValue("@dedmesoe", employeeFirstDeduction.DeduccionMensualOE);
                    storedProcedure.Parameters.AddWithValue("@familia", employeeFirstDeduction.CargasFamilia);
                    storedProcedure.Parameters.AddWithValue("@dedper", employeeFirstDeduction.DeduccionesPersonales);
                    storedProcedure.Parameters.AddWithValue("@importe", employeeFirstDeduction.Deduccion);
                    storedProcedure.ExecuteNonQuery();
                }

                transaction.Commit();

                connectionSql.Close();
            }
        }
        /// <summary>
        /// Agrega un registro en la tabla "segundoparrafo", dentro del esquema "EmployeeDataBase".
        /// </summary>
        /// <param name="employeeAverage">EmployeeSecondDeduction</param>
        public static void InsertEmployeeSecondDeduction(EmployeeSecondDeduction employeeSecondDeduction)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                SqlTransaction transaction = connectionSql.BeginTransaction();

                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertSecondDeduction", connectionSql, transaction))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeSecondDeduction.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeSecondDeduction.Anio);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeSecondDeduction.Mes);
                    storedProcedure.Parameters.AddWithValue("@importe", employeeSecondDeduction.Deduccion);

                    storedProcedure.ExecuteNonQuery();
                }

                transaction.Commit();

                connectionSql.Close();
            }
        }
        /*
         * Queries del esquema sistema.
         */

        /// <summary>
        /// 
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="deduccion"></param>
        /// <param name="importe"></param>
        internal static void InsertPersonalDeduction(short anio, string deduccion, decimal importe)
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();
                using (SqlCommand storedProcedure = new SqlCommand("SP_InsertDeducPersonales", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@anio", anio);
                    storedProcedure.Parameters.AddWithValue("@deduccion", deduccion);
                    storedProcedure.Parameters.AddWithValue("@importe", importe);
                    storedProcedure.ExecuteNonQuery();
                }
            }
        }

        internal static string InsertResolution(Resolucion resolucion, string file)
        {
            string message = "Se finalizo el proceso correctamente.";

            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            List<RangosSegundaDeduccion> rangos = ReadExcelFiles.ImportarRangosSegundaDeduc(file, resolucion.ResolucionName);

            using(SqlConnection connectSql = new SqlConnection( connectionString))
            {
                connectSql.Open();

                SqlTransaction transaction = connectSql.BeginTransaction();
                
                try
                {
                   
                    foreach(RangosSegundaDeduccion rango in rangos)
                    {
                        using (SqlCommand storedProcedure = new SqlCommand("SP_InsertRangoDedEspInc", connectSql, transaction))
                        {
                            storedProcedure.CommandType = CommandType.StoredProcedure;
                            storedProcedure.Parameters.AddWithValue("@resolucion", rango.ResolutionName);
                            storedProcedure.Parameters.AddWithValue("@limiteinferior", rango.LimiteInferior);
                            storedProcedure.Parameters.AddWithValue("@limitesuperior", rango.LimiteSuperior);
                            storedProcedure.Parameters.AddWithValue("@deduccion", rango.Deduccion);
                            storedProcedure.ExecuteNonQuery();
                        }
                    }

                    using (SqlCommand storedProcedure = new SqlCommand("SP_InsertResolucion", connectSql, transaction))
                    {
                        storedProcedure.CommandType = CommandType.StoredProcedure;
                        storedProcedure.Parameters.AddWithValue("@anio", resolucion.Anio);
                        storedProcedure.Parameters.AddWithValue("@mesinicio", resolucion.MesDesde);
                        storedProcedure.Parameters.AddWithValue("@meshasta", resolucion.MesHasta);
                        storedProcedure.Parameters.AddWithValue("@limiteinferior", resolucion.LimiteInferior);
                        storedProcedure.Parameters.AddWithValue("@limitesuperior", resolucion.LimiteSuperior);
                        storedProcedure.Parameters.AddWithValue("@resolucion", resolucion.ResolucionName);
                        storedProcedure.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    connectSql.Close();
                
                }
                catch(Exception ex)
                {
                    message = ex.Message;
                    transaction.Rollback();
                    connectSql.Close();
                }
            }

            return message;
        }        
    }
}