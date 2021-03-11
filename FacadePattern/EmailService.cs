using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class EmailService
    {
        public void SendMail(string email)
        {
            Console.WriteLine("Sending an email to " + email);
        }
    }
}
