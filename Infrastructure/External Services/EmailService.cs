using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.External_Services
{
    public class EmailService : IEmailService
    {
        public async Task SendAsync(string to, string subject, string body)
        {
            // SMTP or SendGrid logic
        }
    }
}
