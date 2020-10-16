using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET_Tedu.Data.EF.Extentions;
using System;
using System.Collections.Generic;
using System.Text;
using NET_Tedu.Data.Entities;

namespace NET_Tedu.Data.EF.Configurations
{
    public class ContactDetailConfiguration : DbEntityConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
