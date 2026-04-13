using System;
using System.Collections.Generic;
using System.Text;

namespace Domin.Entities
{
    public class PropertyImage
    {
        public Guid Id { get; set; }

        // Foreign Key
        public Guid PropertyId { get; set; }

        public string ImageUrl { get; set; }  // Stored path or cloud URL

        public bool IsPrimary { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation Property (optional but recommended)
        public Property Property { get; set; }
    }
}
