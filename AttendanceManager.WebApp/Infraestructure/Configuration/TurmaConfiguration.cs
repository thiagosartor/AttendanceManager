using AttendanceManager.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AttendanceManager.WebApp.Infraestructure.Configuration
{
    public class TurmaConfiguration : EntityTypeConfiguration<Turma>
    {
        public TurmaConfiguration()
        {
            ToTable("TBTurma");

            HasKey(t => t.Id);

            Property(t => t.Ano);
        }
    }
}