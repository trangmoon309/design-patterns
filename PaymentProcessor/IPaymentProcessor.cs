﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    public interface IPaymentProcessor
    {
        public void Process(decimal amount);
    }
}
