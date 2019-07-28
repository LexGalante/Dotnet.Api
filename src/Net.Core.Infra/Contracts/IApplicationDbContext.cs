using Net.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.Core.Infra.Contracts
{
    public interface IApplicationDbContext
    {
        IQueryable<User> Users { get; }
    }
}
