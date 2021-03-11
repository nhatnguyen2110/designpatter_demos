using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class PaymentService
    {
        public void PaymentByPaypal()
        {
            Console.WriteLine("Payment by Paypal");
        }
        public void PaymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit Card");
        }
        public void PaymentByEBanking()
        {
            Console.WriteLine("Payment by E-banking");
        }
        public void PaymentByCash()
        {
            Console.WriteLine("Payment by Cash");
        }
    }
}
