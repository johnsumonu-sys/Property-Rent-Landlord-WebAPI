using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Command___Queries
{
    public class PropertyCommand
    {
        public Guid LandlordId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
