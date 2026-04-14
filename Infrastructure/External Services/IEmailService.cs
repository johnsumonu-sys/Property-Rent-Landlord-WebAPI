using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.External_Services
{
    public interface IEmailService
    {
    Task SendAsync(string to, string subject, string body);
    }
}
