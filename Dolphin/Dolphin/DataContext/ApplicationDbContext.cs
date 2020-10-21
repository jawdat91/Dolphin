using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Npgsql;
using Dolphin.Models;

namespace Dolphin.DataContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext():base(nameOrConnectionString: "Myconnection")
        {

        }
        public virtual DbSet<CompanyClass> Companies { get; set; }
    }
}