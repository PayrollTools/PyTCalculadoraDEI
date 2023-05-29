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
    internal class DeleteQueries
    {
        internal static void DeleteEmployee(int legajo)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectSql = new SqlConnection(connectionString))
            {
                connectSql.Open();
                using (SqlCommand storedProcedure = new SqlCommand("SP_DeleteEmployee", connectSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", legajo);
                    storedProcedure.ExecuteNonQuery();
                }

                connectSql.Close();
            }
        }
        internal static void DeleteRegister(int id, string sp)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand(sp, connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@id", id);
                    storedProcedure.ExecuteNonQuery();
                }                
                connectionSql.Close();
            }
        }
        internal static void DeleteEmployeeAverage(EmployeeAverage employeeAverage)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_DeleteAverage", connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeAverage.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeAverage.Anio);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeAverage.Mes);
                    storedProcedure.ExecuteNonQuery();
                }
                connectionSql.Close();
            }
        }
        internal static void DeleteEmployeeFirstDeduction(EmployeeFirstDeduction employeeFirstDeduction)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_DeleteFirstDeduction", connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeFirstDeduction.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeFirstDeduction.Anio);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeFirstDeduction.Mes);
                    storedProcedure.ExecuteNonQuery();
                }
                connectionSql.Close();
            }
        }
        internal static void DeleteEmployeeSecondDeduction(EmployeeSecondDeduction employeeSecondDeduction)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                using (SqlCommand storedProcedure = new SqlCommand("SP_DeleteSecondDeduction", connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@legajo", employeeSecondDeduction.Legajo);
                    storedProcedure.Parameters.AddWithValue("@anio", employeeSecondDeduction.Anio);
                    storedProcedure.Parameters.AddWithValue("@mes", employeeSecondDeduction.Mes);
                    storedProcedure.ExecuteNonQuery();
                }
                connectionSql.Close();
            }
        }

        internal static void DeleteTable(string sp)
        {
            string connection = "PytCalcModel.Properties.Settings.EmployeeDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using(SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();

                using(SqlCommand storedProcedure = new SqlCommand(sp, connectionSql))
                {
                    storedProcedure.CommandType= CommandType.StoredProcedure;
                    storedProcedure.ExecuteNonQuery();
                }

                connectionSql.Close();
            }
        }

        /*
         * Queries del esquema system
         */

        internal static void DeleteResolution(string resolution)
        {
            string connection = "PytCalcModel.Properties.Settings.SystemDataBase";
            var connectionString = ConfigurationManager.ConnectionStrings[connection].ConnectionString;

            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connectionSql.Open();                

                using (SqlCommand storedProcedure = new SqlCommand("SP_DeleteResolution", connectionSql))
                {
                    storedProcedure.CommandType = CommandType.StoredProcedure;
                    storedProcedure.Parameters.AddWithValue("@resolucion", resolution);
                    storedProcedure.ExecuteNonQuery();
                }
                connectionSql.Close();
            }
        }
    }
}
