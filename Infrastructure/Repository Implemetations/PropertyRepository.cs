using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository_Implemetations
{
    public class PropertyRepository
        {
        private readonly AppDbContext _context;

        public PropertyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Property property)
        {
            await _context.Properties.AddAsync(property);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Property>> GetAllAsync()
        {
            return await _context.Properties.ToListAsync();
        }

        public async Task<Property> GetByIdAsync(Guid id)
        {
            return await _context.Properties.FindAsync(id);
        }

        public async Task UpdateAsync(Property property)
        {
            _context.Properties.Update(property);
            await _context.SaveChangesAsync();
        }
}
