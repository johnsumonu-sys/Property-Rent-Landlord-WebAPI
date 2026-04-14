using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.External_Services
{
    public interface IPaymentGateway
    {
        Task<bool> ChargeAsync(decimal amount, string email);
    }
}
