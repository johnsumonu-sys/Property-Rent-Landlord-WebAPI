using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Request_Models_API_Layer_Only_
{
    public class CreateLeaseRequest
    {
        public Guid PropertyId { get; set; }
        public Guid TenantId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal RentAmount { get; set; }
    }
}
