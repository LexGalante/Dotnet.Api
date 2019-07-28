using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Infra.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("user_role");
            builder.HasKey(x => new { x.Login, x.RoleName });

            builder.Property(x => x.Login)
                   .HasColumnName("login")
                   .HasMaxLength(20);
            builder.Property(x => x.RoleName)
                   .HasColumnName("role_name")
                   .HasMaxLength(50);
            builder.Property(x => x.CreatedBy)
                   .HasColumnName("created_by");
            builder.Property(x => x.CreatedAt)
                   .HasColumnName("created_at");

            builder.HasOne(x => x.User)
                   .WithMany(x => x.UserRoles)
                   .HasForeignKey(x => x.Login)
                   .HasConstraintName("fk_user_role_login");
            builder.HasOne(x => x.Role)
                   .WithMany(x => x.UserRoles)
                   .HasForeignKey(x => x.RoleName)
                   .HasConstraintName("fk_user_role_name");
            builder.HasOne(x => x.UserCreation)
                   .WithMany(x => x.CreatorUserRoles)
                   .HasForeignKey(x => x.CreatedBy)
                   .HasConstraintName("fk_user_role_created_by");
        }
    }
}
