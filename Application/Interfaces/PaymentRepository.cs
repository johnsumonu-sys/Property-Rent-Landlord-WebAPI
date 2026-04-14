using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface IPaymentRepository
    {
        Task AddAsync(Payment payment);
        Task<IEnumerable<Payment>> GetByScheduleId(Guid scheduleId);
    }
}
