using LearnNetCore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using static LearnNetCore.Data.EF.Extentions.ModelBuilderExtensions;

namespace LearnNetCore.Data.EF.Configurations
{
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<Advertistment>
    {
        public override void Configure(EntityTypeBuilder<Advertistment> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
        }
    }
}
