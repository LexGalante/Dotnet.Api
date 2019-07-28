using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Infra.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");
            builder.HasKey("login");

            builder.Property(x => x.Login)
                   .HasColumnName("login")
                   .HasMaxLength(20)
                   .IsRequired();
            builder.Property(x => x.Password)
                   .HasColumnName("password")
                   .HasMaxLength(100)
                   .IsRequired();
            builder.Property(x => x.Name)
                   .HasColumnName("name")
                   .HasMaxLength(150)
                   .IsRequired();
            builder.Property(x => x.Email)
                   .HasColumnName("email")
                   .HasMaxLength(255)
                   .IsRequired();
            builder.Property(x => x.CreatedBy)
                   .HasColumnName("created_by")
                   .HasMaxLength(20)
                   .IsRequired();
            builder.Property(x => x.CreatedAt)
                   .HasColumnName("created_at")
                   .IsRequired();
            builder.Property(x => x.UpdatedBy)
                   .HasColumnName("updated_by")
                   .HasMaxLength(20)
                   .IsRequired();
            builder.Property(x => x.UpdatedAt)
                   .HasColumnName("updated_at")
                   .IsRequired();

            builder.HasOne(x => x.UserCreation)
                   .WithMany(x => x.Creator)
                   .HasForeignKey(x => x.CreatedBy)
                   .HasConstraintName("fk_user_created_by");
            builder.HasOne(x => x.UserChange)
                   .WithMany(x => x.Changer)
                   .HasForeignKey(x => x.UpdatedBy)
                   .HasConstraintName("fk_user_updated_by");
        }
    }
}
