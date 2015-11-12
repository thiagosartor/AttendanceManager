using AttendanceManager.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AttendanceManager.WebApp.Infraestructure.DBContext
{
    public class DAContext : DbContext
    {

        public DAContext()
            : base("DAContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DAContext>());
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Turma> Turmas { get; set; }
    }
}