using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities
{
    public class Rentschedule
    {
        // Primary Key
        public Guid Id { get; set; }

        // Foreign Keys
        public Guid LeaseId { get; set; }
        public Guid TenantId { get; set; }
        public Guid LandlordId { get; set; }

        // Rent Details
        public DateTime DueDate { get; set; }
        public decimal ExpectedAmount { get; set; }
        public decimal AmountPaid { get; set; } = 0m;

        public RentScheduleStatus Status { get; set; } = RentScheduleStatus.PENDING;

        // Audit Fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties (optional but recommended)
        public Lease Lease { get; set; }
        public User Tenant { get; set; }
        public User Landlord { get; set; }
    }
}
