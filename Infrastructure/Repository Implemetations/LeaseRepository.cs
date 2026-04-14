using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository_Implemetations
{
    public class LeaseRepository
    {
        private readonly AppDbContext _context;

        public LeaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Lease lease)
        {
            await _context.Leases.AddAsync(lease);
            await _context.SaveChangesAsync();
        }

        public async Task<Lease> GetByIdAsync(Guid id)
        {
            return await _context.Leases.FindAsync(id);
        }
    }
}
