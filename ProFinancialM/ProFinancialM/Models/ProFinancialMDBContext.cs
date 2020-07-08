using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProFinancialM.Models
{
    public class ProFinancialMDBContext : DbContext
    {
        public ProFinancialMDBContext()
            : base("ProFinancialMConnectionString2")
        {

        }

        public DbSet<CapitalsPhase1> CapitalsPhase1 { get; set; }
    }
}