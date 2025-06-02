using BitPay.Models.Invoice;
using BPIssue.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BPIssue.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BitPayNotificationPaymentController : ControllerBase
    {

        /* SAMPLE REQUEST BODY
         {
  "invoice": {
    "id": "ES7zSAmruwKK1m3wyXtjg6",
    "url": "https://bitpay.com/invoice?id=Hpqc63wvE1ZjzeeH4kEycF",
    "status": "confirmed",
    "price": 1.63,
    "currency": "USD",
    "invoiceTime": 1620669854224,
    "expirationTime": 1620670754224,
    "currentTime": 1620671313184,
    "exceptionStatus": "false",
    "refundAddresses": "givemeMoney@bitpay.com",
    "amountPaid": 700700,
    "orderId": "1",
    "transactionCurrency": "BTC"
  }
}
         */

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InvoiceModel invoice)
        {

            return Ok();

        }
    }
}
