using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using SMP.ApplicationContext.Map;
using System.Reflection;
using System.Linq;

namespace SMP.ApplicationContext
{
    public class SMPContext:DbContext
    {
        public SMPContext(DbContextOptions  options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var mapTypes = Assembly.GetExecutingAssembly().ExportedTypes.Where(p => p.Name.EndsWith("Map") && !p.IsAbstract);
            foreach (var item in mapTypes)
            {
                dynamic obj = Activator.CreateInstance(item);
                modelBuilder.ApplyConfiguration(obj);
            }
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
