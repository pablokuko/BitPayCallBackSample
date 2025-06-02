# BitPay Webhook Issue Reproduction

This repository demonstrates a runtime error that occurs when using BitPay's `Invoice` class and posting a sample webhook payload.

## 🧪 Steps to Reproduce

1. **Clone the repository and open the solution** in Visual Studio or your preferred IDE.

2. **Build and run** the project (`F5` or `dotnet run`).

3. **Use a tool like Postman, Swagger UI, or curl** to make a POST request to the only available endpoint (e.g. `/webhook` or whatever route is defined).

4. **Send the following JSON payload** in the request body:

   ```json
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
