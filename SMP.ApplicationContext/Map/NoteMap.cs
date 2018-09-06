using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMP.ApplicationContext.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMP.ApplicationContext.Map
{
    public class NoteMap : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DateNote).IsUnicode().HasMaxLength(4000).IsRequired();
        }
    }
}
