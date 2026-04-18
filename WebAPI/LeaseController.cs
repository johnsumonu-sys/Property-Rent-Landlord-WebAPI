using Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI
{
    public class LeaseController
    {
        private readonly LeaseService _leaseService;

        public LeaseController(LeaseService leaseService)
        {
            _leaseService = leaseService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateLeaseRequest request)
        {
            var id = await _leaseService.CreateLeaseAsync(
                request.PropertyId,
                request.TenantId,
                request.StartDate,
                request.EndDate,
                request.RentAmount
            );

            return Ok(new { Id = id });
        }
    }
}
