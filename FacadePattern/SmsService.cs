using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class SmsService
    {
        public void SendSMS(string mobilePhone)
        {
            Console.WriteLine("Sending an message to " + mobilePhone);
        }
    }
}
