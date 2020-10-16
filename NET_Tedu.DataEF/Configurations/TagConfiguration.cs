using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_Tedu.Data.Entities;
using NET_Tedu.Data.EF.Extentions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NET_Tedu.Data.EF.Configurations
{
    public class TagConfiguration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50)
                .IsRequired().HasColumnType("varchar");
        }
    }
}
