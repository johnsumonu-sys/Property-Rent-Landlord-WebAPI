using Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Request_Models_API_Layer_Only_;

namespace WebAPI
{
    public class PaymentController
    {
        private readonly PaymentService _paymentService;

        public PaymentController(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Pay(MakePaymentRequest request)
        {
            await _paymentService.MakePaymentAsync(
                scheduleId: request.RentScheduleId,
                request.Amount,
                request.Method
            );

            return Ok("Payment successful");
        }

        private IActionResult Ok(string v)
        {
            throw new NotImplementedException();
        }/;.mkcgdv
    }
}


C V