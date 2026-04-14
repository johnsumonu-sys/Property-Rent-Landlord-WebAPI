using Application.Interfaces;
using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class LeaseService
    {
        private readonly ILeaseRepository _leaseRepository;

        public LeaseService(ILeaseRepository leaseRepository)
        {
            _leaseRepository = leaseRepository;
        }

        public async Task<Guid> CreateLeaseAsync(Guid propertyId, Guid tenantId, DateTime start, DateTime end, decimal rent)
        {
            var lease = new Lease(propertyId, tenantId, start, end, rent);

            lease.Activate();

            await _leaseRepository.AddAsync(lease);

            return lease.Id;
        }
    }
}
