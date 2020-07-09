using ProFinancialM.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProFinancialM.Services
{
    public class CapitalsPhase1Services
    {
        #region InsertCapitalPhase1
        public void InsertCapitalPhase1 (CapitalsPhase1 capitalsPhase1)
        {
            using(var db = new ProFinancialMDBContext())
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
                    new SqlParameter("@amount",capitalsPhase1.Amount),
                    new SqlParameter("@concept",capitalsPhase1.Concept),
                    idCapPh1,
                    error,
                    errorNumber,
                    errorSeverity,
                    errorStatus,
                    errorProcedure,
                    errorLine,
                    errorMessage
                    );
            }
        }
        #endregion
    }
}