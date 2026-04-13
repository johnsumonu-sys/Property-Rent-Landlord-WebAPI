using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domin.Entities
{
    public class Review_Optional_
    {
        public class Review
        {
            public Guid Id { get; set; } // Primary Key

            public Guid PropertyId { get; set; } // FK to Property

            public Guid TenantId { get; set; } // FK to User

            [Range(1, 5)]
            public int Rating { get; set; } // 1 - 5

            public string Comment { get; set; } // Nullable

            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


            // Navigation Properties (optional for EF Core)
            public Property Property { get; set; }

            public User Tenant { get; set; }
        }
    }
}
