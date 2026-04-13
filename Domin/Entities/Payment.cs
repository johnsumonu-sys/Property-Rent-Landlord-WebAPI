using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities
{
    public class Payment
    {
    // Primary Key
    public Guid Id { get; set; }

        // Foreign Keys
        public Guid RentScheduleId { get; set; }
        public Guid LeaseId { get; set; }
        public Guid TenantId { get; set; }
        public Guid LandlordId { get; set; }

        // Payment Details
        public decimal AmountPaid { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public DateTime PaymentDate { get; set; }

        public string? TransactionReference { get; set; } // Nullable (for Paystack)
        public string? Notes { get; set; } // Nullable

        // Audit Field
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties (optional but recommended)
        public RentSchedule RentSchedule { get; set; }
        public Lease Lease { get; set; }
        public User Tenant { get; set; }
        public User Landlord { get; set; }
    }
}
