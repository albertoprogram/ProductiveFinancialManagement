using ProFinancialM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProFinancialM.Services
{
    public class CapitalsPhase1Services
    {
        #region InsertCapitalPhase1
        public void InsertCapitalPhase1(CapitalsPhase1 capitalsPhase1, 
            out long idCapPh1FromSQLServer, 
            out bool errorFromSQLServer,
            out int errorNumberFromSQLServer,
            out int errorSeverityFromSQLServer,
            out int errorStatusFromSQLServer,
            out string errorProcedureFromSQLServer,
            out int errorLineFromSQLServer,
            out string errorMessageFromSQLServer,
            out string originClass,
            out string originMethod)
        {

            using (var db = new ProFinancialMDBContext())
            {
                var idCapPh1 = new SqlParameter
                {
                    ParameterName = "@idCapPh1",
                    SqlDbType = SqlDbType.BigInt,
                    Direction = ParameterDirection.Output
                };

                var error = new SqlParameter
                {
                    ParameterName = "@error",
                    SqlDbType = SqlDbType.Bit,
                    Direction = ParameterDirection.Output
                };

                var errorNumber = new SqlParameter
                {
                    ParameterName = "@errorNumber",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                var errorSeverity = new SqlParameter
                {
                    ParameterName = "@errorSeverity",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                var errorStatus = new SqlParameter
                {
                    ParameterName = "@errorStatus",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                var errorProcedure = new SqlParameter
                {
                    ParameterName = "@errorProcedure",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 250,
                    Direction = ParameterDirection.Output
                };

                var errorLine = new SqlParameter
                {
                    ParameterName = "@errorLine",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                var errorMessage = new SqlParameter
                {
                    ParameterName = "@errorMessage",
                    SqlDbType = SqlDbType.VarChar,
                    Size = 8000,
                    Direction = ParameterDirection.Output
                };

                db.Database.ExecuteSqlCommand("InsertCapitalPhase1 " +
                    "@amount," +
                    "@concept," +
                    "@idCapPh1 OUTPUT," +
                    "@error OUTPUT," +
                    "@errorNumber OUTPUT," +
                    "@errorSeverity OUTPUT," +
                    "@errorStatus OUTPUT," +
                    "@errorProcedure OUTPUT," +
                    "@errorLine OUTPUT," +
                    "@errorMessage OUTPUT",
                    new SqlParameter("@amount", capitalsPhase1.Amount),
                    new SqlParameter("@concept", capitalsPhase1.Concept),
                    idCapPh1,
                    error,
                    errorNumber,
                    errorSeverity,
                    errorStatus,
                    errorProcedure,
                    errorLine,
                    errorMessage
                    );

                idCapPh1FromSQLServer = Convert.ToInt64(idCapPh1.Value);
                errorFromSQLServer = Convert.ToBoolean(error.Value);
                errorNumberFromSQLServer = Convert.ToInt32(errorNumber.Value);
                errorSeverityFromSQLServer = Convert.ToInt32(errorSeverity.Value);
                errorStatusFromSQLServer = Convert.ToInt32(errorStatus.Value);
                errorProcedureFromSQLServer = errorProcedure.Value.ToString();
                errorLineFromSQLServer = Convert.ToInt32(errorLine.Value);
                errorMessageFromSQLServer = errorMessage.Value.ToString();

                originClass = this.GetType().Name;
                originMethod = System.Reflection.MethodBase.GetCurrentMethod().Name;
            }
        }
        #endregion
    }
}