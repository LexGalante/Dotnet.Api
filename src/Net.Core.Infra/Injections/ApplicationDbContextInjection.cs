using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net.Core.Infra.Contexts;
using Net.Core.Infra.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Infra.Injections
{
    public static class ApplicationDbContextInjection
    {
        public static void AddApplicationDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
