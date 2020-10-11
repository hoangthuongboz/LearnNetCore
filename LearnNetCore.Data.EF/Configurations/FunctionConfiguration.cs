using LearnNetCore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using static LearnNetCore.Data.EF.Extentions.ModelBuilderExtensions;

namespace LearnNetCore.Data.EF.Configurations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.Property(c => c.Id).HasColumnType("VARCHAR(20)").IsRequired();
        }
    }
}
