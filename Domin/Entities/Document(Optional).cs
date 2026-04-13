using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities
{
    public class Document_Optional_
    {
        public Guid Id { get; set; } // Primary Key

        public Guid LeaseId { get; set; } // FK to Lease

        public Guid UploadedBy { get; set; } // FK to User

        public string DocumentType { get; set; } // e.g. "TENANCY_AGREEMENT", "IDENTITY"

        public string FileUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        // Navigation Properties (optional for EF Core)
        public Lease Lease { get; set; }

        public User UploadedByUser { get; set; }
    }
}

