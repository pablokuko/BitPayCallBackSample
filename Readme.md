
# 🐞 BitPay Invoice Deserialization Issue - Reproduction Guide

This project demonstrates a runtime error that occurs when deserializing BitPay's `Invoice` model from a webhook-style JSON payload.

---

## ⚙️ How to Reproduce the Issue

### 1. Run the Project

Build and run the solution:

```bash
dotnet run
```

> Ensure the API is running locally on the default URL (e.g. `https://localhost:5001`).

---

### 2. Use the Only POST Endpoint

Use Swagger UI, Postman, or curl to send a **POST** request to the available endpoint  
(e.g. `/webhook`, `/api/invoice`, etc.).

---

### 3. Use This JSON Payload in the Body

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
    "refundAddresses": [
      "givemeMoney@bitpay.com"
    ],
    "amountPaid": 700700,
    "orderId": "1",
    "transactionCurrency": "BTC"
  }
}

```

---

### 4. Observe the Error

You'll get this runtime exception:

```
Microsoft.CSharp.RuntimeBinder.RuntimeBinderException:
No overload for method 'ToString' takes 1 arguments
   at CallSite.Target(Closure , CallSite , Object , Formatting )
```

---

## 💡 Root Cause

The BitPay SDK has an issue when Deserializing the Invoice using System.Text.Json in line value.ToString(Formatting.None)

class Invoice
{
...
    public dynamic RefundAddresses
    {
        get
        {
            return _refundAddresses;
        }
        set
        {
            _refundAddresses = JsonConvert.DeserializeObject(value.ToString(Formatting.None));
        }
    }
...
}
---

## ✅ Fix

I would need a new version released with the fix, it can be either 5.X or in 6.X

---

## 📝 License

This project is open-source and licensed under the MIT License.
