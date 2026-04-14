using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class CreatePropertyRequestDto
    {
        public Guid LandlordId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Address { get; set; }
    }
}
