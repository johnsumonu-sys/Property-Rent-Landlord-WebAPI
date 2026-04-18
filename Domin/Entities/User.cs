using Domin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities
{
    public class User
    {
        public Guid Id { get; set; }  // UUID

        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string PhoneNumber { get; set; }

        public UserRole Role { get; set; }

        public UserStatus Status { get; set; } = UserStatus.Active;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}

