using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Ttar.Entities.Concrete;

namespace Ttar.DAL.Concrete.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(@"Categories", @"dbo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("CategoryId");
            builder.Property(x => x.Name).HasColumnName("CategoryName");
        }
    }
}
