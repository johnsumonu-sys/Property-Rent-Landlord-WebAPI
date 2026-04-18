using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
    builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IPropertyRepository, PropertyRepository>();
builder.Services.AddScoped<ILeaseRepository, LeaseRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();

builder.Services.AddScoped<IPaymentGateway, PaystackService>();
builder.Services.AddScoped<IEmailService, EmailService>();
   

