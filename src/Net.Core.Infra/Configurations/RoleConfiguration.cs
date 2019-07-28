using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Infra.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("role");
            builder.HasKey("name");

            builder.Property(x => x.Name)
                   .HasColumnName("name")
                   .HasMaxLength(50);
            builder.Property(x => x.CreatedBy)
                   .HasColumnName("created_by");
            builder.Property(x => x.CreatedAt)
                   .HasColumnName("created_at");

            builder.HasOne(x => x.UserCreation)
                   .WithMany(x => x.CreatorRoles)
                   .HasForeignKey(x => x.CreatedBy)
                   .HasConstraintName("fk_role_created_by");
        }
    }
}
