using EntityFrameworks.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworks.Data
{
    public class EmployeeContext:DbContext
    {
        public DbSet<EmployeeEntities> Employee { get; set; }
        public object EmployeeEntities { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=VBOPPANA01;Database=Employee;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
