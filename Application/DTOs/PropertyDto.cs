using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Property_DTO
{
    public class PropertyDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
        public PropertyStatus Status { get; set; }
    }
}
