using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Domain
{
    public class Role
    {
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public User UserCreation { get; set; }
    }
}
