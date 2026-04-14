using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.External_Services
{
    public class PaystackService : IPaymentGateway
    {
        public async Task<bool> ChargeAsync(decimal amount, string email)
        {
            // Call Paystack API here
            return true;
        }
    }
}
