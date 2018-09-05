using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMP.ApplicationContext.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMP.ApplicationContext.Map
{
    public class RegisterMap :IEntityTypeConfiguration<Register>
    {
        public void Configure(EntityTypeBuilder<Register> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("Register");
        }
    }
}
