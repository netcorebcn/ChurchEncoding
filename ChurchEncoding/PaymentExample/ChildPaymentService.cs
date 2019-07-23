﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploeh.Samples.ChurchEncoding.PaymentExample
{
    public class ChildPaymentService
    {
        public ChildPaymentService(
            string originalTransactionKey,
            PaymentService paymentService)
        {
            this.OriginalTransactionKey = originalTransactionKey;
            this.PaymentService = paymentService;
        }

        public string OriginalTransactionKey { get; }

        public PaymentService PaymentService { get; }
    }
}
