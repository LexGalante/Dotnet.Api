using Microsoft.EntityFrameworkCore;
using Net.Core.Domain;
using Net.Core.Infra.Configurations;
using Net.Core.Infra.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.Core.Infra.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }

        public IQueryable<User> Users => Set<User>();        
    }
}
