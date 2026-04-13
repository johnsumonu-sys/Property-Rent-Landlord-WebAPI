using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities
{
    internal class Notification
    {
        public Guid Id { get; set; } // Primary Key

        public Guid UserId { get; set; } // Recipient (FK to User)

        public NotificationType Type { get; set; }

        public NotificationChannel Channel { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }

        public NotificationStatus Status { get; set; } = NotificationStatus.PENDING;

        public bool IsRead { get; set; } = false;

        public Guid? ReferenceId { get; set; } // Nullable

        public string ReferenceType { get; set; } // Nullable

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


        // Navigation Property (optional, if using EF Core)
        public User User { get; set; }
    }

    public enum NotificationType
    {
        RENT_DUE,
        PAYMENT_RECEIVED,
        LEASE_EXPIRING,
        PROPERTY_UPDATE,
        GENERAL
    }

    public enum NotificationChannel
    {
        EMAIL,
        SMS,
        IN_APP
    }

    public enum NotificationStatus
    {
        PENDING,
        SENT,
        FAILED
    }
}

