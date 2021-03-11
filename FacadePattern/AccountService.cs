using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class AccountService
    {
        public void GetAccount(string email)
        {
            Console.WriteLine("Getting the account of "+ email);
        }
    }
}
