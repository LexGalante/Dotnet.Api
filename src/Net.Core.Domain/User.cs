using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Core.Domain
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public User UserCreation { get; set; }
        public User UserChange { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

        #region Field Created_By
        public ICollection<User> Creator { get; set; }
        public ICollection<User> Changer { get; set; }
        public ICollection<Role> CreatorRoles { get; set; }
        public ICollection<UserRole> CreatorUserRoles { get; set; }
        #endregion
    }
}
