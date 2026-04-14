using Application.Interfaces;
using Domin.Entities;
using Domin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class PaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task MakePaymentAsync(Guid scheduleId, decimal amount, PaymentMethod method)
        {
            var payment = new Payment(amount, method);

            payment.MarkAsSuccessful();

            await _paymentRepository.AddAsync(payment);
        }
    }
}
