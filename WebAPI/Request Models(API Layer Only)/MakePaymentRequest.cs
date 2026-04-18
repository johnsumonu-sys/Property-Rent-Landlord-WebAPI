using Domin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Request_Models_API_Layer_Only_
{
    public class MakePaymentRequest
    {
        public Guid RentScheduleId { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethod Method { get; set; }
    }
}
