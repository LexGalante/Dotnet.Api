using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Domain
{
    public class UserRole
    {
        public string Login { get; set; }
        public string RoleName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
        public User UserCreation { get; set; }
    }
}
