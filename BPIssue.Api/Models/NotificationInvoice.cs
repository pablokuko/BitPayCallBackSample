using BitPay.Models.Invoice;

namespace BPIssue.Api.Models
{
    public class NotificationInvoice : Invoice
    {
        public NotificationInvoice(decimal price, string currency) : base(price, currency)
        {
            Price = price;
            Currency = currency;
        }
    }
}
