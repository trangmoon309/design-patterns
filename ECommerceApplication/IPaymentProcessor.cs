﻿public interface IPaymentProcessor
{
    bool ProcessPayment(decimal amount, string currency);
}
