using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FacadePattern
{
    public class ShopFacade
    {
        private static ShopFacade Instanse;
        private AccountService accountService;
        private PaymentService paymentService;
        private ShippingService shippingService;
        private EmailService emailService;
        private SmsService smsService;

        private ShopFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
            emailService = new EmailService();
            smsService = new SmsService();
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ShopFacade GetInstanse()
        {
            
                if (Instanse == null)
                {
                    Instanse = new ShopFacade();
                }
           
            return Instanse;
        }
        public void BuyProductByCashWithFreeShipping(string email)
        {
            accountService.GetAccount(email);
            paymentService.PaymentByCash();
            shippingService.FreeShipping();
            emailService.SendMail(email);
            Console.WriteLine("Done");
        }
        public void BuyProductByPaypalWithStandardShipping(string email, string mobilePhone)
        {
            accountService.GetAccount(email);
            paymentService.PaymentByPaypal();
            shippingService.StandardShipping();
            emailService.SendMail(email);
            smsService.SendSMS(mobilePhone);
            Console.WriteLine("Done");
        }
    }
}
