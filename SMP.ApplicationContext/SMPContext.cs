using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using SMP.ApplicationContext.Map;

namespace SMP.ApplicationContext
{
    public class SMPContext:DbContext
    {
        public SMPContext(DbContextOptions  options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RegisterMap());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
