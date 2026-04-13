using Domin.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domin.Entities
{
    public class Lease
    {
        [Key]
        public Guid Id { get; set; }

        // Foreign Keys
        [Required]
        public Guid PropertyId { get; set; }

        [Required]
        public Guid LandlordId { get; set; }

        [Required]
        public Guid TenantId { get; set; }

        // Lease Details
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal RentAmount { get; set; }

        [Required]
        public RentFrequency RentFrequency { get; set; }

        public LeaseStatus Status { get; set; } = LeaseStatus.ACTIVE;

        public string? DocumentUrl { get; set; }

        // Audit Fields
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        [ForeignKey("PropertyId")]
        public Property Property { get; set; }

        [ForeignKey("LandlordId")]
        public User Landlord { get; set; }

        [ForeignKey("TenantId")]
        public User Tenant { get; set; }
    }
}
