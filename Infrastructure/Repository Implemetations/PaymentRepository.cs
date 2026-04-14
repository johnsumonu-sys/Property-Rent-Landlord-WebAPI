using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository_Implemetations
{
    public class PaymentRepository
    {
        private readonly AppDbContext _context;

        public PaymentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Payment>> GetByScheduleId(Guid scheduleId)
        {
            return await _context.Payments
                .Where(p => p.RentScheduleId == scheduleId)
                .ToListAsync();
        }
    }
}
